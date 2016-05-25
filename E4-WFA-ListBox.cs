using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E4_WFA_ListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYeniUrun_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtYeniUrun.Text.Trim()))
            {
                lstUrunListesi.Items.Add(txtYeniUrun.Text.Trim());
                txtYeniUrun.Clear();
                txtYeniUrun.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtYeniUrun.Focus();
            string[] urunListem = { "hd tv", "ddr3", "ram", "mainboard", "laptop" };
            //form yüklendiğinde liste yukarıdaki ürünlerle dolduruluyor.
            foreach (string item in urunListem)
            {
                lstUrunListesi.Items.Add(item);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (lstUrunListesi.SelectedIndex!=-1)
            {
                //lsturunListede seçilen ürünleri bulma
                int seclenIndex = lstUrunListesi.SelectedIndex;
              //  string secilenUrun = lstUrunListesi.SelectedItem.ToString();
                 string secilenUrun=(string)lstUrunListesi.SelectedItem;
              //  lstSecilenler.Items.Add(secilenUrun);//tek satır 
                //çoklu ekleme
                foreach (string item in lstUrunListesi.SelectedItems)
                {
                    lstSecilenler.Items.Add(item);
                }
            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {

            if (lstSecilenler.SelectedIndex!=-1)
            {
                int secilenIndex = lstSecilenler.SelectedIndex;
                //verilen indexteki itemı siler
                // lstSecilenler.Items.RemoveAt(secilenIndex);//tek ürün silme kodu
                //seçilen objeyi siler
                //lstSecilenler.Items.Remove(lstSecilenler.SelectedItem);
                //çoklu ürün silme:
                //for (int i = lstUrunListesi.SelectedIndex;i>=0;i--)
                //{
                //    lstSecilenler.Items.RemoveAt(i);
                //}
                for (int i=lstSecilenler.SelectedItems.Count-1;i>=0;i-- )
                {
                    //  lstSecilenler.Items.Remove(lstSecilenler.SelectedItems[i]);
                    lstSecilenler.Items.RemoveAt(lstSecilenler.SelectedIndex);
                   // lstSecilenler.Items.RemoveAt(lstSecilenler.SelectedIndices[i]);
                }
            }

        }
    }
}
