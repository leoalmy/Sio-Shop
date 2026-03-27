using Sio_Shop.Metiers;
using Sio_Shop.Utils;
using System;
using System.Drawing;
using System.Drawing.Drawing2D;
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
            ThemeManager.AppliquerTheme(this);

            if (ThemeManager.EstModeSombre)
            {
                btn_DarkMode.BackgroundImage = Properties.Resources.icon_sun;
            }
            else
            {
                btn_DarkMode.BackgroundImage = Properties.Resources.icon_moon;
            }

            // --- LE COUP DE CISEAU POUR LE BOUTON ROND ---
            GraphicsPath chemin = new GraphicsPath();
            // On dessine un cercle de la taille exacte du bouton
            chemin.AddEllipse(0, 0, btn_DarkMode.Width, btn_DarkMode.Height);
            // On applique ce cercle comme nouvelle forme (Region) pour le bouton
            btn_DarkMode.Region = new Region(chemin);

            // On récupère ton label du bas (vérifie bien son nom dans le Designer, ex: lbl_UserInfo)
            // Et on construit le texte dynamique sur deux lignes
            lbl_UserInfo.Text = $"Bienvenue {Session.Nom}\nMATRICULE : {Session.Matricule}";


            MettreAJourDashboard("Aperçu Général", "Passez la souris sur le menu pour voir les statistiques.");
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

        private void btn_MouseEnter(object sender, EventArgs e)
        {
            // On récupère le bouton qui a déclenché l'événement
            Button boutonSurvole = sender as Button;

            if (boutonSurvole != null)
            {
                // Selon le nom du bouton, on charge les bonnes stats
                switch (boutonSurvole.Name)
                {
                    case "btn_SaisirVente":
                        decimal ca = VenteManager.CalculerChiffreAffairesTotal();
                        MettreAJourDashboard("Aperçu : Ventes", $"Chiffre d'affaires total :\n{ca:0.00} €");
                        break;

                    case "btn_GestionClients":
                        int totalClients = ClientManager.CompterTotalClients();
                        MettreAJourDashboard("Aperçu : Clients", $"Nombre total de clients :\n{totalClients}");
                        break;

                    case "btn_GestionProduits":
                        int ruptures = ProduitManager.CompterProduitsEnRupture();
                        MettreAJourDashboard("Aperçu : Produits", $"Produits en rupture de stock :\n{ruptures}");
                        break;

                    case "btn_GestionMarques":
                        int nbMarque = MarqueManager.CompterTotalMarques();
                        MettreAJourDashboard("Aperçu : Marques", $"Nombre de marques partenaires :\n{nbMarque}");
                        break;
                }
            }
        }

        private void MettreAJourDashboard(string titre, string info)
        {
            lbl_TitreDashboard.Text = titre;
            lbl_InfoDashboard.Text = info;
        }

        private void btn_DarkMode_Click(object sender, EventArgs e)
        {
            // 1. On inverse le mode (si c'était faux ça devient vrai, et inversement)
            ThemeManager.EstModeSombre = !ThemeManager.EstModeSombre;

            // 2. On applique le nouveau thème sur la page actuelle (MainMenu)
            ThemeManager.AppliquerTheme(this);

            // 3. On change l'image du bouton depuis les ressources du projet
            if (ThemeManager.EstModeSombre)
            {
                // Affiche le soleil pour proposer de repasser en mode clair
                btn_DarkMode.BackgroundImage = Properties.Resources.icon_sun;
            }
            else
            {
                // Affiche la lune pour proposer de passer en mode sombre
                btn_DarkMode.BackgroundImage = Properties.Resources.icon_moon;
            }
        }
    }
}