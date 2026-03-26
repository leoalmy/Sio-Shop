namespace Sio_Shop
{
    partial class Detail_Marque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Detail_Marque));
            this.btn_Retour = new System.Windows.Forms.Button();
            this.btn_Enregistrer = new System.Windows.Forms.Button();
            this.txt_Nom = new System.Windows.Forms.TextBox();
            this.lbl_Nom = new System.Windows.Forms.Label();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.lbl_Titre = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_Retour
            // 
            this.btn_Retour.BackColor = System.Drawing.Color.White;
            this.btn_Retour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retour.Location = new System.Drawing.Point(320, 213);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(90, 35);
            this.btn_Retour.TabIndex = 19;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = false;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // btn_Enregistrer
            // 
            this.btn_Enregistrer.BackColor = System.Drawing.Color.White;
            this.btn_Enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Enregistrer.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Enregistrer.Location = new System.Drawing.Point(160, 213);
            this.btn_Enregistrer.Name = "btn_Enregistrer";
            this.btn_Enregistrer.Size = new System.Drawing.Size(120, 35);
            this.btn_Enregistrer.TabIndex = 18;
            this.btn_Enregistrer.Text = "Enregistrer";
            this.btn_Enregistrer.UseVisualStyleBackColor = false;
            this.btn_Enregistrer.Click += new System.EventHandler(this.btn_Enregistrer_Click);
            // 
            // txt_Nom
            // 
            this.txt_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Nom.Location = new System.Drawing.Point(160, 141);
            this.txt_Nom.Name = "txt_Nom";
            this.txt_Nom.Size = new System.Drawing.Size(250, 23);
            this.txt_Nom.TabIndex = 17;
            // 
            // lbl_Nom
            // 
            this.lbl_Nom.AutoSize = true;
            this.lbl_Nom.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Nom.Location = new System.Drawing.Point(50, 144);
            this.lbl_Nom.Name = "lbl_Nom";
            this.lbl_Nom.Size = new System.Drawing.Size(45, 17);
            this.lbl_Nom.TabIndex = 16;
            this.lbl_Nom.Text = "Nom :";
            // 
            // txt_ID
            // 
            this.txt_ID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txt_ID.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.Location = new System.Drawing.Point(160, 98);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.ReadOnly = true;
            this.txt_ID.Size = new System.Drawing.Size(120, 16);
            this.txt_ID.TabIndex = 15;
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(50, 98);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(29, 17);
            this.lbl_ID.TabIndex = 14;
            this.lbl_ID.Text = "ID :";
            // 
            // lbl_Titre
            // 
            this.lbl_Titre.AutoSize = true;
            this.lbl_Titre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Titre.Location = new System.Drawing.Point(160, 38);
            this.lbl_Titre.Name = "lbl_Titre";
            this.lbl_Titre.Size = new System.Drawing.Size(71, 20);
            this.lbl_Titre.TabIndex = 13;
            this.lbl_Titre.Text = "Marque :";
            // 
            // Detail_Marque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(462, 282);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.btn_Enregistrer);
            this.Controls.Add(this.txt_Nom);
            this.Controls.Add(this.lbl_Nom);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.lbl_Titre);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Detail_Marque";
            this.Text = "Détail Marque";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Detail_Marque_FormClosing);
            this.Load += new System.EventHandler(this.Detail_Marque_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Retour;
        private System.Windows.Forms.Button btn_Enregistrer;
        private System.Windows.Forms.TextBox txt_Nom;
        private System.Windows.Forms.Label lbl_Nom;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.Label lbl_Titre;
    }
}