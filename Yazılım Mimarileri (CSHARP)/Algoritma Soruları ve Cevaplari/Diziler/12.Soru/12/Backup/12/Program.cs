using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _12
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            int[] tekDizi =new int [20];
            int[] ciftDizi = new int[20];
            int tekSayac = 0, ciftSayac = 0;
            Console.WriteLine("Sayı Girin :");
            sayı = int.Parse(Console.ReadLine());
            for (int i = 0; i < sayı; i++)
            {//ilyas bozdemir
                if (i%2==0)
                {
                   ciftDizi[ciftSayac] = i;
                   ciftSayac++;
                }//ilyas bozdemir
                else
                {
                    tekDizi[tekSayac] = i;
                    tekSayac++;
                }//ilyas bozdemir
            }
            Console.WriteLine("Çift Sayılar");
            foreach (var Çift in ciftDizi)
            {
                Console.WriteLine(Çift);
            }
            Console.WriteLine("*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine("Tek Sayılar");//ilyas bozdemir
            foreach (var Tek in tekDizi)
            {
                Console.WriteLine(Tek);
            }

            Console.ReadLine();
        }
    }
}
    

