using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru5
{
    class Program
    {
        static void Main(string[] args)
        {    
    /* 5.	Klavyeden sıfır girilene kadar asal olup
    * olmadığını ekrana yazan programı yapınız. 
    * (yalnızca 1’e ve kendine bölünebilen sayılar asaldır.)*/
    
    Console.WriteLine("Sayı Girin :"); 
   int asal_sayı = Convert.ToInt32(Console.ReadLine());
   
    if (asal_sayı/asal_sayı==1 || asal_sayı/1==asal_sayı )//ilyas bozdemir
    {
        Console.WriteLine(asal_sayı+" Sayı Asal Sayı Değildir.");
    }
    else//ilyas bozdemir
    {
        Console.WriteLine(asal_sayı + " Sayı Asal Sayıdır.");
    }
            Console.ReadLine();
    
    }   
   6+  
        
    
}

}