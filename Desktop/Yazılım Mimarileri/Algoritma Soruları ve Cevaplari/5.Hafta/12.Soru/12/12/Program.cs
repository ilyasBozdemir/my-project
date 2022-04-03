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
            int sayı = Convert.ToInt32(Console.ReadLine());
            int sonuc = sayı % 8;
            switch (sonuc)
            {//ilyas bozdemir
                case 1: Console.Write("A"); break;
                case 2: Console.Write("B"); break;
                case 3: Console.Write("C"); break;
                case 4: Console.Write("D"); break;
                case 5: Console.Write("E"); break;
                case 6: Console.Write("D"); break;
                case 7: Console.Write("C"); break;
            }//ilyas bozdemir
                    Console.ReadLine();
          
            
        }
    }
}
