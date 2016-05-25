namespace E2_WFA_Kontrollere_Giris
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
            this.btnaktar = new System.Windows.Forms.Button();
            this.btntemizle = new System.Windows.Forms.Button();
            this.txtMesaj = new System.Windows.Forms.TextBox();
            this.lstSatirlar = new System.Windows.Forms.ListBox();
            this.txtMetin1 = new System.Windows.Forms.TextBox();
            this.txtMetin2 = new System.Windows.Forms.TextBox();
            this.btnMetinCevir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnaktar
            // 
            this.btnaktar.Location = new System.Drawing.Point(49, 181);
            this.btnaktar.Name = "btnaktar";
            this.btnaktar.Size = new System.Drawing.Size(135, 23);
            this.btnaktar.TabIndex = 0;
            this.btnaktar.Text = "textbox line property";
            this.btnaktar.UseVisualStyleBackColor = true;
            this.btnaktar.Click += new System.EventHandler(this.btnaktar_Click);
            // 
            // btntemizle
            // 
            this.btntemizle.Location = new System.Drawing.Point(49, 210);
            this.btntemizle.Name = "btntemizle";
            this.btntemizle.Size = new System.Drawing.Size(135, 23);
            this.btntemizle.TabIndex = 1;
            this.btntemizle.Text = "textbox temizle";
            this.btntemizle.UseVisualStyleBackColor = true;
            this.btntemizle.Click += new System.EventHandler(this.btntemizle_Click);
            // 
            // txtMesaj
            // 
            this.txtMesaj.Location = new System.Drawing.Point(49, 80);
            this.txtMesaj.Multiline = true;
            this.txtMesaj.Name = "txtMesaj";
            this.txtMesaj.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtMesaj.Size = new System.Drawing.Size(135, 95);
            this.txtMesaj.TabIndex = 2;
            // 
            // lstSatirlar
            // 
            this.lstSatirlar.FormattingEnabled = true;
            this.lstSatirlar.Location = new System.Drawing.Point(242, 80);
            this.lstSatirlar.Name = "lstSatirlar";
            this.lstSatirlar.Size = new System.Drawing.Size(120, 160);
            this.lstSatirlar.TabIndex = 3;
            // 
            // txtMetin1
            // 
            this.txtMetin1.Location = new System.Drawing.Point(49, 271);
            this.txtMetin1.Name = "txtMetin1";
            this.txtMetin1.Size = new System.Drawing.Size(135, 20);
            this.txtMetin1.TabIndex = 4;
            // 
            // txtMetin2
            // 
            this.txtMetin2.Location = new System.Drawing.Point(49, 326);
            this.txtMetin2.Name = "txtMetin2";
            this.txtMetin2.Size = new System.Drawing.Size(135, 20);
            this.txtMetin2.TabIndex = 5;
            // 
            // btnMetinCevir
            // 
            this.btnMetinCevir.Location = new System.Drawing.Point(49, 297);
            this.btnMetinCevir.Name = "btnMetinCevir";
            this.btnMetinCevir.Size = new System.Drawing.Size(135, 23);
            this.btnMetinCevir.TabIndex = 6;
            this.btnMetinCevir.Text = "metin ters çevir(reverse)";
            this.btnMetinCevir.UseVisualStyleBackColor = true;
            this.btnMetinCevir.Click += new System.EventHandler(this.btnMetinCevir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 364);
            this.Controls.Add(this.btnMetinCevir);
            this.Controls.Add(this.txtMetin2);
            this.Controls.Add(this.txtMetin1);
            this.Controls.Add(this.lstSatirlar);
            this.Controls.Add(this.txtMesaj);
            this.Controls.Add(this.btntemizle);
            this.Controls.Add(this.btnaktar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnaktar;
        private System.Windows.Forms.Button btntemizle;
        private System.Windows.Forms.TextBox txtMesaj;
        private System.Windows.Forms.ListBox lstSatirlar;
        private System.Windows.Forms.TextBox txtMetin1;
        private System.Windows.Forms.TextBox txtMetin2;
        private System.Windows.Forms.Button btnMetinCevir;
    }
}

