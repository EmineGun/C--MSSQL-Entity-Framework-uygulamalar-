using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Metodlar_Giris
{
    class Program
    {
        static void Main(string[] args)
        {/*ref ut vs bak.*/

            /*
            metodlar:
            Bazen program yazarken bazı kodları tekrar tekrar yzmak gerekebilir bu tip durumlarda bu kod parçaçıklarını yeniden yazmak yerine 
            bu kodlardan metodlar oluşturarak bunları kullanabiliriz.C# içerisinde geriye değer dönen ve değer dönmeyen olmk üzere iki çeşit metod bulunmaktadır.
            1-Geriye Metod Döneyen Metodlar(parametreli ve parametresiz):
            tanımlama:
            <erişim bicimi>void<metod ismi>(parametre)
            {
            metod içinde çalışacak kodlar
            }

            */
            //parametresiz://static=nesne oluşturmadan metoda ulaşmayı sağlar

            RenkDegistir();
            GirisAl("yeni bir metod deneniyor");
            GirisAl(Console.ReadLine());

            bool[] boolDegerler = { true, true, false, false, false };
            DiziSifirlama(true, boolDegerler);
            //metod overloading(aşırı yüklenmiş)
            DiziSifirlama(true, boolDegerler);
            DiziSifirlama(1, new int[] { 23, 45, 67 });
            //   GirisAl(boolDegerler[1].ToString());
            //2-değer döndüren metodlar:
            //klavyeden girilen 2 sayının toplamını yapan metod
            int sonuc = Toplam(4, 5);
            int sonuc1 = Toplam(1,8,5,6,23,78);
            //params ile yazılı ve sözlu puan hesaplanıyor
         byte gelenPuan=   PuanHesapla(80,90,90,80);
            Console.WriteLine("puanınız "+gelenPuan);
          //  Console.WriteLine(sonuc);
          //parametre olarak 2 farklı (ve ya daha fazla )dizi göndermek istiyorum.
            Console.ReadKey();
        }

        public static void RenkDegistir()
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
        }
        public static void GirisAl(string str)
        {
            Console.WriteLine(str.ToUpper());
        }
        /// <summary>
        /// bool bir dizinin tüm elemanlarını değer ile değiştirir.
        /// </summary>
        /// <param name="deger">bool tipinde bir deger girin true false</param>
        /// <param name="dizi"></param>
        public static void DiziSifirlama(bool deger, bool[] dizi)//dizi bile atasak dizi tipinde olack
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = deger;

            }
        }
        /// <summary>
        /// int bir dizinin tüm elemanlarını değer ile değiştirir.
        /// </summary>
        /// <param name="deger">int  tipinde bir deger girin true false yapar</param>
        /// <param name="dizi"></param>

        public static void DiziSifirlama(int deger, int[] dizi)
        {
            for (int i = 0; i < dizi.Length; i++)
            {
                dizi[i] = deger;

            }

        }
        public static int Toplam(int a, int b)
        {
            int sonuc = a + b;
            return sonuc;//return a+b; aynı şey

        }
        /*
        yukarıdaki toplam metodu gibi her bir parametre için yeni bir topla metodu yazacağımıza (int a,int b,int c gibi) metod karmaşasından kurtulup tek metod ike sınırsız yapı sağladık.params yazarak girilecek verinin tipinde bir dizi oluşturur.
        önemli nokta: params en sona yazılır ondan sonra parametre olmaz.
            */
        public static int Toplam(params int[] degerler)
        {
            int sum = 0;
            for (int i = 0; i < degerler.Length; i++)
            {
                sum += degerler[i];
            }
            return sum;
        }
        public static byte PuanHesapla(byte yazili,params byte[]sozluNotlari)
        {
            int sozluToplam = 0;
            int not = 0;
            byte puan=0;
            foreach (byte  item in sozluNotlari)
            {
                sozluToplam +=item;
            
            }
            not = (sozluToplam+yazili) / (1+sozluNotlari.Length);
            if (not < 25)
                puan = 0;
            else if (not < 60)
                puan = 1;
            else if (not < 80)
                puan = 2;
            else if (not <= 100)

                puan = 5;
            else

                Console.WriteLine("hatalı giriş yaptınız");
            return puan;

        }
        public static byte PuanHesapla(byte yazili,params byte[][] sozluNotlar)
        {
            int birincidonemnotlar = 0;
            //1.dönem notları
            for (int i = 0; i < sozluNotlar[1].Count(); i++)
            {
                birincidonemnotlar+= sozluNotlar[0].ElementAt(i);
            }
            //2.
            return 0;
        }
        }
}
