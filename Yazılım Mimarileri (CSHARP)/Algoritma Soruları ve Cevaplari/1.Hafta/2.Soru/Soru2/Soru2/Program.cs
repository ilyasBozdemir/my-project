using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Soru2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            double a;
            Console.Write("Bir sayı giriniz :");
            a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Girilen Sayının Karesi:" + Math.Pow(a, 2));
            Console.WriteLine("Girilen Sayının Küpü:" + Math.Pow(a, 3));
            Console.WriteLine("Girilen Sayının Karekökü :" + Math.Sqrt(a));
            Console.WriteLine("Devam etmek için herhangi bir tusa basın ...");
            Console.ReadKey();//ilyas Bozdemir
            //cemberin çevresi 

            Console.Write("Cemberin yarıcapını giriniz:");
            double r = Convert.ToDouble(Console.ReadLine());
            r = 2 * Math.PI * r;//ilyas Bozdemir
            Console.WriteLine("Cemberin çevresi :"+r);
            Console.WriteLine("Devam etmek için herhangi bir tusa basın ...");
            Console.ReadKey();
            //dairenin alanı

            Console.Write("Dairenin yarıcapını giriniz:");
            double alan = Convert.ToDouble(Console.ReadLine());
            double r2 = Math.PI * Math.Pow(r2, r2);
            Console.WriteLine("Dairein alanı :"+r2);
            Console.WriteLine("Devam etmek için herhangi bir tusa basın ...");
            Console.ReadKey();
            //silindirin alan hacmi

            Console.Write("Silindirin yarıcapını giriniz:");
            double r3 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Silindirin yüksekliğini giriniz:");
            double h = Convert.ToDouble(Console.ReadLine());
            double alann = 2 * Math.PI*(r3 + h);
            double hacim = Math.PI * r3 * r3 * h;
            Console.WriteLine("Silindirin alanı :" + alann);
            Console.WriteLine("Silindirin hacmi :" + hacim);
            Console.WriteLine("Devam etmek için herhangi bir tusa basın ...");
            Console.ReadKey();  
            // iki sayıdan büyük olanı yazdırma

            Console.Write("Birinci sayı giriniz:");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayı giriniz:");
            int y = Convert.ToInt32(Console.ReadLine());
            if (x > y)
            {
                Console.WriteLine(x);
            }
            else
                Console.WriteLine(y);
            // iki sayıdan küçük olanı yazdırma
            int s = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayı giriniz:");
            int d = Convert.ToInt32(Console.ReadLine());
            if (s < d)
            {
                Console.WriteLine(s);
            }
            else
                Console.WriteLine(d);
            
            
            
            
           
            
        }
    }
}
