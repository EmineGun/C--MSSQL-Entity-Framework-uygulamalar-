using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E2_WFA_Kontrollere_Giris
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnaktar_Click(object sender, EventArgs e)
        {
            //1
            //textbox en fazla 255 karakter bilgi görüntüüler
            //multiline ozelliği:çoklu satır girişi
            //scrollbars:yatay dikey kaydırma çubukları
            //readOnly:sadece okunabilir textbox iiçin kullanılır.
            //font ve forecolor:sadece okunabilir textbox için kullanılabilir.



            //2 textbox içeriği listeye aktarııyor.
            // lstSatirlar.Items.Add("ilk satır");//listbox dizi mantığı ile çalışır içeriğindeki elemanlar item olarak tanımlıdır.
            for (int i = 0; i < txtMesaj.Lines.Length; i++)//lines burada dizi dir 
            {
                if (txtMesaj.Lines[i]!="")
                {
                    lstSatirlar.Items.Add(txtMesaj.Lines[i].Trim());//lines dizisinin i.sine ulaşmaya çalışyoruz.
                }
                
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtMesaj.Clear();
            lstSatirlar.Items.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //3 form yüklendiğinde yeni bir label oluşturuyoruz.
            Label lbl = new Label();
            lbl.Text = "dinamik bir label oluşturuldu.";
            lbl.Name = "lblBaslik";
            lbl.Font = new Font("Verdana",12,FontStyle.Bold);
            lbl.AutoSize = true;
            lbl.Location = new Point(5,5);
            //lbl.Hide();
            lbl.BringToFront();
            this.Controls.Add(lbl);//git bunu formun kontrollerine ekle.

        }

        private void btnMetinCevir_Click(object sender, EventArgs e)
        {

            //char[] yaziDizisi = new char[txtMetin1.Text.Length];
            //Array.Reverse(yaziDizisi);
            //foreach (char item in yaziDizisi)
            //{

            //}
            string text1 = txtMetin1.Text;
            char[] chText = text1.ToCharArray();
            Array.Reverse(chText);
            // string reversedText = new string(chText);//burada char dizisi tanımlayabiliyoruz.
            //txtMetin2.Text = reversedText;
            foreach (char item in chText)
            {
                // txtMetin2.Text += item.ToString();
                txtMetin2.AppendText(item.ToString());//var olanın sonuna ekliyor
            }
        }
    }
}
