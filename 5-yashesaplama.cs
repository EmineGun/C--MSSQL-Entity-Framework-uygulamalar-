using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_yashesaplama
{
    class Program
    {
        static void Main(string[] args)
        {
            /* kullanıcıdan istenenler
            Ad Soyad
            Sehir
            Dogum tarihi (24.06.1985)

         Ekran çıktısı
         adınız       :
         soyadınız    :
         sehir bilgisi:
         yasınız      :

         Bilgilendirme: Ekran çıktısı placeholder ( {}{}{},yer tutucu) kullanılarak verilecektir. */



            /* benim cevabım     string ad;
                                 string soyad;


                 Console.WriteLine("Adınızı ve soyadınızı giriniz :" );
                 ad = Console.ReadLine();
                 Console.WriteLine("Yaşadığınız şehri giriniz");
                 soyad = Console.ReadLine();
                 string dogumTarih = "24.06.1985";
                 DateTime newDateTime = DateTime.Parse(dogumTarih);
                 Console.WriteLine(newDateTime.Date);

                 Console.ReadLine();  */



            // console üzerinden renk değiştirme, 
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();


            string ad, soyad, sehir,dogumT;
            int yas;
            Console.WriteLine("Adınızı giriniz");
            ad = Console.ReadLine();
            Console.WriteLine("Soyadınızı giriniz");
            soyad = Console.ReadLine();
            Console.WriteLine("sehir giriniz");
            sehir = Console.ReadLine();

            Console.WriteLine("Doğum tarihini giriniz");
            dogumT = Console.ReadLine();
            DateTime dt = Convert.ToDateTime(dogumT);
            int dogumYili = dt.Year;
            int simdikiYili = DateTime.Now.Year;
            yas = simdikiYili - dogumYili;

            Console.WriteLine("Adınız : {0}\n Soyadınız: {1}\n Yas:{3}", ad, soyad, sehir, yas);

            Console.ReadKey();

            Console.ResetColor();
            Console.Clear();


            Console.ReadKey();




        }
    }
}
