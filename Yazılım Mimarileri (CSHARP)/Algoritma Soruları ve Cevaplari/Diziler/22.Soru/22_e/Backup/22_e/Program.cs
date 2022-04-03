using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_e
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[50];
            Random rnd = new Random();
           

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(50, 150);
                Console.Write("{0},", sayilar[i]);
            }//ilyas bozdemir
            Console.WriteLine(" ");

            int gecici;
            for (int i = 0; i < sayilar.Length; i++)
            {
                for (int j = i + 1; j < sayilar.Length; j++)
                {
                    if (sayilar[j] > sayilar[i])
                    {
                        gecici = sayilar[i];
                        sayilar[i] = sayilar[j];
                        sayilar[j] = gecici;
                    }
                }//ilyas bozdemir
            }
            
            Console.WriteLine("--------------------------------------");
            foreach (int i in sayilar)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();
            Console.ReadLine();
        }
    }
}
