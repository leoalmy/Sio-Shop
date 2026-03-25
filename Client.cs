using MySql.Data.MySqlClient;
using Sio_Shop.Metiers;
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
    public partial class Client : Form
    {
        private bool _retourEnCours = false;
        public Client()
        {
            InitializeComponent();
        }

        // 1. L'événement qui se déclenche quand la page s'ouvre
        private void Clients_Load(object sender, EventArgs e)
        {
            ChargerClients(); // On appelle notre méthode de chargement !
        }

        // 2. Notre méthode magique pour remplir le tableau
        // On ajoute un paramètre optionnel "recherche" (vide par défaut)
        private void ChargerClients(string recherche = "")
        {
            dgv_Clients.Rows.Clear();

            // 1. On demande les données au Manager
            DataTable mesDonnees = ClientManager.ObtenirTousLesClients(recherche);

            // 2. On boucle sur les lignes reçues pour les mettre dans le tableau
            foreach (DataRow ligne in mesDonnees.Rows)
            {
                dgv_Clients.Rows.Add(
                    ligne["Num_client"].ToString(),
                    ligne["nom"].ToString(),
                    ligne["prenom"].ToString(),
                    ligne["adresse"].ToString(),
                    ligne["mail"].ToString(),
                    ligne["tel"].ToString()
                );
            }
        }

        // --- TES AUTRES BOUTONS EXISTANTS (Ne les efface pas !) ---

        private void btn_Retour_Click(object sender, EventArgs e)
        {
            _retourEnCours = true; // On signale qu'on clique sur le vrai bouton Retour
            MainMenu menu = new MainMenu();
            menu.Show();
            this.Close();
        }

        private void Clients_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si l'utilisateur a cliqué sur la croix (et non sur le bouton Retour)
            if (!_retourEnCours)
            {
                MainMenu menu = new MainMenu();
                menu.Show();
                // Pas besoin d'annuler (e.Cancel), on laisse la fenêtre Clients se fermer !
            }
        }

        private void btn_NouveauClient_Click(object sender, EventArgs e)
        {
            // On envoie un texte vide pour dire "Mode Création"
            _retourEnCours = true;
            Detail_Client pageDetail = new Detail_Client("");
            pageDetail.Show();
            this.Close();
        }

        private void dgv_Clients_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // On vérifie qu'on ne clique pas sur les en-têtes
            if (e.RowIndex >= 0)
            {
                // On récupère l'ID du client dans la 1ère colonne (index 0) de la ligne cliquée
                string idClique = dgv_Clients.Rows[e.RowIndex].Cells[0].Value.ToString();

                _retourEnCours = true;

                // On envoie cet ID pour dire "Mode Modification"
                Detail_Client pageDetail = new Detail_Client(idClique);
                pageDetail.Show();
                this.Close();
            }
        }

        private void txt_Recherche_TextChanged(object sender, EventArgs e)
        {
            ChargerClients(txt_Recherche.Text);
        }
    }
}