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
            int x = 5, y = 8;
            Console.WriteLine("x = {0}", x);
            Console.WriteLine("{0} + {0} = {1}", x, (x + x));
            Console.Write("x =");//ilyas Bozdemir
            Console.WriteLine("{0} = {1}", (x + y), (y + x));
            Console.ReadLine();//ilyas Bozdemir

        }
    }
}
