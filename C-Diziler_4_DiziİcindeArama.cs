using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Diziler_4_DiziİcindeArama
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] student = new string[5];
            student[0] = "ali";
            student[1] = "osman";
            student[2] = "hasan";
            student[3] = "mehmet";
            student[4] = "fatma";
            //contains metodu
            //dizi içnde bir elemanın var olup olmadığını true false olarak döner.
            Console.WriteLine("aranacak ogrenciyi girin");
            string aranan = Console.ReadLine();
            // bool varmi=eleman.Contains(aranan);
            if (student.Contains(aranan))
            
                Console.WriteLine("aranan bulundu");
            
            else
            
                Console.WriteLine("aranan bulunamadı");
            //ındexOf metodu
            //Dizi içinde aranan elemanın index değerini döner.
            //bulunmazsa -1 döner.
            //hasan adlı ogrenciyi bulup yerine doğan yaz
            int bulunanIndex = Array.IndexOf(student,"hasan");
            if (bulunanIndex != -1)
            {
                Console.WriteLine("aranan bulundu");
                student[bulunanIndex] = "doğan";
            }
            else
                Console.WriteLine("bulunamadı");
            //LastIndexOf
            //ındexof gibi işlem yapar.Aranan elemandan birden fazla varsa sonuncusunun indexini döner.
            string denemeText = "caner mollaoğlu";
            //her string bir karekter(char )dizisidir.
            char[] denemeHarfler = denemeText.ToCharArray();
            int sonaHarfi = Array.LastIndexOf(denemeHarfler, 'a');
            //int ilkaHarfi = Array.LastIndexOf(denemeHarfler, 'a');
            //int asayisi = sonaHarfi - ilkaHarfi;
            //Console.WriteLine(asayisi);
            if (sonaHarfi != -1)
        
                Console.WriteLine("son a harfi bulundu index değeri" + sonaHarfi);
          
            else
                Console.WriteLine("bulunamadı");
            int asayac = 0;
            foreach (char  item in denemeText)
            {
                if (item.ToString().ToLower()=="a")
                {
                    asayac++;
                  
                }
            }
            Console.WriteLine("toplam :{0} tane a bulunuyor", asayac);
            Console.Read();
        }
    }
}
