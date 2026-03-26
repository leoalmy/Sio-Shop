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
    public partial class MainMenu : Form
    {
        private bool _deconnexionEnCours = false;

        // 1. C'est le nouveau constructeur qui "accepte" les données
        public MainMenu()
        {
            InitializeComponent();
        }

        // 2. On utilise l'événement Load pour mettre à jour le texte
        private void MainMenu_Load(object sender, EventArgs e)
        {
            // On récupère ton label du bas (vérifie bien son nom dans le Designer, ex: lbl_UserInfo)
            // Et on construit le texte dynamique sur deux lignes
            lbl_UserInfo.Text = $"Bienvenue {Session.Nom}\nMATRICULE : {Session.Matricule}";
        }

        private void btn_SaisirVente_Click(object sender, EventArgs e)
        {
            // Ouvre la page Vente
            Vente pageVente = new Vente();
            pageVente.Show();
            this.Hide();
        }

        private void btn_GestionClients_Click(object sender, EventArgs e)
        {
            // Ouvre la page Client
            Client pageClients = new Client();
            pageClients.Show();
            this.Hide();
        }

        private void btn_GestionProduits_Click(object sender, EventArgs e)
        {
            // Ouvre la page Produit
            Produit pageProduits = new Produit();
            pageProduits.Show();
            this.Hide();
        }

        private void btn_GestionMarques_Click(object sender, EventArgs e)
        {
            // Ouvre la page Marque
            Marque pageProduits = new Marque();
            pageProduits.Show();
            this.Hide();
        }

        private void btn_Deconnexion_Click(object sender, EventArgs e)
        {
            _deconnexionEnCours = true; // On prévient l'application qu'on se déconnecte exprès
            Connexion pageConnexion = new Connexion();
            pageConnexion.Show();
            this.Close();
        }
        
        private void MainMenu_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Si on clique sur la croix (donc pas une déconnexion)
            if (!_deconnexionEnCours)
            {
                DialogResult reponse = MessageBox.Show("Voulez-vous vraiment quitter l'application ?", "Fermeture", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (reponse == DialogResult.Yes)
                {
                    // On tue complètement le processus de l'application (ça ferme tout !)
                    Environment.Exit(0);
                }
                else
                {
                    // L'utilisateur a cliqué sur Non : on annule la fermeture de la fenêtre
                    e.Cancel = true;
                }
            }
        }
    }
}