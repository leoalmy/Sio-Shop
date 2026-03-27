using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Sio_Shop.Metiers
{
    public static class MarqueManager
    {
        // 1. Récupérer TOUTES les marques
        public static DataTable ObtenirToutesLesMarques(bool OrderById = false)
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = BaseManager.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "";
                    if (OrderById)
                    {
                        requete = "SELECT * FROM marque ORDER BY id_marque";
                    }
                    else
                    {
                        requete = "SELECT * FROM marque ORDER BY nom_marque";
                    }
                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        using (MySqlDataAdapter adaptateur = new MySqlDataAdapter(commande))
                            adaptateur.Fill(tableau);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD (Marques) : " + ex.Message); }
            return tableau;
        }

        // 2. Récupérer une marque par son ID
        public static DataTable ObtenirMarqueParID(string id)
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = BaseManager.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "SELECT id_marque, nom_marque FROM marque WHERE id_marque = @id";
                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@id", id);
                        using (MySqlDataAdapter adaptateur = new MySqlDataAdapter(commande))
                            adaptateur.Fill(tableau);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD : " + ex.Message); }
            return tableau;
        }

        // 3. Insérer une nouvelle marque
        public static bool InsererMarque(string nomMarque)
        {
            try
            {
                using (MySqlConnection maConnexion = BaseManager.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "INSERT INTO marque (nom_marque) VALUES (@nom)";
                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@nom", nomMarque);
                        int result = commande.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD (Insertion Marque) : " + ex.Message); return false; }
        }

        // 4. Modifier une marque existante
        public static bool ModifierMarque(int idMarque, string nouveauNom)
        {
            try
            {
                using (MySqlConnection maConnexion = BaseManager.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "UPDATE marque SET nom_marque = @nom WHERE id_marque = @id";
                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@nom", nouveauNom);
                        commande.Parameters.AddWithValue("@id", idMarque);
                        int result = commande.ExecuteNonQuery();
                        return result > 0;
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD (Modification Marque) : " + ex.Message); return false; }
        }

        // 5. Compter le nombre total de marques
        public static int CompterTotalMarques()
        {
            int total = 0;
            try
            {
                using (MySqlConnection maConnexion = BaseManager.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "SELECT COUNT(*) FROM marque";
                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        total = Convert.ToInt32(commande.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD (Compte Marques) : " + ex.Message); }
            return total;
        }
    }
}
