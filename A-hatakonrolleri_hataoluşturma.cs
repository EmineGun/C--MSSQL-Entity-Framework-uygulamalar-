using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_hatakonrolleri_hataoluşturma
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ExceptionOlusturma(throw)
            /*istenilen hata mesajını fırlatarak hata mesajından sonraki satırların çalışması engellenir.*/
            try
            {
                Console.WriteLine("bir sayı giriniz");
            }
            catch 
            {
                int sayi = Convert.ToInt32(Console.ReadLine());
                if (sayi <= 0) { 
               
                    //exception sınıfnın message adlı propertisine bir hata mesajı atandı.
                  throw new Exception("sayı negatif olamaz");
                }
                if (sayi > 100) { 
                
                    throw new Exception("100den büyük sayı girmeyiniz");
                }

                Console.WriteLine("tebrikler doğru sayı girişi yaptınız");
            }

            #endregion
        }
    }
}
