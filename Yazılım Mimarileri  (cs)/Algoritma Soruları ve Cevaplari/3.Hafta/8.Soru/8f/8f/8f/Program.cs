using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8f
{
    class Program
    {
        static void Main(string[] args)
        {
            ///f.	0 ila 100 arasındaki sayılardan 10 ve 10’un 
            ///katlarında ekrana “BOM” yazdıran programı yazınız(for-while).
            for (int x = 0; x < 101; x++)
            {
                Console.Write("f.");
                Console.WriteLine(x);
                if (x % 10 == 9)
                {
                    Console.WriteLine("BOM!!!");
                    //ilyas Bozdemir
                }
            }
            Console.ReadLine();
        }
    }
}
