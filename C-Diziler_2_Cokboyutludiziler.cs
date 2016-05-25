using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Diziler_2_Cokboyutludiziler
{
    class Program
    {
        static void Main(string[] args)
        {
            //çok boyutlu dizler:satır ve sütunları var.
            string[] liste = new string[5];
            //3 eleman (satır)x2 boyut(sütun)
        
            string[,] ogrenciListesi = new string[3,2];
            string[,] ogrenciListem = {
                {"Ahmet","aslan" },//0.eleman
                {"Ali","uzun" },//1.eleman
                { "veli","kısa"}//2.eleman

            };
            //0.eleman
            ogrenciListesi[0,0]= "Ahmet";
            ogrenciListesi[0,1]= "aslan";
            //1.eleman
            ogrenciListesi[1, 0] = "Ali";
            ogrenciListesi[1, 1] = "uzun";
            //2.eleman
            ogrenciListesi[2, 0] = "veli";
            ogrenciListesi[2, 1] = "kısa";
            Console.WriteLine("ilk ogrencinin adı" + ogrenciListesi[0, 0]);
            Console.WriteLine("ilk ogrencinin soyadı" + ogrenciListesi[0, 1]);
            int listeBoyutu = ogrenciListesi.Length;//6=satırxsutun
            int lsteElemanSayisi = ogrenciListesi.GetLength(0);//eleman(satır) sayısı 3
            int lsteBoyutSayisi = ogrenciListesi.GetLength(1);//boyut(sutun) sayısı 3
            //2 satır
            //3 eleman
            //4 boyut
            int[,,] yeniListem = new int[2, 3, 4];
            //Düzensiz diziler:(Jagged Arrays)
            int[][] duzensizDizi = {
                new int [] {1},
                new int [] {1,2,3},
                new int [] {1,2,3,4,5,6,7}
            };
            foreach (int[] item in duzensizDizi)//okucağımız verilerin tipi:int[]
            {
                foreach (int eleman in   item)
                {
                    Console.Write(eleman);
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
