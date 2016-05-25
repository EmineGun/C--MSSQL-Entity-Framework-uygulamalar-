using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D4_Metodlar_Ref_Out
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 
            REF VE OUT
            ref:Bu anahtar kelime c# dilinde işaretçilerin yerini tutar metodun geri dönüş tipi olmamasına rağmen ref sayesinde metod içerisinden sayi değişkenine ram üzrindeki adresine erişilerek değeri değeri değiştirilebilir.Değişkenin mutlaka bir ilk değerinin olması gerekiyor.
            */
            int sayi = 10;
            DegerDegistir(ref sayi);
            Console.WriteLine(sayi);
            /* OUT:
            metodlardan irden fazla parametre döndürmek için kullanılı.Değişkene "ilkleme(ilk değer atama )" işlemi  zorunlu değildir.
            */
            int value;
            string str1, str2;
            outMetod(out value,out str1,out str2);
            Console.WriteLine(value);
            Console.WriteLine(str1);
            Console.WriteLine(str2);
            //metodu otomatik oluşturmaya bak.
            //cümle birleştir
            string ad, soyad,ad_soyad;

            //ad soyad alınıyor
            Console.WriteLine("ad gir");
            ad = Console.ReadLine();
            Console.WriteLine("soyad gir");
            soyad = Console.ReadLine();
            cumleBirlestir(ad,ref soyad ,out ad_soyad);

            Console.WriteLine(ad);
            Console.WriteLine(soyad);
            Console.WriteLine(ad_soyad);
            Console.Read();
        }
        public static void DegerDegistir(ref int x) { }
        private static void outMetod(out int v,out string s1,out string s2)
        {
            v = 100;
            s1 = "yeni bir değer girildi";
            s2 = null;
        }
        public static void cumleBirlestir(string ad,ref string soyad,out string ad_soyad)
        {
            ad = "Abdullah";
            soyad = "kocaman";
            ad_soyad = ad + " "+soyad;
           
        }
    }
}
