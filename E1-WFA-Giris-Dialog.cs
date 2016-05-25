using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace E1_WFA_Giris
{
    public partial class Dialog : Form
    {
        public Dialog()
        {
            InitializeComponent();
        }

        private void Dialog_Load(object sender, EventArgs e)
        {

        }
        /*
        globa değişkenler
        değer değişkenine program çalıştığı sürece tüm eventler (olaylar) içerisinden erişilebilir.
            */
      public   string deger;//öteki formdan erişebilmek için public tanımladık.//property gibi oldu.başka yerlerden erişmek istersek property tanımlayıp erişiriz.
        private void btnTamam_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
         deger = "OK butonuna basıldı";
        }

        private void btnİptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            deger = "CANCEL butonuna basıldı";
        }
    }
}
