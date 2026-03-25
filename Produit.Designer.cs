namespace Sio_Shop
{
    partial class Produit
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Produit));
            this.dgv_Produits = new System.Windows.Forms.DataGridView();
            this.col_Reference = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Marque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Prix = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Stock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl_RechercheAvancee = new System.Windows.Forms.Label();
            this.lbl_Marque = new System.Windows.Forms.Label();
            this.cb_Marque = new System.Windows.Forms.ComboBox();
            this.btn_NouveauProduit = new System.Windows.Forms.Button();
            this.btn_Retour = new System.Windows.Forms.Button();
            this.btn_MajStock = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produits)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Produits
            // 
            this.dgv_Produits.AllowUserToAddRows = false;
            this.dgv_Produits.AllowUserToDeleteRows = false;
            this.dgv_Produits.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Produits.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Produits.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Produits.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_Reference,
            this.col_Marque,
            this.col_Nom,
            this.col_Prix,
            this.col_Stock});
            this.dgv_Produits.Location = new System.Drawing.Point(27, 25);
            this.dgv_Produits.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Produits.Name = "dgv_Produits";
            this.dgv_Produits.ReadOnly = true;
            this.dgv_Produits.RowHeadersVisible = false;
            this.dgv_Produits.RowHeadersWidth = 51;
            this.dgv_Produits.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Produits.Size = new System.Drawing.Size(867, 554);
            this.dgv_Produits.TabIndex = 0;
            this.dgv_Produits.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Produits_CellContentClick);
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
            // col_Nom
            // 
            this.col_Nom.HeaderText = "Nom";
            this.col_Nom.MinimumWidth = 6;
            this.col_Nom.Name = "col_Nom";
            this.col_Nom.ReadOnly = true;
            // 
            // col_Prix
            // 
            this.col_Prix.HeaderText = "Prix";
            this.col_Prix.MinimumWidth = 6;
            this.col_Prix.Name = "col_Prix";
            this.col_Prix.ReadOnly = true;
            // 
            // col_Stock
            // 
            this.col_Stock.HeaderText = "Stock";
            this.col_Stock.MinimumWidth = 6;
            this.col_Stock.Name = "col_Stock";
            this.col_Stock.ReadOnly = true;
            // 
            // lbl_RechercheAvancee
            // 
            this.lbl_RechercheAvancee.AutoSize = true;
            this.lbl_RechercheAvancee.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_RechercheAvancee.Location = new System.Drawing.Point(920, 49);
            this.lbl_RechercheAvancee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_RechercheAvancee.Name = "lbl_RechercheAvancee";
            this.lbl_RechercheAvancee.Size = new System.Drawing.Size(271, 31);
            this.lbl_RechercheAvancee.TabIndex = 1;
            this.lbl_RechercheAvancee.Text = "Recherche avancée :";
            // 
            // lbl_Marque
            // 
            this.lbl_Marque.AutoSize = true;
            this.lbl_Marque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Marque.Location = new System.Drawing.Point(933, 123);
            this.lbl_Marque.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Marque.Name = "lbl_Marque";
            this.lbl_Marque.Size = new System.Drawing.Size(85, 24);
            this.lbl_Marque.TabIndex = 2;
            this.lbl_Marque.Text = "Marque :";
            // 
            // cb_Marque
            // 
            this.cb_Marque.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Marque.FormattingEnabled = true;
            this.cb_Marque.Items.AddRange(new object[] {
            "TOUTES"});
            this.cb_Marque.Location = new System.Drawing.Point(1040, 119);
            this.cb_Marque.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Marque.Name = "cb_Marque";
            this.cb_Marque.Size = new System.Drawing.Size(199, 28);
            this.cb_Marque.TabIndex = 3;
            this.cb_Marque.Text = "TOUTES";
            this.cb_Marque.SelectedIndexChanged += new System.EventHandler(this.cb_Marque_SelectedIndexChanged);
            // 
            // btn_NouveauProduit
            // 
            this.btn_NouveauProduit.BackColor = System.Drawing.Color.White;
            this.btn_NouveauProduit.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_NouveauProduit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NouveauProduit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NouveauProduit.Location = new System.Drawing.Point(987, 246);
            this.btn_NouveauProduit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_NouveauProduit.Name = "btn_NouveauProduit";
            this.btn_NouveauProduit.Size = new System.Drawing.Size(213, 43);
            this.btn_NouveauProduit.TabIndex = 4;
            this.btn_NouveauProduit.Text = "Nouveau produit";
            this.btn_NouveauProduit.UseVisualStyleBackColor = false;
            this.btn_NouveauProduit.Click += new System.EventHandler(this.btn_NouveauProduit_Click);
            // 
            // btn_Retour
            // 
            this.btn_Retour.BackColor = System.Drawing.Color.White;
            this.btn_Retour.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retour.Location = new System.Drawing.Point(1133, 535);
            this.btn_Retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(120, 43);
            this.btn_Retour.TabIndex = 5;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = false;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // btn_MajStock
            // 
            this.btn_MajStock.BackColor = System.Drawing.Color.White;
            this.btn_MajStock.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_MajStock.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MajStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MajStock.Location = new System.Drawing.Point(987, 366);
            this.btn_MajStock.Margin = new System.Windows.Forms.Padding(4);
            this.btn_MajStock.Name = "btn_MajStock";
            this.btn_MajStock.Size = new System.Drawing.Size(213, 43);
            this.btn_MajStock.TabIndex = 6;
            this.btn_MajStock.Text = "MAJ Stock";
            this.btn_MajStock.UseVisualStyleBackColor = false;
            this.btn_MajStock.Click += new System.EventHandler(this.btn_MajStock_Click);
            // 
            // Produit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1280, 603);
            this.Controls.Add(this.btn_MajStock);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.btn_NouveauProduit);
            this.Controls.Add(this.cb_Marque);
            this.Controls.Add(this.lbl_Marque);
            this.Controls.Add(this.lbl_RechercheAvancee);
            this.Controls.Add(this.dgv_Produits);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Produit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des produits";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Produit_FormClosing);
            this.Load += new System.EventHandler(this.Produit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Produits)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgv_Produits;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Reference;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Marque;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Prix;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Stock;
        private System.Windows.Forms.Label lbl_RechercheAvancee;
        private System.Windows.Forms.Label lbl_Marque;
        private System.Windows.Forms.ComboBox cb_Marque;
        private System.Windows.Forms.Button btn_NouveauProduit;
        private System.Windows.Forms.Button btn_Retour;
        private System.Windows.Forms.Button btn_MajStock;
    }
}