using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_g
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };
            int gecici; 
            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = i+1; j < sayilar.Length; j++)
                {
                    if (sayilar[j]<sayilar[i])
                    {
                        gecici = sayilar[i];//ilyas bozdemir
                        sayilar[i] = sayilar[j];
                        sayilar[j] = gecici;
                    }
                }//ilyas bozdemir
            }
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
