using Sio_Shop.Metiers;
using Sio_Shop.Utils;
using System;
using System.Windows.Forms;

namespace Sio_Shop
{
    public partial class Connexion : Form
    {
        public Connexion()
        {
            InitializeComponent();
        }

        private void btn_Connexion_Click(object sender, EventArgs e)
        {
            string identifiantTapé = textBox1.Text;
            string mdpTapé = textBox2.Text;

            // 1. Vérification des champs vides
            if (string.IsNullOrWhiteSpace(identifiantTapé) || string.IsNullOrWhiteSpace(mdpTapé))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // 2. Appel au Manager pour vérifier la connexion
            if (EmployeManager.VerifierConnexion(identifiantTapé, mdpTapé, out string nomEmploye, out string matriculeEmploye))
            {
                // Bingo ! On met en session
                Session.Nom = nomEmploye;
                Session.Matricule = matriculeEmploye;

                // Ouverture du menu principal
                MainMenu menu = new MainMenu();
                menu.Show();
                this.Hide();
            }
            else
            {
                // Échec (mauvais ID ou mauvais MDP)
                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            // On ferme l'application complètement, sans poser de question
            Environment.Exit(0);
        }

        private void Connexion_Load(object sender, EventArgs e)
        {
            ThemeManager.AppliquerTheme(this);
        }
    }
}