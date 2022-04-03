using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _20
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] On_numara = new int[22];
            Random rast = new Random();
            int numara;
            int sayac = 0;
            while (sayac < 22)//dizinin sayısını 6'ya esitle
            {
                numara = rast.Next(0, 80); //1-34 arası sayıları 
                //'rastgele' değişkenine ata
                if (Array.IndexOf(On_numara, numara) == -1)//dizilerin içindekiler
                // aynı olmasın diye
                {//ilyas bozdemir
                    On_numara[sayac] = numara;
                    sayac++;
                }
            }

            Console.Write("On Numara : ");
            for (int i = 0; i < 22; i++)
            {
                if (Array.IndexOf(On_numara,rast)==-1)
                {
                    Console.Write("{0},",On_numara[i]);
                }
            }//ilyas bozdemir
            Console.ReadLine();

        }
    }
}
