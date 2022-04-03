using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_c
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizilerim = new int[50];//50 sayı tutan dizi yaptık.
            Random rastgele = new Random();//rastgele sayı sınıfını cagırdık
            int rast, sayac = 0;
            while (sayac < 50)
            {
                rast = rastgele.Next(50, 150);
                if (Array.IndexOf(dizilerim, rastgele) == -1)//dizilerin içindekiler
                // aynı olmasın diye
                {
                    dizilerim[sayac] = rast;//rastgele sayıları sayac 50 oluncaya kadar
                    sayac++;//sayacı arttır.                //diziye aktar
                }
            }//ilyas bozdemir
            Console.WriteLine("Dizidekiler :");
            for (int i = 0; i < dizilerim.Length; i++)
            {
                Console.Write("{0},", dizilerim[i]);
            }
            Console.WriteLine("----------------------------------");

            foreach (var kucuk in dizilerim)
            {
                if (kucuk <= 100)
                {
                    Console.Write("{0},", kucuk);
                }
            }
            Console.WriteLine("");
            Console.ReadLine();
        }
    }
}
