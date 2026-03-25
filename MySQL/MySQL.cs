using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Sio_Shop
{
    class MySQL
    {
        public static MySqlConnection GetDBConnection()
        /* static pour l'appeler sans déclaration
         * On retourne un objet du type MySqlConnection
         */
        {
            // 1. Paramètres de connexion
            string server = "localhost";    // L'adresse du serveur (127.0.0.1 ou localhost en local)
            string database = "db_sioshop1";   // Le nom exact de ta base de données
            string uid = "root";            // L'utilisateur (souvent "root" par défaut)
            string pwd = "";                // Le mot de passe (souvent vide "" ou "root" sur XAMPP/WAMP)

            // 2. Chaine de connexion (Connection String)
            // On utilise le symbole $ devant les guillemets pour injecter directement nos variables dans le texte
            string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={pwd};";

            // 3. Création et retour de l'objet de connexion
            MySqlConnection connection = new MySqlConnection(connectionString);

            return connection;
        }
    }
}