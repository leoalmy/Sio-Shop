using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sio_Shop.Metiers
{
    public static class EmployeManager
    {
        /// <summary>
        /// Vérifie les identifiants de l'employé en base de données.
        /// </summary>
        /// <param name="login">Identifiant tapé par l'utilisateur</param>
        /// <param name="motDePasse">Mot de passe tapé par l'utilisateur</param>
        /// <param name="nom">Paramètre de sortie : nom de l'employé si trouvé</param>
        /// <param name="matricule">Paramètre de sortie : matricule de l'employé si trouvé</param>
        /// <returns>True si la connexion est valide, False sinon.</returns>
        public static bool VerifierConnexion(string login, string motDePasse, out string nom, out string matricule)
        {
            // Initialisation des valeurs de sortie par défaut
            nom = null;
            matricule = null;

            try
            {
                // Connexion à la base avec le profil "login" comme dans ton code d'origine
                using (MySqlConnection maConnexion = BaseManager.GetDBConnection("login"))
                {
                    maConnexion.Open();
                    string requete = "SELECT nom, matricule, mdp FROM employe WHERE login = @id";

                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@id", login);

                        using (MySqlDataReader reader = commande.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string hashEnBase = reader["mdp"].ToString();

                                // Vérification du mot de passe BCrypt
                                if (BCrypt.Net.BCrypt.Verify(motDePasse, hashEnBase))
                                {
                                    nom = reader["nom"].ToString();
                                    matricule = reader["matricule"].ToString();
                                    return true;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connexion à la base de données : \n" + ex.Message, "Erreur SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            // Si on arrive ici, c'est que l'utilisateur n'existe pas, que le mot de passe est faux, ou qu'il y a eu une erreur SQL
            return false;
        }
    }
}