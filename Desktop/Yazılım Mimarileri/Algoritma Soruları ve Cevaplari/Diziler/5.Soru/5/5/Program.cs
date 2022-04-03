using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 45, 12, 23, 65, 95, 47, 
                 85, 32, 21, 78, 59, 83, 33, 70 };
             Console.Write("Sayı girin :");
            int sayı = Convert.ToInt32(Console.ReadLine());
          for (int i = 0; i < dizi.Length; i++)
            {
                if (dizi[i] == sayı)
                {//ilyas bozdemir
                    Console.WriteLine("{0} Sayısı Dizimizde Mevcuttur.",dizi[i]);
                    
                 }
                   //ilyas bozdemir
                else
                {
                    Console.WriteLine("{0} Sayısı Dizimizde Mevcut Değildir.", dizi[i]);
                }

            }Console.ReadLine();
         
            
            }
        }
    }

