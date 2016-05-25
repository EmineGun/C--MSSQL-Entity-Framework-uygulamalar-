using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E7_WFA_HepsiOrada
{
    class Kategori
    {
        public string KategoriAdi { get; set; }
        public int ID { get; set; }
        public override string ToString()
        {
            return KategoriAdi;
        }
    }
     
    
}
