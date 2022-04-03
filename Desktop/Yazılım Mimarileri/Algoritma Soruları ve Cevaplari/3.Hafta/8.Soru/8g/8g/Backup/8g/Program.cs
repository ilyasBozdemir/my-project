using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _8g
{
    class Program
    {
        static void Main(string[] args)
        {
   /*g.	100 ila 500 arasındaki sayılardan(100 ve 500 dahil) 3’e bölünen fakat 
   5’e bölünmeyen sayıları bulan ve ekranda gösteren kodları yazınız (while).*/
            
            int i = 100;
            while (i < 501)
          {
              if (i % 3 == 0)//ilyas Bozdemir
	          {
                    if (  i%5!=0)
	{
		 Console.WriteLine(i); 
	}

                  //ilyas Bozdemir
	          }
                i++;
                
          } 
            Console.ReadLine();
                
             }
        }
    }
