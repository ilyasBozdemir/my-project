using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizilerim = new int[50];//50 sayı tutan dizi yaptık.
            Random rastgele = new Random();//rastgele sayı sınıfını cagırdık
            int rast, sayac = 0;
            double toplam = 0;
            while (sayac < 50)//ilyas bozdemir
            {
                rast = rastgele.Next(50, 150);
                if (Array.IndexOf(dizilerim, rastgele) == -1)//dizilerin içindekiler
                // aynı olmasın diye
                {
                    dizilerim[sayac] = rast;//rastgele sayıları sayac 50 oluncaya kadar
                    sayac++;//sayacı arttır.                //diziye aktar
                }
            }
            Console.Write("Dizidekiler :");
            for (int i = 0; i < dizilerim.Length; i++)
            {
                Console.Write("{0},",dizilerim[i]);
            }
            Console.WriteLine("");
            Console.Write("toplamı: ");
            for (int i = 0; i < dizilerim.Length; i++)
            {
             foreach (var top in dizilerim)
               {
                toplam = dizilerim[i];//dizileri toplama aktar ve topla 
               }   
            }
            Console.WriteLine("Toplam : {0}",toplam);
            Console.WriteLine("Ortalama : {0}", toplam / 50);
            Console.ReadLine();










        }
    }
}
