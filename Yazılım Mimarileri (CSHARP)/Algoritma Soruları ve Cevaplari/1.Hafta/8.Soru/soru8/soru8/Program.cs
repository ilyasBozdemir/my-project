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
            Console.Write("1.Sayıyı Girin :");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.Write("2.Sayıyı Girin :");
            double b = Convert.ToDouble(Console.ReadLine());
            double topla = a + b;//ilyas Bozdemir
            double cıkarma = a - b;
            double carpma = a * b;//ilyas Bozdemir
            double bolme = a / b;
            Console.WriteLine("Toplama Sonucu :" + topla);
            Console.WriteLine("Çıkarma Sonucu :" + cıkarma);
            Console.WriteLine("Çarpma Sonucu :" + carpma);
            Console.WriteLine("Bölme Sonucu :" + bolme);
            Console.ReadLine();//ilyas Bozdemir

        }
    }
}
