using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Diziler_3_DiziMetodları
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] egitimTuru = { "C#", "MVC", "AsP.Net", "Bootstrap", "Ajax" };
            string ad = "caner";
            //IsArray Metodu
            //bir değişkenin dizi olup olmadığını kontrol eder geriye true false döner.
            Type tip = egitimTuru.GetType();
            Console.WriteLine(tip.IsArray);//true 
            Console.WriteLine(ad.GetType().IsArray);//false
            //GetValue Metodu
            //Dizi elemanlarının değerlerine erişmek için kullanılır.
            //setValu Metdu
            //Dizi elemanlarına değer atama için kullanılır
         //   string egitim = egitimTuru.GetValue(0).ToString();//getvaue object deger dönderir.
            string egitim = (string)egitimTuru.GetValue(0);
            egitimTuru.SetValue("Html5",2);
            //Join Metodu
            //Dizi içerisinde bulunan elemanları belirtilen bir ayraç yardımı ile yan yana yazdırır.
            string tumEgitimler = string.Join("--",egitimTuru);
            string[] dolu = new string[5];
        //  dolu[5]= { "abc","bcd","cgh","der","ety"};bak sonra
            //Copy Metodu 
            //Bir dizinin içeriğini başka diziye kopyalar.
            string[] kopyaDizi = new string[5];
            //Array.Copy(egitimTuru, kopyaDizi, 3);
            Array.Copy(egitimTuru, 2, kopyaDizi,3,2);//2.indexten almaya başla kpyadizide 3ten başlayıp 2 taneyi yerleştir.
            Console.Read();
        }
    }
}
