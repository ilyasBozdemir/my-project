using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru7
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int a = 1; a < 10; a++)
            {
                for (int b = 1; b < 10; b++)
                {//ilyas bozdemir
                    Console.Write("{0}*{1}={2}\t", a, b ,(a*b));
                }
                Console.WriteLine();
            }//ilyas bozdemir
         Console.WriteLine();
         Console.ReadKey(); 
 

        }
    }
}
