using MySql.Data.MySqlClient;
using MySqlX.XDevAPI;
using Sio_Shop.Metiers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sio_Shop
{
    public partial class Detail_Client : Form
    {
        // On stocke l'ID reçu en mémoire
        private string _idClientActuel;
        private bool _changementDePage = false;

        // Le constructeur a été modifié pour accepter l'ID !
        public Detail_Client(string idClientRecu)
        {
            InitializeComponent();
            _idClientActuel = idClientRecu;
        }

        // --- 1. AU CHARGEMENT DE LA PAGE ---
        private void Detail_Client_Load(object sender, EventArgs e)
        {

            // Si l'ID n'est pas vide, on est en mode MODIFICATION
            if (!string.IsNullOrEmpty(_idClientActuel))
            {
                lbl_Titre.Text = "Modification du client :";
                txt_NumClient.Text = _idClientActuel;
                ChargerInfosClient();
                ChargerHistoriqueAchats();
            }
            else // Sinon, on est en mode CRÉATION
            {
                lbl_Titre.Text = "Nouveau client :";
                txt_NumClient.Text = "Auto"; // L'ID sera généré par la BDD
            }
        }

        private void ChargerInfosClient()
        {
            // On récupère le tableau (qui ne contiendra qu'une seule ligne)
            DataTable dataClient = ClientManager.ObtenirClientParId(_idClientActuel);

            // Si on a bien trouvé une ligne (le client)
            if (dataClient.Rows.Count > 0)
            {
                // On remplit les cases (index 0 car c'est la première et seule ligne)
                txt_Nom.Text = dataClient.Rows[0]["nom"].ToString();
                txt_Prenom.Text = dataClient.Rows[0]["prenom"].ToString();
                txt_Adresse.Text = dataClient.Rows[0]["adresse"].ToString();
                txt_Mail.Text = dataClient.Rows[0]["mail"].ToString();
                txt_Tel.Text = dataClient.Rows[0]["tel"].ToString();
            }
        }

        private void ChargerHistoriqueAchats()
        {
            dgv_Achats.Rows.Clear();
            decimal montantTotal = 0;

            DataTable mesAchats = ClientManager.ObtenirHistoriqueAchats(_idClientActuel);

            foreach (DataRow ligne in mesAchats.Rows)
            {
                string dateAchat = ligne["date_achat"].ToString();
                if (DateTime.TryParse(dateAchat, out DateTime dateParsed))
                {
                    dateAchat = dateParsed.ToShortDateString();
                }

                // On ajoute la ligne et on garde son index (sa position) en mémoire
                int indexLigne = dgv_Achats.Rows.Add(
                    dateAchat,
                    ligne["reference"].ToString(),
                    ligne["marque"].ToString(),
                    ligne["nom"].ToString(),
                    ligne["prix"].ToString() + " €"
                );

                dgv_Achats.Rows[indexLigne].Tag = ligne["id_achat"].ToString();

                if (decimal.TryParse(ligne["prix"].ToString(), out decimal prixAchat))
                {
                    montantTotal += prixAchat;
                }
            }

            lbl_MontantTotal.Text = $"Montant total : {montantTotal} €";

            dgv_Achats.ClearSelection();
            btn_VoirFacture.Enabled = false;
        }

        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_Nom.Text) || string.IsNullOrWhiteSpace(txt_Prenom.Text))
            {
                MessageBox.Show("Le nom et le prénom sont obligatoires !");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(_idClientActuel))
                {
                    // Mode CRÉATION
                    ClientManager.AjouterClient(txt_Nom.Text, txt_Prenom.Text, txt_Adresse.Text, txt_Mail.Text, txt_Tel.Text);
                }
                else
                {
                    // Mode MODIFICATION
                    ClientManager.ModifierClient(_idClientActuel, txt_Nom.Text, txt_Prenom.Text, txt_Adresse.Text, txt_Mail.Text, txt_Tel.Text);
                }

                MessageBox.Show("Client enregistré avec succès !");

                Client pageClient = new Client();
                pageClient.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }

        // --- 3. AU CLIC SUR RETOUR ---
        private void btn_Retour_Click(object sender, EventArgs e)
        {
            _changementDePage = true;
            Client pageClient = new Client();
            pageClient.Show();
            this.Close();
        }

        // --- 4. À LA FERMETURE DE LA PAGE (X) ---
        private void Detail_Client_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_changementDePage)
            {
                Client pageClient = new Client();
                pageClient.Show();
            }
        }

        // --- 5. AU CLIC SUR VOIR FACTURE ---
        private void btn_VoirFacture_Click(object sender, EventArgs e)
        {
            // On vérifie qu'une ligne est bien sélectionnée dans le tableau
            if (dgv_Achats.SelectedRows.Count > 0)
            {
                // 1. On récupère la ligne sélectionnée
                DataGridViewRow ligneChoisie = dgv_Achats.SelectedRows[0];

                // 2. On récupère notre fameux ID caché dans le Tag
                long idAchat = Convert.ToInt64(ligneChoisie.Tag);

                // 3. On rassemble les informations pour le PDF
                string nomClient = txt_Nom.Text + " " + txt_Prenom.Text;

                // On construit la chaîne "RÉFÉRENCE - Marque Modèle"
                string infosProduit = $"{ligneChoisie.Cells[1].Value} - {ligneChoisie.Cells[2].Value} {ligneChoisie.Cells[3].Value}";

                string prix = ligneChoisie.Cells[4].Value.ToString();

                // 4. On génère (ou regénère) la facture à la volée !
                FactureManager.GenererFacturePdf(idAchat, nomClient, infosProduit, prix);
            }
            else
            {
                MessageBox.Show("Veuillez sélectionner un achat dans la liste pour voir sa facture.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        // --- 6. QUAND LA SÉLECTION CHANGE DANS LE TABLEAU ---
        private void dgv_Achats_SelectionChanged(object sender, EventArgs e)
        {
            // On active (Enabled = true) le bouton UNIQUEMENT si une ligne est sélectionnée
            btn_VoirFacture.Enabled = (dgv_Achats.SelectedRows.Count > 0);
        }
    }
}