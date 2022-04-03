using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden girilen iki sayıdan büyük olanı ekrana 
            //yazdıran programı yapınız(if deyimi ile)
            Console.Write("birinci sayıyı girin :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin :");
            int b = Convert.ToInt32(Console.ReadLine());
            if (a > b)//ilyas Bozdemir
            {
                Console.WriteLine("Büyük Olan Sayı :" + a);
            }
            else//ilyas Bozdemir
                Console.WriteLine("Büyük Olan Sayı :" + b);
            Console.ReadLine();
        }
    }
}
