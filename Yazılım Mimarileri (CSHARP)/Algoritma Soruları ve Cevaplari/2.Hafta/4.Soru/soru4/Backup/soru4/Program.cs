using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Eski sistem pence değerini girin :");  //ilyas Bozdemir
            double pence = Convert.ToDouble(Console.ReadLine());
            Console.Write("Eski sistem shilling değerini girin :"); 
            double shilling = Convert.ToDouble(Console.ReadLine());
            Console.Write("Eski sistem pound değerini girin :");  //ilyas Bozdemir
            double pound = Convert.ToDouble(Console.ReadLine());
            double new_pence = (shilling * 12 + pence) * 5 / 12;
            Console.WriteLine("Yeni para birimine göre {0}",new_pence);
            Console.ReadLine();
        }
    }
}
