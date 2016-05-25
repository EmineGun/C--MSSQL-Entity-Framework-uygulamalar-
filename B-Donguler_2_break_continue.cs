using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Donguler_1_break_continue
{
    class Program
    {
        static void Main(string[] args)
        {
            #region
            //break keyword kullanımı:
            //sadece bir üstteki döngünün içinden çıkar.
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine(i);
            //    if (i==5)
            //    {
            //        break;//break keywordünü gördüğü anda döngüden çıkar.buradan itibaren döngü içindeki satırları çalıştırmaz.
            //        Console.WriteLine("a");//break ten sonra yazmadı.
            //    }
            //    Console.WriteLine("deneme");
            //}
            //Console.WriteLine("döngüden çıkıldı");
            //continue keywordü  kullanımı:
            //döngüyü bir adım ileriye atlatır.
            //for (int i = 0;  i< 10;i ++)
            //{

            //    if (i==5)//5.adımda bir şey yapmdan atlar.
            //    {
            //        continue;
            //    }
            //    Console.WriteLine(i);//5 yazmaz atlatır.
            //}

            #endregion

            #region
            //ekrana girilen sayılar toplanıyor toplam sonucu >=200 olduğunda program duruyor.
            //mesaj :max değere ulaştınız
            //toplam :350
            //tekrar denemek ister misniz?E/H
            //string cvp;
            //do
            //{

            //    int toplam = 0;
            //    int sayi;
            //    while (toplam <= 200)
            //    {


            //        Console.WriteLine("sayi giriniz: ");
            //        sayi = Convert.ToInt32(Console.ReadLine());
            //        toplam += sayi;
            //    }
            //    Console.WriteLine("max değeri aştınız");
            //    Console.WriteLine("sonucunuz: " + toplam);
            //    Console.WriteLine("devam etmek ister misiniz E/H");
            //    cvp = Console.ReadLine();
            //} while (cvp.ToLower() == "e");


            //#endregion
            //string cevap;
            //do
            //{
            //    Console.Clear();
            //    #region 1OyunKodu
            //    int newNumber, sum = 0;
                
            //    do
            //    {
            //        Console.WriteLine("bir sayı giriniz");
            //        newNumber = Convert.ToInt32(Console.ReadLine());
            //        sum += newNumber;
            //        if (sum >= 200)
            //        {
            //            Console.WriteLine("max değere ulaştınız");
            //            break;
            //        }
            //    } while (true);
            //    Console.WriteLine("sonuc:{0}", sum);
            //    Console.WriteLine("devam etmek istiyor musunuz E/H");
            //    cevap = Console.ReadLine();
            //    if (cevap.ToLower()=="h")
            //    {
            //        break;
            //    }
                #endregion
            } while (cevap.ToLower()=="e");
            Console.WriteLine("GAME OVER");
            
            Console.Read();
        }
    }
}
