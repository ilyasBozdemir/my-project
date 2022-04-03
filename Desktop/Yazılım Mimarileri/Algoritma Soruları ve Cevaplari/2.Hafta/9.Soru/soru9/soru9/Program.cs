using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru9
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            //Kullanıcıdan iki adet kesirli sayı girmesini isteyen ve bu
            //sayıların toplamını kesirli biçimde görüntüleyen bir program yazın.
            //not :paydaları eşit olacak.
            Console.WriteLine("a/c + b/c seklinde olacak sekilde kesirli sayı girin");
            Console.Write("a sayısını girin :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("b sayısını girin :");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("c sayısını girin :");
            c = Convert.ToDouble(Console.ReadLine());//ilyas Bozdemir
            double sonuc = (a/c)+(b/c);
            Console.WriteLine("sonuc :"+a+"/"+c+"+"+b+"/"+c);
            Console.WriteLine("sadeleştirmeyi görmek için herhangi bir tusa basın...");
            Console.ReadLine();
            Console.WriteLine("sadeleştirme :" + (a + b) + "/" + c);//ilyas Bozdemir
            Console.ReadLine();
            Console.WriteLine("sonucu  görmek için herhangi bir tusa basın...");
            Console.WriteLine("sonuc :" + (a + b) / c);
            Console.ReadLine();
            



        }
    }
}
