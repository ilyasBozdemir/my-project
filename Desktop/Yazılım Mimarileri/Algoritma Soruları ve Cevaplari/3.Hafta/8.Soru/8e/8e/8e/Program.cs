using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8e
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  e.	1 ila 100 arasındaki sayılardan 5’e bölümünde kalan 1 olan
    * sayıları ekrana yazdır(for).*/
            for (int b = 0; b < 101; b++)
            {

                if (b % 5 == 1)
                {
                    Console.WriteLine(b);
                    Console.Write("e.");
                }
            }//ilyas Bozdemir
            Console.ReadLine();
        }
    }
}
