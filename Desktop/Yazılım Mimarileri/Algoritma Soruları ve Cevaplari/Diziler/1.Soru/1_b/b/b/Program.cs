using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace b
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
            int toplam = 0;
            for (int i = 0; i < 10; i++)
            {
                
                toplam = sayılar[i] + toplam;
                //ilyas bozdemir
            }
              Console.WriteLine("dizinin sayıları toplamı : {0} ",toplam);

            Console.ReadKey(); 
        }
    }
}
