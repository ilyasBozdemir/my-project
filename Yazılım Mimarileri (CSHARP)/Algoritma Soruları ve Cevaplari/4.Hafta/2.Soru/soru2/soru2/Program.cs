using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
    /*Girilen hava sıcaklığına göre, yapılması önerilen 
    * faaliyeti ekrana yazdıran programı yazınız.
•	30 dereceden yüksek ise YÜZME
•	20 dereceden yüksek ise TENİS
•	10 dereceden yüksek ise GOLF
•	0 dereceden yüksek ise SİNEMA
•	0 dereceden düşük ise KAYAK
 */
     Console.Write("Sıcaklık değeri Girin :");
     int sıcaklık =Convert.ToInt32(Console.ReadLine());
     if (sıcaklık>30)
     {
         Console.WriteLine("YÜZME");
      }
         else if (sıcaklık >20 &&sıcaklık <30)
         {
             Console.WriteLine("TENİS");
         } 
          else  if (sıcaklık >10 &&sıcaklık <20)
         {
             Console.WriteLine("GOLF");//ilyas bozdemir
         }
         else if (sıcaklık >0 &&sıcaklık <10)
            {
                Console.WriteLine("SİNEMA");
            }
           else 
            {
                Console.WriteLine("KAYAK");
            }
            Console.ReadLine();//ilyas bozdemir

     }
     



        }
    }
}
