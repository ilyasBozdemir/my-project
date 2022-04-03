using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Ödev
{ class Program
    {
        static void Main(string[] args)
        {   //Küre alan ve hacmi
            int hacim, alan, r, hacim2, alan2, r2, h;
            Console.WriteLine("Küre Yarıçap Girin :");
            r = Convert.ToInt32(Console.ReadLine());
            hacim = Convert.ToInt32((4 * Math.PI * Math.Pow(r, 3) / 3));
            alan = Convert.ToInt32(4 * Math.PI * Math.Pow(r, 2));
            Console.WriteLine("Kürenin Hacmi :" + hacim + " " + "cm3");
            Console.WriteLine("Kürenin Alanı :" + alan + " " + "cm2");
            Console.ReadLine();
            //koninin alan ve hacmi
            // yarıçap için r2 yükseklik için h ,
            // alan için alan2 hacim için hacim2 şeklinde tanımlayalım.
            // koklu ifade için kok değişkeni atayalım.

            Console.WriteLine("Koni Yarıçap Girin :");
            r2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Koni Yükseklik Girin :");
            h = Convert.ToInt32(Console.ReadLine());
            hacim2 = Convert.ToInt32((Math.PI * Math.Pow(r2, 2) / 3));
            double kok = Math.Sqrt(r2 * r2) + (h * h);
            alan2 = Convert.ToInt32(Math.PI * r2 * kok);
            Console.WriteLine("Koninin Hacmi :" + hacim2 + " " + "cm3");
            Console.WriteLine("Koninin Alanı :" + alan2 + " " + "cm2");
            Console.WriteLine("Programdan Çıkmak İçin Enter'a Basın ... ");
            Console.ReadLine();
        }
    }
}
       

            
            
           

           
            



       
