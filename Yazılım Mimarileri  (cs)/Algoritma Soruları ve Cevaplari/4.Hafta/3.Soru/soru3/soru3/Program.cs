using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        {
/*3.	Klavyeden girilen değerler ile alan hesaplamaları yaparak
 * aşağıdaki menü seçeneklerini gerçekleştiren projeyi oluşturunuz.
******ALAN HESAPLARI******
•	Dikdörtgen
•	Üçgen
•	Daire
•	Programdan çıkış */
       Console.WriteLine("//Dikdörtgen// ");
       Console.Write("a kenarını girin :");
       int dik_a = Convert.ToInt32(Console.ReadLine());
       Console.Write("b kenarını girin :");
       int dik_b = Convert.ToInt32(Console.ReadLine());
       int dik_alan =dik_a*dik_b;
       Console.WriteLine("dikdörtgenin alanı :"+dik_alan);
       Console.Write("üçgen için enter'a basın...");
       Console.ReadLine();
       Console.WriteLine("//Üçgen// ");
       Console.WriteLine("a kenarını girin :");//ilyas bozdemir
       int üçgen_a = Convert.ToInt32(Console.ReadLine());
       Console.WriteLine("yükseklik girin :");
       int üçgen_h = Convert.ToInt32(Console.ReadLine());
       int üçgen_alan = (üçgen_a * üçgen_h) / 2;
       Console.WriteLine("Üçgenin alanı :" + üçgen_alan);
       Console.Write("daire için enter'a basın...");
       Console.ReadLine();
       Console.WriteLine("//Daire// ");//ilyas bozdemir
       Console.WriteLine("r yarıcapı girin :");
       int r = Convert.ToInt32(Console.ReadLine());
       double daire_alan = Math.PI * Math.Pow(r, 2); 
       Console.WriteLine("Dairenin Alanı :"+daire_alan);
       Console.ReadLine();



        }
    }
}
