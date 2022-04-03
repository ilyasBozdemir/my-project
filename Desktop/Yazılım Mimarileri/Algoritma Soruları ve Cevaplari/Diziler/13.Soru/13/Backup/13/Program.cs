using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _13
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayılar = { -23, -41, -82, -73, -44, 0, 56, 23, 78, 45 };
            int pozsay = 0, negsay = 0, say = 0;
            foreach (var sayı in sayılar)
            {
                if (sayı>0&&sayı!=0)
                {//ilyas bozdemir
                    pozsay++;
                }
                else if (sayı<0&&sayı!=0)
                {
                    negsay++;
                }
            }
            say = (sayılar.Length ) - (negsay + pozsay);
            Console.WriteLine("Dizimizde {0} tane  pozitif sayı vardır",pozsay);
            Console.WriteLine("Dizimizde {0} tane  negatif sayı vardır",negsay);
            Console.WriteLine("Dizimizde {0} tane  sıfır sayı vardır", say);
            Console.ReadLine();
        }//ilyas bozdemir

    }
}
