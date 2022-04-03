using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_d
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[50];
            Random rnd = new Random();
            int min, mak;
            //ilyas bozdemir
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(50, 150);
                Console.Write("{0},",sayilar[i]);
            }
            Console.WriteLine(" ");
            min = sayilar[0]; //ayrıntı burda
            mak = sayilar[0];
            for (int i = 1; i < sayilar.Length; i++)
            {
                if (min > sayilar[i])
                {
                    min = sayilar[i];
                }
                if (mak < sayilar[i])
                {
                    mak = sayilar[i];
                }
            }
            Console.WriteLine("--------------------------------------");
            Console.WriteLine("Dizi içindeki en büyük sayı: > > > " + mak);
            Console.WriteLine("Dizi içindeki en küçük sayı: > > > " + min);
            Console.WriteLine("--------------------------------------");
            Console.ReadKey();     
        }
    }
  }

