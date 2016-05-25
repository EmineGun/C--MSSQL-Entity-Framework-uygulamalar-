using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_operatörler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* 1-Aritmetik Operatörler
       Matematiksel işlemler için kullanılır.
     +,-,*,/,%,++,--, a=a+b; yerine a+=b;
a=a-b; yerine a-=b;
a=a*b; yerine a*=b;
a=a/b; yerine a/=b;
a=a%b; yerine a%=b;
a=a<<b; yerine a<<=b;
a=a>>b; yerine a>>=b;
a=a&b; yerine a&=b;
a=a^b; yerine a^=b;
a=a|b; yerine a|=b;
              2-Karşılaştırma Operatörleri
      ==,>,<,!=,>=,<=,! (not anlamında), -->(uzaklaşma), <-- (yakınlaşma),
              3-Aktarma Operatörleri
       =, *=, /=, %=, +=, -=, <<=, >>=, &=, ^=, |=

*/          byte a = 10;
            byte b = 3;
            byte sonuc = a += b;  // a=a+b; demek oluyo. a=13 oldu 10=10+3 oluyo ve 13 ü 10 a atıyo yneni a mız 13 oluyo.

            a %= b; // a nın b ye bölümünden kalanımız artık yeni a sayımız olarak işleme devam ederiz.


            /* 4-Mantıksal Operatörler
            & (ve operatörü) true değer alması için iki tarafında true değerler alması gerekir, diğer türlü false çalışacaktır */


           
            int mSayi1 = 100, mSayi2 = 50;

            if (mSayi1>50 & mSayi2<300)
            {
                //true
            }
            else
            {
                //false
            }


            /*
            | operatörü (veya) 
            int mSayi1 = 100, mSayi2 = 50;

            if (mSayi1 > 50 | mSayi2 < 300)       // veya da bir koşulun true olması yeterli.
            {
                //true
            }
            else
            {
                //false
            }*/


            /*
            && operatörü (ve değil - mantıksal ve- koşullu ve)
            Eğer ilk koşul false ise diğer koşullara bakılmadan false bloğu çalışır. en belirgin özelliği bu.
            
            || (mantıksal veya- koşullu veya)
               ilk koşul true ise 2. değişkene bakılmadan true değeri döner.

            ! operatörü(değil, not)
            */

            if (mSayi2!=100)
            {
                Console.WriteLine("sayı 100 den farklıdır.");
            }
            else
            {
                Console.WriteLine("Sayı 100 e eşittir.");
            }
            // ?? Operatörü (null coalescing) , eğer ilk değişken null ise 2. değer hesaplanır.

            string ogrenciAdi = null;
            string bilgi = ogrenciAdi ?? "Adi girilmedi";
            Console.WriteLine(bilgi);


            // ?: koşul operatörü   , tek satırlık if gibi, 

            string girilenDurum;
            Console.WriteLine("çıkmak istediğinizden emin misiniz? E/H");
            girilenDurum = Console.ReadLine();

            Console.WriteLine(girilenDurum.ToUpper() == "E" ? "Program kapatılıyor." : "Çalışmaya devam"); //tek satırda if else yapısı yaptık.
            Console.ReadKey();
        }
    }
}
