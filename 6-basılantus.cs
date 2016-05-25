using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_basılantus
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir tuşa basın : ");
            char karakter = (char)Console.Read();  // ben klavyeye yazılan ilk harfi istiyorum. char dan stringe dönüşmeli
            Console.WriteLine("Basılan tuş " + karakter);

            if (karakter.ToString().ToUpper()=="E")
            {
                Console.WriteLine("Devam edebilirsiniz");
            }
            else
            {
                Console.WriteLine("Çalışma sonlandırılıyor");
            }
            // read metodu ile basılan tuşlar yakalaır, enter ok işareti F5 gibi tuşları yakalayamayız bunun için readkey metodu ile consoleKeyInfo metdodu kullanılır.


            ConsoleKeyInfo keyInfo=Console.ReadKey();
            Console.WriteLine(keyInfo.Key + "tuşuna basıldı.");
            Console.ReadKey(); 
        }      // adam program yazarken F1 e basınca yardım çıksın derse bunları kullancaz keyinfo vs

    }
}
