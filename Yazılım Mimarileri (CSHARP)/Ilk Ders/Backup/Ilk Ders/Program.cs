using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Ilk_Ders
{
    class Program
    {
        static void Main(string[] args)
        {
             // kürenin alanı ve hacmi
            double yukseklik, yaricap;
            const double PI = 3.14;
            double kok = Math.Sqrt((h * h) + (r * r));
            // Math.Sqrt sayının karekökünü verir.
            Console.WriteLine("yukseklik girin :");
            yukseklik = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("yaricap girin :");

            yaricap = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("koninin alanı: "+ yaricap * PI *(kok+yaricap);
            Console.WriteLine("koninin hacmi: " +(1/3)PI * yaricap * yaricap * yukseklik );
            Console.ReadKey();
            
        }
    }
}
