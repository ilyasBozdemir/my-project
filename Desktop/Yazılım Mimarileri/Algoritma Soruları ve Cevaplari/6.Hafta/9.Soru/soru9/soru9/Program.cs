using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru9
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("kişi sayısı girin :");
            int kişi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            int i ;
            for (i =1; i <= kişi; i++)
            {
               toplam = toplam + i;
            }
            Console.WriteLine(" ");
            Console.WriteLine(toplam);
            //ilyas Bozdemir
            Console.ReadLine();
        }
    }
}
