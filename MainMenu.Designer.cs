namespace Sio_Shop
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.btn_SaisirVente = new System.Windows.Forms.Button();
            this.btn_GestionClients = new System.Windows.Forms.Button();
            this.btn_GestionProduits = new System.Windows.Forms.Button();
            this.btn_Deconnexion = new System.Windows.Forms.Button();
            this.lbl_UserInfo = new System.Windows.Forms.Label();
            this.btn_GestionMarques = new System.Windows.Forms.Button();
            this.panel_Menu = new System.Windows.Forms.Panel();
            this.panel_graph = new System.Windows.Forms.Panel();
            this.lbl_InfoDashboard = new System.Windows.Forms.Label();
            this.lbl_TitreDashboard = new System.Windows.Forms.Label();
            this.btn_DarkMode = new System.Windows.Forms.Button();
            this.panel_Menu.SuspendLayout();
            this.panel_graph.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_SaisirVente
            // 
            this.btn_SaisirVente.BackColor = System.Drawing.Color.White;
            this.btn_SaisirVente.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_SaisirVente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaisirVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaisirVente.Location = new System.Drawing.Point(13, 58);
            this.btn_SaisirVente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SaisirVente.Name = "btn_SaisirVente";
            this.btn_SaisirVente.Size = new System.Drawing.Size(333, 68);
            this.btn_SaisirVente.TabIndex = 0;
            this.btn_SaisirVente.Text = "Saisir une vente";
            this.btn_SaisirVente.UseVisualStyleBackColor = false;
            this.btn_SaisirVente.Click += new System.EventHandler(this.btn_SaisirVente_Click);
            this.btn_SaisirVente.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            // 
            // btn_GestionClients
            // 
            this.btn_GestionClients.BackColor = System.Drawing.Color.White;
            this.btn_GestionClients.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_GestionClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionClients.Location = new System.Drawing.Point(13, 159);
            this.btn_GestionClients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GestionClients.Name = "btn_GestionClients";
            this.btn_GestionClients.Size = new System.Drawing.Size(333, 68);
            this.btn_GestionClients.TabIndex = 1;
            this.btn_GestionClients.Text = "Gestion clients";
            this.btn_GestionClients.UseVisualStyleBackColor = false;
            this.btn_GestionClients.Click += new System.EventHandler(this.btn_GestionClients_Click);
            this.btn_GestionClients.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            // 
            // btn_GestionProduits
            // 
            this.btn_GestionProduits.BackColor = System.Drawing.Color.White;
            this.btn_GestionProduits.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_GestionProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionProduits.Location = new System.Drawing.Point(13, 257);
            this.btn_GestionProduits.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GestionProduits.Name = "btn_GestionProduits";
            this.btn_GestionProduits.Size = new System.Drawing.Size(333, 68);
            this.btn_GestionProduits.TabIndex = 2;
            this.btn_GestionProduits.Text = "Gestion produits";
            this.btn_GestionProduits.UseVisualStyleBackColor = false;
            this.btn_GestionProduits.Click += new System.EventHandler(this.btn_GestionProduits_Click);
            this.btn_GestionProduits.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            // 
            // btn_Deconnexion
            // 
            this.btn_Deconnexion.BackColor = System.Drawing.Color.White;
            this.btn_Deconnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Deconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deconnexion.Location = new System.Drawing.Point(13, 500);
            this.btn_Deconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Deconnexion.Name = "btn_Deconnexion";
            this.btn_Deconnexion.Size = new System.Drawing.Size(333, 68);
            this.btn_Deconnexion.TabIndex = 4;
            this.btn_Deconnexion.Text = "Deconnexion";
            this.btn_Deconnexion.UseVisualStyleBackColor = false;
            this.btn_Deconnexion.Click += new System.EventHandler(this.btn_Deconnexion_Click);
            // 
            // lbl_UserInfo
            // 
            this.lbl_UserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserInfo.Location = new System.Drawing.Point(367, 508);
            this.lbl_UserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserInfo.Name = "lbl_UserInfo";
            this.lbl_UserInfo.Size = new System.Drawing.Size(587, 64);
            this.lbl_UserInfo.TabIndex = 4;
            this.lbl_UserInfo.Text = "Bienvenue admin\r\nMATRICULE : 0";
            this.lbl_UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GestionMarques
            // 
            this.btn_GestionMarques.BackColor = System.Drawing.Color.White;
            this.btn_GestionMarques.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_GestionMarques.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionMarques.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionMarques.Location = new System.Drawing.Point(13, 356);
            this.btn_GestionMarques.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GestionMarques.Name = "btn_GestionMarques";
            this.btn_GestionMarques.Size = new System.Drawing.Size(333, 68);
            this.btn_GestionMarques.TabIndex = 3;
            this.btn_GestionMarques.Text = "Gestion Marques";
            this.btn_GestionMarques.UseVisualStyleBackColor = false;
            this.btn_GestionMarques.Click += new System.EventHandler(this.btn_GestionMarques_Click);
            this.btn_GestionMarques.MouseEnter += new System.EventHandler(this.btn_MouseEnter);
            // 
            // panel_Menu
            // 
            this.panel_Menu.Controls.Add(this.btn_SaisirVente);
            this.panel_Menu.Controls.Add(this.btn_GestionClients);
            this.panel_Menu.Controls.Add(this.btn_GestionMarques);
            this.panel_Menu.Controls.Add(this.btn_Deconnexion);
            this.panel_Menu.Controls.Add(this.btn_GestionProduits);
            this.panel_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_Menu.Location = new System.Drawing.Point(0, 0);
            this.panel_Menu.Name = "panel_Menu";
            this.panel_Menu.Size = new System.Drawing.Size(360, 581);
            this.panel_Menu.TabIndex = 5;
            // 
            // panel_graph
            // 
            this.panel_graph.Controls.Add(this.lbl_InfoDashboard);
            this.panel_graph.Controls.Add(this.lbl_TitreDashboard);
            this.panel_graph.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_graph.Location = new System.Drawing.Point(360, 0);
            this.panel_graph.Name = "panel_graph";
            this.panel_graph.Size = new System.Drawing.Size(712, 492);
            this.panel_graph.TabIndex = 6;
            // 
            // lbl_InfoDashboard
            // 
            this.lbl_InfoDashboard.AutoSize = true;
            this.lbl_InfoDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_InfoDashboard.Location = new System.Drawing.Point(6, 159);
            this.lbl_InfoDashboard.Name = "lbl_InfoDashboard";
            this.lbl_InfoDashboard.Size = new System.Drawing.Size(234, 36);
            this.lbl_InfoDashboard.TabIndex = 1;
            this.lbl_InfoDashboard.Text = "Infos Dashboard";
            // 
            // lbl_TitreDashboard
            // 
            this.lbl_TitreDashboard.AutoSize = true;
            this.lbl_TitreDashboard.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TitreDashboard.Location = new System.Drawing.Point(100, 32);
            this.lbl_TitreDashboard.Name = "lbl_TitreDashboard";
            this.lbl_TitreDashboard.Size = new System.Drawing.Size(140, 46);
            this.lbl_TitreDashboard.TabIndex = 0;
            this.lbl_TitreDashboard.Text = "Titre : ";
            // 
            // btn_DarkMode
            // 
            this.btn_DarkMode.BackgroundImage = global::Sio_Shop.Properties.Resources.icon_moon;
            this.btn_DarkMode.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_DarkMode.FlatAppearance.BorderSize = 0;
            this.btn_DarkMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DarkMode.Location = new System.Drawing.Point(985, 498);
            this.btn_DarkMode.Name = "btn_DarkMode";
            this.btn_DarkMode.Size = new System.Drawing.Size(75, 75);
            this.btn_DarkMode.TabIndex = 7;
            this.btn_DarkMode.UseVisualStyleBackColor = true;
            this.btn_DarkMode.Click += new System.EventHandler(this.btn_DarkMode_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1072, 581);
            this.Controls.Add(this.btn_DarkMode);
            this.Controls.Add(this.panel_graph);
            this.Controls.Add(this.panel_Menu);
            this.Controls.Add(this.lbl_UserInfo);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Sio Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.panel_Menu.ResumeLayout(false);
            this.panel_graph.ResumeLayout(false);
            this.panel_graph.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaisirVente;
        private System.Windows.Forms.Button btn_GestionClients;
        private System.Windows.Forms.Button btn_GestionProduits;
        private System.Windows.Forms.Button btn_Deconnexion;
        private System.Windows.Forms.Label lbl_UserInfo;
        private System.Windows.Forms.Button btn_GestionMarques;
        private System.Windows.Forms.Panel panel_Menu;
        private System.Windows.Forms.Panel panel_graph;
        private System.Windows.Forms.Label lbl_TitreDashboard;
        private System.Windows.Forms.Label lbl_InfoDashboard;
        private System.Windows.Forms.Button btn_DarkMode;
    }
}