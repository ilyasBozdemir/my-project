using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru3
{
    class Program
    {
        static void Main(string[] args)
        { //Dört işlem hesap makinası yapan programı yazınız.(if deyimi)
            Console.Write("birinci sayıyı girin :");
            int a = Convert.ToInt32(Console.ReadLine());//ilyas Bozdemir
            Console.Write("İkinci sayıyı girin :");
            int b = Convert.ToInt32(Console.ReadLine());
            Console.Write("1.Toplama\n2.Cıkarma\n3.Carpma\n4.Bölme\nİşlemleri için seçim yapınız.");
            int secim = Convert.ToInt32(Console.ReadLine());
            int topla = a + b;
            int cıkar = a - b;//ilyas Bozdemir
            int carp = a * b;
            double bol = a / b;
            if (secim == 1)
            {
                Console.Write("Toplama :" + topla);
            }
            else if (secim == 2)
            {
                Console.Write("Çıkarma :" + cıkar);
            }
            else if (secim == 3)
            {
                Console.Write("Çarpma :" + carp);
            }
            else if (secim == 4)//ilyas Bozdemir
            {
                Console.Write("Bölme :" + bol);
            }
            else Console.WriteLine("\aListeden seçim yapın.!!!");
            Console.ReadLine();    
             
            

        }
    }        
               
            }

