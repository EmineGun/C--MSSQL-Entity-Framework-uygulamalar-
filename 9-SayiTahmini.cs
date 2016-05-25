using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_SayiTahmini
{
    class Program
    {
        static void Main(string[] args)
        {
            //1-random bir sayı oluşturunuz

            //2-kullanıcı dan sayıyı tahmin etmenisini isteyiniz.
            //3-kullanıcının tahmin için 3 hakkı vardır.doğru bilirse 3. tahminde bildiniz şklinde mesaj veriniz.
            Random rnd = new Random();
            int randomNumber =rnd.Next(1,10);
            //WHILE döngüsü

            int gelenSayi=0;//bir değer tamanayınca hata verir.
            int sayac = 0;
            //int gelenSayi= Convert.ToInt32(Console.ReadLine());

            while (randomNumber!=gelenSayi) //içteki koşul eşit olmadığında çıkmayı sağlar
            {
               Console.WriteLine("sayı giriniz:");
               gelenSayi = Convert.ToInt32(Console.ReadLine());
            



            if (gelenSayi==randomNumber)
            {
                Console.WriteLine("tebrikler bildiniz");
            }
                sayac++;
                
            }
            Console.WriteLine(sayac+".tahminde bildiniz.");
            Console.ReadKey();
        }
    }
}
