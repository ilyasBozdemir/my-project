using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace e
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[10];

            for (int i = 0; i < 10; i++)
            {//ilyas bozdemir
                Console.Write((i + 1) + "." + " sayı giriniz = ");
                sayılar[i] = Convert.ToInt32(Console.ReadLine());
            }
            foreach (int eleman in sayılar)
            {
                if (eleman <0) // tek sayı olup olmadığı kontrol ediliyor.
                //ilyas bozdemir
                {
                    Console.WriteLine("negatif => "+eleman);
                }
                else
                {
                    Console.WriteLine("pozitif => "+eleman);  
                }

            }
            Console.ReadKey();
        }
    }
}
