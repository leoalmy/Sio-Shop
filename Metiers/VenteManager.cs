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
                using (MySqlConnection maConnexion = BaseManager.GetDBConnection())
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

        // Méthode pour calculer le chiffre d'affaires total
        public static decimal CalculerChiffreAffairesTotal()
        {
            decimal chiffreAffaires = 0;
            try
            {
                using (MySqlConnection maConnexion = BaseManager.GetDBConnection())
                {
                    maConnexion.Open();
                    // On fait la somme des prix des produits liés aux achats
                    // COALESCE permet de renvoyer 0 si la table des ventes est vide (évite les crashs)
                    string requete = @"
                        SELECT COALESCE(SUM(p.prix), 0) 
                        FROM pdt_achete a
                        INNER JOIN produit p ON a.REFERENCE = p.reference";

                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        // On convertit en décimal car c'est de l'argent (type double en base)
                        chiffreAffaires = Convert.ToDecimal(commande.ExecuteScalar());
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD (Calcul CA) : " + ex.Message); }
            return chiffreAffaires;
        }
    }
}