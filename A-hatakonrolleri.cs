using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_hatakonrolleri
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            HATA KONTROLÜ
            hatalar programın çalışması esnasında oluşurlar ve programın durmsına neden olurlR.Bu hatalar kullanıcı yazılıcıya da sistem kaynaklı olabilir.
            yapmamız gereken oluşabilecek hataların analizini yaparak gerekirse kullanıcıya bilgilencirici mesajlar vermektir.Hata konrolü
            try catch yapısı ile sağlanır.
       */
            #region tryCatchTanımlama 
            //try
            //{
            //    //herhangi bir hata olabilecek kodlar buraya yazılır.
            //}
            //catch (Exception)
            //{
            //    //hata meydana geldikten sonra çalışması gereken kodlar buraya yazılır.   
            //}
            //finally {
            //    //hata olsa da olmasa da çalışacak olan kodlar burada bulunur.
            // }//ctrl+k+c :toplu comment yapma
            #endregion
            #region ilkOrnek
            //try
            //{
            //    int sifir = Convert.ToInt32(Console.ReadLine());
            //    int sonuc = 10 / sifir;
            //    Console.WriteLine(sonuc);
            //}
            //catch (Exception)
            //{


            //    Console.WriteLine("bir hata oluştu");

            //}
            #endregion
            #region ExceptionYakalama

            /*exception nesnesi
            oluşan hatalar exception nesnesinden türetilir.System snıfının altında yer alır.*/
            //klavyeden not girişi yapınız:45 ile 100 arasında ise geçtiniz, <45 ise kaldınız .>100 ise max değer 100 olmalı hatası versin.
            //try
            //{
            //    byte not;
            //    Console.WriteLine("not giriniz.");
            //    not = Convert.ToByte(Console.ReadLine());

            //    if (not>=45 & not<=100)
            //    {
            //        Console.WriteLine("geçtiniz");
            //    }
            //    else if (not<45)
            //    {
            //        Console.WriteLine("kaldınız");
            //    }else
            //    {
            //        Console.WriteLine("max değer 100 olabilir.");
            //    }
            //}
            //catch (Exception ex)//ex ddiye bi nesne  oluşturduk.

            //{
            //    //oluşan her türlü hatada aynı mesajjı göstermek istemdiğimiz için exception nesnesini kullandık.
            //    //Console.WriteLine(ex.ToString());//bu şekil olunca tüm hataları getirdi
            //    Console.WriteLine(ex.Message);//bu olunca sadece olan hatayı getirdi.

            //}
            //exception nesnesinin özellikleri
            /*message:hata ile ilgili açıklamayı verir.
            source: hatayı oluşturan nesne ya da sınıfı verir.
            targetsite:hatayı oluşturan metod hakkında bilgi verir.*/
            #endregion
            #region BirdenFazlaException
            //try
            //{
            //    byte not;
            //    Console.WriteLine("not giriniz.");
            //    not = Convert.ToByte(Console.ReadLine());

            //    if (not >= 45 & not <= 100)
            //    {
            //        Console.WriteLine("geçtiniz");

            //    }
            //    else if (not < 45)
            //    {
            //        Console.WriteLine("kaldınız");
            //    }
            //    else
            //    {
            //        Console.WriteLine("max değer 100 olabilir.");
            //    }
            //}
            //catch (OverflowException)//owerflow expcetin olunca bu kodları çalıştır.

            //{

            //    Console.WriteLine("ongorülen değerler dışında değer girildi.girilen değerller "+byte.MinValue+"--"+byte.MaxValue+ "arasında olnalıydı.");
            //    //byteın alt ve üst değerinni  ekrana yazdırdık.
            //}
            //catch(FormatException)//istediğimiz hata mesajını yazdırırız.
            //{
            //    Console.WriteLine("rakam giriniz");
            //}
            //finally {
            //    Console.WriteLine(DateTime.Now.ToLongDateString());//her halükarda sistem saatini yazdırmak için finally bloğunda yazdırdık.
            //}
            #endregion
            #region BirdenFazlaException_2
            //klavyeden girilen sayıların birbirne bölünmesi
            //bölünen sayı giriniz
            //bölen sayı giriniz
            //sonuc
            //try
            //{
                
            //   Console.WriteLine("Bölünen Sayıyı Giriniz:");
            //  decimal bolunen = Convert.ToDecimal(Console.ReadLine());
            //  Console.WriteLine("Bölen Sayıyı Giriniz:");
            //  decimal bolen = Convert.ToDecimal(Console.ReadLine());
            //  decimal sonuc = bolunen / bolen;
            //   Console.WriteLine(sonuc);



            //}
            //catch (OverflowException)//aritmeticexception bunun yerine de yazılabilir
            //{

            //    Console.WriteLine("aralıkta olmayan değerler girdiniz");
            //}
            //catch(FormatException)
            //{
            //    Console.WriteLine("formata uymayan değerler girdiniz");
            //}
            //catch(DivideByZeroException)
            //{
            //    Console.WriteLine("bolen sıfır olamaz");
            //}
            //catch 
            //{
            //    Console.WriteLine("tanımlanamayan bi hata oluştu");
            //}
            ////catch (ArgumentNullException)//tüm exceptionlar hocanın attığı linkte
            ////{

            ////}
            //finally
            //{
            //    Console.WriteLine("işlem bitmiştir" );
            //    Console.WriteLine( DateTime.Now.ToLongDateString());
            //}

            #endregion
            #region

            #endregion
            Console.ReadKey();
        }
    }
}
