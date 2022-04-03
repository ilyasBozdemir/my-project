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
            // 1.487 Amerikan Dolarına 
            //Fransız Frank’ı $0.172
            //Alman Mark’ı $0.584 
            //Japon Yen’i $0.00955 
            Console.Write("Dolar İçin Değer Giriniz :");
            double a = Convert.ToDouble(Console.ReadLine());//ilyas Bozdemir
            double dolar = 1.487, frank = 0.172, mark = 0.584, Yen = 0.00955;
            Console.WriteLine("ABD Doları :" + dolar * a);//ilyas Bozdemir
            Console.WriteLine("Fransız Frank’ı :" + frank * a);
            Console.WriteLine("Alman Mark’ı :" + mark * a);
            Console.WriteLine("Japon Yen’i :" + Yen * a);
            Console.ReadLine();
        }
    }
}
