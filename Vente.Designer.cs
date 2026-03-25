namespace Sio_Shop
{
    partial class Vente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Vente));
            this.lbl_Client = new System.Windows.Forms.Label();
            this.cb_Client = new System.Windows.Forms.ComboBox();
            this.lbl_Produit = new System.Windows.Forms.Label();
            this.cb_Produit = new System.Windows.Forms.ComboBox();
            this.lbl_PrixHT = new System.Windows.Forms.Label();
            this.txt_PrixHT = new System.Windows.Forms.TextBox();
            this.lbl_TVA = new System.Windows.Forms.Label();
            this.txt_TVA = new System.Windows.Forms.TextBox();
            this.lbl_PrixTTC = new System.Windows.Forms.Label();
            this.txt_PrixTTC = new System.Windows.Forms.TextBox();
            this.btn_Acheter = new System.Windows.Forms.Button();
            this.lbl_Stock = new System.Windows.Forms.Label();
            this.btn_Retour = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_Client
            // 
            this.lbl_Client.AutoSize = true;
            this.lbl_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Client.Location = new System.Drawing.Point(40, 49);
            this.lbl_Client.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Client.Name = "lbl_Client";
            this.lbl_Client.Size = new System.Drawing.Size(62, 20);
            this.lbl_Client.TabIndex = 0;
            this.lbl_Client.Text = "Client :";
            // 
            // cb_Client
            // 
            this.cb_Client.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Client.FormattingEnabled = true;
            this.cb_Client.Location = new System.Drawing.Point(200, 46);
            this.cb_Client.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Client.Name = "cb_Client";
            this.cb_Client.Size = new System.Drawing.Size(732, 28);
            this.cb_Client.TabIndex = 1;
            // 
            // lbl_Produit
            // 
            this.lbl_Produit.AutoSize = true;
            this.lbl_Produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Produit.Location = new System.Drawing.Point(40, 111);
            this.lbl_Produit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Produit.Name = "lbl_Produit";
            this.lbl_Produit.Size = new System.Drawing.Size(72, 20);
            this.lbl_Produit.TabIndex = 2;
            this.lbl_Produit.Text = "Produit :";
            // 
            // cb_Produit
            // 
            this.cb_Produit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Produit.FormattingEnabled = true;
            this.cb_Produit.Location = new System.Drawing.Point(200, 107);
            this.cb_Produit.Margin = new System.Windows.Forms.Padding(4);
            this.cb_Produit.Name = "cb_Produit";
            this.cb_Produit.Size = new System.Drawing.Size(732, 28);
            this.cb_Produit.TabIndex = 3;
            this.cb_Produit.SelectedIndexChanged += new System.EventHandler(this.cb_Produit_SelectedIndexChanged);
            // 
            // lbl_PrixHT
            // 
            this.lbl_PrixHT.AutoSize = true;
            this.lbl_PrixHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrixHT.Location = new System.Drawing.Point(40, 172);
            this.lbl_PrixHT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PrixHT.Name = "lbl_PrixHT";
            this.lbl_PrixHT.Size = new System.Drawing.Size(76, 20);
            this.lbl_PrixHT.TabIndex = 4;
            this.lbl_PrixHT.Text = "Prix HT :";
            // 
            // txt_PrixHT
            // 
            this.txt_PrixHT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrixHT.Location = new System.Drawing.Point(200, 169);
            this.txt_PrixHT.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrixHT.Name = "txt_PrixHT";
            this.txt_PrixHT.Size = new System.Drawing.Size(199, 26);
            this.txt_PrixHT.TabIndex = 5;
            this.txt_PrixHT.TextChanged += new System.EventHandler(this.txt_PrixHT_TextChanged);
            // 
            // lbl_TVA
            // 
            this.lbl_TVA.AutoSize = true;
            this.lbl_TVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TVA.Location = new System.Drawing.Point(40, 234);
            this.lbl_TVA.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_TVA.Name = "lbl_TVA";
            this.lbl_TVA.Size = new System.Drawing.Size(101, 20);
            this.lbl_TVA.TabIndex = 6;
            this.lbl_TVA.Text = "TVA (20%) :";
            // 
            // txt_TVA
            // 
            this.txt_TVA.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_TVA.Location = new System.Drawing.Point(200, 230);
            this.txt_TVA.Margin = new System.Windows.Forms.Padding(4);
            this.txt_TVA.Name = "txt_TVA";
            this.txt_TVA.ReadOnly = true;
            this.txt_TVA.Size = new System.Drawing.Size(199, 26);
            this.txt_TVA.TabIndex = 7;
            // 
            // lbl_PrixTTC
            // 
            this.lbl_PrixTTC.AutoSize = true;
            this.lbl_PrixTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_PrixTTC.Location = new System.Drawing.Point(40, 295);
            this.lbl_PrixTTC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_PrixTTC.Name = "lbl_PrixTTC";
            this.lbl_PrixTTC.Size = new System.Drawing.Size(85, 20);
            this.lbl_PrixTTC.TabIndex = 8;
            this.lbl_PrixTTC.Text = "Prix TTC :";
            // 
            // txt_PrixTTC
            // 
            this.txt_PrixTTC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_PrixTTC.Location = new System.Drawing.Point(200, 292);
            this.txt_PrixTTC.Margin = new System.Windows.Forms.Padding(4);
            this.txt_PrixTTC.Name = "txt_PrixTTC";
            this.txt_PrixTTC.ReadOnly = true;
            this.txt_PrixTTC.Size = new System.Drawing.Size(199, 26);
            this.txt_PrixTTC.TabIndex = 9;
            // 
            // btn_Acheter
            // 
            this.btn_Acheter.BackColor = System.Drawing.Color.White;
            this.btn_Acheter.FlatAppearance.BorderColor = System.Drawing.Color.LightGray;
            this.btn_Acheter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Acheter.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Acheter.Location = new System.Drawing.Point(200, 357);
            this.btn_Acheter.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Acheter.Name = "btn_Acheter";
            this.btn_Acheter.Size = new System.Drawing.Size(147, 43);
            this.btn_Acheter.TabIndex = 10;
            this.btn_Acheter.Text = "Acheter";
            this.btn_Acheter.UseVisualStyleBackColor = false;
            this.btn_Acheter.Click += new System.EventHandler(this.btn_Acheter_Click);
            // 
            // lbl_Stock
            // 
            this.lbl_Stock.AutoSize = true;
            this.lbl_Stock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Stock.Location = new System.Drawing.Point(196, 443);
            this.lbl_Stock.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_Stock.Name = "lbl_Stock";
            this.lbl_Stock.Size = new System.Drawing.Size(151, 20);
            this.lbl_Stock.TabIndex = 11;
            this.lbl_Stock.Text = "Stock avant vente :";
            // 
            // btn_Retour
            // 
            this.btn_Retour.BackColor = System.Drawing.Color.White;
            this.btn_Retour.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(215)))));
            this.btn_Retour.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Retour.Location = new System.Drawing.Point(907, 492);
            this.btn_Retour.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Retour.Name = "btn_Retour";
            this.btn_Retour.Size = new System.Drawing.Size(120, 43);
            this.btn_Retour.TabIndex = 12;
            this.btn_Retour.Text = "Retour";
            this.btn_Retour.UseVisualStyleBackColor = false;
            this.btn_Retour.Click += new System.EventHandler(this.btn_Retour_Click);
            // 
            // Vente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ClientSize = new System.Drawing.Size(1067, 566);
            this.Controls.Add(this.btn_Retour);
            this.Controls.Add(this.lbl_Stock);
            this.Controls.Add(this.btn_Acheter);
            this.Controls.Add(this.txt_PrixTTC);
            this.Controls.Add(this.lbl_PrixTTC);
            this.Controls.Add(this.txt_TVA);
            this.Controls.Add(this.lbl_TVA);
            this.Controls.Add(this.txt_PrixHT);
            this.Controls.Add(this.lbl_PrixHT);
            this.Controls.Add(this.cb_Produit);
            this.Controls.Add(this.lbl_Produit);
            this.Controls.Add(this.cb_Client);
            this.Controls.Add(this.lbl_Client);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Vente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Vente";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Vente_FormClosing);
            this.Load += new System.EventHandler(this.Vente_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Client;
        private System.Windows.Forms.ComboBox cb_Client;
        private System.Windows.Forms.Label lbl_Produit;
        private System.Windows.Forms.ComboBox cb_Produit;
        private System.Windows.Forms.Label lbl_PrixHT;
        private System.Windows.Forms.TextBox txt_PrixHT;
        private System.Windows.Forms.Label lbl_TVA;
        private System.Windows.Forms.TextBox txt_TVA;
        private System.Windows.Forms.Label lbl_PrixTTC;
        private System.Windows.Forms.TextBox txt_PrixTTC;
        private System.Windows.Forms.Button btn_Acheter;
        private System.Windows.Forms.Label lbl_Stock;
        private System.Windows.Forms.Button btn_Retour;
    }
}