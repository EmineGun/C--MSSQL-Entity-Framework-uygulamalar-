using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Diziler_6_DiziOrnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*klavyeden iki ogrenci için ayrı ayrı ad soyad ve tc kimlik isticez.Bu bilgileri çok boyutlu diziye kaydedip tüm bilgiyileri
            ogrenci listesi başlığı altında ekrana yazdırın.
            */
            /*string bir dizi içinden random olarak bir seçim yapın ve seçimin karekter sayısı kadar ekrana - işareti yazınız.
            */
            /*
            string bir dizi oluşturarark 2. eleman ve 5. elemanın yerlerini değiştiriniz.
            */
            /*
            6 ile 49 arasında birbirinden farklı 6 rakam seçimi yaparak ekrana yazdırın(seçilen bir sayının bir daha seçilmemesine dikkat ediniz.)
            */
            #region OgrenciListesi
            /*klavyeden iki ogrenci için ayrı ayrı ad soyad ve tc kimlik isticez.Bu bilgileri çok boyutlu diziye kaydedip tüm bilgiyileri
            ogrenci listesi başlığı altında ekrana yazdırın.
            */
            //    Console.WriteLine("dizi byutunu giriniz:");
            //    int i = Convert.ToInt32(Console.ReadLine());
            //    int j = Convert.ToInt32(Console.ReadLine());
            //    string[,] ogrenciListesi = new string[i, j];
            //    for (int a=0;a<i;a++) { 
            //    Console.WriteLine(" ogrencinin adını giriniz:");
            //    string ad = Console.ReadLine();
            //    Console.WriteLine("ogrencinin  soyadını giriniz:");
            //    string soy = Console.ReadLine();
            //    Console.WriteLine(" ogrencinin tc sinigiriniz:");
            //    int tc = Convert.ToInt32(Console.ReadLine());
            //}

            //    Console.WriteLine("ogrenci listesi: "+ogrenciListesi[i,j]);
            #endregion
            #region alternatif
            //string[,] ogrenciListesi = new string[2, 3];
            //for (int i = 0; i < ogrenciListesi.GetLength(0); i++)
            //{
            //    for (int j = 0; j < ogrenciListesi.GetLength(1); j++)
            //    {
            //        Console.WriteLine("ogrenci adı");
            //        ogrenciListesi[i, j] = Console.ReadLine();
            //        j++;
            //        Console.WriteLine("ogrenci soyadı");
            //        ogrenciListesi[i, j] = Console.ReadLine();
            //        j++;
            //        Console.WriteLine("ogrenci tc");
            //        ogrenciListesi[i, j] = Console.ReadLine();
            //        j++;
            //    }
            //}
            //for (int i = 0; i < 2; i++)
            //{
            //    Console.WriteLine("ogrenci adı:{0}\n soyadı:{1}\n tc:{2}",ogrenciListesi[i,0],ogrenciListesi[i,1],ogrenciListesi[i,2]);
            //}
            #endregion
            #region DiziRandomSeçim
            //string bir dizi içinden random olarak bir seçim yapın ve seçimin karekter sayısı kadar ekrana - işareti yazınız.
            //string[] dizi = { "elma", "çilek", "kayısı", "karpuz" };
            //Random rnd = new Random();
            //int sayi = rnd.Next(0,3);
            //string yazi = (string)dizi.GetValue(sayi);

            //int sayac = 0;
            //foreach (char harf in yazi)
            //{
            //    Console.WriteLine(" __ ");
            //}

            //Console.WriteLine("random sayı ve index : "+sayi);



            #endregion
            #region Yerdeğistirme
            /*
            string bir dizi oluşturarark 2. eleman ve 5. elemanın yerlerini değiştiriniz.
            */
            //string[] egitimTuru = { "C#", "MVC", "AsP.Net", "Bootstrap", "Ajax", "java" };

            //string eleman1 = (string)egitimTuru.GetValue(1);
            //string eleman4 = (string)egitimTuru.GetValue(4);
            //string tutucu = eleman1;
            //eleman1 = eleman4;
            //eleman4 = tutucu;
            //egitimTuru[1] = eleman1;
            //egitimTuru[4] = eleman4;

            //Console.WriteLine(egitimTuru[0]+ "   "+ egitimTuru[1]+"  "+egitimTuru[2] + "   " + egitimTuru[3]+" "+egitimTuru[4] + "   " + egitimTuru[5]);





            #endregion

            #region  
            /*
            6 ile 49 arasında birbirinden farklı 6 rakam seçimi yaparak ekrana yazdırın(seçilen bir sayının bir daha seçilmemesine dikkat ediniz.)
            */
            int[] sayiDizisi = new int[6];
            Random rnd = new Random();
            int randomSayi;



            for (int i = 0; i < sayiDizisi.Length; i++)//6 rakama ihtiyacımız var.
            {
                do//dizi içinde olmayan random rakamlar üretir
                {
                    randomSayi = rnd.Next(6, 50);
                } while (sayiDizisi.Contains(randomSayi)==true);
                sayiDizisi[i] = randomSayi;
            }
            foreach (int eleman in sayiDizisi)
            {
                Console.WriteLine(eleman);
            }
            #endregion
            Console.Read();
            
        }
    }
}
