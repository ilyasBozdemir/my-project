using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        {
            int sonuc = 0;
            int i, j, AsalKontrol;
            Console.WriteLine("Sayı Girin :");
            int sayı = Convert.ToInt32(Console.ReadLine());
            for (i = sayı + 1; i > sayı; i++)
            {
                AsalKontrol = 1;// a sayı asal değilse 0 
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        AsalKontrol = 0;// burdaki gibi
                        break;
                    }
                }
                if (AsalKontrol == 1)//sayı 1'se hala 
                {
                    sonuc = i;
                    i = 0;
                }
            }
            Console.WriteLine("Sonraki Sayı {0}'dır.", sonuc);
            for (i = sayı - 1; i < sayı; i--)
            {
                AsalKontrol = 1;
                for (j = 2; j < i; j++)
                {
                    if (i % j == 0)//asal sayı değilse 
                    {
                        AsalKontrol = 0;
                        break;
                    }
                }
                if (AsalKontrol == 1) // asal sayıysa
                {
                    sonuc = i;
                    i = sayı + 1;
                }
            }
            Console.WriteLine("Önceki Sayı {0}'dır.", sonuc);
            Console.ReadLine();
    }
        

        }
    }
