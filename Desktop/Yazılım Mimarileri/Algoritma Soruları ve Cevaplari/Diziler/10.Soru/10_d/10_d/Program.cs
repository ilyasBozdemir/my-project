using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _10_d
{
    class Program
    {
        static void Main(string[] args)
        {
            
           int[] sayilar={4,5,-15,22,-34,3,0,7,43,100};
           int teksayac = 0, ciftsayac = 0; 
           for (int i = 0; i < sayilar.Length; i++)
           {
               if (sayilar[i]%2==0)//sayılar dizi ikinin katı mı ?
               {
                   ciftsayac++;  //true
               }
               else//ilyas bozdemir
               {
                   teksayac++;  //false
               }
            } 
          
           Console.WriteLine("dizide {0} tane tek sayı vardır",teksayac);
           Console.WriteLine("dizide {0} tane çift sayı vardır",ciftsayac);
           //ilyas bozdemir
           Console.ReadKey();
        }
    }
}
