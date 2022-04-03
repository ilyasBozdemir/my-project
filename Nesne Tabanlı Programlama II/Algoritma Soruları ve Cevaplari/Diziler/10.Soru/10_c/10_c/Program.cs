using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_c
{
    class Program
    {
        static void Main(string[] args)
        {
         	int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
          
            // tersi yazılacak  olan diziyi olustur.

            int[] tersDizi = new int[sayilar.Length];

            // dizinin tersini for döngüsü kullanarak al

            for (int i = 0; i < sayilar.Length; i++)
            {
                tersDizi[i] = sayilar[sayilar.Length - 1 - i];
            } foreach (int sayi in sayilar)//ilyas bozdemir
            {
                Console.WriteLine("Düzü :{0}", sayi);
            }
             Console.WriteLine("********************");
            foreach (int sayi in tersDizi)//tersdiziyi ekrana yazdır
            {
                Console.WriteLine("tersi :{0}", sayi);//ilyas bozdemir
            }
            Console.ReadKey();
        }
    }
}
