using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace D1_Metodlar_AlanHesaplama
{
    class Program
    {
        //const double PI = 3;
        static void Main(string[] args)
        {
            string cvp;
            do
            {
                Console.Clear();//temizleyip devam etsin.

                double gelenCevap = GirisAl("1)karenin alanı\n2)dikdörtgenin alanı \n3)dairenin alanı\n4)yamuk alanı");
                //secici(gelenCevap)byte,short,ushort,int,long,ulong,char,string ya da enum tiplerinden biri olmalıdır.olmazsa hata verir.
                #region AlanHesapları
                switch (gelenCevap.ToString())
                {
                    case "1":
                        //kare alanı
                        Console.WriteLine("Alan Sonucu:{0} ", AlanHesapla(GirisAl("kenar giriniz:"))); ;
                        break;
                    case "2":
                        //dikdörtgenin alanı
                        Console.WriteLine("Alan Sonucu:{0} ", AlanHesapla(GirisAl("kısa kenar giriniz"), GirisAl("uzun kenar giriniz"))); ;
                        break;
                    case "3":
                        //dairenin alanı
                        Console.WriteLine("Alan Sonucu:{0} ", AlanHesapla(Convert.ToInt32(GirisAl("Çap giriniz")))); ;
                        break;
                    case "4":
                        //yamuk alanı
                        Console.WriteLine("Alan Sonucu:{0} ", AlanHesapla(GirisAl("alt taban giriniz")), GirisAl("ust taban giriniz"), GirisAl("yukseklik giriniz")); ;
                        break;

                    default:
                        //hiç bir koşul sağlanmazsa burası çalışır.
                        break;
                }
                #endregion
                Console.WriteLine("devam etmek ister misiniz?E/H");
                cvp = Console.ReadLine();
            } while (cvp.ToLower()=="e");
            Console.Read();
        }
        /// <summary>
        /// kalavyeden aldığı girişi double a çevirir
        /// </summary>
        /// <param name="mesaj">kullanıcıya gösterilecek olan mesajdır.</param>
        /// <returns></returns>
        public static double GirisAl(string mesaj)
        {
            Console.WriteLine(mesaj);
            double sayi = 0;
            try
            {
                sayi = double.Parse(Console.ReadLine());
              //  return sayi; burda tanımlarsak patlar dönmeme ihtimali var
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            return sayi;
        }
        public static double AlanHesapla(double kısaKenar,double uzunKenar) {
            return kısaKenar * uzunKenar;
        }
        public static double AlanHesapla(double kenar)
        {
            return kenar*kenar;
        }
        public static double AlanHesapla(int  çap,double PI=Math.PI)
        {
            return PI*(çap*çap);
        }
        public static double AlanHesapla(double alt,double ust,double yukseklik)
        {
            return ((alt+ust)*yukseklik)/2;
        }
    }
}
