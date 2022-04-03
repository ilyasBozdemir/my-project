using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _17
{
    class Program
    {
        static void Main(string[] args)
        {
           int[] dizi = new int[5];
           int toplam = 0;
           int i;
           int çsay = 0;//ilyas bozdemir

           for (i = 0; i < 5; i++)//kullanıcdan 5 sayıyı alalım
           {
               Console.Write("{0}. Sayıyı Giriniz :", i + 1);
               dizi[i] = Convert.ToInt32(Console.ReadLine()); 
               
           }
            // cift sayılarının sayısını bulalım....
            for ( i = 0; i < dizi.Length; i++)
            {
                if ((dizi[i])%2==0)
                {
                    çsay++;//ilyas bozdemir
                   toplam += dizi[i]; 
                }
            }
            
            Console.WriteLine("Çift Sayıların Ortalaması : " + toplam / çsay);//toplam
            Console.WriteLine("Çift Sayıların Sayısı : " +çsay);//çift sayıların 
            //toplamını
            Console.ReadKey();
        }

    }
}
