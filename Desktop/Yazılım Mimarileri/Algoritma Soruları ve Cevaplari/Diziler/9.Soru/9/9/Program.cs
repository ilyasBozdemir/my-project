using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _9
{
    class Program
    {
        static void Main(string[] args)
        {
            char[] sesli = { 'a', 'e', 'i', 'u', 'ı', 'ü', 'o', 'ö',
                             'A', 'E', 'İ', 'U', 'I', 'Ü', 'O', 'Ö' };
            int sayi = 0;
         Console.Write("Bir Cümle Girin :");
         string cumle = Console.ReadLine();
         int[] yer=new int [0];//sesli harflerin kacıncı hecede oldugunu göstermek için 
         for (int i = 0; i < cumle.Length; i++)//girilen cümle için
         {
             //ilyas bozdemir
             for (int j = 0; j < sesli.GetLength(0); j++)//sesli harfler için
              {
                  if (cumle[i]==sesli[j])//kosul kosma
                  {
                        sayi++;//sayıyı arttır
                  System.Array.Resize(ref yer, yer.GetLength(0) + 1);
                  yer[yer.GetLength(0) - 1] = i;//i sesli katrakterin oldugu yer 
                    }
              }//ilyas bozdemir
            }
            Console.WriteLine("Cümlede {0} tane sesli harf vardır. ",sayi);
            Console.WriteLine(); 
            Console.WriteLine("***********************");
            Console.WriteLine(); 
            for (int i = 0; i < yer.GetLength(0); i++)
            {
                Console.WriteLine("Cümlenin {0} hecesinde sesli harf vardır. ",yer[i]+1);
            }//ilyas bozdemir
            Console.ReadKey();
        }
    }
}
