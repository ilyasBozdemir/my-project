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
            Console.Write("kitap_sayısı girin :"); 
            int kitap_sayısı = Convert.ToInt32(Console.ReadLine());
            Console.Write("gecikme_gün girin :");
            int gecikme_gün = Convert.ToInt32(Console.ReadLine());
            Console.Write("gecikme_tutarı girin :");
            int gecikme_tutarı = Convert.ToInt32(Console.ReadLine());
            double ilk = (kitap_sayısı * gecikme_tutarı);// ilk bes
            double orta = (ilk * 0.10);// 6-10
            double son = (orta * 0.25);//+10
            //ilyas bozdemir
            Console.ReadLine();

        }
    }
}
