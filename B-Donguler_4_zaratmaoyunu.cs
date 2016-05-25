using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace B_Donguler_4_zaratmaoyunu
{
    class Program
    {
        static void Main(string[] args)
        {
            #region zaratmabenim
            //kullanıcı 1 ile 6 arasında bir rakam girşi yapacak.Çift zar kaçıncı tahminde gelecek bunu bulduğumuzda denemeyi sonlandıracaz.
            //ekran çıktısı
            //1-6 arasında zar giriniz?
            //1.deneme==>1-4
            //2.deneme==>3-2
            //3.deneme==>4-2
            //4.deneme de ÇİFT GELDİ 4-4
            //tekrar oynamak ister misiiz? E/H
            //programın tüm hata kontrolleri yapılacak
            //oyunun başarı ile tamamlanması sonucunda olduğu gibi , hatalı girişerde "tekrar oynamak ister misniz"
            //E/H sorusu sorulacaktır.
            //try
            //{
            //    Console.WriteLine("sayi gir");
            //    int sayi = Convert.ToInt32(Console.ReadLine());
            //    int sayici = 1;
            //    Random rnd = new Random();
            //    do
            //    {

            //        int randomNumber1 = rnd.Next(1, 6);
            //        int randomNumber2 = rnd.Next(1, 6);
            //        if (randomNumber1 == sayi & randomNumber2 == sayi)
            //        {
            //            Console.WriteLine("cift geldi");
            //            break;
            //        }
            //        sayici++;
            //        Console.WriteLine("{2}deneme: {0} {1}", randomNumber1, randomNumber2, sayici);
            //        if (sayi > 0 || sayi < 0)
            //            throw new Exception("aralıkta olmayan bir sayı girdiniz");
                    
                    
            //    } while (true);
            //}
            //catch (Exception ex)
            //{
            //    if (ex is FormatException)
            //    {
            //        Console.WriteLine("lütfen sayı giriniz.");
            //    }
            //    Console.WriteLine(ex.Message);
            
            //}
            





        
            #endregion
            int deneme=1;
           string gelenCevap="";
            do
            {
                Console.Clear();
                #region 1eloyunkodu
                try
                {
                    Console.WriteLine("1-6 arasında bir sayı giriniz");
                    int gelenZar = Convert.ToInt32(Console.ReadLine());
                    int zar1;
                    int zar2;
                   
                    if (gelenZar<1||gelenZar>6)
                    {
                        throw new Exception("1-6 arasında bir eğer girmelisiniz");
                    }
                    Random rnd = new Random();
                    do//sürekli zar atmak için kullanıacak olan döngü
                    {
                        zar1 = rnd.Next(1, 6);
                        zar2 = rnd.Next(1, 6);
                        Console.WriteLine("{0}.deneme {1}-{2}", deneme, zar1, zar2);
                        deneme++;
                    } while (gelenZar!=zar1||gelenZar!=zar2);
                    Console.WriteLine("{0}.deneme de ÇİFT geldi {1}-{2}", deneme, zar1, zar2);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    try
                    {
                        Console.WriteLine("tekrar oynamak ister misiniz? E/H");
                        gelenCevap = Console.ReadLine();
                        if (gelenCevap.ToLower()!="e"||gelenCevap.ToLower()!="h")
                        {
                            // throw new Exception("e ya da h girin");
                            Console.WriteLine("e ya da h girin");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine(ex.Message);
                        
                    }
                }
                #endregion
            } while (gelenCevap.ToLower()=="e");
            Console.WriteLine("oyun bitti");
            //Environment.Exit(0);
        }
    }
}
