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
            Console.Write("Sayı Girin :");  
         int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i = 1; i <= sayi / 2; i++)
            {

                if (sayi % i == 0)//ilyas bozdemir
                {
                    toplam = toplam + i;
                }
            }
            if (sayi == toplam)
            {
                Console.WriteLine("Girdiğiniz Sayı Bir Mükemmel Sayıdır");
            }
            else//ilyas bozdemir
            {
                Console.WriteLine("Girdiğiniz Sayı Bir Mükemmel Sayı Değildir");
            }
            Console.ReadLine();
           
         
        }
    }
}
