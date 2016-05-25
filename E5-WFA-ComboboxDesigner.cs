namespace E5_WFA_Combobox
{
    partial class Form1
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
            this.cmbListe = new System.Windows.Forms.ComboBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnYerlestir = new System.Windows.Forms.Button();
            this.btnTemizle = new System.Windows.Forms.Button();
            this.lblElemanSayisi = new System.Windows.Forms.Label();
            this.lblSecilen = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbListe
            // 
            this.cmbListe.FormattingEnabled = true;
            this.cmbListe.Location = new System.Drawing.Point(2, 12);
            this.cmbListe.Name = "cmbListe";
            this.cmbListe.Size = new System.Drawing.Size(168, 21);
            this.cmbListe.TabIndex = 0;
            this.cmbListe.SelectedIndexChanged += new System.EventHandler(this.cmbListe_SelectedIndexChanged);
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(2, 55);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(95, 55);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "SİL";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // btnYerlestir
            // 
            this.btnYerlestir.Location = new System.Drawing.Point(2, 84);
            this.btnYerlestir.Name = "btnYerlestir";
            this.btnYerlestir.Size = new System.Drawing.Size(75, 23);
            this.btnYerlestir.TabIndex = 1;
            this.btnYerlestir.Text = "YERLEŞTİR";
            this.btnYerlestir.UseVisualStyleBackColor = true;
            this.btnYerlestir.Click += new System.EventHandler(this.btnYerlestir_Click);
            // 
            // btnTemizle
            // 
            this.btnTemizle.Location = new System.Drawing.Point(95, 84);
            this.btnTemizle.Name = "btnTemizle";
            this.btnTemizle.Size = new System.Drawing.Size(75, 23);
            this.btnTemizle.TabIndex = 1;
            this.btnTemizle.Text = "TEMİZLE";
            this.btnTemizle.UseVisualStyleBackColor = true;
            this.btnTemizle.Click += new System.EventHandler(this.btnTemizle_Click);
            // 
            // lblElemanSayisi
            // 
            this.lblElemanSayisi.AutoSize = true;
            this.lblElemanSayisi.Location = new System.Drawing.Point(13, 39);
            this.lblElemanSayisi.Name = "lblElemanSayisi";
            this.lblElemanSayisi.Size = new System.Drawing.Size(35, 13);
            this.lblElemanSayisi.TabIndex = 2;
            this.lblElemanSayisi.Text = "label1";
            // 
            // lblSecilen
            // 
            this.lblSecilen.AutoSize = true;
            this.lblSecilen.Location = new System.Drawing.Point(13, 123);
            this.lblSecilen.Name = "lblSecilen";
            this.lblSecilen.Size = new System.Drawing.Size(35, 13);
            this.lblSecilen.TabIndex = 2;
            this.lblSecilen.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.lblSecilen);
            this.Controls.Add(this.lblElemanSayisi);
            this.Controls.Add(this.btnTemizle);
            this.Controls.Add(this.btnYerlestir);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.cmbListe);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbListe;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnYerlestir;
        private System.Windows.Forms.Button btnTemizle;
        private System.Windows.Forms.Label lblElemanSayisi;
        private System.Windows.Forms.Label lblSecilen;
    }
}

