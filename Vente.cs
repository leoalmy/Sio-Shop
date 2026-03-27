using Sio_Shop.Metiers; // On n'oublie pas les managers !
using Sio_Shop.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sio_Shop
{
    public partial class Vente : Form
    {
        private bool _changementDePage = false;

        public Vente()
        {
            InitializeComponent();
        }

        // 1. Au chargement de la page
        private void Vente_Load(object sender, EventArgs e)
        {
            ThemeManager.AppliquerTheme(this);

            // --- CHARGER LES CLIENTS ---
            DataTable clients = ClientManager.ObtenirTousLesClients();
            clients.Columns.Add("affichage_client", typeof(string), "Convert(Num_client, 'System.String') + ' - ' + nom + ' ' + prenom + ' - ' + adresse + ' - ' + tel");

            // L'ASTUCE EST ICI : Toujours définir ce qu'on affiche/cache AVANT de donner les données (DataSource) !
            cb_Client.DisplayMember = "affichage_client";
            cb_Client.ValueMember = "Num_client";
            cb_Client.DataSource = clients;
            cb_Client.SelectedIndex = -1;

            // --- CHARGER LES PRODUITS ---
            DataTable produits = ProduitManager.ObtenirTousLesProduits();
            produits.Columns.Add("affichage_produit", typeof(string), "reference + ' - ' + marque + ' ' + nom");

            // PAREIL ICI : L'ordre est super important !
            cb_Produit.DisplayMember = "affichage_produit";
            cb_Produit.ValueMember = "reference";
            cb_Produit.DataSource = produits;
            cb_Produit.SelectedIndex = -1;
        }

        // 2. Quand on choisit un produit
        private void cb_Produit_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Sécurité 1 : Si rien n'est sélectionné (comme au démarrage avec le -1)
            if (cb_Produit.SelectedIndex == -1 || cb_Produit.SelectedValue == null || cb_Produit.SelectedValue is DataRowView)
            {
                // LA CORRECTION EST ICI : On vide les cases manuellement !
                txt_PrixHT.Clear();
                lbl_Stock.Text = "Stock avant vente : ";
                lbl_Stock.ForeColor = System.Drawing.Color.Black;

                return; // On s'arrête là, pas besoin d'aller interroger la base de données
            }

            // Si on arrive ici, c'est qu'un vrai produit a été cliqué !
            string refProduit = cb_Produit.SelectedValue.ToString();
            DataTable dtProduit = ProduitManager.ObtenirProduitParRef(refProduit);

            if (dtProduit.Rows.Count > 0)
            {
                txt_PrixHT.Text = dtProduit.Rows[0]["prix"].ToString();

                string stockDispo = dtProduit.Rows[0]["stock"].ToString();
                lbl_Stock.Text = "Stock avant vente : " + stockDispo;

                if (stockDispo == "0")
                    lbl_Stock.ForeColor = System.Drawing.Color.Red;
                else
                    lbl_Stock.ForeColor = System.Drawing.Color.Black;
            }
        }

        // 3. Le calcul automatique
        private void txt_PrixHT_TextChanged(object sender, EventArgs e)
        {
            // On nettoie le texte pour être sûr de n'avoir que des chiffres (on vire le symbole € s'il y est)
            string prixTexte = txt_PrixHT.Text.Replace("€", "").Trim();

            // L'ASTUCE : On tente avec une virgule ET avec un point, comme ça peu importe la langue du PC, ça marche !
            if (decimal.TryParse(prixTexte.Replace(".", ","), out decimal prixHT) ||
                decimal.TryParse(prixTexte.Replace(",", "."), out prixHT))
            {
                decimal tva = prixHT * 0.20m;
                decimal ttc = prixHT + tva;

                txt_TVA.Text = tva.ToString("0.00") + " €";
                txt_PrixTTC.Text = ttc.ToString("0.00") + " €";
            }
            else
            {
                txt_TVA.Clear();
                txt_PrixTTC.Clear();
            }
        }

        // 4. Clic sur le bouton Acheter !
        private void btn_Acheter_Click(object sender, EventArgs e)
        {
            if (cb_Client.SelectedValue == null || cb_Produit.SelectedValue == null)
            {
                MessageBox.Show("Veuillez sélectionner un client et un produit !");
                return;
            }

            string idClient = cb_Client.SelectedValue.ToString();
            string refProduit = cb_Produit.SelectedValue.ToString();

            DataTable dtProduit = ProduitManager.ObtenirProduitParRef(refProduit);
            if (dtProduit.Rows.Count > 0 && dtProduit.Rows[0]["stock"].ToString() == "0")
            {
                MessageBox.Show("Ce produit est hors stock !", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // ON RÉCUPÈRE L'ID DE LA VENTE EN FAISANT LA VENTE
            long idVente = VenteManager.RealiserVente(idClient, refProduit);

            // Si l'ID est > 0, c'est que la vente a réussi dans la BDD !
            if (idVente > 0)
            {
                // On récupère le nom propre du client depuis la BDD pour le nom du fichier PDF
                DataTable dtClient = ClientManager.ObtenirClientParId(idClient);
                string nomClientPropre = dtClient.Rows[0]["nom"].ToString() + " " + dtClient.Rows[0]["prenom"].ToString();

                // 🎇 ON GÉNÈRE LE PDF !
                FactureManager.GenererFacturePdf(idVente, nomClientPropre, cb_Produit.Text, txt_PrixTTC.Text);

                MessageBox.Show("La vente a été enregistrée avec succès !", "Succès", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MainMenu menu = new MainMenu();
                menu.Show();
                _changementDePage = true;
                this.Close();
            }
        }

        // --- GESTION DE LA NAVIGATION ---
        private void btn_Retour_Click(object sender, EventArgs e)
        {
            _changementDePage = true;
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void Vente_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_changementDePage)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
            }
        }
    }
}