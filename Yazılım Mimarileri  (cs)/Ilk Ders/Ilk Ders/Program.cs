using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ilk_Ders
{
    class Program
    {
        static void Main(string[] args)//07.03.2017
        {
             // kürenin alanı ve hacmi
            double yukseklik, yaricap;
            const double PI = Math.PI;
            
            // Math.Sqrt sayının karekökünü verir.
            Console.Write("yukseklik girin : ");
            yukseklik = Convert.ToDouble(Console.ReadLine());
            Console.Write("yaricap girin : ");
            yaricap = Convert.ToDouble(Console.ReadLine());
            double kok = Math.Sqrt((yukseklik * yukseklik) + (yaricap * yaricap));

            Console.WriteLine("koninin alanı: " + yaricap * PI * (kok + yaricap));
            Console.WriteLine("koninin hacmi: " + (1/3)*PI * (yaricap * yaricap ));
            Console.ReadKey();
            
        }
    }
}
