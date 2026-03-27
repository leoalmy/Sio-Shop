using System.Drawing;
using System.Windows.Forms;

namespace Sio_Shop.Utils
{
    public static class ThemeManager
    {
        // 1. Variable globale pour mémoriser l'état (Clair par défaut)
        public static bool EstModeSombre
        {
            get
            {
                // Quand on demande l'état, on va lire le fichier de sauvegarde
                return Properties.Settings.Default.ModeSombreActive;
            }
            set
            {
                // Quand on change l'état, on met à jour le fichier ET on sauvegarde sur le PC
                Properties.Settings.Default.ModeSombreActive = value;
                Properties.Settings.Default.Save();
            }
        }

        // 2. La méthode qui s'adapte en fonction de la variable
        public static void AppliquerTheme(Control conteneur)
        {
            // On définit les couleurs à la volée selon le mode actif
            Color fond = EstModeSombre ? Color.FromArgb(45, 45, 48) : Color.FromArgb(240, 240, 240);
            Color texte = EstModeSombre ? Color.White : Color.Black;
            Color fondBouton = EstModeSombre ? Color.FromArgb(62, 62, 66) : Color.White;
            Color bordure = EstModeSombre ? Color.FromArgb(100, 100, 100) : Color.LightGray;

            conteneur.BackColor = fond;
            conteneur.ForeColor = texte;

            foreach (Control c in conteneur.Controls)
            {
                if (c.HasChildren)
                {
                    AppliquerTheme(c); // Récursivité
                }

                if (c is Button btn)
                {
                    btn.BackColor = fondBouton;
                    btn.ForeColor = texte;
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderColor = bordure;
                }
                else if (c is Label lbl)
                {
                    lbl.BackColor = Color.Transparent;
                    lbl.ForeColor = texte;
                }
                else if (c is TextBox txt)
                {
                    txt.BackColor = fondBouton;
                    txt.ForeColor = texte;
                    txt.BorderStyle = BorderStyle.FixedSingle;
                }
                else if (c is DataGridView dgv)
                {
                    dgv.BackgroundColor = fond;
                    dgv.GridColor = bordure;
                    dgv.DefaultCellStyle.BackColor = fondBouton;
                    dgv.DefaultCellStyle.ForeColor = texte;

                    dgv.EnableHeadersVisualStyles = false;
                    dgv.ColumnHeadersDefaultCellStyle.BackColor = fond;
                    dgv.ColumnHeadersDefaultCellStyle.ForeColor = texte;
                }
                else if (c is ComboBox cmb)
                {
                    cmb.BackColor = fondBouton;
                    cmb.ForeColor = texte;
                    cmb.FlatStyle = FlatStyle.Flat;
                }
            }
        }
    }
}