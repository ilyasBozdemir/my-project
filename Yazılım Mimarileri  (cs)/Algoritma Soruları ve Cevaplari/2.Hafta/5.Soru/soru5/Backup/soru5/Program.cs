using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Yeni  sistem pence değerini girin :");  //ilyas Bozdemir
            double pence = Convert.ToDouble(Console.ReadLine());
            Console.Write("Yeni  sistem pound değerini girin :");  
            double pound = Convert.ToDouble(Console.ReadLine());
            double shilling = (pence * 12 / 5) / 12;//ilyas Bozdemir
            Console.Write("Eski para birimine göre £{0}.{1}:",pound,shilling);
            Console.ReadLine();
        }
    }
}
