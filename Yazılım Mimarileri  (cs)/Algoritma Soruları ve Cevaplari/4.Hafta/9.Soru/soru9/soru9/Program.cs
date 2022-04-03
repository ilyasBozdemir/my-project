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
   /*9.	Klavyeden girilen sayı kadar aşağıdaki şekil gibi 
             * ekrana yıldız yazan programı yapınız.
*
**
***
****
      */
            for (int i = 1; i <= 4; i++)
            {//ilyas bozdemir
                for (int j = 1; j <= i; j++)
                {
                    Console.Write("*");
                }

                Console.Write("\n");
            }//ilyas bozdemir
             Console.ReadLine();



        }
    }
}
