using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _1_a
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = new int[10];

            for (int i = 0; i < 10; i++)
            {

                Console.Write((i+1)+"."+" sayı giriniz = ");

                sayılar[i] = Convert.ToInt32(Console.ReadLine());
                
            }
            //ilyas bozdemir
            for (int i = 0; i < 10; i++)
            {

                Console.Write("girilen sayılar :"+" {0}", sayılar[i]);
                //ilyas bozdemir
            }

            Console.ReadKey(); 


        }
    }
}
