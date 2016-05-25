namespace E7_WFA_HepsiOrada
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
            this.cmbKategori = new System.Windows.Forms.ComboBox();
            this.lstUrunler = new System.Windows.Forms.ListBox();
            this.lstSepet = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbIndirimYok = new System.Windows.Forms.RadioButton();
            this.rdb15 = new System.Windows.Forms.RadioButton();
            this.rdb10 = new System.Windows.Forms.RadioButton();
            this.rdb5 = new System.Windows.Forms.RadioButton();
            this.btnEkle = new System.Windows.Forms.Button();
            this.lblKategori = new System.Windows.Forms.Label();
            this.lblToplamUrun = new System.Windows.Forms.Label();
            this.lblToplamTutar = new System.Windows.Forms.Label();
            this.btnHesapla = new System.Windows.Forms.Button();
            this.btnGuncelle = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtGenelToplam = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lstTumSiparisler = new System.Windows.Forms.ListBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btnUrunBilgiGuncelle = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtFiyatGuncelle = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cmbUrunSec = new System.Windows.Forms.ComboBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbKategoriSec = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbKategori
            // 
            this.cmbKategori.FormattingEnabled = true;
            this.cmbKategori.Location = new System.Drawing.Point(33, 53);
            this.cmbKategori.Name = "cmbKategori";
            this.cmbKategori.Size = new System.Drawing.Size(121, 21);
            this.cmbKategori.TabIndex = 0;
            this.cmbKategori.SelectedIndexChanged += new System.EventHandler(this.cmbKategori_SelectedIndexChanged);
            // 
            // lstUrunler
            // 
            this.lstUrunler.DisplayMember = "UrunAdi";
            this.lstUrunler.FormattingEnabled = true;
            this.lstUrunler.Location = new System.Drawing.Point(33, 105);
            this.lstUrunler.Name = "lstUrunler";
            this.lstUrunler.Size = new System.Drawing.Size(157, 173);
            this.lstUrunler.TabIndex = 1;
            // 
            // lstSepet
            // 
            this.lstSepet.FormattingEnabled = true;
            this.lstSepet.Location = new System.Drawing.Point(236, 105);
            this.lstSepet.Name = "lstSepet";
            this.lstSepet.Size = new System.Drawing.Size(131, 160);
            this.lstSepet.TabIndex = 2;
            this.lstSepet.SelectedIndexChanged += new System.EventHandler(this.lstSepet_SelectedIndexChanged);
            this.lstSepet.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.lstSepet_MouseDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbIndirimYok);
            this.groupBox1.Controls.Add(this.rdb15);
            this.groupBox1.Controls.Add(this.rdb10);
            this.groupBox1.Controls.Add(this.rdb5);
            this.groupBox1.Location = new System.Drawing.Point(33, 283);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(157, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "İndirim Miktarı Seçiniz";
            // 
            // rdbIndirimYok
            // 
            this.rdbIndirimYok.AutoSize = true;
            this.rdbIndirimYok.Location = new System.Drawing.Point(29, 93);
            this.rdbIndirimYok.Name = "rdbIndirimYok";
            this.rdbIndirimYok.Size = new System.Drawing.Size(77, 17);
            this.rdbIndirimYok.TabIndex = 1;
            this.rdbIndirimYok.TabStop = true;
            this.rdbIndirimYok.Text = "İndirim Yok";
            this.rdbIndirimYok.UseVisualStyleBackColor = true;
            // 
            // rdb15
            // 
            this.rdb15.AutoSize = true;
            this.rdb15.Location = new System.Drawing.Point(26, 77);
            this.rdb15.Name = "rdb15";
            this.rdb15.Size = new System.Drawing.Size(45, 17);
            this.rdb15.TabIndex = 0;
            this.rdb15.TabStop = true;
            this.rdb15.Text = "%15";
            this.rdb15.UseVisualStyleBackColor = true;
            // 
            // rdb10
            // 
            this.rdb10.AutoSize = true;
            this.rdb10.Location = new System.Drawing.Point(26, 56);
            this.rdb10.Name = "rdb10";
            this.rdb10.Size = new System.Drawing.Size(45, 17);
            this.rdb10.TabIndex = 0;
            this.rdb10.TabStop = true;
            this.rdb10.Text = "%10";
            this.rdb10.UseVisualStyleBackColor = true;
            // 
            // rdb5
            // 
            this.rdb5.AutoSize = true;
            this.rdb5.Location = new System.Drawing.Point(26, 33);
            this.rdb5.Name = "rdb5";
            this.rdb5.Size = new System.Drawing.Size(39, 17);
            this.rdb5.TabIndex = 0;
            this.rdb5.TabStop = true;
            this.rdb5.Text = "%5";
            this.rdb5.UseVisualStyleBackColor = true;
            // 
            // btnEkle
            // 
            this.btnEkle.Location = new System.Drawing.Point(196, 165);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(34, 23);
            this.btnEkle.TabIndex = 4;
            this.btnEkle.Text = ">>";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // lblKategori
            // 
            this.lblKategori.AutoSize = true;
            this.lblKategori.Location = new System.Drawing.Point(30, 28);
            this.lblKategori.Name = "lblKategori";
            this.lblKategori.Size = new System.Drawing.Size(107, 13);
            this.lblKategori.TabIndex = 5;
            this.lblKategori.Text = "KATEGORİ SEÇİNİZ";
            // 
            // lblToplamUrun
            // 
            this.lblToplamUrun.AutoSize = true;
            this.lblToplamUrun.Location = new System.Drawing.Point(256, 283);
            this.lblToplamUrun.Name = "lblToplamUrun";
            this.lblToplamUrun.Size = new System.Drawing.Size(68, 13);
            this.lblToplamUrun.TabIndex = 6;
            this.lblToplamUrun.Text = "Toplam Ürün";
            this.lblToplamUrun.Click += new System.EventHandler(this.lblToplamUrun_Click);
            // 
            // lblToplamTutar
            // 
            this.lblToplamTutar.AutoSize = true;
            this.lblToplamTutar.Location = new System.Drawing.Point(251, 316);
            this.lblToplamTutar.Name = "lblToplamTutar";
            this.lblToplamTutar.Size = new System.Drawing.Size(73, 13);
            this.lblToplamTutar.TabIndex = 7;
            this.lblToplamTutar.Text = "Toplam Tutar:";
            this.lblToplamTutar.Click += new System.EventHandler(this.lblToplamTutar_Click);
            // 
            // btnHesapla
            // 
            this.btnHesapla.Location = new System.Drawing.Point(254, 365);
            this.btnHesapla.Name = "btnHesapla";
            this.btnHesapla.Size = new System.Drawing.Size(86, 23);
            this.btnHesapla.TabIndex = 8;
            this.btnHesapla.Text = "SİPARİŞ GEÇ";
            this.btnHesapla.UseVisualStyleBackColor = true;
            this.btnHesapla.Click += new System.EventHandler(this.btnHesapla_Click);
            // 
            // btnGuncelle
            // 
            this.btnGuncelle.Location = new System.Drawing.Point(0, 178);
            this.btnGuncelle.Name = "btnGuncelle";
            this.btnGuncelle.Size = new System.Drawing.Size(124, 23);
            this.btnGuncelle.TabIndex = 9;
            this.btnGuncelle.Text = "güncelle";
            this.btnGuncelle.UseVisualStyleBackColor = true;
            this.btnGuncelle.Click += new System.EventHandler(this.btnGuncelle_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtGenelToplam);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.lstTumSiparisler);
            this.panel1.Controls.Add(this.btnGuncelle);
            this.panel1.Location = new System.Drawing.Point(373, 100);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(127, 287);
            this.panel1.TabIndex = 10;
            // 
            // txtGenelToplam
            // 
            this.txtGenelToplam.Location = new System.Drawing.Point(0, 263);
            this.txtGenelToplam.Name = "txtGenelToplam";
            this.txtGenelToplam.Size = new System.Drawing.Size(124, 20);
            this.txtGenelToplam.TabIndex = 11;
            this.txtGenelToplam.TextChanged += new System.EventHandler(this.txtGenelToplam_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 239);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Genel Toplam";
            // 
            // lstTumSiparisler
            // 
            this.lstTumSiparisler.FormattingEnabled = true;
            this.lstTumSiparisler.Location = new System.Drawing.Point(4, 3);
            this.lstTumSiparisler.Name = "lstTumSiparisler";
            this.lstTumSiparisler.Size = new System.Drawing.Size(120, 173);
            this.lstTumSiparisler.TabIndex = 0;
            this.lstTumSiparisler.SelectedIndexChanged += new System.EventHandler(this.lstTumSiparisler_SelectedIndexChanged);
            this.lstTumSiparisler.DoubleClick += new System.EventHandler(this.lstTumSiparisler_DoubleClick);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(530, 105);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(200, 282);
            this.tabControl1.TabIndex = 11;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.btnUrunBilgiGuncelle);
            this.tabPage1.Controls.Add(this.groupBox4);
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(192, 256);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // btnUrunBilgiGuncelle
            // 
            this.btnUrunBilgiGuncelle.Location = new System.Drawing.Point(114, 179);
            this.btnUrunBilgiGuncelle.Name = "btnUrunBilgiGuncelle";
            this.btnUrunBilgiGuncelle.Size = new System.Drawing.Size(75, 23);
            this.btnUrunBilgiGuncelle.TabIndex = 1;
            this.btnUrunBilgiGuncelle.Text = "GÜNCELLE";
            this.btnUrunBilgiGuncelle.UseVisualStyleBackColor = true;
            this.btnUrunBilgiGuncelle.TextChanged += new System.EventHandler(this.btnUrunBilgiGuncelle_Click);
            this.btnUrunBilgiGuncelle.Click += new System.EventHandler(this.btnUrunBilgiGuncelle_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.txtFiyatGuncelle);
            this.groupBox4.Location = new System.Drawing.Point(6, 114);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(158, 37);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "groupBox2";
            // 
            // txtFiyatGuncelle
            // 
            this.txtFiyatGuncelle.Location = new System.Drawing.Point(6, 11);
            this.txtFiyatGuncelle.Name = "txtFiyatGuncelle";
            this.txtFiyatGuncelle.Size = new System.Drawing.Size(79, 20);
            this.txtFiyatGuncelle.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbUrunSec);
            this.groupBox3.Location = new System.Drawing.Point(0, 71);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(158, 37);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "groupBox2";
            // 
            // cmbUrunSec
            // 
            this.cmbUrunSec.FormattingEnabled = true;
            this.cmbUrunSec.Location = new System.Drawing.Point(3, 16);
            this.cmbUrunSec.Name = "cmbUrunSec";
            this.cmbUrunSec.Size = new System.Drawing.Size(121, 21);
            this.cmbUrunSec.TabIndex = 0;
            this.cmbUrunSec.SelectedIndexChanged += new System.EventHandler(this.cmbUrunSec_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cmbKategoriSec);
            this.groupBox2.Location = new System.Drawing.Point(0, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(158, 37);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // cmbKategoriSec
            // 
            this.cmbKategoriSec.FormattingEnabled = true;
            this.cmbKategoriSec.Location = new System.Drawing.Point(6, 10);
            this.cmbKategoriSec.Name = "cmbKategoriSec";
            this.cmbKategoriSec.Size = new System.Drawing.Size(121, 21);
            this.cmbKategoriSec.TabIndex = 0;
            this.cmbKategoriSec.SelectedIndexChanged += new System.EventHandler(this.cmbKategoriSec_SelectedIndexChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnKaydet);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(192, 256);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(59, 117);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(75, 23);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "KAYDET";
            this.btnKaydet.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(990, 511);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnHesapla);
            this.Controls.Add(this.lblToplamTutar);
            this.Controls.Add(this.lblToplamUrun);
            this.Controls.Add(this.lblKategori);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstSepet);
            this.Controls.Add(this.lstUrunler);
            this.Controls.Add(this.cmbKategori);
            this.Name = "Form1";
            this.Text = "Ana Ekran";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbKategori;
        private System.Windows.Forms.ListBox lstUrunler;
        private System.Windows.Forms.ListBox lstSepet;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb15;
        private System.Windows.Forms.RadioButton rdb10;
        private System.Windows.Forms.RadioButton rdb5;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Label lblKategori;
        private System.Windows.Forms.Label lblToplamUrun;
        private System.Windows.Forms.Label lblToplamTutar;
        private System.Windows.Forms.Button btnHesapla;
        private System.Windows.Forms.Button btnGuncelle;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtGenelToplam;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox lstTumSiparisler;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox cmbUrunSec;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cmbKategoriSec;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnUrunBilgiGuncelle;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.TextBox txtFiyatGuncelle;
        private System.Windows.Forms.RadioButton rdbIndirimYok;
    }
}

