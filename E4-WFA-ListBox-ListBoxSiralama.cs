using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;
namespace E4_WFA_ListBox
{
    public partial class ListBoxSiralama : Form
    {
        public ListBoxSiralama()
        {
            InitializeComponent();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            int sayi;
            for (int i = 1; i <= 10; i++)
            {
                 int.TryParse(Interaction.InputBox(i + ".sayıyı giriniz"), out sayi);

                lstListe.Items.Add(sayi);
               
                
            }
            int aradeger;
            for (int l = 0; l <lstListe.Items.Count-1; l++)
            {
                for (int m = l+1; m < lstListe.Items.Count; m++)
                {
                    if (Convert.ToInt32(lstListe.Items[l])>Convert.ToInt32(lstListe.Items[m]))
                    {
                        //büyük olanı tempe at
                        aradeger = Convert.ToInt32(lstListe.Items[l]);
                        //küçük olanı büyüğün yerine yaz
                        lstListe.Items[l]= lstListe.Items[m];
                        //tempi küçük olana yaz
                        lstListe.Items[m] = aradeger;
                    }
                }
            }
            
        }
    }
}
