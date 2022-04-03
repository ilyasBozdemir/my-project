using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tahminim = new int[22];
            for (int i = 0; i < tahminim.Length; i++)
            {
                Console.Write("{0}.Tahmini Girin :", i + 1);
                tahminim[i] = Convert.ToInt32(Console.ReadLine());     
            }
            int sayac = 0;
            int[] OnNumara = new int[22];
            Random rastgele = new Random();
            for (int i = 0; i < OnNumara.Length; i++)
            {
                OnNumara[i] = rastgele.Next(1, 80);
            }
            foreach (var sayı in OnNumara)
            {
                Console.WriteLine("{0} ",sayı);
                
            }
            Console.WriteLine("  ");

            for (int i = 0; i < tahminim.Length; i++)
            {
                for (int j = 0; j < tahminim.Length; j++)
                {
                    if (tahminim[j] == OnNumara[i])
                    {
                        sayac++;
                    }
                }
            }
            if (sayac == 6)
            {
                Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
            }
            else if (sayac == 7)
            {
                Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
            }
            else if (sayac == 8)
            {
                Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
            }
            else if (sayac == 9)
            {
                Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
            }
            else if (sayac == 10)
            {
                Console.WriteLine("Tebrikler {0} Bildiniz", sayac);
            }
            else
            {
                Console.WriteLine("Bilemediniz");
            }
            Console.ReadLine();

        }
    }
}
