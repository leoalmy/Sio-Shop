using Sio_Shop.Metiers;
using Sio_Shop.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sio_Shop
{
    public partial class Detail_Marque : Form
    {
        private string _idMarqueActuelle;
        private bool _changementDePage = false;
        public Detail_Marque(string idRecue)
        {
            InitializeComponent();
            _idMarqueActuelle = idRecue;
        }
        
        private void Detail_Marque_Load(object sender, EventArgs e)
        {
            ThemeManager.AppliquerTheme(this);

            if (!string.IsNullOrEmpty(_idMarqueActuelle))
            {
                // MODE MODIFICATION
                lbl_Titre.Text = "Modification de la Marque :";
                txt_ID.Text = _idMarqueActuelle;
                txt_ID.ReadOnly = false;
                ChargerInfosMarque();
            }
            else
            {
                // MODE CRÉATION
                lbl_Titre.Text = "Nouvelle Marque :";
                txt_ID.Text = "Auto";
                txt_ID.ReadOnly = false;
            }
        }

        // 2. Remplissage des cases si on modifie
        private void ChargerInfosMarque()
        {
            DataTable dataMarque = MarqueManager.ObtenirMarqueParID(_idMarqueActuelle);

            if (dataMarque.Rows.Count > 0)
            {
                txt_ID.Text = dataMarque.Rows[0]["id_marque"].ToString();
                txt_Nom.Text = dataMarque.Rows[0]["nom_marque"].ToString();
            }
        }

        // 3. Bouton Enregistrer
        private void btn_Enregistrer_Click(object sender, EventArgs e)
        {
            // Vérification basique
            if (string.IsNullOrWhiteSpace(txt_ID.Text) || string.IsNullOrWhiteSpace(txt_Nom.Text))
            {
                MessageBox.Show("ID et Nom obligatoires !");
                return;
            }

            try
            {
                if (string.IsNullOrEmpty(_idMarqueActuelle))
                    MarqueManager.InsererMarque(txt_Nom.Text);
                else
                    MarqueManager.ModifierMarque(Int32.Parse(txt_ID.Text), txt_Nom.Text);

                MessageBox.Show("Marque enregistré avec succès !");

                _changementDePage = true;
                Marque pageMarque = new Marque();
                pageMarque.Show();
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
            Marque pageMarque = new Marque();
            pageMarque.Show();
            this.Close();
        }

        // 5. Fermeture via la croix rouge
        private void Detail_Marque_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_changementDePage)
            {
                Marque pageMarque = new Marque();
                pageMarque.Show();
            }
        }
    }
}
