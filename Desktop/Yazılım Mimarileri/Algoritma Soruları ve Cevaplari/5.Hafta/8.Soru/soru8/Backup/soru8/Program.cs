using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru8
{
    class Program
    {
        static void Main(string[] args)
        {
            double toplam = 0;
            double sonuc = 0;
            for (int i = 1; i < 100; i=i+2)
            {//ilyas bozdemir
                sonuc = i * (i + i);
                toplam=toplam+Math.Sqrt(i*(i+2));
            }//ilyas bozdemir
             Console.WriteLine(toplam);
        Console.ReadKey();
    }
}
}