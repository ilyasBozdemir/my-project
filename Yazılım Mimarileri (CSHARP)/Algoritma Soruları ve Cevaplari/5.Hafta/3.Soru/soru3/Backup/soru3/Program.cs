using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kişi sayısını girin:");
            int kişi = Convert.ToInt32(Console.ReadLine());
            Console.Write("sandalye sayısını girin :");
            int sandalye = Convert.ToInt32(Console.ReadLine());
            int sonuc = 1;
            for (int i = 0; i < sandalye; i++)//ilyas bozdemir
            {
                sonuc = sonuc * kişi;
                kişi--;
            }
            //ilyas bozdemir
            Console.WriteLine(sonuc);
            Console.ReadLine();
        }
    }
}
