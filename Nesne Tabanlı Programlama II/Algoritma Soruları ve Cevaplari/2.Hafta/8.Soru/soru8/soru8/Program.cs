using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru8
{
    class Program
    {
        static void Main(string[] args)
        {   /*8.	Klavyeden girdiğin toplam süreyi,
        "saat: dakika: saniye" tipine değiştirecek olan programı yazınız. */

            int saat, dakika, saniye,sure;
            Console.Write("Süre Giriniz :");//ilyas Bozdemir
            sure = Convert.ToInt32(Console.ReadLine());
            saat = sure / 3600;
            dakika = (sure - (saat * 3600)) / 60;
            saniye = sure - (saat * 3600) - (dakika * 60);//ilyas Bozdemir
            Console.WriteLine("Saat/Dakika/Saniye"+saat+":"+dakika+":"+saniye);
            Console.ReadKey();


        }
    }
}
