using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[10];

            for (int i = 0; i < 10; i++)
            {
             Console.Write((i + 1) + "." + " sayı giriniz = ");
            sayılar[i] = Convert.ToInt32(Console.ReadLine());
            }//ilyas bozdemir
            foreach (int eleman in sayılar)
            {
                if (eleman % 2 == 1&&eleman>0) // tek sayı olup olmadığı kontrol ediliyor.
                  Console.WriteLine(eleman);
            }//ilyas bozdemir
            Console.ReadKey();
        }
    }
}
