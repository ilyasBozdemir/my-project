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
            /*100 ila 500 arasındaki sayılardan(100 ve 500 dahil)
               *  3’e bölünen fakat 5’e bölünmeyen sayıları
               *  bulan ve ekranda gösteren kodları yazınız (while).
               */
            int i = 100;
            int say = 0;
            while (i < 500)
            {
                if (i % 3 == 0)//sayi 3'e tam bolunuyorsa
                {
                    if (i % 5 != 0)//fakat sayı 5'in katı değilse 
                    {
                        Console.WriteLine("i =>> {0}", i);//Consol'a Yazdır
                        say++;
                    }
                }
                i++;
            }
            Console.WriteLine("Toplamda {0} Tane Vardır.", say);
            Console.ReadLine();
        }
    }
}
