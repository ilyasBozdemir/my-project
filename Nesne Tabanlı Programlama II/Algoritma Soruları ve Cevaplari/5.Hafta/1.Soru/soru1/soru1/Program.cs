using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
   /*1.	Klavyeden girilen sayının asal olup olmadığını 
    * bulan programı yazınız. NOT: Bir ve kendisinden 
    * başka böleni olmayan sayılara asal sayı denir. (Örnek 11,13,7….) */
            Console.Write("Sayı Girin :");
            int sayı = Convert.ToInt32(Console.ReadLine());
            if (sayı/1==sayı ||sayı/sayı==1)
            {
                Console.Write("Sayı Asal Sayı Değildir:");
            }
            else//ilyas bozdemir
	{
        Console.Write("Sayı Asal Sayıdır:");   //ilyas bozdemir       
	}
            Console.ReadLine();//ilyas bozdemir
        }
    }
}
