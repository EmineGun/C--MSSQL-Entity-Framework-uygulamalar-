using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1_WFA_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("text");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //form ilk açıldığında çalışan event
            //tüm kontrollere name ile erişiriz.
            btngiris.Text = "kullanıcı girişi";
            //Form1 frm = new Form1();
            //thid:içerisinde bulunulan nesne olan formu işaret eder.
            this.Text = "yeni anaform  başlığı";
            this.WindowState = FormWindowState.Maximized;
        }

        private void altFormAc_Click(object sender, EventArgs e)
        {
            //burada alt forma ulaşacaz.Formlar arası geçişler show(),Hide(), ShowDialog() metodları ve Vİsible Property si ile yapılabilir.
            AltForm altfrm = new AltForm();//nesne oluşturduk ve 
                                           //altfrm.Show();
                                           //altfrm.ShowDialog();//altta bulunan formlara ageçiş yapılamaz.ShowDialog tan sonraki satırlar çalıştırılmıyor.
            altfrm.Visible = true;
           // this.Hide();
           // this.Visible = false;
            altfrm.lblBaslik.Text = "ana formdan alt forma değer döndürülüyor.";
           
        }

        private void btnenter_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            ad = txtAd.Text;
            soyad = txtSoyad.Text;
           // if (ad!="" && soyad!="")
           //trim():string bir değişkenn baştaki ve sondaki boşluklarını temizler.
                if (!string.IsNullOrEmpty(ad.Trim())&&!string.IsNullOrEmpty(soyad.Trim()))
                {
                //   MessageBox.Show("Adınız : "+ad+"soyadınız"+soyad);
                MessageBox.Show(string.Format("Adınız : {0} soyadınız {1}", ad, soyad));
            }

            else
            {
                MessageBox.Show("lütfen tüm alanları doldurunuz!");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("entera basıldı");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("esc ye basıldı");
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            this.Close();//formu kapatır.
            Application.Exit();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
           
        }

        private void btnDialog_Click(object sender, EventArgs e)
        {
            Dialog dialog_formu = new Dialog();
            dialog_formu.Text = "SİLME İŞLEMİ";
            
            dialog_formu.lblMesaj.Text = "SİLMEK İSTEDİĞİNİZDEN EMİN MİSİNİZ? ";
            dialog_formu.ShowDialog();//show diaog kendinden sonrakileri çalıştıramıyor.
            if (dialog_formu.DialogResult==DialogResult.OK)
            {
                //lblAltMesaj.Text = "kullanıcı ok butonuna bastı";
                lblAltMesaj.Text = dialog_formu.deger;
            }
            if (dialog_formu.DialogResult==DialogResult.Cancel)
            {
                //lblAltMesaj.Text = "kullanıcı cancel butonuna bastı";
                lblAltMesaj.Text = dialog_formu.deger;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
