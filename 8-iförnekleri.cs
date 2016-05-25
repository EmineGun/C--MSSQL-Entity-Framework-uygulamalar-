using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_iförnekleri
{
    class Program
    {
        static void Main(string[] args)
        {
            // klavyeden girilen 3 sayıyı karşılaştırın içlerinden en büyük olanı bulunuz.girilen satı 0dan büyük olmalıdır.
            /* benm cvbım 
              int num1, num2, num3;
              Console.WriteLine("Bir sayı giriniz num1 =");
              num1 = Console.Read();
              Console.WriteLine("Bir sayı giriniz num2 =");
              num2 = Console.Read();
              Console.WriteLine("Bir sayı giriniz num3 =");
              num3 = Console.Read();

              if (num1 > num2 & num1 > num3 )
              {
                  Console.WriteLine("En büyük sayı = " + num1, "\n İkinci Sayı = " + num2);
              }

              else if(num2>num3)
              {
                  Console.WriteLine("Başa dönün.");  */




            int num1, num2, num3;
            Console.Write("Bir sayı giriniz num1 =");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Bir sayı giriniz num2 =");
            num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bir sayı giriniz num3 =");
            num3 = Convert.ToInt32(Console.ReadLine());

            if (num1 > 0 && num2 > 0 && num3 > 0)
            {
                if (num1 >= num2 && num1 >= num3)
                {
                    Console.WriteLine("Girilen en büyük sayı: " + num1);
                }
                else if (num2 >= num1 && num2 >= num3)

                {
                    Console.WriteLine("Girilen en büyük sayı: " + num2);
                }
            }
            else

            {
                Console.Write("Sıfır sayısı girilemez !");
            }
                Console.Read();

            }

        }
    }












