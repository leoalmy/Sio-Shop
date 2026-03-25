using MySql.Data.MySqlClient;
using Mysqlx.Crud;
using Sio_Shop;
using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;
using System.IO;

namespace Sio_Shop.Metiers
{
    public static class ProduitManager
    {
        // 1. Obtenir les produits (avec INNER JOIN pour afficher le nom de la marque, pas son ID)
        public static DataTable ObtenirTousLesProduits(int idMarqueFiltre = 0)
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = @"
                        SELECT p.reference, m.nom_marque AS marque, p.nom, p.prix, p.stock 
                        FROM produit p
                        INNER JOIN marque m ON p.id_marque = m.id_marque";

                    // Si on a choisi une marque spécifique dans la liste déroulante
                    if (idMarqueFiltre > 0)
                        requete += " WHERE p.id_marque = @idMarque";

                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        if (idMarqueFiltre > 0)
                            commande.Parameters.AddWithValue("@idMarque", idMarqueFiltre);

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

        // 2. Récupérer un produit par sa réf (on récupère aussi l'id_marque pour la liste déroulante !)
        public static DataTable ObtenirProduitParRef(string reference)
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "SELECT id_marque, nom, prix, stock FROM produit WHERE reference = @ref";
                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@ref", reference);
                        using (MySqlDataAdapter adaptateur = new MySqlDataAdapter(commande))
                            adaptateur.Fill(tableau);
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD : " + ex.Message); }
            return tableau;
        }

        // 3. Ajouter un produit (prend un INT idMarque maintenant !)
        public static void AjouterProduit(string reference, int idMarque, string nom, string prix, string stock)
        {
            using (MySqlConnection maConnexion = MySQL.GetDBConnection())
            {
                maConnexion.Open();
                string requete = "INSERT INTO produit (reference, id_marque, nom, prix, stock) VALUES (@ref, @idMarque, @nom, @prix, @stock)";
                using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                {
                    commande.Parameters.AddWithValue("@ref", reference);
                    commande.Parameters.AddWithValue("@idMarque", idMarque);
                    commande.Parameters.AddWithValue("@nom", nom);
                    commande.Parameters.AddWithValue("@prix", prix.Replace(",", "."));
                    commande.Parameters.AddWithValue("@stock", stock);
                    commande.ExecuteNonQuery();
                }
            }
        }

        // 4. Modifier un produit
        public static void ModifierProduit(string reference, int idMarque, string nom, string prix, string stock)
        {
            using (MySqlConnection maConnexion = MySQL.GetDBConnection())
            {
                maConnexion.Open();
                string requete = "UPDATE produit SET id_marque=@idMarque, nom=@nom, prix=@prix, stock=@stock WHERE reference=@ref";
                using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                {
                    commande.Parameters.AddWithValue("@idMarque", idMarque);
                    commande.Parameters.AddWithValue("@nom", nom);
                    commande.Parameters.AddWithValue("@prix", prix.Replace(",", "."));
                    commande.Parameters.AddWithValue("@stock", stock);
                    commande.Parameters.AddWithValue("@ref", reference);
                    commande.ExecuteNonQuery();
                }
            }
        }

        // 5. Récupérer TOUTES les marques (renvoie un DataTable maintenant, plus une List<string>)
        public static DataTable ObtenirToutesLesMarques()
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "SELECT id_marque, nom_marque FROM marque ORDER BY nom_marque";
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

        
        // 6. Mise à jour des stocks via un fichier CSV
        public static (int lignesMaj, int erreurs) MettreAJourStockDepuisCSV(string cheminFichier)
        {
            int lignesMaj = 0;
            int erreurs = 0;

            try
            {
                string[] lignes = File.ReadAllLines(cheminFichier);

                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();

                    foreach (string ligne in lignes)
                    {
                        if (string.IsNullOrWhiteSpace(ligne)) continue;

                        string[] colonnes = ligne.Split(';', ',');

                        if (colonnes.Length >= 2)
                        {
                            string reference = colonnes[0].Trim();
                            string strQuantite = colonnes[1].Trim();

                            if (int.TryParse(strQuantite, out int quantiteLivree))
                            {
                                string requete = "UPDATE produit SET stock = stock + @qte WHERE reference = @ref";

                                using (MySqlCommand cmd = new MySqlCommand(requete, maConnexion))
                                {
                                    cmd.Parameters.AddWithValue("@qte", quantiteLivree);
                                    cmd.Parameters.AddWithValue("@ref", reference);

                                    int resultat = cmd.ExecuteNonQuery();

                                    if (resultat > 0) lignesMaj++;
                                    else erreurs++;
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur critique lors de la lecture du fichier : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return (-1, -1);
            }

            return (lignesMaj, erreurs);
        }
    }
}