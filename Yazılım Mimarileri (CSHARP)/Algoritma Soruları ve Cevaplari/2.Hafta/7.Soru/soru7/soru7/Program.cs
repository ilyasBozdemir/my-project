using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru7
{
    class Program
    {         tekrar:
        static void Main(string[] args)
           
        {   Console.Write("Saat :"+" ");
            int Saat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Dakika :" + " ");
            int Dakika = Convert.ToInt32(Console.ReadLine());
            Console.Write("Saniye :");
            int Saniye = Convert.ToInt32(Console.ReadLine());
            if(Saniye>60)//ilyas Bozdemir
            {
                Console.WriteLine("Saniye 60'dan yukarı olmaz \n tekrar deneyin");
                  goto tekrar;
            }
            Console.WriteLine("Saat/Dakika/Saniye :"+Saat + ":" + Dakika + ":" + Saniye);//ilyas Bozdemir
            int toplam =(Saat*3600)+(Dakika*60)+Saniye;
            Console.Write("Toplam Süre :"+toplam);
            Console.ReadKey();//ilyas Bozdemir
        }
    }
}
