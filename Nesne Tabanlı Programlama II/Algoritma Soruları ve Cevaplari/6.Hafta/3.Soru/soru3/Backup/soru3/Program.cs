using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Üç basamaklı rakamları dokuzdan farklı
           * tüm sayıları ekranda gösteren ve bu kurala uygun kaç tane 
           * sayı olduğunu söyleyen programı C# Console kodları ile yazınız. */
            int sayı;
            int a, b, c, sayac = 0;
            for (a = 1; a < 10; a++)
            {
                for (b = 0; b < 10; b++)//ilyas bozdemir
                {
                    for (c = 0; c < 10; c++)
                    {
                        for (int i = 0; i < 10; i++)
                        {
                            sayı = (a * 100) + (b * 10) + c;
                        }
                        Console.WriteLine(sayı);//ilyas bozdemir
                    sayac++;
                    Console.Write("sayac :"+sayac);
                    Console.ReadLine();

                        
                    }
                }
            }
        }
    }
}
