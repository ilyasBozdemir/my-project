using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru2
{
    class Program
    {
        static void Main(string[] args)
        {
      /*Bugün günlerden cumartesi ise X gün sonra hangi gün olur?” 
    * diye sorulan bir LYS sınav sorusunu klavyeden girilen 
   * sayıya göre hesaplayan programı C# Console kodları ile çözünüz .
Örnek: X=100 için Cevap: Pazartesi
 */
            int x_gün = Convert.ToInt32(Console.ReadLine());
            int sonuc = x_gün % 7;
            switch (sonuc)//ilyas bozdemir
            {
                case 0: Console.Write("persembe"); break;
                case 1: Console.Write("cuma"); break;
                case 2: Console.Write("cumartesi"); break;
                case 3: Console.Write("pazar"); break;
                case 4: Console.Write("pazartesi"); break;
                case 5: Console.Write("salı"); break;
                case 6: Console.Write("carsamba"); break;
            }
            Console.ReadLine();
                  
            




        }
    }
}
