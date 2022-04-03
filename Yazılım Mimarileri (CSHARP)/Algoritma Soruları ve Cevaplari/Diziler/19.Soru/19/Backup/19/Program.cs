using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            Random sayılar = new Random();//rastgele sayıları 'sayılar'a ata
            int rastgele;
            int sayac = 0;//ilyas bozdemir
            int[] sans = new int[6];
            
            while (sayac < 5)//dizinin sayısını 6'ya esitle
            {
                rastgele = sayılar.Next(0, 35); //1-34 arası sayıları 
                //'rastgele' değişkenine ata
                if (Array.IndexOf(sans, rastgele) == -1)//dizilerin içindekiler
                // aynı olmasın diye
                {
                    sans[sayac] = rastgele;
                    sayac++;
                }
            }//ilyas bozdemir
            Random s_artı = new Random();
            int rast;
            rast = s_artı.Next(1, 14);
            Console.Write("Sans Topu : ");
            for (int i = 0; i < sans.Length; i++)
            {
                Console.Write("{0},",sans[i]);
            }
            Console.Write("+{0}", rast);
            Console.ReadLine();
            //ikramiye kazanıp kazanmadıgı kısmı bos
            
        }
    }
}
