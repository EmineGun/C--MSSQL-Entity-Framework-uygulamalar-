using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Donguler_3_sayiTahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            //1.deneme 0-20 arasında bir sayı girini:
            //13
            //AŞAĞI
            //2.deneme 0-20 arasında bir sayı giriniz:
            //11
            //YUKARI
            //3.deneme 0-200 arasında bir sayı giriniz:
            //12
            //tebrikler 3.denemede buldunuz.
            //kontrol:0-20 arasında veri girisi yapılmazsa exception oluşturunuz.
            #region sayitahminbenimkodum
            //int gelenSayi = 1;
            //try
            //{
            //    #region
            //    string cevap;

            //    int sayac = 0;
            //    do
            //    {


            //        do
            //        {
            //            Random rnd = new Random();
            //            int randomNumber = rnd.Next(1, 10);
            //             Console.Clear();



            //            while (randomNumber != gelenSayi)
            //            {
            //                Console.WriteLine("sayı giriniz:");
            //                gelenSayi = Convert.ToInt32(Console.ReadLine());
            //                if (gelenSayi > randomNumber)

            //                    Console.WriteLine("AŞAĞI");

            //                if (gelenSayi < randomNumber)

            //                    Console.WriteLine("YUKARI");

            //                sayac++;

            //                if (gelenSayi < 0 || gelenSayi > 20)
            //                {
            //                    throw new Exception("aralıkta olmayan bir sayı girdiniz");
            //                }
            //            }

            //            Console.WriteLine(sayac + ".denemede bildiniz.");
            //            Console.WriteLine("devam etmek ister misiniz E/H");
            //            cevap = Console.ReadLine();

            //            if (cevap.ToLower() == "h")
            //            {
            //                break;
            //            }
            //        } while (true);


            //    } while (cevap.ToLower() == "e");
            //    #endregion

            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);

            //}
            #endregion

            Console.ReadKey();
        }

    }
}
