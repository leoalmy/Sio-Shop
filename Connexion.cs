using MySql.Data.MySqlClient;
using Org.BouncyCastle.Crypto.Generators;
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

            if (string.IsNullOrWhiteSpace(identifiantTapé) || string.IsNullOrWhiteSpace(mdpTapé))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Attention", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();

                    // 1. NOUVELLE REQUÊTE : On récupère aussi le nom et le matricule !
                    string requete = "SELECT nom, matricule, mdp FROM employe WHERE login = @id";

                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@id", identifiantTapé);

                        // 2. On utilise ExecuteReader pour lire plusieurs colonnes
                        using (MySqlDataReader reader = commande.ExecuteReader())
                        {
                            // 3. Si on a trouvé un utilisateur
                            if (reader.Read())
                            {
                                // On récupère ses infos
                                string nomEmployeBase = reader["nom"].ToString();
                                string matriculeEmployeBase = reader["matricule"].ToString();
                                string hashEnBase = reader["mdp"].ToString();

                                // 4. On vérifie le mot de passe BCrypt
                                bool mdpValide = BCrypt.Net.BCrypt.Verify(mdpTapé, hashEnBase);

                                if (mdpValide)
                                {
                                    // Bingo ! Le mot de passe est bon.

                                    // 4. On stocke le nom et le matricule dans la session
                                    Session.Nom = nomEmployeBase;
                                    Session.Matricule = matriculeEmployeBase;

                                    // 5. C'est ici qu'on passe les données !
                                    // On ouvre le menu principal en lui donnant le nom et le matricule
                                    MainMenu menu = new MainMenu();
                                    menu.Show();
                                    this.Hide();
                                }
                                else
                                {
                                    // Échec du mot de passe
                                    MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                // Aucun utilisateur trouvé avec cet identifiant
                                MessageBox.Show("Identifiant ou mot de passe incorrect.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion : \n" + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Connexion_FormClosing(object sender, FormClosingEventArgs e)
        {
            // On ferme l'application complètement, sans poser de question
            Environment.Exit(0);
        }
    }
}