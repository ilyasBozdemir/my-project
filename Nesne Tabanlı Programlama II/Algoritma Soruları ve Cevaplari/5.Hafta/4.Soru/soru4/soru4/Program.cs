using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru4
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            for (int a = 1; a <10; a++)
            {
                for (int b = 1; b < 10; b++)
                {
                    for (int c = 1; c < 10; c++)
                    {
                        int sayi = (a * 100) + (b * 10) + c;

                        if (sayi%10==9)
                        {
                            Console.WriteLine(sayi);//ilyas bozdemir
                            sayac++;
                            Console.WriteLine("Sayac :"+sayac);
                            Console.ReadLine();//ilyas bozdemir

                            //ilyas bozdemir
                        }

                       
                    } 
                }
            }
           
            
            
           
        }
    }  
}
