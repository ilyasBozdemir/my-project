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
            int a=0, b=1, c=2;
            int d = (a >= b - c) ? (a + b + c) : (a * b * c);
            Console.WriteLine(d);//ilyas Bozdemir
            Console.ReadLine();
            int a = 1, b = 3, c = 2;
            int d = (a >= b - c) ? (a + b + c) : (a * b * c);
            Console.WriteLine(d);
            Console.ReadLine();//ilyas Bozdemir
            int a = 5, b = 1, c = 2;
            int d = (a >= b - c) ? (a + b + c) : (a * b * c);
            Console.WriteLine(d);
            Console.ReadLine();//ilyas Bozdemir

        }
    }
}
