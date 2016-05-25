using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F1_CheckedListBox
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTumunuSec_Click(object sender, EventArgs e)
        {
            //chlistbox.ıtems.count:chlşstboc eleman sayısı
            for (int i = 0; i <= chListBox.Items.Count-1; i++)
            {
                //setItemCehcked:indexe göre ıtem seçer.
                chListBox.SetItemChecked(i,true);//işaretlenecek değeri ve bool değer istiyor.
            }
            lblMesaj.Text = chListBox.CheckedItems.Count + "Eleman seçili";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i <= 10; i++)
            {
                chListBox.Items.Add(i);//listbox gibi çalışıyor.
            }
        }

        private void chListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
          //  lblMesaj.Text = chListBox.CheckedItems.Count.ToString();
        }
        /*
        
            */
        private void chListBox_ItemCheck(object sender, ItemCheckEventArgs e)//chlist boxunu sender işaret eder.e nesnesi üzerinden bazı spesific özellkelere ulaşıyoruz.e=suanda eventi birebir gerçeklerştiren nesne.
        {
            int sayi = chListBox.CheckedItems.Count;
            if (e.NewValue==CheckState.Checked)
            
                sayi++;
            if (e.NewValue == CheckState.Unchecked)
                
                    sayi--;

            lblMesaj.Text = sayi + "  eleman seçili ";
        }

        private void btnSecimiKaldir_Click(object sender, EventArgs e)
        {
            SecimiKaldir();
            lblMesaj.Text = chListBox.CheckedItems.Count + "Eleman seçili";
        }

        private void SecimiKaldir()//seç sağ tık actions enter metod yapar.
        {
            for (int i = 0; i <= chListBox.Items.Count - 1; i++)
            {
                //setItemCehcked:indexe göre ıtem seçer.
                chListBox.SetItemChecked(i, false);//işaretlenecek değeri ve bool değer istiyor.
            }
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            foreach (int item in chListBox.CheckedItems)
            {
                lstListe.Items.Add(item);
            }
            //seçili olanlarını otomatik kaldırmak için.

            SecimiKaldir();
        }
    }
}
