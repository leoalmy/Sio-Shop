using Sio_Shop.Metiers; // On n'oublie pas d'appeler notre boîte à outils !
using System;
using System.Data;
using System.Windows.Forms;

namespace Sio_Shop
{
    public partial class Produit : Form
    {
        private bool _changementDePage = false; // Le drapeau pour la croix rouge

        public Produit()
        {
            InitializeComponent();
        }

        // 1. Au chargement de la page
        private void Produit_Load(object sender, EventArgs e)
        {
            // 1. On affiche le bouton de mise à jour du stock uniquement si c'est l'admin qui est connecté
            if (Session.Matricule == "0")
            {
                btn_MajStock.Visible = true;  // Le boss est là, on montre le bouton
            }
            else
            {
                btn_MajStock.Visible = false; // Simple mortel, on cache le bouton
            }

            // 2. On charge la liste déroulante des marques
            DataTable dtMarques = MarqueManager.ObtenirToutesLesMarques(true);
            
            // Astuce : On crée manuellement une ligne "TOUTES" avec l'ID 0
            DataRow ligneToutes = dtMarques.NewRow();
            ligneToutes["id_marque"] = 0;
            ligneToutes["nom_marque"] = "TOUTES";
            dtMarques.Rows.InsertAt(ligneToutes, 0); // On la met tout en haut de la liste

            cb_Marque.DisplayMember = "nom_marque"; // Ce qu'on lit
            cb_Marque.ValueMember = "id_marque";    // L'ID caché
            cb_Marque.DataSource = dtMarques;
            cb_Marque.SelectedIndex = 0;

            // 3. On charge le tableau
            ChargerProduits();
        }

        // 2. Méthode pour remplir le tableau (avec filtre de marque optionnel)
        private void ChargerProduits(int idMarqueFiltre = 0)
        {
            dgv_Produits.Rows.Clear();

            // On demande les données au Manager
            DataTable mesDonnees = ProduitManager.ObtenirTousLesProduits(idMarqueFiltre);

            foreach (DataRow ligne in mesDonnees.Rows)
            {
                // 1. On lit la vraie valeur du stock depuis la base de données
                string vraiStock = ligne["stock"].ToString();

                // 2. On prépare ce qu'on va écrire dans la case
                string affichageStock = vraiStock;
                if (vraiStock == "0")
                {
                    affichageStock = "HORS STOCK";
                }

                // 3. On ajoute la ligne ET on récupère son "index" (sa position dans le tableau)
                int indexLigne = dgv_Produits.Rows.Add(
                    ligne["reference"].ToString(),
                    ligne["marque"].ToString(),
                    ligne["nom"].ToString(),
                    ligne["prix"].ToString() + " €",
                    affichageStock
                );

                // 4. On applique la peinture si le stock est à 0 !
                if (vraiStock == "0")
                {
                    DataGridViewRow ligneActuelle = dgv_Produits.Rows[indexLigne];

                    // On met le fond de toute la ligne en rouge
                    ligneActuelle.DefaultCellStyle.BackColor = System.Drawing.Color.Red;

                    // Astuce UX : sur fond rouge, le texte noir est illisible. On met le reste du texte en blanc !
                    ligneActuelle.DefaultCellStyle.ForeColor = System.Drawing.Color.White;

                    // Et on force spécifiquement la case du stock (index 4) à écrire "HORS STOCK" en jaune et en gras
                    ligneActuelle.Cells[4].Style.ForeColor = System.Drawing.Color.Yellow;
                    ligneActuelle.Cells[4].Style.Font = new System.Drawing.Font(dgv_Produits.Font, System.Drawing.FontStyle.Bold);
                }
            }
        }

        // 3. Quand on change la marque dans la liste déroulante
        private void cb_Marque_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_Marque.SelectedValue != null && cb_Marque.SelectedValue is int idMarque)
            {
                ChargerProduits(idMarque);
            }
        }

        // 4. Bouton Nouveau Produit
        private void btn_NouveauProduit_Click(object sender, EventArgs e)
        {
            _changementDePage = true;
            Detail_Produit pageDetail = new Detail_Produit(""); // Chaine vide = Nouveau
            pageDetail.Show();
            this.Close();
        }

        // 5. Clic sur une ligne du tableau (Modification)
        private void dgv_Produits_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _changementDePage = true;

                // On récupère la référence dans la première colonne (col_Reference)
                string refCliquee = dgv_Produits.Rows[e.RowIndex].Cells[0].Value.ToString();

                Detail_Produit pageDetail = new Detail_Produit(refCliquee);
                pageDetail.Show();
                this.Close();
            }
        }

        // 6. Bouton Mise à jour du stock
        private void btn_MajStock_Click(object sender, EventArgs e)
        {
            // On ouvre un explorateur de fichiers (File Picker)
            OpenFileDialog explorateur = new OpenFileDialog();
            explorateur.Title = "Sélectionner le fichier de livraison CSV";
            explorateur.Filter = "Fichiers CSV (*.csv)|*.csv|Fichiers Texte (*.txt)|*.txt";

            // Si l'utilisateur a bien cliqué sur "Ouvrir" après avoir choisi un fichier
            if (explorateur.ShowDialog() == DialogResult.OK)
            {
                string cheminDuFichier = explorateur.FileName;

                // On lance notre super méthode Manager !
                var bilan = ProduitManager.MettreAJourStockDepuisCSV(cheminDuFichier);

                // Si la méthode n'a pas crashé (-1)
                if (bilan.lignesMaj != -1)
                {
                    // On prépare un beau message de compte-rendu
                    string message = $"Traitement terminé !\n\n" +
                                     $"✅ Produits mis à jour : {bilan.lignesMaj}\n" +
                                     $"❌ Références inconnues : {bilan.erreurs}";

                    MessageBox.Show(message, "Bilan de la livraison", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // On récupère l'ID de la marque actuellement sélectionnée (ou 0 si "TOUTES") pour recharger le tableau
                    int idMarqueChoisie = cb_Marque.SelectedValue != null ? Convert.ToInt32(cb_Marque.SelectedValue) : 0;
                    ChargerProduits(idMarqueChoisie);
                }
            }
        }

        // 7. Bouton Retour
        private void btn_Retour_Click(object sender, EventArgs e)
        {
            _changementDePage = true;
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        // 8. Fermeture via la croix rouge
        private void Produit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_changementDePage)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
            }
        }
    }
}