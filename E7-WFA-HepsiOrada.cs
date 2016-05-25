using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace E7_WFA_HepsiOrada
{

    public partial class Form1 : Form
    {
        Kategori[] kategoriDizisi = new Kategori[] { new Kategori { ID = 1, KategoriAdi = "TEKNOLOJİ1" }, new Kategori { ID = 2, KategoriAdi = "TEKNOLOJİ2" }, new Kategori { ID = 3, KategoriAdi = "TEKNOLOJİ3" }, new Kategori { ID = 4, KategoriAdi = "TEKNOLOJİ4" } };


        Urun[] urunKategori = new Urun[] { 
            new Urun { ID = 1, UrunAdi = "LAPTOP", KategoriID = 1, fiyat = 100 }, 
            new Urun { ID = 2, UrunAdi = "LCD TV", KategoriID = 1, fiyat = 200 }, 
            new Urun { ID = 3, UrunAdi = "TELEFON", KategoriID = 1, fiyat = 300 }, 
            new Urun { ID = 4, UrunAdi = "YAZICI", KategoriID = 2, fiyat = 10 }, 
            new Urun { ID = 5, UrunAdi = "UYDU ALICI", KategoriID = 2, fiyat = 20 }, 
            new Urun { ID = 6, UrunAdi = "3D TV", KategoriID = 2, fiyat = 30}, 
            new Urun { ID = 7, UrunAdi = "MP3", KategoriID = 3, fiyat = 10.10 }, 
            new Urun { ID = 8, UrunAdi = "MP4", KategoriID = 3, fiyat = 20.20}, 
            new Urun { ID = 9, UrunAdi = "MP5", KategoriID = 3, fiyat = 30.30 }, 
            new Urun { ID = 10, UrunAdi = "BUZDOLABI", KategoriID = 4, fiyat = 1000 }, 
            new Urun { ID = 11, UrunAdi = "ÇAMAŞIR MAKİNESİ", KategoriID = 4, fiyat = 2000 }, 
            new Urun { ID = 12, UrunAdi = "BULAŞIK MAKİNESİ", KategoriID = 4, fiyat = 3000 },
          
             };

        public Form1()
        {
            InitializeComponent();
            cmbKategori.DataSource = kategoriDizisi;
            cmbKategoriSec.DataSource = kategoriDizisi;
           

        }

        private void cmbKategori_SelectedIndexChanged(object sender, EventArgs e)
        {
            Kategori secilenKategori = cmbKategori.SelectedItem as Kategori;
            if (secilenKategori == null)
            {
                return;
            }
            Urun[] secilenUrunler = urunKategori.Where(item => item.KategoriID == secilenKategori.ID).ToArray();
            lstUrunler.DataSource = secilenUrunler;
        }
        double GenelToplam = 0;
        double GenelToplam1 = 0;
        double GenelToplam2 = 0;
        private void btnEkle_Click(object sender, EventArgs e)
        {

            ElemanSayisi();
            lstSepet.Items.Add(lstUrunler.SelectedItem);
                GenelToplam = lstSepet.Items.Cast<Urun>().Sum(c => c.fiyat);
            lblToplamTutar.Text = String.Format("Genel Toplam: {0:C}", GenelToplam);
        }

        private void ElemanSayisi()
        {

            lblToplamUrun.Text = String.Format("{0} Ürün Seçili", lstSepet.Items.Count+1);
        }


        private void lblToplamUrun_Click(object sender, EventArgs e)
        {

        }

        private void lblToplamTutar_Click(object sender, EventArgs e)
        {



        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            List<Urun> uruns = lstSepet.Items.Cast<Urun>().ToList();//tüm değerleri urune cast ediyor.
            lstTumSiparisler.Items.Add(new AraSiparis(uruns));
            lstSepet.Items.Clear();

            txtGenelToplam.Text = lstTumSiparisler.Items.Cast<AraSiparis>().Sum(c => c.Toplam).ToString("C");
        }

        private void lstTumSiparisler_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            if (rdb5.Checked)
            {
                GenelToplam = GenelToplam - (GenelToplam * 0.05);
            }
            if (rdb10.Checked)
            {
                GenelToplam = GenelToplam - (GenelToplam * 0.1);
            }
            if (rdb15.Checked)
            {
                GenelToplam = GenelToplam - (GenelToplam * 0.15);
            }
            if (rdbIndirimYok.Checked)
            {
                txtGenelToplam.Text = GenelToplam.ToString();
            }
            txtGenelToplam.Text = GenelToplam.ToString();
            if (lstSepet.Items == null)
            {
                lstTumSiparisler.Items.Clear();
            }
        }

        private void lstSepet_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void lstSepet_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (lstSepet.SelectedIndex != -1)
            {
                int secilenIndex = lstSepet.SelectedIndex;
                Urun yeniUrun = (Urun)lstSepet.Items[secilenIndex];
                GenelToplam -= yeniUrun.fiyat;
                lblToplamTutar.Text = GenelToplam.ToString();

                lstSepet.Items.RemoveAt(lstSepet.SelectedIndex);


            }
            lstTumSiparisler.Items.Clear();
        }

        private void txtGenelToplam_TextChanged(object sender, EventArgs e)
        {

        }



        private void btnUrunBilgiGuncelle_Click(object sender, EventArgs e)
        {

            if (cmbUrunSec.SelectedItem != null)
            {

                Urun secilenUrun = cmbUrunSec.SelectedItem as Urun;

                double girilenFiyat = Convert.ToDouble(txtFiyatGuncelle.Text);

                secilenUrun.fiyat = girilenFiyat;
            }

        
        }

        private void lstTumSiparisler_DoubleClick(object sender, EventArgs e)
        {
            var araSiparis = lstTumSiparisler.SelectedItem as AraSiparis;
            if (araSiparis == null)
            {
                return;
            }
        }

        private void cmbKategoriSec_SelectedIndexChanged(object sender, EventArgs e)
        {

            Kategori secilenKategori = cmbKategoriSec.SelectedItem as Kategori;
            if (secilenKategori == null)
            {
                return;
            }
            Urun[] secilenUrunler = urunKategori.Where(item => item.KategoriID == secilenKategori.ID).ToArray();

            // cmbUrunSec.Items.Clear();





            cmbUrunSec.DataSource = secilenUrunler;

            //   txtFiyatGuncelle.Text = ((Urun)cmbUrunSec.SelectedItem).fiyat.ToString();



        }

        private void cmbUrunSec_SelectedIndexChanged(object sender, EventArgs e)
        {
            Urun urun = cmbUrunSec.SelectedItem as Urun;
            if (urun != null) txtFiyatGuncelle.Text = urun.fiyat.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
