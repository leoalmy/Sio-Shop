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
            this.SuspendLayout();
            // 
            // btn_SaisirVente
            // 
            this.btn_SaisirVente.BackColor = System.Drawing.Color.White;
            this.btn_SaisirVente.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_SaisirVente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_SaisirVente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_SaisirVente.Location = new System.Drawing.Point(367, 49);
            this.btn_SaisirVente.Margin = new System.Windows.Forms.Padding(4);
            this.btn_SaisirVente.Name = "btn_SaisirVente";
            this.btn_SaisirVente.Size = new System.Drawing.Size(333, 68);
            this.btn_SaisirVente.TabIndex = 0;
            this.btn_SaisirVente.Text = "Saisir une vente";
            this.btn_SaisirVente.UseVisualStyleBackColor = false;
            this.btn_SaisirVente.Click += new System.EventHandler(this.btn_SaisirVente_Click);
            // 
            // btn_GestionClients
            // 
            this.btn_GestionClients.BackColor = System.Drawing.Color.White;
            this.btn_GestionClients.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_GestionClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionClients.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionClients.Location = new System.Drawing.Point(367, 142);
            this.btn_GestionClients.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GestionClients.Name = "btn_GestionClients";
            this.btn_GestionClients.Size = new System.Drawing.Size(333, 68);
            this.btn_GestionClients.TabIndex = 1;
            this.btn_GestionClients.Text = "Gestion clients";
            this.btn_GestionClients.UseVisualStyleBackColor = false;
            this.btn_GestionClients.Click += new System.EventHandler(this.btn_GestionClients_Click);
            // 
            // btn_GestionProduits
            // 
            this.btn_GestionProduits.BackColor = System.Drawing.Color.White;
            this.btn_GestionProduits.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_GestionProduits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionProduits.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionProduits.Location = new System.Drawing.Point(367, 234);
            this.btn_GestionProduits.Margin = new System.Windows.Forms.Padding(4);
            this.btn_GestionProduits.Name = "btn_GestionProduits";
            this.btn_GestionProduits.Size = new System.Drawing.Size(333, 68);
            this.btn_GestionProduits.TabIndex = 2;
            this.btn_GestionProduits.Text = "Gestion produits";
            this.btn_GestionProduits.UseVisualStyleBackColor = false;
            this.btn_GestionProduits.Click += new System.EventHandler(this.btn_GestionProduits_Click);
            // 
            // btn_Deconnexion
            // 
            this.btn_Deconnexion.BackColor = System.Drawing.Color.White;
            this.btn_Deconnexion.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Deconnexion.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Deconnexion.Location = new System.Drawing.Point(367, 388);
            this.btn_Deconnexion.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Deconnexion.Name = "btn_Deconnexion";
            this.btn_Deconnexion.Size = new System.Drawing.Size(333, 68);
            this.btn_Deconnexion.TabIndex = 3;
            this.btn_Deconnexion.Text = "Deconnexion";
            this.btn_Deconnexion.UseVisualStyleBackColor = false;
            this.btn_Deconnexion.Click += new System.EventHandler(this.btn_Deconnexion_Click);
            // 
            // lbl_UserInfo
            // 
            this.lbl_UserInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_UserInfo.Location = new System.Drawing.Point(16, 480);
            this.lbl_UserInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_UserInfo.Name = "lbl_UserInfo";
            this.lbl_UserInfo.Size = new System.Drawing.Size(1035, 49);
            this.lbl_UserInfo.TabIndex = 4;
            this.lbl_UserInfo.Text = "Bienvenue admin\r\nMATRICULE : 0";
            this.lbl_UserInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1067, 566);
            this.Controls.Add(this.lbl_UserInfo);
            this.Controls.Add(this.btn_Deconnexion);
            this.Controls.Add(this.btn_GestionProduits);
            this.Controls.Add(this.btn_GestionClients);
            this.Controls.Add(this.btn_SaisirVente);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Principal - Sio Shop";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainMenu_FormClosing);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_SaisirVente;
        private System.Windows.Forms.Button btn_GestionClients;
        private System.Windows.Forms.Button btn_GestionProduits;
        private System.Windows.Forms.Button btn_Deconnexion;
        private System.Windows.Forms.Label lbl_UserInfo;
    }
}