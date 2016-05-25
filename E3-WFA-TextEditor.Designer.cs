namespace E3_WFA_TextEditor
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
            this.txtMetin = new System.Windows.Forms.TextBox();
            this.btnYaziTipi = new System.Windows.Forms.Button();
            this.btnYaziRengi = new System.Windows.Forms.Button();
            this.btnKalin = new System.Windows.Forms.Button();
            this.btnEgik = new System.Windows.Forms.Button();
            this.btnAltiÇizili = new System.Windows.Forms.Button();
            this.btnKes = new System.Windows.Forms.Button();
            this.btnKopyala = new System.Windows.Forms.Button();
            this.btnYapistir = new System.Windows.Forms.Button();
            this.btnGeriAl = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.lblSayac = new System.Windows.Forms.Label();
            this.btnSayac = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtMetin
            // 
            this.txtMetin.Location = new System.Drawing.Point(12, 12);
            this.txtMetin.Multiline = true;
            this.txtMetin.Name = "txtMetin";
            this.txtMetin.Size = new System.Drawing.Size(318, 194);
            this.txtMetin.TabIndex = 0;
            // 
            // btnYaziTipi
            // 
            this.btnYaziTipi.Location = new System.Drawing.Point(336, 12);
            this.btnYaziTipi.Name = "btnYaziTipi";
            this.btnYaziTipi.Size = new System.Drawing.Size(75, 35);
            this.btnYaziTipi.TabIndex = 1;
            this.btnYaziTipi.Text = "yazı tipi";
            this.btnYaziTipi.UseVisualStyleBackColor = true;
            this.btnYaziTipi.Click += new System.EventHandler(this.btnYaziTipi_Click);
            // 
            // btnYaziRengi
            // 
            this.btnYaziRengi.Location = new System.Drawing.Point(336, 48);
            this.btnYaziRengi.Name = "btnYaziRengi";
            this.btnYaziRengi.Size = new System.Drawing.Size(75, 35);
            this.btnYaziRengi.TabIndex = 1;
            this.btnYaziRengi.Text = "yazı rengi";
            this.btnYaziRengi.UseVisualStyleBackColor = true;
            this.btnYaziRengi.Click += new System.EventHandler(this.btnYaziRengi_Click);
            // 
            // btnKalin
            // 
            this.btnKalin.Location = new System.Drawing.Point(336, 89);
            this.btnKalin.Name = "btnKalin";
            this.btnKalin.Size = new System.Drawing.Size(75, 35);
            this.btnKalin.TabIndex = 1;
            this.btnKalin.Text = "Kalın";
            this.btnKalin.UseVisualStyleBackColor = true;
            this.btnKalin.Click += new System.EventHandler(this.btnKalin_Click);
            // 
            // btnEgik
            // 
            this.btnEgik.Location = new System.Drawing.Point(336, 130);
            this.btnEgik.Name = "btnEgik";
            this.btnEgik.Size = new System.Drawing.Size(75, 35);
            this.btnEgik.TabIndex = 1;
            this.btnEgik.Text = "Eğik";
            this.btnEgik.UseVisualStyleBackColor = true;
            this.btnEgik.Click += new System.EventHandler(this.btnEgik_Click);
            // 
            // btnAltiÇizili
            // 
            this.btnAltiÇizili.Location = new System.Drawing.Point(336, 171);
            this.btnAltiÇizili.Name = "btnAltiÇizili";
            this.btnAltiÇizili.Size = new System.Drawing.Size(75, 35);
            this.btnAltiÇizili.TabIndex = 1;
            this.btnAltiÇizili.Text = "Altı Çizili";
            this.btnAltiÇizili.UseVisualStyleBackColor = true;
            this.btnAltiÇizili.Click += new System.EventHandler(this.btnAltiÇizili_Click);
            // 
            // btnKes
            // 
            this.btnKes.Location = new System.Drawing.Point(3, 212);
            this.btnKes.Name = "btnKes";
            this.btnKes.Size = new System.Drawing.Size(75, 35);
            this.btnKes.TabIndex = 1;
            this.btnKes.Text = "KES";
            this.btnKes.UseVisualStyleBackColor = true;
            this.btnKes.Click += new System.EventHandler(this.btnKes_Click);
            // 
            // btnKopyala
            // 
            this.btnKopyala.Location = new System.Drawing.Point(84, 212);
            this.btnKopyala.Name = "btnKopyala";
            this.btnKopyala.Size = new System.Drawing.Size(75, 35);
            this.btnKopyala.TabIndex = 1;
            this.btnKopyala.Text = "KOPYALA";
            this.btnKopyala.UseVisualStyleBackColor = true;
            this.btnKopyala.Click += new System.EventHandler(this.btnKopyala_Click);
            // 
            // btnYapistir
            // 
            this.btnYapistir.Location = new System.Drawing.Point(165, 212);
            this.btnYapistir.Name = "btnYapistir";
            this.btnYapistir.Size = new System.Drawing.Size(75, 35);
            this.btnYapistir.TabIndex = 1;
            this.btnYapistir.Text = "YAPIŞTIR";
            this.btnYapistir.UseVisualStyleBackColor = true;
            this.btnYapistir.Click += new System.EventHandler(this.btnYapistir_Click);
            // 
            // btnGeriAl
            // 
            this.btnGeriAl.Location = new System.Drawing.Point(246, 212);
            this.btnGeriAl.Name = "btnGeriAl";
            this.btnGeriAl.Size = new System.Drawing.Size(75, 35);
            this.btnGeriAl.TabIndex = 1;
            this.btnGeriAl.Text = "GERİ AL";
            this.btnGeriAl.UseVisualStyleBackColor = true;
            this.btnGeriAl.Click += new System.EventHandler(this.btnGeriAl_Click);
            // 
            // lblSayac
            // 
            this.lblSayac.AutoSize = true;
            this.lblSayac.Location = new System.Drawing.Point(377, 213);
            this.lblSayac.Name = "lblSayac";
            this.lblSayac.Size = new System.Drawing.Size(0, 13);
            this.lblSayac.TabIndex = 2;
            // 
            // btnSayac
            // 
            this.btnSayac.Location = new System.Drawing.Point(335, 247);
            this.btnSayac.Name = "btnSayac";
            this.btnSayac.Size = new System.Drawing.Size(75, 29);
            this.btnSayac.TabIndex = 3;
            this.btnSayac.Text = "start";
            this.btnSayac.UseVisualStyleBackColor = true;
            this.btnSayac.Click += new System.EventHandler(this.btnSayac_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 345);
            this.Controls.Add(this.btnSayac);
            this.Controls.Add(this.lblSayac);
            this.Controls.Add(this.btnGeriAl);
            this.Controls.Add(this.btnYapistir);
            this.Controls.Add(this.btnKopyala);
            this.Controls.Add(this.btnKes);
            this.Controls.Add(this.btnAltiÇizili);
            this.Controls.Add(this.btnEgik);
            this.Controls.Add(this.btnKalin);
            this.Controls.Add(this.btnYaziRengi);
            this.Controls.Add(this.btnYaziTipi);
            this.Controls.Add(this.txtMetin);
            this.Name = "Form1";
            this.Text = "TextEditör";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtMetin;
        private System.Windows.Forms.Button btnYaziTipi;
        private System.Windows.Forms.Button btnYaziRengi;
        private System.Windows.Forms.Button btnKalin;
        private System.Windows.Forms.Button btnEgik;
        private System.Windows.Forms.Button btnAltiÇizili;
        private System.Windows.Forms.Button btnKes;
        private System.Windows.Forms.Button btnKopyala;
        private System.Windows.Forms.Button btnYapistir;
        private System.Windows.Forms.Button btnGeriAl;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Label lblSayac;
        private System.Windows.Forms.Button btnSayac;
    }
}

