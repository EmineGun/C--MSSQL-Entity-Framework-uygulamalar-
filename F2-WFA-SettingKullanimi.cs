using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace F2_WFA_SettingKullanimi
{
    public partial class SettingKullanımı : Form
    {
        public SettingKullanımı()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrEmpty(txtKullaniciAdi.Text.Trim())&&!string.IsNullOrEmpty(txtSifre.Text.Trim()))
            {
                if (txtKullaniciAdi.Text==Properties.Settings.Default.UserName&&txtSifre.Text==Properties.Settings.Default.Password)
                {
                    SifreDegistirme sfr = new SifreDegistirme();
                    this.Hide();
                    sfr.Show();
                }
                else
                {
                    MessageBox.Show("Yanlış Kullanıcı Adı veya Şifre");
                }
            }
            else
            {
                MessageBox.Show("Lütfen Tüm alanları doldurunuz");
            }
        }

        private void SettingKullanımı_Load(object sender, EventArgs e)
        {

        }
    }
}
