namespace Sio_Shop
{
    partial class Marque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Marque));
            this.btn_Retour = new System.Windows.Forms.Button();
            this.btn_NouvelleMarque = new System.Windows.Forms.Button();
            this.dgv_Marques = new System.Windows.Forms.DataGridView();
            this.col_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.col_Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marques)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_Retour
            // 
            this.btn_Retour.BackColor = System.Drawing.Color.White;
            this.btn_Retour.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Retour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retour.Location = new System.Drawing.Point(462, 443);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(90, 35);
            this.btn_Retour.TabIndex = 8;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = false;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // btn_NouvelleMarque
            // 
            this.btn_NouvelleMarque.BackColor = System.Drawing.Color.White;
            this.btn_NouvelleMarque.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_NouvelleMarque.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_NouvelleMarque.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_NouvelleMarque.Location = new System.Drawing.Point(369, 221);
            this.btn_NouvelleMarque.Name = "btn_NouvelleMarque";
            this.btn_NouvelleMarque.Size = new System.Drawing.Size(160, 35);
            this.btn_NouvelleMarque.TabIndex = 7;
            this.btn_NouvelleMarque.Text = "Nouvelle Marque";
            this.btn_NouvelleMarque.UseVisualStyleBackColor = false;
            this.btn_NouvelleMarque.Click += new System.EventHandler(this.btn_NouvelleMarque_Click);
            // 
            // dgv_Marques
            // 
            this.dgv_Marques.AllowUserToAddRows = false;
            this.dgv_Marques.AllowUserToDeleteRows = false;
            this.dgv_Marques.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Marques.BackgroundColor = System.Drawing.Color.White;
            this.dgv_Marques.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Marques.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.col_ID,
            this.col_Nom});
            this.dgv_Marques.Location = new System.Drawing.Point(12, 12);
            this.dgv_Marques.Name = "dgv_Marques";
            this.dgv_Marques.ReadOnly = true;
            this.dgv_Marques.RowHeadersVisible = false;
            this.dgv_Marques.RowHeadersWidth = 51;
            this.dgv_Marques.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Marques.Size = new System.Drawing.Size(337, 450);
            this.dgv_Marques.TabIndex = 6;
            this.dgv_Marques.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Marques_CellContentClick);
            this.dgv_Marques.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Marques_CellContentClick);
            // 
            // col_ID
            // 
            this.col_ID.HeaderText = "ID";
            this.col_ID.MinimumWidth = 6;
            this.col_ID.Name = "col_ID";
            this.col_ID.ReadOnly = true;
            // 
            // col_Nom
            // 
            this.col_Nom.HeaderText = "Nom";
            this.col_Nom.MinimumWidth = 6;
            this.col_Nom.Name = "col_Nom";
            this.col_Nom.ReadOnly = true;
            // 
            // Marque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 489);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.btn_NouvelleMarque);
            this.Controls.Add(this.dgv_Marques);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Marque";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion des Marques";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Marque_FormClosing);
            this.Load += new System.EventHandler(this.Marque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Marques)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_Retour;
        private System.Windows.Forms.Button btn_NouvelleMarque;
        private System.Windows.Forms.DataGridView dgv_Marques;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn col_Nom;
    }
}