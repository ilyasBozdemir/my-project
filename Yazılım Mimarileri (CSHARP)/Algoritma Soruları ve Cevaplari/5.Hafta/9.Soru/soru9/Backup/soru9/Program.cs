using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru9
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı = Convert.ToInt32(Console.ReadLine());
            //sayının asal olup olmadıgını bulan program

            int sayac = 0;
            for (int i = 1; i < sayı; i++)
            {
                if (sayı%i==0)
                {
                    sayac++;
                }//ilyas bozdemir
            }
                if (sayac==0)
                {
                    Console.WriteLine("asal");
                }
                else
                {//ilyas bozdemir
                    Console.WriteLine("asal değil");
                }
                Console.ReadKey();
            
        }
    }
}
