using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E5_WFA_Combobox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i += 2)
            {
                cmbListe.Items.Add(i);

            }
            ElemanSayisi();

        }
        //metod yapmak istediğim yeri seçip quik actiondan metod yapabiliriz.
        private void ElemanSayisi()
        {
            lblElemanSayisi.Text = cmbListe.Items.Count + "adet eleman var";
            cmbListe.SelectedIndex = 0;
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            //comboboxta seçilen bir eleman varsa işlem yap. anlamına gelir.
            if (cmbListe.SelectedIndex!=-1)
            {
                //seçilen ıtem silindi
                cmbListe.Items.RemoveAt(cmbListe.SelectedIndex);
                ElemanSayisi();//sildikten sonra da yazması için eleman sayısını yazsın diye 
            }
        }

        private void cmbListe_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblSecilen.Text = "seçilen eleman" + cmbListe.SelectedItem; ;
            //lblSecilen.Text = "seçilen eleman"+cmbListe.Items[cmbListe.SelectedIndex];
        }

        private void btnYerlestir_Click(object sender, EventArgs e)
        {
            cmbListe.Items.Insert(0,-1);
            //cmbListe.Items.Insert(0, "ahmet");
            //cmbListe.Items.Insert(0, new string[] { "ali","veli","fatma"});
            //string[] gelenDizi = new string[5];
            //gelenDizi = (string[])cmbListe.Items[0];
            ElemanSayisi();

        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            cmbListe.Items.Clear();
            //ElemanSayisi(); bunu yazınca hata veriyor.
            lblElemanSayisi.Text = cmbListe.Items.Count + "adet eleman var";

        }
    }
}
