using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _14
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dizi = { 15, 26, 7, 8, 56, 78, 34, -32, -58};
            int toplam = 0;
            foreach (var diz in dizi)
            { //ilyas bozdemir
                toplam = toplam + diz;
            }    
            Console.WriteLine("toplam : {0}",toplam);
            Console.ReadLine();
        }
    }
}
