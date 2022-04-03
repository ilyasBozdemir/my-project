using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru6
{
    class Program
    {
        static void Main(string[] args)
        {
            /*6.	1’den 50’ye kadar sayılardan çift sayıların karelerini 
          * tek sayıların küplerini alıp 
          * ekrana yazdıran programı  yapınız (Math.Pow ile yapılacak). */
            
            for (int i = 1; i <= 50; i++)
            {
                if (i % 2 == 0)
                {//ilyas bozdemir
                    Console.WriteLine("çift :" + Math.Pow(i, 2));
                }
                else
                {
                    Console.WriteLine("tek :" + Math.Pow(i, 3));
                }
            }//ilyas bozdemir
            Console.ReadLine();
        }
    }
}
