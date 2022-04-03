using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = new int[50];

            for (int i = 0; i < 50; i++)//ilyas bozdemir
			{
                if (i%5==0)//sart koyma 5 ve 5in katları
                {
                    dizi[i] = i;//i'yi diziye atadık
                    Console.WriteLine(dizi[i]);//diziyi yazdırdık ekrana 
                }
                //ilyas bozdemir
			} 
            Console.ReadKey();
        }
    }
}
