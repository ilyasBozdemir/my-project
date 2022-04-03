using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8b
{
    class Program
    {
        static void Main(string[] args)
        {
            //b.	0 ila 14 arasındaki sayıların karelerini gösteriniz(while).
            int a = 0;
            while (a < 15)
            {
                a++;
                Console.Write("b. ");
                Console.WriteLine(a * a);
            }
            //ilyas Bozdemir
            Console.ReadLine();
        }
    }
}
