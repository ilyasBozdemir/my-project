using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_f
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100,};
            int neg = 0;
            for (int i = 1; i < sayilar.Length; i++)
            {
                    if (sayilar[i]<0 )
                    {
                       neg = sayilar[i]; //// eksik kod var
                    }
            }//ilyas bozdemir
            //ilyas bozdemir

            Console.WriteLine("Dizi içindeki en büyük negatif sayı: > > > " + neg);
            Console.ReadKey();
        }
    }
}
