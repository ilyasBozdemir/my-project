using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _18
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rastgele = new Random();
            int[] loto = new int[6];
            for (int i = 0; i < loto.Length; i++)
            {
                loto[i] = rastgele.Next(1, 49);
            }
            foreach (var sayısal in loto)
            {
                Console.Write("{0} ", sayısal);
            }
            Console.ReadLine();
    }
}
}