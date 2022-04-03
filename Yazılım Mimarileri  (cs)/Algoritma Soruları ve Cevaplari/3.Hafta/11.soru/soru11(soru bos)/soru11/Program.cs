using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru11
{
    class Program
    {
        static void Main(string[] args)
        {
            basla: Console.Write("1-5 Arası Not Giriniz :");
            int not = Convert.ToInt32(Console.ReadLine());
            do
            { switch (not)//ilyas Bozdemir
                case 1: Console.WriteLine("Seciminiz :" + not + " Pekiyi"); break;
                case 2: Console.WriteLine("Seciminiz :" + not + " İyi"); break;
                case 3: Console.WriteLine("Seciminiz :" + not + " Orta"); break;
                case 4: Console.WriteLine("Seciminiz :" + not + " Geçer"); break;
                case 5: Console.WriteLine("Seciminiz :" + not + " Kalır"); break;
                default: Console.WriteLine("lutfen 1-5 arası değer girin"); break;
            } goto basla;
                //ilyas Bozdemir
            } while (true); 
            {
               
            Console.ReadLine();

        }
    }
}
