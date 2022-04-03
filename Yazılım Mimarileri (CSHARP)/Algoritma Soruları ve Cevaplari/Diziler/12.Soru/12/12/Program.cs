using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Sayı Gir :");
            int sayı = Convert.ToInt32(Console.ReadLine());
            int[] tekdizi = new int[(sayı + 1) / 2];
            int[] çiftdizi = new int[(sayı + 1) / 2];
            int teksay = 0, çiftsay = 0;

            for (int i = 0; i < sayı; i++)
            {
                if (i % 2 == 0)
                    çiftdizi[çiftsay++] = i;
                else
                    tekdizi[teksay++] = i;
            }
            Console.Write("Çift Sayılar");
            Console.WriteLine(" ");
            foreach (var çift in çiftdizi)
            {
                Console.Write("{0} ,", çift);
            }
            Console.WriteLine(" ");
            Console.WriteLine("Tek Sayılar");

            foreach (var tek in tekdizi)
            {
                Console.Write("{0} ,", tek);
            }
            Console.ReadLine();
        }
    }
}
    

