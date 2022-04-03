using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_e
{
    class Program
    {
        static void Main(string[] args)
        {
           	int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
            int mak = 0;
            for (int i = 1; i < sayilar.Length; i++)
            {

                if (mak > sayilar[i])
                {//ilyas bozdemir
                    mak = sayilar[i];
                }
            }
            //ilyas bozdemir
            Console.WriteLine("Dizi içindeki en büyük sayı: > > > " + mak);
            
            Console.ReadKey();
        }
    }
}
