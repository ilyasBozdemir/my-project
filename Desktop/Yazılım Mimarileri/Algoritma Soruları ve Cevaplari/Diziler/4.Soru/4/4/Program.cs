using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _4
{
    class Program
    {
        static void Main(string[] args)
        {//ilyas bozdemir
            string[] gün = { "Haftanın 1.Günü", "Haftanın 2.Günü", "haftanın 3.Günü",
             "Haftanın 4.Günü", "Haftanın 5.Günü", "Haftanın 6.Günü",
         "Haftanın 7.Günü"};
            Console.Write("Gün Adı girin : ");
            string secim = Console.ReadLine();
            
            switch (secim)
            {//ilyas bozdemir
                case "Pazartesi": Console.WriteLine(gün[0]); break;
                case "Salı": Console.WriteLine(gün[1]); break;
                case "Carsamba": Console.WriteLine(gün[2]); break;
                case "Persembe": Console.WriteLine(gün[3]); break;
                case "Cuma": Console.WriteLine(gün[4]); break;
                case "Cumartesi": Console.WriteLine(gün[5]); break;
                case "Pazar": Console.WriteLine(gün[6]); break;
            }
            Console.ReadKey();
        }
    }
}
