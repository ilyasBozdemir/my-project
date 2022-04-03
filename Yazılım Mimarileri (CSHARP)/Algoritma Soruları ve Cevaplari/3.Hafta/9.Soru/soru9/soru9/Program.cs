using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru9
{
    class Program
    {
        static void Main(string[] args)
        {
    /*9.	Altıncı sorudaki programı, hatalı giriş yapıldığında uyarı mesajı
     * geldikten sonra program kapanmadan 
     * tekrar giriş yapılıp sonucu ekranda görünecek şekilde düzenleyiniz(goto). */
            baslangıc :Console.Write("1-5 Arası Not Giriniz :");//baslangıc
            int not = Convert.ToInt32(Console.ReadLine());
            switch (not)//ilyas Bozdemir
            {
                case 1: Console.WriteLine("Seciminiz :" + not + " Pekiyi"); break;
                case 2: Console.WriteLine("Seciminiz :" + not + " İyi"); break;
                case 3: Console.WriteLine("Seciminiz :" + not + " Orta"); break;
                case 4: Console.WriteLine("Seciminiz :" + not + " Geçer"); break;
                case 5: Console.WriteLine("Seciminiz :" + not + " Kalır"); break;
                default: Console.WriteLine("lutfen 1-5 arası değer girin"); break;
                //ilyas Bozdemir
            } goto baslangıc;//1-5 arası olmazsa hata verir basar sarar
             Console.ReadLine();


        }
    }
}
