using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Döngüler_2_Break
{
    class Program
    {
        static void Main(string[] args)
        {
            // Break heyword kullanımı

            /*    for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine(i);
                    if (i==3)
                    {
                        break; // bir üst döngünün dışına çıkar
                    }
                }
                Console.WriteLine("Donguden çıktı");  */


            #region örnek
            //ekrandan girilen sayılar toplanıyor. toplam sonucu büyük eşit 200 olduğunda program duruyor. mesaj olarak :
            // Maximum değere ulaştınız, toplam:350, Tekrar denemek istermisin?



            //1 Oyun için gereken kodla başlıyorum.
            do
            {
                int newNumber;
                int Sum = 0;
                do
                {
                    Console.WriteLine("Bir sayı giriniz");
                    newNumber = Convert.ToInt32(Console.ReadLine());
                    Sum += newNumber;
                    if (Sum >= 200)
                    {
                        Console.WriteLine("Maximum değere ulaştınız");
                        break;
                    }




                } while (true);

                Console.WriteLine("Toplam : {0} ", Sum);
                Console.WriteLine("Tekrar oynamak istermisiniz? E/H");
                string answer = Console.ReadLine();
                if (answer.ToLower()!="e")
                {
                    break;
                }

            } while (true);
            


            #endregion





            // Soru:









            Console.Read();
        }
    }
}
