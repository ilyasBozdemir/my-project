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
            Random sayılar = new Random();//rastgele sayıları 'sayılar'a ata
            int rastgele;//ilyas bozdemir
            int sayac = 0;
            int[] loto = new int[6];
            Console.Write("Aradığınız sayıyı giriniz = ");
            int aranan = Convert.ToInt32(Console.ReadLine());
            if (Array.IndexOf(sayılar,aranan == -1))
            {
                Console.WriteLine(" Aradığınız isim bulunamadı");
            }

            else//ilyas bozdemir
            {
                Console.WriteLine("Aradığınız isim bulundu");
            } 
            
            while (sayac<6)//dizinin sayısını 6'ya esitle
            {
                rastgele = sayılar.Next(1, 50); //1-50 arası sayıları 
                //'rastgele' değişkenine ata
                if (Array.IndexOf(loto, rastgele) == -1)//dizilerin içindekiler
                    // aynı olmasın diye
                {
                    loto[sayac] = rastgele;
                    sayac++;//ilyas bozdemir
                }
            }
            Console.Write("Sayısal Lotolarımız: ");
            for (int i = 0; i < loto.Length; i++)
            {
                 Console.Write("{0},",loto[i]);
            }
            Console.ReadLine();   
    }
}
}