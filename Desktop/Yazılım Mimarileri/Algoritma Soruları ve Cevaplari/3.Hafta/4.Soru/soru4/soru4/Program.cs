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
               // Klavyeden girilen numara ile bölüm adını
              //yazan programı yazınız(switch-case deyimi).
            Console.WriteLine("Bölüm Seçimi yapın: \n1.Bilgisayar Programcılıgı\n2.Saglık Yönetimi"+
           " \n3.Elektrik elektronik\n4.Muhasebe\n5.işletme");
            Console.Write("Bölüm İçin Seçim yapın  :");
            
            int bolum = Convert.ToInt32(Console.ReadLine());
            switch (bolum)//ilyas Bozdemir
            { 
            case 1:Console.WriteLine("Seçiminiz :"+"Bilgisayar Programcılıgı "); break;
            case 2: Console.WriteLine("Seçiminiz :" + "Saglık Yönetimi"); break;
            case 3: Console.WriteLine("Seçiminiz :" + "Elektrik elektronik"); break;
            case 4: Console.WriteLine("Seçiminiz :" + "Muhasebe"); break;
            case 5: Console.WriteLine("Seçiminiz :" + "işletme "); break;//ilyas Bozdemir
            default: Console.WriteLine("\a 1-5 arası değer girin !!! "); break;
            }
             Console.ReadLine();
}
               
       }
}
                 
            
            

        
