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
           	/* Bir ürün için klavyeden girilen fiyat ve kdv değerlerine
             göre ürünün kdv’li fiyatını bulan programı yazınız.*/
            Console.Write("Fiyat giriniz :");
            double fiyat = Convert.ToDouble(Console.ReadLine());
            double kdvli = fiyat + (fiyat * 0.18);
            Console.Write("Kdvli fiyat :" + kdvli);//ilyas Bozdemir
            Console.ReadLine();



        }
    }
}
