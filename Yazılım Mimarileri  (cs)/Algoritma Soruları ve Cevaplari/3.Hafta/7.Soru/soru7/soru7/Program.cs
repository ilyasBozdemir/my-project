using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru7
{
    class Program
    {
        static void Main(string[] args)
        {
  /* Harfle gösterilen not sistemine göre :
   A:100-90 
   B:89-80 
   C:79-70 
   D:69-60 
   E:59-50 
   F:50 ve altı,
   eğer 0 ila 100 arasında bir sayı girmezse “yanlış not girdiniz” diye bir uyarı ekrana getiren program,
   klavyeden girilen değere göre harf notunu ekranda göstersin(if deyimi- if else deyimi).*/

            Console.Write("1-100 Arası Not Giriniz :");

            int not = Convert.ToInt32(Console.ReadLine());
          if (not>=90&&not<=100)
	{
		 Console.WriteLine("not ve harfiniz :" + not + " A");
	}
          else if (not >= 80 && not < 89)//ilyas Bozdemir
          {
              Console.WriteLine("not ve harfiniz :" + not + " B");
          }
          else if (not >= 70 && not <=79)
          {
              Console.WriteLine("not ve harfiniz :" + not + " C");
          }
          else if (not >= 60 && not <= 69)
          {//ilyas Bozdemir
              Console.WriteLine("not ve harfiniz :" + not + " D");
          }
          else if (not >= 50 && not <= 59)
          {
              Console.WriteLine("not ve harfiniz :" + not + " E");
          }
          else if ( not < 50)
          {//ilyas Bozdemir
              Console.WriteLine("not ve harfiniz :" + not + " F");
          }
          else
          {
              Console.WriteLine("\a 1-100 Arası değer girin...");
          }

 
         Console.ReadLine();
          
            
           
         }     
    }
}
