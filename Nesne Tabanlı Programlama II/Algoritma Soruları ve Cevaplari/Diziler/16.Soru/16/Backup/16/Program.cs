using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ahmet", "ilyas", "Recep", "Hüseyin", "Seda",
            "Mehmet","Ali","Veli","Saban","Hayri"};
            Console.WriteLine("Aranan Kelime Dizimizde {0}. indistedir.",Array.IndexOf(isimler, "ilyas"));
            Console.ReadKey();//ilyas bozdemir
        }
    }
}
