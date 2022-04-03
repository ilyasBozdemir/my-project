using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_a
{
    class Program
    {
        static void Main(string[] args)
        {
          	int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
            foreach (var sayı in sayilar)
            {
                if (sayı % 3 == 0)//ilyas bozdemir
                {
                    Console.WriteLine(sayı); 
                }
             }
            Console.ReadKey();
        }
    }
}
