using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_HataKontorlü_2_HataTanimlama
{
    class Program
    {
        static void Main(string[] args)
        {

         /*   #region HataOluşturma(exceptionoluşturma)(throw)
            Console.WriteLine("Lütfen sayı giriniz");
            String okunan = Console.ReadLine();
            int girilenSayi = 0;
            try
            {
                girilenSayi = int.Parse(okunan);
                if (!(girilenSayi > 0))
                   // Exception nesnesinin message propertisine bu hata mesajını atar.

                    throw new Exception("Lütfen pozitif bir sayı giriniz");   //if yapısında tek satır yazcaksan aç kapa yapmasan olur.
                if (girilenSayi > 100)
                    throw new Exception("100den büyük sayı giremessiniz");
                Console.WriteLine("Tebrikler doğru sayı girşi yaptınız");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }
            finally
            {
                Console.WriteLine("Finally bloğu çalışıyor");

            }

            Console.ReadLine();

            #endregion   */



            #region ExceptionKontrolü


            Console.WriteLine("Lütfen sayı giriniz");
            String okunan = Console.ReadLine();
            int girilenSayi = 0;
            try
            {
                girilenSayi = int.Parse(okunan);
               
                Console.WriteLine("Tebrikler doğru sayı girşi yaptınız");
            }
            catch (Exception ex)
            {
                //is as oeratörü = is operatörü bir değişken,n tipinn belirlenen bir değişken tipi ile karıştırılması için uygundur.

                //as operatörü= Referans tipli olan değişkenlerde dönüşüm için kullanılır (object, string,dynamic)

                if (ex is OverflowException)
                {
                    Console.WriteLine("Sayı belirlenen değerler dışında");
                }
                if (ex is FormatException )
                {
                    Console.WriteLine("Belirlenen formatta giriş yaptınız.");
                }
            }
            finally
            {
                Console.WriteLine("Finally bloğu çalışıyor");

            }

            #endregion












        }
    }
}
