namespace F2_WFA_SettingKullanimi
{
    partial class SifreDegistirme
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
            this.grpSifreDegistirme = new System.Windows.Forms.GroupBox();
            this.btnDegistir = new System.Windows.Forms.Button();
            this.txtYeniSifre2 = new System.Windows.Forms.TextBox();
            this.txtYeniSifre1 = new System.Windows.Forms.TextBox();
            this.txtEskiSifre = new System.Windows.Forms.TextBox();
            this.grpSifreDegistirme.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpSifreDegistirme
            // 
            this.grpSifreDegistirme.Controls.Add(this.btnDegistir);
            this.grpSifreDegistirme.Controls.Add(this.txtYeniSifre2);
            this.grpSifreDegistirme.Controls.Add(this.txtYeniSifre1);
            this.grpSifreDegistirme.Controls.Add(this.txtEskiSifre);
            this.grpSifreDegistirme.Location = new System.Drawing.Point(25, 35);
            this.grpSifreDegistirme.Name = "grpSifreDegistirme";
            this.grpSifreDegistirme.Size = new System.Drawing.Size(227, 195);
            this.grpSifreDegistirme.TabIndex = 0;
            this.grpSifreDegistirme.TabStop = false;
            this.grpSifreDegistirme.Text = "Şifre Değiştirme";
            this.grpSifreDegistirme.Enter += new System.EventHandler(this.grpSifreDegistirme_Enter);
            // 
            // btnDegistir
            // 
            this.btnDegistir.Location = new System.Drawing.Point(147, 121);
            this.btnDegistir.Name = "btnDegistir";
            this.btnDegistir.Size = new System.Drawing.Size(51, 25);
            this.btnDegistir.TabIndex = 1;
            this.btnDegistir.Text = "Değiştir";
            this.btnDegistir.UseVisualStyleBackColor = true;
            this.btnDegistir.Click += new System.EventHandler(this.btnDegistir_Click);
            // 
            // txtYeniSifre2
            // 
            this.txtYeniSifre2.Location = new System.Drawing.Point(28, 89);
            this.txtYeniSifre2.Name = "txtYeniSifre2";
            this.txtYeniSifre2.Size = new System.Drawing.Size(171, 20);
            this.txtYeniSifre2.TabIndex = 0;
            // 
            // txtYeniSifre1
            // 
            this.txtYeniSifre1.Location = new System.Drawing.Point(28, 63);
            this.txtYeniSifre1.Name = "txtYeniSifre1";
            this.txtYeniSifre1.Size = new System.Drawing.Size(171, 20);
            this.txtYeniSifre1.TabIndex = 0;
            // 
            // txtEskiSifre
            // 
            this.txtEskiSifre.Location = new System.Drawing.Point(28, 26);
            this.txtEskiSifre.Name = "txtEskiSifre";
            this.txtEskiSifre.Size = new System.Drawing.Size(171, 20);
            this.txtEskiSifre.TabIndex = 0;
            this.txtEskiSifre.TextChanged += new System.EventHandler(this.txtEskiSifre_TextChanged);
            // 
            // SifreDegistirme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.grpSifreDegistirme);
            this.Name = "SifreDegistirme";
            this.Text = "SifreDegistirme";
            this.grpSifreDegistirme.ResumeLayout(false);
            this.grpSifreDegistirme.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpSifreDegistirme;
        private System.Windows.Forms.Button btnDegistir;
        private System.Windows.Forms.TextBox txtYeniSifre2;
        private System.Windows.Forms.TextBox txtYeniSifre1;
        private System.Windows.Forms.TextBox txtEskiSifre;
    }
}