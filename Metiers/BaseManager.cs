using System;
using MySql.Data.MySqlClient;
using dotenv.net;
using System.Windows.Forms;

namespace Sio_Shop
{
    class BaseManager
    {
        public static MySqlConnection GetDBConnection(string ConnexionType = null)
        {
            // Charge le fichier .env
            DotEnv.Load();
            var envVars = DotEnv.Read();

            // Récupération sécurisée avec des valeurs par défaut si la clé manque
            string server = envVars["DB_SERVER"];
            string database = envVars["DB_NAME"];
            string uid = "";
            string pwd = "";

            // Sélection des identifiants selon le type
            switch (ConnexionType)
            {
                case "login":
                    uid = envVars["DB_LOGIN_USER"];
                    pwd = envVars["DB_LOGIN_PASS"];
                    break;

                default:
                    uid = envVars["DB_USER"];
                    pwd = envVars["DB_PASS"];
                    break;
            }

            // Construction de la chaîne de connexion
            string connectionString = $"Server={server};Database={database};Uid={uid};Pwd={pwd};";

            // Retour de l'objet
            return new MySqlConnection(connectionString);
        }
    }
}