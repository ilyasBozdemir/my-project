using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru5
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.WriteLine("Bölüm Seçimi yapın: \n1.Bilgisayar Programcılıgı\n2.Saglık Yönetimi"+
           " \n3.Elektrik elektronik\n4.Muhasebe\n5.işletme");
            Console.Write("Bölüm İçin Seçim yapın  :");
            
            int bolum = Convert.ToInt32(Console.ReadLine());
           if (bolum==1)
	{
		 Console.WriteLine("Seçiminiz :"+"Bilgisayar Programcılıgı ");
	}
           else if (bolum == 2)//ilyas Bozdemir
	{
		 Console.WriteLine("Seçiminiz :" + "Saglık Yönetimi");
	}   
             else if (bolum==3)
	{
		 Console.WriteLine("Seçiminiz :" + "Elektrik elektronik");
	}
           else if (bolum == 4//ilyas Bozdemir
               )
	{
		 Console.WriteLine("Seçiminiz :" + "Muhasebe");
	} 
             else if (bolum==5)
	{
		 Console.WriteLine("Seçiminiz :" + "işletme ");
	} 
           else
              
	{
           Console.WriteLine("\a 1-5 arası değer girin !!! ");   
	}
           
             Console.ReadLine();
}
        }
    }

