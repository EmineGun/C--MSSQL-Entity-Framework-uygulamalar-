using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E3_WFA_TextEditor
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnKes_Click(object sender, EventArgs e)
        {
            if (txtMetin.SelectionLength > 0)

                txtMetin.Cut();

            else
                MessageBox.Show("bir seçim yapınız");
        }

        private void btnKopyala_Click(object sender, EventArgs e)
        {
            if (txtMetin.SelectionLength > 0)
                txtMetin.Copy();

            else
                MessageBox.Show("bir seçim yapınız");
           
        }

        private void btnYapistir_Click(object sender, EventArgs e)
        {
            txtMetin.Paste();
        }

        private void btnGeriAl_Click(object sender, EventArgs e)
        {
            txtMetin.Undo();
        }

        private void btnYaziTipi_Click(object sender, EventArgs e)
        {
            if (fontDialog1.ShowDialog() == DialogResult.OK)
            {
                txtMetin.Font = fontDialog1.Font;
            }
        }

        private void btnYaziRengi_Click(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog()==DialogResult.OK)
            {
                txtMetin.ForeColor = colorDialog1.Color;
               
            }
        }

        private void btnKalin_Click(object sender, EventArgs e)
        {

            if (txtMetin.Font.Bold)
                txtMetin.Font = new Font(fontDialog1.Font, FontStyle.Regular);
            else
            txtMetin.Font = new Font(fontDialog1.Font,FontStyle.Bold);
        }

        private void btnEgik_Click(object sender, EventArgs e)
        {
            if (txtMetin.Font.Italic)
                txtMetin.Font = new Font(fontDialog1.Font, FontStyle.Regular);
            else
                txtMetin.Font = new Font(fontDialog1.Font, FontStyle.Italic);
        }

        private void btnAltiÇizili_Click(object sender, EventArgs e)
        {
            if (txtMetin.Font.Underline)
                txtMetin.Font = new Font(fontDialog1.Font, FontStyle.Regular);
            else
                txtMetin.Font = new Font(fontDialog1.Font, FontStyle.Underline);
        }
        int a = 1;
        private void btnSayac_Click(object sender, EventArgs e)
        {
           // int a = 1; burada olsa sürekli 2 yaziyor global tanımladık bu yüzden.
            a = a + 1;
            lblSayac.Text = a.ToString();
            if (btnSayac.Text == "start")
                btnSayac.Text = "stop";
            else
                btnSayac.Text ="start";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblSayac.Text = a.ToString();
        }
    }
}
