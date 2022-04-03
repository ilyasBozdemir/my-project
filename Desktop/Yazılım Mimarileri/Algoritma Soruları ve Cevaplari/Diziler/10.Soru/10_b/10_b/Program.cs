using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 4, 5, -15, 22, -34, 3, 0, 7, 43, 100 };
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);//ilyas bozdemir
            }
            Console.WriteLine("***********************");
            Console.WriteLine("tersten yazılmıs hali :");
            Array.Reverse(sayilar);//terse cevirir.
            foreach (var sayi in sayilar)
            {
                Console.WriteLine(sayi);//ilyas bozdemir
            }
              
            Console.ReadKey();
         }
            
        }
    }

