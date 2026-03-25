using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.IO;

namespace Sio_Shop.Metiers
{
    public static class ProduitManager
    {
        // 1. Lister les produits (avec recherche sur le nom ou la marque)
        public static DataTable ObtenirTousLesProduits(string recherche = "")
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "SELECT reference, marque, nom, prix, stock FROM produit";

                    if (!string.IsNullOrWhiteSpace(recherche))
                        requete += " WHERE nom LIKE @recherche OR marque LIKE @recherche";

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

        // 2. Récupérer UN SEUL produit pour la page de détails
        public static DataTable ObtenirProduitParRef(string reference)
        {
            DataTable tableau = new DataTable();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    string requete = "SELECT marque, nom, prix, stock FROM produit WHERE reference = @ref";
                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        commande.Parameters.AddWithValue("@ref", reference);
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

        // 3. Ajouter un produit
        public static void AjouterProduit(string reference, string marque, string nom, string prix, string stock)
        {
            using (MySqlConnection maConnexion = MySQL.GetDBConnection())
            {
                maConnexion.Open();
                string requete = "INSERT INTO produit (reference, marque, nom, prix, stock) VALUES (@ref, @marque, @nom, @prix, @stock)";
                using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                {
                    commande.Parameters.AddWithValue("@ref", reference);
                    commande.Parameters.AddWithValue("@marque", marque);
                    commande.Parameters.AddWithValue("@nom", nom);
                    // Astuce : On remplace la virgule par un point pour le SQL si on tape un prix à virgule
                    commande.Parameters.AddWithValue("@prix", prix.Replace(",", "."));
                    commande.Parameters.AddWithValue("@stock", stock);
                    commande.ExecuteNonQuery();
                }
            }
        }

        // 4. Modifier un produit
        public static void ModifierProduit(string reference, string marque, string nom, string prix, string stock)
        {
            using (MySqlConnection maConnexion = MySQL.GetDBConnection())
            {
                maConnexion.Open();
                string requete = "UPDATE produit SET marque=@marque, nom=@nom, prix=@prix, stock=@stock WHERE reference=@ref";
                using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                {
                    commande.Parameters.AddWithValue("@marque", marque);
                    commande.Parameters.AddWithValue("@nom", nom);
                    commande.Parameters.AddWithValue("@prix", prix.Replace(",", "."));
                    commande.Parameters.AddWithValue("@stock", stock);
                    commande.Parameters.AddWithValue("@ref", reference);
                    commande.ExecuteNonQuery();
                }
            }
        }

        // 5. Récupérer la liste des marques sans doublons (pour les listes déroulantes)
        public static List<string> ObtenirToutesLesMarques()
        {
            List<string> listeMarques = new List<string>();
            try
            {
                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();
                    // Le mot-clé DISTINCT permet de ne pas récupérer 10 fois "Samsung"
                    string requete = "SELECT DISTINCT marque FROM produit WHERE marque IS NOT NULL AND marque != ''";

                    using (MySqlCommand commande = new MySqlCommand(requete, maConnexion))
                    {
                        using (MySqlDataReader reader = commande.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                listeMarques.Add(reader["marque"].ToString());
                            }
                        }
                    }
                }
            }
            catch (Exception ex) { MessageBox.Show("Erreur BDD (Marques) : " + ex.Message); }

            return listeMarques;
        }

        // 6. Mise à jour des stocks via un fichier CSV
        public static (int lignesMaj, int erreurs) MettreAJourStockDepuisCSV(string cheminFichier)
        {
            int lignesMaj = 0;
            int erreurs = 0;

            try
            {
                // On lit absolument toutes les lignes du fichier d'un seul coup
                string[] lignes = File.ReadAllLines(cheminFichier);

                using (MySqlConnection maConnexion = MySQL.GetDBConnection())
                {
                    maConnexion.Open();

                    foreach (string ligne in lignes)
                    {
                        // On ignore les lignes vides
                        if (string.IsNullOrWhiteSpace(ligne)) continue;

                        // On découpe la ligne. Le CSV peut être séparé par des virgules ou des points-virgules
                        string[] colonnes = ligne.Split(';', ',');

                        // On s'assure qu'il y a bien au moins 2 colonnes (Référence et Quantité)
                        if (colonnes.Length >= 2)
                        {
                            string reference = colonnes[0].Trim();
                            string strQuantite = colonnes[1].Trim();

                            // On essaie de transformer la quantité en chiffre. 
                            // (L'avantage de TryParse, c'est que si la première ligne du fichier contient les mots "Reference;Quantite" (les en-têtes), ça va juste l'ignorer sans planter !)
                            if (int.TryParse(strQuantite, out int quantiteLivree))
                            {
                                // La magie du SQL : on fait "stock = stock + quantiteLivree" !
                                string requete = "UPDATE produit SET stock = stock + @qte WHERE reference = @ref";

                                using (MySqlCommand cmd = new MySqlCommand(requete, maConnexion))
                                {
                                    cmd.Parameters.AddWithValue("@qte", quantiteLivree);
                                    cmd.Parameters.AddWithValue("@ref", reference);

                                    // ExecuteNonQuery renvoie le nombre de lignes modifiées en BDD
                                    int resultat = cmd.ExecuteNonQuery();

                                    if (resultat > 0)
                                        lignesMaj++; // Produit trouvé et mis à jour !
                                    else
                                        erreurs++;   // Référence introuvable dans la base
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

            return (lignesMaj, erreurs); // On renvoie le bilan de l'opération
        }
    }
}