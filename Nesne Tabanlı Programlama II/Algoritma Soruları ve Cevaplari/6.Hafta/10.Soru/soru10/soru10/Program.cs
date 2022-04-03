using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x gün sonraki nöbet :");
            int x_gün_sonra = Convert.ToInt32(Console.ReadLine());
            int nöbet = x_gün_sonra % 6;//en buyuk 5 oldugu için 6
            switch (nöbet)
            {
                case 1: Console.WriteLine("Salı"); break;
                case 2: Console.WriteLine("Cuma"); break;
                case 3: Console.WriteLine("Pazartesi"); break;
                case 4: Console.WriteLine("Çarşamba"); break;
                case 5: Console.WriteLine("Cumartesi"); break;
            }
            Console.ReadLine();//ilyas bozdemir
               
                    
            
            
        }
    }
}
