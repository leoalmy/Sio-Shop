using System;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Sio_Shop.Metiers
{
    public static class VenteManager
    {
        // Méthode pour valider l'achat et baisser le stock
        public static long RealiserVente(string idClient, string referenceProduit)
        {
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();

                    // 1. On enregistre l'achat
                    string requeteAchat = "INSERT INTO pdt_achete (Num_client, REFERENCE, date_achat) VALUES (@client, @ref, CURDATE())";
                    using (MySqlCommand cmdAchat = new MySqlCommand(requeteAchat, maConnexion))
                    {
                        cmdAchat.Parameters.AddWithValue("@client", idClient);
                        cmdAchat.Parameters.AddWithValue("@ref", referenceProduit);
                        cmdAchat.ExecuteNonQuery();

                        // NOUVEAU : On récupère l'ID qui vient tout juste d'être créé !
                        long idVenteGenere = cmdAchat.LastInsertedId;

                        // 2. On diminue le stock
                        string requeteStock = "UPDATE produit SET stock = stock - 1 WHERE reference = @ref";
                        using (MySqlCommand cmdStock = new MySqlCommand(requeteStock, maConnexion))
                        {
                            cmdStock.Parameters.AddWithValue("@ref", referenceProduit);
                            cmdStock.ExecuteNonQuery();
                        }

                        return idVenteGenere; // On renvoie le numéro de la vente !
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la vente : " + ex.Message);
                return -1; // En cas d'erreur, on renvoie -1
            }
        }
    }
}