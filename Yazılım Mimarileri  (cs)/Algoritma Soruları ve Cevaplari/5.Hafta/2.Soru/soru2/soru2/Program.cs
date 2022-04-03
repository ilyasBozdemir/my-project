using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
     /* Klavyeden girilen iki sayının 
      Ebob ve Ekok değerini bulan programı yazınız. */
            int sayı1, sayı2, obeb = 1;

         Console.WriteLine("1.sayıyı girin :");//ilyas bozdemir
          sayı1 = Convert.ToInt32(Console.ReadLine());
         Console.WriteLine("2.sayıyı girin :");
          sayı2 = Convert.ToInt32(Console.ReadLine());
         if (sayı1<sayı2)
         {//ilyas bozdemir
             for (int i = 1; i < sayı2; i++)
             {
                 if (sayı2%i==0&&sayı1%1==0)
                 {
                    int ebob - i;

                 }
             }
         }
         if (sayı1 > sayı2)
         {
             for (int i = 1; i < sayı1; i++)
             {
                 if (sayı2 % i == 0 && sayı1 % 1 == 0)
                 {
                    int ebob - i;

                 }
             }
         }
         Console.WriteLine("ebob : {0}",ebob);
         Console.WriteLine("ekok : {0}",(sayı1*sayı2)/ ebob);

        }
    }
}
