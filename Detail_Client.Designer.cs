namespace Sio_Shop
{
    partial class Detail_Client
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_Client));
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.lbl_NumClient = new System.Windows.Forms.Label();
            this.txt_NumClient = new System.Windows.Forms.TextBox();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.lbl_Prenom = new System.Windows.Forms.Label();
            this.txt_Prenom = new System.Windows.Forms.TextBox();
            this.lbl_Adresse = new System.Windows.Forms.Label();
            this.txt_Adresse = new System.Windows.Forms.TextBox();
            this.lbl_Mail = new System.Windows.Forms.Label();
            this.txt_Mail = new System.Windows.Forms.TextBox();
            this.lbl_Tel = new System.Windows.Forms.Label();
            this.txt_Tel = new System.Windows.Forms.TextBox();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.dgv_Achats = new System.Windows.Forms.DataGridView();
            this.col_Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Modele = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_MontantTotal = new System.Windows.Forms.Label();
            this.btn_Retour = new System.Windows.Forms.Button();
            this.btn_VoirFacture = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Achats)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.Location = new System.Drawing.Point(27, 25);
            this.lbl_Titre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(219, 29);
            this.lbl_Titre.TabIndex = 0;
            this.lbl_Titre.Text = "Informations client :";
            // 
            // lbl_NumClient
            // 
            this.lbl_NumClient.AutoSize = true;
            this.lbl_NumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_NumClient.Location = new System.Drawing.Point(27, 86);
            this.lbl_NumClient.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_NumClient.Name = "lbl_NumClient";
            this.lbl_NumClient.Size = new System.Drawing.Size(86, 20);
            this.lbl_NumClient.TabIndex = 1;
            this.lbl_NumClient.Text = "N° Client :";
            // 
            // txt_NumClient
            // 
            this.txt_NumClient.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_NumClient.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_NumClient.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_NumClient.Location = new System.Drawing.Point(133, 86);
            this.txt_NumClient.Margin = new System.Windows.Forms.Padding(4);
            this.txt_NumClient.Name = "txt_NumClient";
            this.txt_NumClient.ReadOnly = true;
            this.txt_NumClient.Size = new System.Drawing.Size(133, 19);
            this.txt_NumClient.TabIndex = 2;
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom.Location = new System.Drawing.Point(27, 135);
            this.lbl_Nom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(54, 20);
            this.lbl_Nom.TabIndex = 3;
            this.lbl_Nom.Text = "Nom :";
            // 
            // txt_Nom
            // 
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.Location = new System.Drawing.Point(133, 132);
            this.txt_Nom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(265, 26);
            this.txt_Nom.TabIndex = 4;
            // 
            // lbl_Prenom
            // 
            this.lbl_Prenom.AutoSize = true;
            this.lbl_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Prenom.Location = new System.Drawing.Point(27, 185);
            this.lbl_Prenom.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Prenom.Name = "lbl_Prenom";
            this.lbl_Prenom.Size = new System.Drawing.Size(77, 20);
            this.lbl_Prenom.TabIndex = 5;
            this.lbl_Prenom.Text = "Prénom :";
            // 
            // txt_Prenom
            // 
            this.txt_Prenom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Prenom.Location = new System.Drawing.Point(133, 181);
            this.txt_Prenom.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Prenom.Name = "txt_Prenom";
            this.txt_Prenom.Size = new System.Drawing.Size(265, 26);
            this.txt_Prenom.TabIndex = 6;
            // 
            // lbl_Adresse
            // 
            this.lbl_Adresse.AutoSize = true;
            this.lbl_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Adresse.Location = new System.Drawing.Point(467, 86);
            this.lbl_Adresse.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Adresse.Name = "lbl_Adresse";
            this.lbl_Adresse.Size = new System.Drawing.Size(81, 20);
            this.lbl_Adresse.TabIndex = 7;
            this.lbl_Adresse.Text = "Adresse :";
            // 
            // txt_Adresse
            // 
            this.txt_Adresse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Adresse.Location = new System.Drawing.Point(600, 82);
            this.txt_Adresse.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Adresse.Name = "txt_Adresse";
            this.txt_Adresse.Size = new System.Drawing.Size(532, 26);
            this.txt_Adresse.TabIndex = 8;
            // 
            // lbl_Mail
            // 
            this.lbl_Mail.AutoSize = true;
            this.lbl_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mail.Location = new System.Drawing.Point(467, 135);
            this.lbl_Mail.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Mail.Name = "lbl_Mail";
            this.lbl_Mail.Size = new System.Drawing.Size(50, 20);
            this.lbl_Mail.TabIndex = 9;
            this.lbl_Mail.Text = "Mail :";
            // 
            // txt_Mail
            // 
            this.txt_Mail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Mail.Location = new System.Drawing.Point(600, 132);
            this.txt_Mail.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Mail.Name = "txt_Mail";
            this.txt_Mail.Size = new System.Drawing.Size(532, 26);
            this.txt_Mail.TabIndex = 10;
            // 
            // lbl_Tel
            // 
            this.lbl_Tel.AutoSize = true;
            this.lbl_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Tel.Location = new System.Drawing.Point(467, 185);
            this.lbl_Tel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Tel.Name = "lbl_Tel";
            this.lbl_Tel.Size = new System.Drawing.Size(115, 20);
            this.lbl_Tel.TabIndex = 11;
            this.lbl_Tel.Text = "N° téléphone :";
            // 
            // txt_Tel
            // 
            this.txt_Tel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Tel.Location = new System.Drawing.Point(600, 181);
            this.txt_Tel.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tel.Name = "txt_Tel";
            this.txt_Tel.Size = new System.Drawing.Size(265, 26);
            this.txt_Tel.TabIndex = 12;
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.BackColor = System.Drawing.Color.White;
            this.btn_Enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enregistrer.Location = new System.Drawing.Point(133, 234);
            this.btn_Enregistrer.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(160, 43);
            this.btn_Enregistrer.TabIndex = 13;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // dgv_Achats
            // 
            this.dgv_Achats.AllowUserToAddRows = false;
            this.dgv_Achats.AllowUserToDeleteRows = false;
            this.dgv_Achats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Achats.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Achats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Achats.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Date,
            this.col_Reference,
            this.col_Marque,
            this.col_Modele,
            this.col_Prix});
            this.dgv_Achats.Location = new System.Drawing.Point(27, 308);
            this.dgv_Achats.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Achats.MultiSelect = false;
            this.dgv_Achats.Name = "dgv_Achats";
            this.dgv_Achats.ReadOnly = true;
            this.dgv_Achats.RowHeadersVisible = false;
            this.dgv_Achats.RowHeadersWidth = 51;
            this.dgv_Achats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Achats.Size = new System.Drawing.Size(1107, 308);
            this.dgv_Achats.TabIndex = 14;
            this.dgv_Achats.SelectionChanged += new System.EventHandler(this.dgv_Achats_SelectionChanged);
            // 
            // col_Date
            // 
            this.col_Date.HeaderText = "Date";
            this.col_Date.MinimumWidth = 6;
            this.col_Date.Name = "col_Date";
            this.col_Date.ReadOnly = true;
            // 
            // col_Reference
            // 
            this.col_Reference.HeaderText = "Référence";
            this.col_Reference.MinimumWidth = 6;
            this.col_Reference.Name = "col_Reference";
            this.col_Reference.ReadOnly = true;
            // 
            // col_Marque
            // 
            this.col_Marque.HeaderText = "Marque";
            this.col_Marque.MinimumWidth = 6;
            this.col_Marque.Name = "col_Marque";
            this.col_Marque.ReadOnly = true;
            // 
            // col_Modele
            // 
            this.col_Modele.HeaderText = "Modèle";
            this.col_Modele.MinimumWidth = 6;
            this.col_Modele.Name = "col_Modele";
            this.col_Modele.ReadOnly = true;
            // 
            // col_Prix
            // 
            this.col_Prix.HeaderText = "Prix";
            this.col_Prix.MinimumWidth = 6;
            this.col_Prix.Name = "col_Prix";
            this.col_Prix.ReadOnly = true;
            // 
            // lbl_MontantTotal
            // 
            this.lbl_MontantTotal.AutoSize = true;
            this.lbl_MontantTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_MontantTotal.Location = new System.Drawing.Point(27, 640);
            this.lbl_MontantTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_MontantTotal.Name = "lbl_MontantTotal";
            this.lbl_MontantTotal.Size = new System.Drawing.Size(167, 25);
            this.lbl_MontantTotal.TabIndex = 15;
            this.lbl_MontantTotal.Text = "Montant total : 0 €";
            // 
            // btn_Retour
            // 
            this.btn_Retour.BackColor = System.Drawing.Color.White;
            this.btn_Retour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retour.Location = new System.Drawing.Point(1013, 634);
            this.btn_Retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(120, 43);
            this.btn_Retour.TabIndex = 16;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = false;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // btn_VoirFacture
            // 
            this.btn_VoirFacture.BackColor = System.Drawing.Color.White;
            this.btn_VoirFacture.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_VoirFacture.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VoirFacture.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_VoirFacture.Location = new System.Drawing.Point(857, 634);
            this.btn_VoirFacture.Margin = new System.Windows.Forms.Padding(4);
            this.btn_VoirFacture.Name = "btn_VoirFacture";
            this.btn_VoirFacture.Size = new System.Drawing.Size(148, 43);
            this.btn_VoirFacture.TabIndex = 17;
            this.btn_VoirFacture.Text = "Voir Facture";
            this.btn_VoirFacture.UseVisualStyleBackColor = false;
            this.btn_VoirFacture.Click += new System.EventHandler(this.btn_VoirFacture_Click);
            // 
            // Detail_Client
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1173, 702);
            this.Controls.Add(this.btn_VoirFacture);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.lbl_MontantTotal);
            this.Controls.Add(this.dgv_Achats);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.txt_Tel);
            this.Controls.Add(this.lbl_Tel);
            this.Controls.Add(this.txt_Mail);
            this.Controls.Add(this.lbl_Mail);
            this.Controls.Add(this.txt_Adresse);
            this.Controls.Add(this.lbl_Adresse);
            this.Controls.Add(this.txt_Prenom);
            this.Controls.Add(this.lbl_Prenom);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.txt_NumClient);
            this.Controls.Add(this.lbl_NumClient);
            this.Controls.Add(this.lbl_Titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Detail_Client";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Détail Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Detail_Client_FormClosing);
            this.Load += new System.EventHandler(this.Detail_Client_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Achats)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Titre;
        private System.Windows.Forms.Label lbl_NumClient;
        private System.Windows.Forms.TextBox txt_NumClient;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label lbl_Prenom;
        private System.Windows.Forms.TextBox txt_Prenom;
        private System.Windows.Forms.Label lbl_Adresse;
        private System.Windows.Forms.TextBox txt_Adresse;
        private System.Windows.Forms.Label lbl_Mail;
        private System.Windows.Forms.TextBox txt_Mail;
        private System.Windows.Forms.Label lbl_Tel;
        private System.Windows.Forms.TextBox txt_Tel;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.DataGridView dgv_Achats;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Modele;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Prix;
        private System.Windows.Forms.Label lbl_MontantTotal;
        private System.Windows.Forms.Button btn_Retour;
        private System.Windows.Forms.Button btn_VoirFacture;
    }
}