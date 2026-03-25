using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sio_Shop.Metiers
{
    public static class ClientManager
    {
        // 1. Pour lister les clients (avec ou sans recherche)
        public static DataTable ObtenirTousLesClients(string recherche = "")
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "SELECT Num_client, nom, prenom, adresse, mail, tel FROM client";

                    if (!string.IsNullOrWhiteSpace(recherche))
                        requete += " WHERE nom LIKE @recherche";

                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        if (!string.IsNullOrWhiteSpace(recherche))
                            commande.Parameters.AddWithValue("@recherche", "%" + recherche + "%");

                        using (MySqlDataAdapter adaptateur = new MySqlDataAdapter(commande))
                        {
                            adaptateur.Fill(tableau);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD : " + ex.Message); }

            return tableau;
        }

        // 2. Pour récupérer UN SEUL client (pour la page de détails)
        public static DataTable ObtenirClientParId(string id)
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "SELECT nom, prenom, adresse, mail, tel FROM client WHERE Num_client = @id";
                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@id", id);
                        using (MySqlDataAdapter adaptateur = new MySqlDataAdapter(commande))
                        {
                            adaptateur.Fill(tableau);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD : " + ex.Message); }

            return tableau;
        }

        // 3. Pour AJOUTER un nouveau client
        public static void AjouterClient(string nom, string prenom, string adresse, string mail, string tel)
        {
            using (MySqlConnection maConnexion = MySQL.GetDBConnection())
            {
                maConnexion.Open();
                string requete = "INSERT INTO client (nom, prenom, adresse, mail, tel) VALUES (@nom, @prenom, @adresse, @mail, @tel)";
                using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                {
                    commande.Parameters.AddWithValue("@nom", nom);
                    commande.Parameters.AddWithValue("@prenom", prenom);
                    commande.Parameters.AddWithValue("@adresse", adresse);
                    commande.Parameters.AddWithValue("@mail", mail);
                    commande.Parameters.AddWithValue("@tel", tel);
                    commande.ExecuteNonQuery();
                }
            }
        }

        // 4. Pour MODIFIER un client existant
        public static void ModifierClient(string id, string nom, string prenom, string adresse, string mail, string tel)
        {
            using (MySqlConnection maConnexion = MySQL.GetDBConnection())
            {
                maConnexion.Open();
                string requete = "UPDATE client SET nom=@nom, prenom=@prenom, adresse=@adresse, mail=@mail, tel=@tel WHERE Num_client=@id";
                using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                {
                    commande.Parameters.AddWithValue("@nom", nom);
                    commande.Parameters.AddWithValue("@prenom", prenom);
                    commande.Parameters.AddWithValue("@adresse", adresse);
                    commande.Parameters.AddWithValue("@mail", mail);
                    commande.Parameters.AddWithValue("@tel", tel);
                    commande.Parameters.AddWithValue("@id", id);
                    commande.ExecuteNonQuery();
                }
            }
        }

        // 5. Récupérer l'historique des achats d'un client
        public static DataTable ObtenirHistoriqueAchats(string idClient)
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = @"
                SELECT a.id_achat, a.date_achat, p.reference, m.nom_marque AS marque, p.nom, p.prix 
                FROM pdt_achete a
                INNER JOIN produit p ON a.REFERENCE = p.reference
                INNER JOIN marque m ON p.id_marque = m.id_marque
                WHERE a.Num_client = @id";

                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@id", idClient);
                        using (MySqlDataAdapter adaptateur = new MySqlDataAdapter(commande))
                        {
                            adaptateur.Fill(tableau);
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD (Achats) : " + ex.Message); }
            return tableau;
        }
    }
}