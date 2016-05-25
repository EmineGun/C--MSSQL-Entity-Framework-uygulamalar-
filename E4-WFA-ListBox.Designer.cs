namespace E4_WFA_ListBox
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
            this.lstUrunListesi = new System.Windows.Forms.ListBox();
            this.lstSecilenler = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.txtYeniUrun = new System.Windows.Forms.TextBox();
            this.btnYeniUrun = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstUrunListesi
            // 
            this.lstUrunListesi.FormattingEnabled = true;
            this.lstUrunListesi.Location = new System.Drawing.Point(12, 48);
            this.lstUrunListesi.Name = "lstUrunListesi";
            this.lstUrunListesi.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstUrunListesi.Size = new System.Drawing.Size(100, 173);
            this.lstUrunListesi.TabIndex = 9;
            // 
            // lstSecilenler
            // 
            this.lstSecilenler.FormattingEnabled = true;
            this.lstSecilenler.Location = new System.Drawing.Point(194, 48);
            this.lstSecilenler.Name = "lstSecilenler";
            this.lstSecilenler.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.lstSecilenler.Size = new System.Drawing.Size(105, 173);
            this.lstSecilenler.TabIndex = 1;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(113, 78);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 2;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(113, 107);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 23);
            this.btnCikar.TabIndex = 3;
            this.btnCikar.Text = "ÇIKAR";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // txtYeniUrun
            // 
            this.txtYeniUrun.Location = new System.Drawing.Point(12, 227);
            this.txtYeniUrun.Name = "txtYeniUrun";
            this.txtYeniUrun.Size = new System.Drawing.Size(100, 20);
            this.txtYeniUrun.TabIndex = 0;
            // 
            // btnYeniUrun
            // 
            this.btnYeniUrun.Location = new System.Drawing.Point(12, 258);
            this.btnYeniUrun.Name = "btnYeniUrun";
            this.btnYeniUrun.Size = new System.Drawing.Size(100, 23);
            this.btnYeniUrun.TabIndex = 1;
            this.btnYeniUrun.Text = "Yeni Ürün Ekle";
            this.btnYeniUrun.UseVisualStyleBackColor = true;
            this.btnYeniUrun.Click += new System.EventHandler(this.btnYeniUrun_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(326, 293);
            this.Controls.Add(this.btnYeniUrun);
            this.Controls.Add(this.txtYeniUrun);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.lstSecilenler);
            this.Controls.Add(this.lstUrunListesi);
            this.Name = "Form1";
            this.Text = "Listbox Kontrolü";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstUrunListesi;
        private System.Windows.Forms.ListBox lstSecilenler;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
        private System.Windows.Forms.TextBox txtYeniUrun;
        private System.Windows.Forms.Button btnYeniUrun;
    }
}

