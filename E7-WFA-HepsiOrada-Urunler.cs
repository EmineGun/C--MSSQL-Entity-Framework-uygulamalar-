using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_WFA_HepsiOrada
{
    public class Urun
    {
        public int ID { get; set; }
       
        public string UrunAdi { get; set; }
        public int KategoriID { get; set; }

        [DisplayName("Ürün Fiyatı")]
        public double fiyat { get; set; }
        public override string ToString()
        {
            return UrunAdi+"--"+fiyat;
        }

    }
}
