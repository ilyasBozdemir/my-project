using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_h
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[50];
            Random rnd = new Random();
            double toplam = 0.0;
            Console.WriteLine("A dizisi ");
            Console.WriteLine(" ");//ilyas bozdemir
            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(50, 150);
                Console.Write("{0},", sayilar[i]);
             }
             Console.WriteLine(" ");
             Console.WriteLine(" ");
            Console.Write("B dizisindeki, ");//ilyas bozdemir
            int[] bdizisi = new int[50];
            Console.WriteLine("Sayıların Kareleri : ");
            Console.WriteLine(" ");
            for (int i = 0; i < sayilar.Length; i++)
            {
                bdizisi[i] = sayilar[i];
                Console.Write("{0},", Math.Pow(bdizisi[i],2));
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("C dizisinde ki");
            Console.WriteLine("Sayıların Karekökleri : ");
            Console.WriteLine(" ");//ilyas bozdemir
            int[] cdizisi = new int[50];
            for (int i = 0; i < sayilar.Length; i++)
            {
                cdizisi[i] = sayilar[i];
              Console.Write("{0},",Math.Sqrt(cdizisi[i]));
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("D dizisi ");
            Console.WriteLine("b ve c dizisindeki sayıların toplamı :");//ilyas bozdemir
            for (int i = 0; i < sayilar.Length; i++)
            {
                toplam = toplam+ bdizisi[i] + cdizisi[i];
            Console.WriteLine(toplam);
            }
            Console.WriteLine("sayıların toplamı :{0}",toplam);
            
            Console.ReadKey();     
                          
        }
    }
}
