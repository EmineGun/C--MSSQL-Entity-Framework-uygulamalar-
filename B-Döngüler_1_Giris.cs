using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Döngüler_1_Giris
{
    class Program
    {
        static void Main(string[] args)
        {

            #region Döngüler
            //Döngüler : Birden fazla tekrarlanması gereken isimleri döngüler yardımı ile yaparız.
            /*
            While Döngüsü: 
            While(şart)     // oşart sağlandığı sürece anlamı veriyor
              {
              Komutlar
              sayacın artış değeri
               } 
               */
            #endregion




            //0 dan 10 a kadar olan sayıları yazın.

            #region WhileDongu
            /*   byte a = 0;
               while (a<=10)      //koşul true olduğu sürece döneriz.
               {
                   Console.WriteLine(a);
                   a++;
                   //a +=1;    a=a+1;
               }
               */

            #endregion




            #region ForGiris
            //For Döngüsü
            /*
            for (sayac değişkeni; şart ;  artış veya azalış değeri)
            {
            Komutlar
            }    */


            /*  for (int sayac = 0; sayac < 10; sayac++)
              {
                  Console.WriteLine(sayac);
              }
              Console.Read(); */

            #endregion



            //klavyeden girilen 3 sayının toplamını ekrana yazdırınız.
            #region WhileOrnek
            /* int sayac = 0;
             int sayi;
             int Toplam=0;  //ilk eğeri verdik hata çıkarmadı.


             while (sayac<3)
             {
                 Console.WriteLine(sayac + ".sayıyı giriniz");
                 sayi = Convert.ToInt32(Console.ReadLine());
                 Toplam += sayi;       //Toplam=Toplam+sayi
                 sayac++;


             }

             Console.WriteLine("Sonuc: {0}" , Toplam);   // döngünün dışına yazıyoruz bütün ş bitince toplamı söylesin diye.

     */

            #endregion


            #region 0GireneKadarToplamaYap
            //Klavyeden 0 girene kadar girilen tüm sayıları toplayıp toplamı yaz.

            /* int number=1;
            int sum = 0;
            Console.WriteLine("Bir sayı giriniz");

            while (number!=0)   //0 dan farklı olduğu sürece
            {
                number = Convert.ToInt32(Console.ReadLine());
                sum += number;


            }

            Console.WriteLine(sum); */

            //aynı soruyu do while ile yazalım : while döngüsünün tersidir, önce işlemini yapar daha sonra koşusu test eder.
            //Her koşul en az 1 kere çalışacaktır.


            /* int number = 1;  //kullanıcı girişi ile değiştii için 0 yada 1 atanması önemli değildir.
             int sum = 0;

             do
             {
                 Console.WriteLine("Bir sayı giriniz");
                 number = Convert.ToInt32(Console.ReadLine());
                 sum += number;
             } while (number!=0);

             Console.WriteLine(sum); */

            #endregion



            #region MyRegion
            //Klavyeden girilen sayıya kadar olan sayıları ekrana yazdırınız.Bittiğinde devam etmek istermisiniz E/H? şeklinde mesaj veriniz. E ye basılırsa
            // başlatınız, h ye basılırsa bitti şeklinde mesaj veriniz.


            /* benm cvbım 
              int sayi=0;
              char tercih;
              int sayac=0;


              Console.WriteLine("Devam etmek istiyor musunuz(E/H) ?");
              tercih = Convert.ToChar(Console.ReadLine());
              while (sayac==sayi)
              {
                  Console.WriteLine("Bir sayı giriniz");
                  sayi = Convert.ToInt32(Console.ReadLine());
                  sayac++;

              }
          Console.WriteLine("Devam etmek ister misiniz ?")   */

            // hocanın cvbı
            /*   string cevap = "";
                 do
                 {
                     //1 kez saymak için kullandığımız kod
                     Console.WriteLine("Bir sayı giriniz");
                     int sayi = Convert.ToInt32(Console.ReadLine());


                     for (int i = 0; i <= sayi; i++)
                     {

                         Console.WriteLine(i);

                     }
                     //////////////////////////////////////// buraya kadar, şimdi yeni kontrol oluşturcaz
                     Console.WriteLine("Devam etmek isterminiz ? (E/H)");
                     cevap = Console.ReadLine();

                     } while (cevap.ToLower()=="e");    */

            #endregion

            
        }
    }
}
