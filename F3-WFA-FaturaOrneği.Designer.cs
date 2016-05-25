namespace F3_WFA_FaturaOrneği
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
            this.lbl = new System.Windows.Forms.Label();
            this.txtAdSoyad = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtİlkİn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSonİn = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbMesken = new System.Windows.Forms.RadioButton();
            this.rdpUmumi = new System.Windows.Forms.RadioButton();
            this.lstAdSoyad = new System.Windows.Forms.ListBox();
            this.lstSuMiktari = new System.Windows.Forms.ListBox();
            this.lstFaturaTutari = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Location = new System.Drawing.Point(24, 20);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(57, 13);
            this.lbl.TabIndex = 0;
            this.lbl.Text = "Adı Soaydı";
            // 
            // txtAdSoyad
            // 
            this.txtAdSoyad.Location = new System.Drawing.Point(85, 22);
            this.txtAdSoyad.Name = "txtAdSoyad";
            this.txtAdSoyad.Size = new System.Drawing.Size(339, 20);
            this.txtAdSoyad.TabIndex = 1;
            this.txtAdSoyad.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "İlk İndex";
            // 
            // txtİlkİn
            // 
            this.txtİlkİn.Location = new System.Drawing.Point(3, 33);
            this.txtİlkİn.Name = "txtİlkİn";
            this.txtİlkİn.Size = new System.Drawing.Size(333, 20);
            this.txtİlkİn.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Son İndex";
            // 
            // txtSonİn
            // 
            this.txtSonİn.Location = new System.Drawing.Point(3, 4);
            this.txtSonİn.Name = "txtSonİn";
            this.txtSonİn.Size = new System.Drawing.Size(333, 20);
            this.txtSonİn.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtİlkİn);
            this.panel1.Controls.Add(this.txtSonİn);
            this.panel1.Location = new System.Drawing.Point(85, 48);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 58);
            this.panel1.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbMesken);
            this.groupBox1.Controls.Add(this.rdpUmumi);
            this.groupBox1.Location = new System.Drawing.Point(79, 123);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(345, 81);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kullanım Yeri";
            // 
            // rdbMesken
            // 
            this.rdbMesken.AutoSize = true;
            this.rdbMesken.Location = new System.Drawing.Point(99, 43);
            this.rdbMesken.Name = "rdbMesken";
            this.rdbMesken.Size = new System.Drawing.Size(63, 17);
            this.rdbMesken.TabIndex = 0;
            this.rdbMesken.TabStop = true;
            this.rdbMesken.Text = "Mesken";
            this.rdbMesken.UseVisualStyleBackColor = true;
            // 
            // rdpUmumi
            // 
            this.rdpUmumi.AutoSize = true;
            this.rdpUmumi.Location = new System.Drawing.Point(15, 43);
            this.rdpUmumi.Name = "rdpUmumi";
            this.rdpUmumi.Size = new System.Drawing.Size(57, 17);
            this.rdpUmumi.TabIndex = 0;
            this.rdpUmumi.TabStop = true;
            this.rdpUmumi.Text = "Umumi";
            this.rdpUmumi.UseVisualStyleBackColor = true;
            // 
            // lstAdSoyad
            // 
            this.lstAdSoyad.FormattingEnabled = true;
            this.lstAdSoyad.Location = new System.Drawing.Point(12, 245);
            this.lstAdSoyad.Name = "lstAdSoyad";
            this.lstAdSoyad.Size = new System.Drawing.Size(120, 121);
            this.lstAdSoyad.TabIndex = 4;
            // 
            // lstSuMiktari
            // 
            this.lstSuMiktari.FormattingEnabled = true;
            this.lstSuMiktari.Location = new System.Drawing.Point(152, 245);
            this.lstSuMiktari.Name = "lstSuMiktari";
            this.lstSuMiktari.Size = new System.Drawing.Size(120, 121);
            this.lstSuMiktari.TabIndex = 5;
            // 
            // lstFaturaTutari
            // 
            this.lstFaturaTutari.FormattingEnabled = true;
            this.lstFaturaTutari.Location = new System.Drawing.Point(324, 243);
            this.lstFaturaTutari.Name = "lstFaturaTutari";
            this.lstFaturaTutari.Size = new System.Drawing.Size(120, 121);
            this.lstFaturaTutari.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 227);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adı Soaydı";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(149, 229);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(96, 13);
            this.label5.TabIndex = 7;
            this.label5.Text = "Kullanım Su Miktarı";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(321, 227);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Fatura Tutarı";
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(362, 210);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(61, 25);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "Hesapla";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 379);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lstFaturaTutari);
            this.Controls.Add(this.lstSuMiktari);
            this.Controls.Add(this.lstAdSoyad);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtAdSoyad);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl);
            this.Name = "Form1";
            this.Text = "Fatura Örneği";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.TextBox txtAdSoyad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtİlkİn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtSonİn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbMesken;
        private System.Windows.Forms.RadioButton rdpUmumi;
        private System.Windows.Forms.ListBox lstAdSoyad;
        private System.Windows.Forms.ListBox lstSuMiktari;
        private System.Windows.Forms.ListBox lstFaturaTutari;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnHesapla;
    }
}

