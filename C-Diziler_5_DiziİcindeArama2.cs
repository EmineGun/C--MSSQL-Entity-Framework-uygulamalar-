using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Diziler_5_DiziİcindeArama2
{
    class Program
    {
        static void Main(string[] args)
        {


            /*klavyeden girilen metin içindeki buyuk harfi kucuk harf, rakam, ve alfasayısal (rakam ve harf olmayan karekterlerin sayısını bulunuz)
            char sınıfının ilgili metodları kullanılarak bu islemleri yapabiliriz.
            IsDigit()   IsLower() IsLower()  IsLetterorDigital
            buyuk harf:3
            kucuk harf:34
            rakam sayısı:2
            alfasayısal:5

            */
            Console.WriteLine("yazı girin ");
            string gelenMetin =Console.ReadLine();
            char[] denemeHarfler = gelenMetin.ToCharArray();
            int kHarfSayac = 0;
            int bHarfSayac = 0;
            int rSayac = 0;
            int alfaSayac = 0;
            foreach (char harf in gelenMetin)
            {
                if (char.IsDigit(harf))
                    rSayac++;
                if (char.IsUpper(harf))
                
                    bHarfSayac++;
                if (char.IsLower(harf))
                    kHarfSayac++;
                if (!char.IsLetterOrDigit(harf))
                    alfaSayac++;
            }
            Console.WriteLine("büyük harf sayısı:{0}\nküçük harf sayısı:{1}\nrakam sayısı:{2}\nalfasayısal karekter sayısı:{3}",bHarfSayac,kHarfSayac,rSayac,alfaSayac);
            Console.Read();
        }
    }
}

