using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c//ilyas bozdemir
{
    class Program
    {
        static void Main(string[] args)
        {//ilyas bozdemir
            int[] sayılar = new int[10];

            for (int i = 0; i < 10; i++)
            {

                Console.Write((i + 1) + "." + " sayı giriniz = ");

                sayılar[i] = Convert.ToInt32(Console.ReadLine());

            }
            foreach (int eleman in sayılar)
            {//ilyas bozdemir
                if (eleman >0) // Çift sayı olup olmadığı kontrol ediliyor.
                    Console.WriteLine(eleman);
            }
            Console.ReadKey();
        }
    }
}
