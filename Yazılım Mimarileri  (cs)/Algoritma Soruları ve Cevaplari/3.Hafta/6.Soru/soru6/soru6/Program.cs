using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru6
{
    class Program
    {
        static void Main(string[] args)
        {
  /*Beşlik not sistemine göre :
5:Pekiyi,
4:İyi,
3:Orta,
2:Geçer,
1:Kaldı,
Bunların dışında girilen rakamlar için hata mesajı verecek program, 
klavyeden girilen değere göre notun karşılığını yazıyla ekranda göstersin("switch-case").*/
            Console.Write("1-5 Arası Not Giriniz :");
            int not = Convert.ToInt32(Console.ReadLine());
            switch (not)//ilyas Bozdemir
            {
                case 1: Console.WriteLine("Seciminiz :" + not + " Pekiyi"); break;//ilyas Bozdemir
                case 2: Console.WriteLine("Seciminiz :" + not + " İyi"); break;
                case 3: Console.WriteLine("Seciminiz :" + not + " Orta"); break;
                case 4: Console.WriteLine("Seciminiz :" + not + " Geçer"); break;
                case 5: Console.WriteLine("Seciminiz :" + not + " Kalır"); break;
                default: Console.WriteLine("lutfen 1-5 arası değer girin"); break;//ilyas Bozdemir
              }  Console.ReadLine();
                    
                    
            


        }
            
    }
}
