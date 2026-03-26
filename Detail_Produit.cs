using Sio_Shop.Metiers; // Appel du manager
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;

namespace Sio_Shop
{
    public partial class Detail_Produit : Form
    {
        private string _refProduitActuel;
        private bool _changementDePage = false;

        // On modifie le constructeur pour qu'il demande une référence !
        public Detail_Produit(string refRecue)
        {
            InitializeComponent();
            _refProduitActuel = refRecue;
        }

        // 1. Chargement de la page
        private void Detail_Produit_Load(object sender, EventArgs e)
        {
            // --- NOUVEAU : On remplit la liste des marques disponibles ---
            DataTable dtMarques = MarqueManager.ObtenirToutesLesMarques();
            cbx_Marque.DisplayMember = "nom_marque";
            cbx_Marque.ValueMember = "id_marque";
            cbx_Marque.DataSource = dtMarques;
            cbx_Marque.SelectedIndex = -1;
            // -------------------------------------------------------------

            if (!string.IsNullOrEmpty(_refProduitActuel))
            {
                // MODE MODIFICATION
                lbl_Titre.Text = "Modification du produit :";
                txt_Reference.Text = _refProduitActuel;
                txt_Reference.ReadOnly = false;
                ChargerInfosProduit();
            }
            else
            {
                // MODE CRÉATION
                lbl_Titre.Text = "Nouveau produit :";
                txt_Reference.Text = "Auto";
                txt_Reference.ReadOnly = false;
            }
        }

        // 2. Remplissage des cases si on modifie
        private void ChargerInfosProduit()
        {
            DataTable dataProduit = ProduitManager.ObtenirProduitParRef(_refProduitActuel);

            if (dataProduit.Rows.Count > 0)
            {
                cbx_Marque.SelectedValue = dataProduit.Rows[0]["id_marque"];
                txt_Nom.Text = dataProduit.Rows[0]["nom"].ToString();
                txt_Prix.Text = dataProduit.Rows[0]["prix"].ToString();
                txt_Stock.Text = dataProduit.Rows[0]["stock"].ToString();
            }
        }

        // 3. Bouton Enregistrer
        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            // Vérification basique
            if (string.IsNullOrWhiteSpace(txt_Reference.Text) || string.IsNullOrWhiteSpace(txt_Nom.Text) || cbx_Marque.SelectedValue == null)
            {
                MessageBox.Show("Référence, Nom et Marque obligatoires !");
                return;
            }

            try
            {
                // On récupère l'ID caché de la marque
                int idMarqueChoisie = Convert.ToInt32(cbx_Marque.SelectedValue);

                if (string.IsNullOrEmpty(_refProduitActuel))
                    ProduitManager.AjouterProduit(idMarqueChoisie, txt_Nom.Text, txt_Prix.Text, txt_Stock.Text);
                else
                    ProduitManager.ModifierProduit(txt_Reference.Text, idMarqueChoisie, txt_Nom.Text, txt_Prix.Text, txt_Stock.Text);

                MessageBox.Show("Produit enregistré avec succès !");

                _changementDePage = true;
                Produit pageProduit = new Produit();
                pageProduit.Show();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de l'enregistrement : " + ex.Message);
            }
        }

        // 4. Bouton Retour
        private void btn_Retour_Click(object sender, EventArgs e)
        {
            _changementDePage = true;
            Produit pageProduit = new Produit();
            pageProduit.Show();
            this.Close();
        }

        // 5. Fermeture via la croix rouge
        private void Detail_Produit_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_changementDePage)
            {
                Produit pageProduit = new Produit();
                pageProduit.Show();
            }
        }
    }
}