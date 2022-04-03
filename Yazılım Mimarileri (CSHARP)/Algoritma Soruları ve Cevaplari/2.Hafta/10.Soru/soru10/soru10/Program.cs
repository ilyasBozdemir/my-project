using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru10
{
    class Program
    {
        static void Main(string[] args)
        {   
           /* Kullanıcıdan iki adet kesirli sayı girmesini isteyen  ve bu 
           sayıların toplamını kesirli biçimde görüntüleyen bir program yazın.*/
            //not:10.	Eğer Paydaları eşit olmayan iki adet kesirli sayı olcak.
            double a, b, c, d;
            Console.WriteLine("a/b + c/d şeklinde sırasıyla değer girin ");
            Console.Write("a değerini girin :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b değerini girin :");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c değerini girin :");
            c = Convert.ToDouble(Console.ReadLine());
            Console.Write("d değerini girin :");
            d = Convert.ToDouble(Console.ReadLine());//ilyas Bozdemir
            Console.WriteLine();
            Console.WriteLine("kesirli hali :"+a+"/"+b+" "+"+"+" "+c+"*"+d);
            Console.WriteLine("Sonuc için Enter'a tusa basın...");
            Console.ReadLine();
            double sonuc = ((a * d) + (b * c)) / (b * d);//ilyas Bozdemir
            Console.WriteLine("sonuc :" + sonuc);
            Console.ReadLine();
        }
    }
}
