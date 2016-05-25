using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using SavingUserSettings.Properties;
namespace F2_WFA_SettingKullanimi
{
    public partial class SifreDegistirme : Form
    {
        public SifreDegistirme()
        {
            InitializeComponent();
        }

        private void txtEskiSifre_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDegistir_Click(object sender, EventArgs e)
        {
            string eskiSifre = Properties.Settings.Default.Password;
            //string eski = txtEskiSifre.Text;
            //string yeni1
            if (!string.IsNullOrEmpty(txtEskiSifre.Text)&&!string.IsNullOrEmpty(txtEskiSifre.Text)&&!string.IsNullOrEmpty(txtYeniSifre2.Text))
            {
                //hepsi dolu ise
                if (eskiSifre==txtEskiSifre.Text)
                {
                    if (txtYeniSifre1.Text==txtYeniSifre2.Text)
                    {
                       Properties.Settings.Default.Password = txtYeniSifre1.Text;
                       // Properties.Settings.Default["Password"] = txtYeniSifre1.Text;
                       // Properties.Settings.Default["UserName"] = txtYeniSifre1.Text;
                        Properties.Settings.Default.Save();//değiştirdiğim alan saklansın diye yaptım.

                        Properties.Settings.Default.Reload();
                        MessageBox.Show("Şifreniz başarı ile değiştirildi");
                    }
                    else
                    {
                        MessageBox.Show("Yeni şifre uyuşmuyor");
                    }
                }
                else
                {
                    MessageBox.Show("Eski şifrenizi hatalı girdiniz");
                }
            }
            else
            {
                MessageBox.Show("Lütfen tüm alanları doldurun");
            }
        }

        private void grpSifreDegistirme_Enter(object sender, EventArgs e)
        {

        }
    }
}
