using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru10
{
    class Program
    {
        static void Main(string[] args)
        {
   /* 10.	3 basamaklı sayılardan 10 un katlarını 
   * do-while ile ekrana yazdıran programı yapınız.*/

            int i=0;
            do//ilyas Bozdemir
            {
                if (i%10==0)
                {
                    Console.WriteLine(i);

                } //ilyas Bozdemir
                i++;
                
            } while (i<1000);
           
            Console.ReadKey();
        }
    }
}
