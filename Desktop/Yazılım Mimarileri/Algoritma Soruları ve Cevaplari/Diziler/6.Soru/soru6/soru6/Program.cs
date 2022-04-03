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
            int[] sayı = new int[10];
            int rastsayı;
            Random rastgele = new Random();//rasgele nesnesi olusturduk
            for (int i = 0; i < sayı.Length; i++)
            {
                rastsayı = rastgele.Next(1, 50); //nesneye 1-50 arası değer verdik
                sayı[i] = rastsayı;//değerleri diziye atadık
            }
            for (int i = 0; i < sayı.Length; i++)
            {//ilyas bozdemir
                Console.WriteLine(sayı[i]);//diziyi ekrana yazdırdık.
                //ilyas Bozdemir
            }//sayılar tekrar ediyo burda ama sro oyle istemiyo

            Console.ReadKey();
        }
    }
}
