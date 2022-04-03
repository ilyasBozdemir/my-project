using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = { 11, 15, 24, 35, 56, 78, 98, 70, 34, 12 };
            Console.WriteLine("Dizideki Sayılar : ");
            for (int i = 0; i < sayılar.Length; i++)
            {
                Console.WriteLine("{0}.indeks =>{1}", i, sayılar[i]);
            }
            int mak = sayılar[0];
            int min = sayılar[0];//ilyas bozdemir

            for (int i = 1; i < sayılar.Length; i++)
            {
                if (mak < sayılar[i])
                {
                    mak = sayılar[i];//ilyas bozdemir
                }
                if (min > sayılar[i])
                {
                    min = sayılar[i];
                }
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("Dizi içindeki en büyük sayı ===> " + mak);
            Console.WriteLine("Dizi içindeki en küçük sayı ===> " + min);
            Console.ReadKey();
        }
    }
}
