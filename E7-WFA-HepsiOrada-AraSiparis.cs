using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms.VisualStyles;

namespace E7_WFA_HepsiOrada
{
    public class AraSiparis
    {
        public AraSiparis(List<Urun> uruns)
        {
            Uruns = uruns;
            Toplam = Uruns.Sum(c => c.fiyat);

        }
        public double Toplam { get; set; }
        public List<Urun> Uruns { get; set; }
        public override string ToString()
        {
            return String.Format("{0} Ürün, Toplam: {1:C1}", Uruns.Count, Toplam);
        }
    }
}