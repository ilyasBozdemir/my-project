using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _22_g
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayac = 0;
            Random rastgele = new Random();
            int[] sayılar = new int[20];
 
            Console.WriteLine("Oluşturulan Dizi");
            Console.WriteLine();
            for (int i = 0; i < sayılar.Length; i++)
            {
                sayılar[i] = rastgele.Next(50, 150);
                Console.Write(sayılar[i].ToString() + " ");
            }
            Console.WriteLine();
           for(int i=50; i<=150;i++)
            {
                sayac = 0;
                for (int j = 0; j < sayılar.Length; j++)
                    {
                        if (i == sayılar[j])
                        {
                            sayac++;
                        }
                    }
                    if(sayac!=0)
                    Console.WriteLine("{0} sayısından  {1} tane vardır",i,sayac);
            }
                Console.ReadLine();
            }
        }
    }
