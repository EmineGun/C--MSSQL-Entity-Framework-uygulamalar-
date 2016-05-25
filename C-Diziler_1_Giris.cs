using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Diziler_Giris
{
    class Program
    {
        static void Main(string[] args)
        {/*
            ARRAYS(DİZİLER)
            Diziler ve koleksiyonlar .net içinde verileri gruplayarak saklamak için kullanılan yapılardır.
            -Diziler içerisinde "aynı türden"veriler saklanabilir.
            -Eleman sayıarı oluşturulduklarında tanımlanmalıdır.
            -Koleksiyonlara göre daha hızlıdırlar.
            _System.Array namespace altında bkunurlar.
            -Hem değer tipinde hem de referans tipinde verileri saklayabilirler.
            -Dizi içerisinde veriler sıfır numaralı indexten itibaren saklanırlar.

            DegişkenTürü[] dizi değişken adı=new DeğişkenTürü[eleman sayısı]
            */
            int[] dizi = new int[4];//4 elemanlı int türünde elemanları tutabilen br dizi oluşturduk.
            string[] ogrenciListesi = new string[5];
            ogrenciListesi[0] = "ahmet";
            ogrenciListesi[3] = "veli";
            int sayi = 12;
            //  ogrenciListesi[4]=3; int atanmaz
            ogrenciListesi[4] = sayi.ToString();
            string[] adSoyad = { "ali", "osman", "350", "true" };
            Console.WriteLine(adSoyad[1]);
            int diziBoyutu = adSoyad.Length;
            Console.WriteLine(diziBoyutu);//4 elemanlıdır.
                                          //tüm dizi elemanlarını okuyarak ekrana yazdıralım.
            for (int i = 0; i < adSoyad.Length; i++)
            {
                Console.WriteLine(adSoyad[i]);
            }
            //Index was outside the bounds of the array.hatası dizinin olmayan bir indexine erişmek isteyince gelir.
         //   0 ile 50 arasındaaki çift sayıları bir diziye atalım.
         int diziUzunluk = 50 / 2 + 1;
            int[] ciftlistesi = new int[diziUzunluk];
            int sayac = 0;
            for (int i = 0; i < 50; i++)
            {
                if (i % 2 == 0)
                {
                    ciftlistesi[sayac] = i;
                    sayac++;


                }
            }
            //1.yöntem
            int ciftSayici = 0;
            int[] ciftSayilar = new int[1];
            for (int i = 0; i < 50; i++)
            {
                if (i%2==0)
                {
                    ciftSayilar[ciftSayici] = i;
                    //arrayi yeniden boyutlandır.
                    Array.Resize(ref ciftSayilar, ciftSayilar.Length + 1);
                }

            }
            //ciftSayilar = new int[123]; diziyi resize için kullnılmamalıdır.
            //2.yöntem FOR EACH

            foreach (string item in adSoyad)
            {
                Console.WriteLine(item);
            }
            Console.Read();

        }
    }
}
