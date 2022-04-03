using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru6._1
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam;
            int sayi = Convert.ToInt32(Console.ReadLine());
            for (int i = 2; i <= sayi; i++)
            {
                toplam = 0;
                for (int j = 1; j <= (i / 2); j++)
                {
                    if (i % j == 0)
                    {//ilyas bozdemir
                        toplam = toplam + j;
                    }
                }
                if (i == toplam)
                {
                    Console.WriteLine(i); 
                }
                Console.ReadLine();
            }
        }
    }
}
