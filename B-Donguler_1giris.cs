using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Donguler_1giris
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Donguler
            birden fazla tekrarlanması gereken işleri döngüler sayesinde yaparız bu sayede gerçekleşmesini istediğimiz işleri hem daha az kod hem daha hılı yaparız.
            While döngüsü:
            while(koşul) koşul sağlandığı sürece dön
            {
            komutlar
            sayacın artım değeri(opsiyonel:her zaman olmak zorunda değil)
            }
            */
            #region WhileGiris
            //0 dan 10 a kadar olan sayılari ekrana yazdırınız.
            //  byte a = 0;
            //while (a<=10)
            //{
            //    Console.WriteLine(a);
            //    //Console.Read();
            //    a++;//a+=1 a=a+1
            //}
            //while (true)//sonsuz while döngüsü
            //{
            //    Console.WriteLine("1");
            //}
            //Console.ReadKey();
            #endregion
            #region ForGiriş
            /*
            for döngüsü
            for(sayac değişkeni;şart;artış ya da azalış değeri)
            {
            komutlar
            }
            */
            //for (int i = 0; i <=10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            #endregion
            #region whileÖrnek
            ////klavyeden girilen 3 sayıyı toplayarak toplamı ekrana yazdırınız.

            //int sayac = 1;
            //int sayi, toplam=0;
            //while (sayac<=3)
            //{
            //    Console.WriteLine(sayac+" .sayıyı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //    sayac++;

            //}
            //Console.WriteLine("sonuc: "+toplam);

            #endregion
            #region 0gireneKadarSayilariTopla
            //klavyeden girilen sayıları 0 girilene kadar toplayınız.
            //for ile yapılanına bak.
            //int sayi = 1;
            //double toplam = 0;

            //while (sayi!=0)
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    sayi = Convert.ToInt32(Console.ReadLine());

            //    toplam += sayi;

            //}
            //Console.WriteLine("toplamamız:{0}"+toplam);
            //for ile yapılannı
            //int i,number=1;
            //int toplam=0;
            //for ( i = 0; number!=0; i++)
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    toplam += number;

            //}
            //Console.WriteLine("toplam sonucu:{0}",toplam);
            //Console.WriteLine("toplam {0}adet sayı giriniz",i);
            //3.versiyon

            //int i, number = 0;
            //int toplam = 0;
            //char cvp;
            //Console.WriteLine("devam etmek istiyomusunuz E/H");
            //cvp = Convert.ToInt32();
            ////while döngüsünün tersidir kod bloğu olmaksızın en az bir kez çalışır.
            //do
            //{
            //    Console.WriteLine("bir sayı giriniz");
            //    number = Convert.ToInt32(Console.ReadLine());
            //    toplam += number;

            //} while (number!=0);
            //Console.WriteLine("sonuc" + toplam);
            #endregion
            #region GirilenSayiyaKadarSayma
            //girilen bir sayıya kadar sayıp devam etmek isteyip istemediğimizi sorsun.ekranı temizleyin.

            string cvp;
            do
            {
                Console.Clear();//ekranı temizlemek için
                //////////bir kez oynamak için gerekn kodlar/////////
                Console.WriteLine("bir sayı giriniz");
                int sayi = Convert.ToInt32(Console.ReadLine());
                for (int i = 0; i <= sayi; i++)
                {
                    Console.WriteLine(i);

                }
                Console.WriteLine("tekrar sayı girmek ister misiniz E/H");
                cvp = Console.ReadLine();
                ////////////////////////////////////////////////////////
            } while (cvp.ToLower()=="e");
            Console.WriteLine("oynadığınız için teşekkürler");
            #endregion
            Console.ReadKey();
        }
    }
}
