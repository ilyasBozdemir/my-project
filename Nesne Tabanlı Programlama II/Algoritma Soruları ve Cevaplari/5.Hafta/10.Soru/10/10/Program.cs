using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("girilen gün sayısı sonra :");
            int gün = Convert.ToInt32(Console.ReadLine());
            int sonuc = gün % 7;
            switch (sonuc)
            {//ilyas bozdemir
                case 0: Console.Write("Persembe"); break;
                case 1: Console.Write("Cuma"); break;
                case 2: Console.Write("Cumartesi"); break;
                case 3: Console.Write("Pazar"); break;
                case 4: Console.Write("Pazartesi"); break;
                case 5: Console.Write("Salı"); break;
                case 6: Console.Write("Carsamba"); break;
            }//ilyas bozdemir
            Console.ReadLine();     
            
        }
    }
}
