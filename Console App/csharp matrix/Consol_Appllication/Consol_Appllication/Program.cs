using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consol_Appllication
{
    class Program
    {
        static void Main(string[] args)
        {
            //int a = Convert.ToInt16(Console.ReadLine());
            //int[] dizi = new int[a];

            //for (int i = 0; i < a; i++)
            //{
            //    Console.Write("dizinin " + i + ".değerini giriniz=");
            //    dizi[i] = Convert.ToInt16(Console.ReadLine());
            //}

            //Array.Sort(dizi);

            //foreach (int i in dizi)
            //{
            //   Console.WriteLine(i);
            //}
            //Console.ReadLine();
                         //matrix
            int[,] dizi = { { 1, 2 }, { 9, 6 } };
            int[,] dizi2 = { { 5, 6 }, { 4, 8 } };
            int[,] sonuç = new int[2, 2];
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    sonuç[i, j] = dizi[i, j] + dizi2[i, j];
                    Console.Write("{0} sütun {1} satırı : ",i,j);
                    Console.WriteLine(sonuç[i, j]);
                }
            }

            Console.ReadLine();
        }
    }
}
