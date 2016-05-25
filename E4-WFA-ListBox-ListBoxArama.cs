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
    public partial class ListBoxArama : Form
    {
        public ListBoxArama()
        {
            InitializeComponent();
        }

        private void btnAktar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i <= 100; i++)
            {
                lstArama.Items.Add(i);
               // lstArama.Items.Add(txtArama.Text);
            }
        }

        private void ListBoxArama_Load(object sender, EventArgs e)
        {

        }

        private void llstArama_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnAra_Click(object sender, EventArgs e)
        {//benim çözümüm
         //for (int i = 0; i < lstArama.Items.Count; i++)
         //{
         //    if (lstArama.Items[i].ToString().Contains(txtArama.Text.ToString())) //containts tüm dizinin içini aramadığı için items[i] yaptık
         //        MessageBox.Show("aranan bulundu");




            //}
            //MessageBox.Show("aranan bulunamadı");
            //hocanın çözümü
            bool durum = false;
            //contains(veri tipi aynı olmadı)
            //FindString() geriye int index döner.
            foreach (int item in lstArama.Items)
            {
            
                if (item.ToString() == txtArama.Text)
                {
                    lstArama.SelectedIndex = item;
                    txtArama.Clear();
                    txtArama.Focus();
                    durum = true;
                    break;
                  


                }
               
           
                    
                
            }
            if (durum) MessageBox.Show("Bulundu");
            else MessageBox.Show("Bulunamadı");

        }
    }
}
