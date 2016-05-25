using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E6_WFA_RadioButtom
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnOnay_Click(object sender, EventArgs e)
        {
            //    if (radioButton1.Checked)
            //        MessageBox.Show("en çok kullandığınız dil:" + radioButton1.Text);
            //    if (radioButton2.Checked)
            //        MessageBox.Show("en çok kullandığınız dil:" + radioButton2.Text);
            //    if (radioButton3.Checked)
            //        MessageBox.Show("en çok kullandığınız dil:" + radioButton3.Text);
            //    if (radioButton4.Checked)
            //        MessageBox.Show("en çok kullandığınız dil:" + radioButton4.Text);
            foreach (Control radio in grpDil.Controls)
            {
              
                if (radio is RadioButton)
                {
                    RadioButton rdp = (RadioButton)radio;//radio botton da tek seçim yapılır.//burda checked a erişebilmek için cast ettik.
                    if (rdp.Checked)
                    {
                        MessageBox.Show("En çok kullandığınız dil:" +rdp.Text);
                    }
                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}
