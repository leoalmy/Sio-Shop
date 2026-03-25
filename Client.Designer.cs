namespace Sio_Shop
{
    partial class Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Client));
            this.dgv_Clients = new System.Windows.Forms.DataGridView();
            this.col_Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Prenom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Adresse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Mail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Tel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_Recherche = new System.Windows.Forms.Label();
            this.txt_Recherche = new System.Windows.Forms.TextBox();
            this.btn_NouveauClient = new System.Windows.Forms.Button();
            this.btn_Retour = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Clients
            // 
            this.dgv_Clients.AllowUserToAddRows = false;
            this.dgv_Clients.AllowUserToDeleteRows = false;
            this.dgv_Clients.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Clients.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Clients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Clients.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Id,
            this.col_Nom,
            this.col_Prenom,
            this.col_Adresse,
            this.col_Mail,
            this.col_Tel});
            this.dgv_Clients.Location = new System.Drawing.Point(27, 25);
            this.dgv_Clients.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Clients.Name = "dgv_Clients";
            this.dgv_Clients.ReadOnly = true;
            this.dgv_Clients.RowHeadersWidth = 51;
            this.dgv_Clients.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Clients.Size = new System.Drawing.Size(1147, 443);
            this.dgv_Clients.TabIndex = 0;
            this.dgv_Clients.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Clients_CellDoubleClick);
            // 
            // col_Id
            // 
            this.col_Id.FillWeight = 40F;
            this.col_Id.HeaderText = "Id";
            this.col_Id.MinimumWidth = 6;
            this.col_Id.Name = "col_Id";
            this.col_Id.ReadOnly = true;
            // 
            // col_Nom
            // 
            this.col_Nom.HeaderText = "Nom";
            this.col_Nom.MinimumWidth = 6;
            this.col_Nom.Name = "col_Nom";
            this.col_Nom.ReadOnly = true;
            // 
            // col_Prenom
            // 
            this.col_Prenom.HeaderText = "Prenom";
            this.col_Prenom.MinimumWidth = 6;
            this.col_Prenom.Name = "col_Prenom";
            this.col_Prenom.ReadOnly = true;
            // 
            // col_Adresse
            // 
            this.col_Adresse.FillWeight = 150F;
            this.col_Adresse.HeaderText = "Adresse";
            this.col_Adresse.MinimumWidth = 6;
            this.col_Adresse.Name = "col_Adresse";
            this.col_Adresse.ReadOnly = true;
            // 
            // col_Mail
            // 
            this.col_Mail.FillWeight = 120F;
            this.col_Mail.HeaderText = "Mail";
            this.col_Mail.MinimumWidth = 6;
            this.col_Mail.Name = "col_Mail";
            this.col_Mail.ReadOnly = true;
            // 
            // col_Tel
            // 
            this.col_Tel.HeaderText = "Tél";
            this.col_Tel.MinimumWidth = 6;
            this.col_Tel.Name = "col_Tel";
            this.col_Tel.ReadOnly = true;
            // 
            // lbl_Recherche
            // 
            this.lbl_Recherche.AutoSize = true;
            this.lbl_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Recherche.Location = new System.Drawing.Point(53, 511);
            this.lbl_Recherche.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Recherche.Name = "lbl_Recherche";
            this.lbl_Recherche.Size = new System.Drawing.Size(189, 24);
            this.lbl_Recherche.TabIndex = 1;
            this.lbl_Recherche.Text = "Recherche par nom :";
            // 
            // txt_Recherche
            // 
            this.txt_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Recherche.Location = new System.Drawing.Point(260, 507);
            this.txt_Recherche.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Recherche.Name = "txt_Recherche";
            this.txt_Recherche.Size = new System.Drawing.Size(265, 28);
            this.txt_Recherche.TabIndex = 2;
            this.txt_Recherche.TextChanged += new System.EventHandler(this.txt_Recherche_TextChanged);
            // 
            // btn_NouveauClient
            // 
            this.btn_NouveauClient.BackColor = System.Drawing.Color.White;
            this.btn_NouveauClient.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_NouveauClient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NouveauClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NouveauClient.Location = new System.Drawing.Point(600, 501);
            this.btn_NouveauClient.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NouveauClient.Name = "btn_NouveauClient";
            this.btn_NouveauClient.Size = new System.Drawing.Size(187, 43);
            this.btn_NouveauClient.TabIndex = 3;
            this.btn_NouveauClient.Text = "Nouveau Client";
            this.btn_NouveauClient.UseVisualStyleBackColor = false;
            this.btn_NouveauClient.Click += new System.EventHandler(this.btn_NouveauClient_Click);
            // 
            // btn_Retour
            // 
            this.btn_Retour.BackColor = System.Drawing.Color.White;
            this.btn_Retour.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retour.Location = new System.Drawing.Point(1040, 501);
            this.btn_Retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(133, 43);
            this.btn_Retour.TabIndex = 4;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = false;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1200, 578);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.btn_NouveauClient);
            this.Controls.Add(this.txt_Recherche);
            this.Controls.Add(this.lbl_Recherche);
            this.Controls.Add(this.dgv_Clients);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Clients";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Clients_FormClosing);
            this.Load += new System.EventHandler(this.Clients_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Clients)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Clients;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Prenom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Adresse;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Mail;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Tel;
        private System.Windows.Forms.Label lbl_Recherche;
        private System.Windows.Forms.TextBox txt_Recherche;
        private System.Windows.Forms.Button btn_NouveauClient;
        private System.Windows.Forms.Button btn_Retour;
    }
}