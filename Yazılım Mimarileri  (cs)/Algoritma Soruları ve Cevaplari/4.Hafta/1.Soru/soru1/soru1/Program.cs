using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
      /*1.	Klavyeden girilen değerler ile üniversite öğrencisinin
        * Türkçe dersinden ortalamasını hesaplayan ve ekrana geçip
      * kaldığını yazan programı koşul ifadeleri kullanarak 
       * yapınız, geçme notu 70’dir. ( Vize1 %20 + Vize2%20 + Final%60) */
            int vize1, vize2, final;
            Console.Write("vize1 değer girin :");
            vize1 = Convert.ToInt32(Console.ReadLine()); //ilyas bozdemir
            Console.Write("vize2 değer girin :");
            vize2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("final değer girin :");
            final = Convert.ToInt32(Console.ReadLine());
           double  sonuc = (vize1*0.20)+(vize2*0.20)+(final*0.60);
            if (sonuc > 70)
                
            {
             Console.WriteLine(sonuc+"= Geçti");
            }
            else
            {
              Console.WriteLine(sonuc+"= Kaldı");    
            }
            Console.ReadKey();

        }
    }
}
