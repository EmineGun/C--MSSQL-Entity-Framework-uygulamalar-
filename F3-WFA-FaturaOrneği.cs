using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F3_WFA_FaturaOrneği
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            try
            {
                int ilkIndex = int.Parse(txtİlkİn.Text);
                int sonIndex = int.Parse(txtSonİn.Text);
                if (ilkIndex > sonIndex)

                    throw new Exception("son index ilk indexten büyük olmalıdır");
                lstAdSoyad.Items.Add(txtAdSoyad.Text);
                lstSuMiktari.Items.Add(string.Format("{0}m³", sonIndex - ilkIndex));
                lstFaturaTutari.Items.Add(string.Format("{0:C2}", Hesapla(ilkIndex, sonIndex, (rdbMesken.Checked ? true : false))));


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally {
                Temizle(this.Controls);
            }
        }

        private void Temizle(Control.ControlCollection controlCollection)
        {
            foreach (Control item in controlCollection)
            {
                if (item is TextBox)
                    item.Text = string.Empty;
                else if (item is Panel)
                    Temizle(item.Controls);
                else if (item is RadioButton)
                {
                    RadioButton rb = item as RadioButton;rb.Checked = false;
                }
                else if (item is GroupBox)
                {
                    Temizle(item.Controls);
                }
            }
            txtAdSoyad.Focus();
        }

        private decimal Hesapla(int ilkIndex, int sonIndex, bool meskenMi)
        {
            //mesken ise 0.9 ile umumi ise 0.3 ile çarpılacak
            if (meskenMi)
            {
                return (sonIndex-ilkIndex)*0.9m;//m ile decimal oldu
            }else
            {
                return (sonIndex - ilkIndex) * 0.3m;
            }
        }
       
    }
}
