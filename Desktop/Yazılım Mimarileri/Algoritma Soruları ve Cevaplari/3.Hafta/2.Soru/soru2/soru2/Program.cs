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
            // Dört işlem hesap makinası yapan 
           // programı yazınız.(switch-case)
            Console.Write("birinci sayıyı girin :");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.Write("İkinci sayıyı girin :");//ilyas Bozdemir
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("1.Toplama\n2.Cıkarma\n3.Carpma\n4.Bölme\nİşlemleri için seçim yapınız."); 
            int secim = Convert.ToInt32(Console.ReadLine());
            int topla = a + b;
            int cıkar = a - b;
            int carp = a * b;
            double bol = a / b;//ilyas Bozdemir
           switch (secim)
           { case 1: Console.Write("Toplama :"+topla);break;
             case 2: Console.Write("Çıkarma :"+cıkar ); break;
             case 3: Console.Write("Çarpma :"+carp); break;
             case 4: Console.Write("Bölme :" + bol); break;//ilyas Bozdemir
             default: Console.Write("listeden değer seçiniz!!!"); break;
             }
              Console.ReadLine(); 
            
            
        }
    }
}
