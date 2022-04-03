using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _15
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] Dizi = { "Ahmet", "Hayri", "Recep", "Hüseyin", "Seda" };
            Array.Reverse(Dizi);
            foreach (var değer in Dizi)
            {//ilyas bozdemir
                Console.WriteLine(değer);
            }
            Console.ReadKey();
        }
    }
}
