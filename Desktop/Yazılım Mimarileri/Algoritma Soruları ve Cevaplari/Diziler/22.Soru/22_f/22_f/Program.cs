using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_f
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[50];
            Random rnd = new Random();
            Console.Write("Aradığınız sayıyı giriniz = ");
            int aranan =Convert.ToInt32(Console.ReadLine());
            if (Array.IndexOf(sayilar,aranan) == -1)
            {
                Console.WriteLine("Yok");
            }

            else//ilyas bozdemir
            {
                Console.WriteLine("Var");
            } 

            for (int i = 0; i < sayilar.Length; i++)
            {
                sayilar[i] = rnd.Next(50, 150);
                Console.Write("{0},",sayilar[i]);
            }
            Console.WriteLine(" ");//ilyas bozdemir
             Console.ReadKey();     
        }
        }
    }

