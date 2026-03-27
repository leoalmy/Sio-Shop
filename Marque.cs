using Sio_Shop.Metiers;
using Sio_Shop.Utils;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sio_Shop
{
    public partial class Marque : Form
    {
        private bool _changementDePage = false; // Le drapeau pour la croix rouge
        public Marque()
        {
            InitializeComponent();
        }

        private void Marque_Load(object sender, EventArgs e)
        {
            ThemeManager.AppliquerTheme(this);

            if (Session.Matricule != "0")
            {
                btn_NouvelleMarque.Visible = false;
                this.Size = new System.Drawing.Size(377, 563);
                btn_Retour.Location = new System.Drawing.Point(12, 477);
                btn_Retour.Size = new System.Drawing.Size(337, 35);
            }
            ChargerMarques();
        }

        private void ChargerMarques()
        {
            dgv_Marques.Rows.Clear();

            // On demande les données au Manager
            DataTable mesDonnees = MarqueManager.ObtenirToutesLesMarques(true);

            foreach (DataRow ligne in mesDonnees.Rows)
            {
                // On ajoute la ligne ET on récupère son "index" (sa position dans le tableau)
                int indexLigne = dgv_Marques.Rows.Add(
                    ligne["id_marque"].ToString(),
                    ligne["nom_marque"].ToString()
                );
            }
        }

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            _changementDePage = true;
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void btn_NouvelleMarque_Click(object sender, EventArgs e)
        {
            _changementDePage = true;
            Detail_Marque pageDetail = new Detail_Marque(""); // Chaine vide = Nouveau
            pageDetail.Show();
            this.Close();
        }

        private void Marque_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!_changementDePage)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
            }
        }

        private void dgv_Marques_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (Session.Matricule == "0")
            {
                if (e.RowIndex >= 0)
                {
                    _changementDePage = true;

                    // On récupère la référence dans la première colonne (col_ID)
                    string idCliquee = dgv_Marques.Rows[e.RowIndex].Cells[0].Value.ToString();

                    Detail_Marque pageMarque = new Detail_Marque(idCliquee);
                    pageMarque.Show();
                    this.Close();
                }
            }
        }
    }
}
