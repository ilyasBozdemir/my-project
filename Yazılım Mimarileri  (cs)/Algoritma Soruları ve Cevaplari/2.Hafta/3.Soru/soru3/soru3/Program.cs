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
            Console.Write("Celsius degeri girin :");
            double Celsius = Convert.ToDouble(Console.ReadLine());
            double Fahrenheit = Celsius * 9 / 5 + 32;//ilyas Bozdemir
            Console.WriteLine("Fahrenheit değeri :" + Fahrenheit);
            Console.ReadLine();
            //ilyas Bozdemir

        }
    }
}
