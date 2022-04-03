using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _7
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = {12,34,54,6,65,74,51,17,98,43,32,100 };
            for (int i = 0; i < sayilar.Length; i++)
            {
                
                Console.WriteLine(sayilar[i]);
            }
            int min = sayilar[0];//ilyas bozdemir
           int mak = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (min > sayilar[i])
                {
                    min = sayilar[i];
                }
                if (mak < sayilar[i])//ilyas bozdemir
                {
                    mak = sayilar[i];
                }
            }
            Console.WriteLine("=====================================");
            Console.WriteLine("Dizi içindeki en büyük sayı: > > > " + mak);
            Console.WriteLine("Dizi içindeki en küçük sayı: > > > " + min);
            Console.ReadKey();
           //ilyas bozdemir
        }
       
    }
}
