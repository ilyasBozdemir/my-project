using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru8
{
    class Program
    {
        static void Main(string[] args)
        {

            int sayi;
            int yazilacak_rakam;//ilyas bozdemi
            Console.Write("Sayiyi giriniz : ");
            sayi = Convert.ToInt32(Console.ReadLine());
            Console.Write("Sayinin tersi : ");
            while (sayi > 10)
            {
                yazilacak_rakam = sayi % 10;
                Console.Write(yazilacak_rakam);
                sayi /= 10; //sayi=sayı/10
            }//ilyas bozdemi
            Console.WriteLine(sayi);
           Console.ReadKey();
            
        }
    }
}
