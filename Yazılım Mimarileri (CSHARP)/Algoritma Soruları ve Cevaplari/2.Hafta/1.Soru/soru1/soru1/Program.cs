using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("vize notu girin :");
            double vize1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("vize2 notunu girin :");//ilyas Bozdemir
            double vize2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("final notunu girin :");
            double final = Convert.ToInt32(Console.ReadLine());
            double ort = ort = (vize1 * 0.2 + vize2 * 0.2 + final * 0.6);
            //ilyas Bozdemir
            Console.WriteLine("Durum :"+ort>70?"Geçti":"Kaldı");
            
            Console.ReadLine(); // sor hocaya


        }
    }
}
