using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D3_Metodlar_ExtentionMetodlar
{
    class Program
    {
        static void Main(string[] args)
        {    /* EXTENSION METOD 

            extentions metod tanımlamak için
            1-public static bir sınıf tanımlanır
            2-yapmak istediğimiz işlemleri yapan metod yazılır.
            3-metod da static olarak tanımlanır ki istediğimiz anda erişebilelim
            4-ilk parametrenin başına this( keywordü) konur.Bu metodun extensin metod olduğunun işaretidir.
            5-This ilk parametre olmak zorundadır.

    */
            string gelenDeger ="123";
            int a=gelenDeger.ToInt32();
            string metin = "yeni bir extention metod deniyoruz";
          metin=  metin.BuyukHarf(true);
            Console.Read();
        }
    
    }



}
