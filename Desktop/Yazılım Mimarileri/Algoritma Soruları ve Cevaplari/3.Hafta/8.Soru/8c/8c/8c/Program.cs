using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8c
{
    class Program
    {
        static void Main(string[] args)
        {
            //c.	0 ila 9 arasındaki sayıların küplerini gösteriniz(for).

            for (int t = 0; t <= 9; t++)
            {
                Console.Write("c.");
                Console.WriteLine(Math.Pow(t, 3));//math.pow üslü sayılar içindir.
            }//ilyas Bozdemir
            Console.ReadLine();
        }
    }
}
