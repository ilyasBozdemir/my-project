using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8d
{
    class Program
    {
        static void Main(string[] args)
        {
            //d.	0 ila 10 arasındaki sayıların toplamını bulunuz(while).
            int toplam = 0;
            int y = 0;//baslangıc 
            while (y <= 10)//bitiş 
            {
                Console.Write("d.");
                toplam = y + toplam;
                Console.WriteLine(toplam);
                y++;//artırma/(azaltma)
            }
            Console.ReadLine();//ilyas Bozdemir
        }
    }
}
