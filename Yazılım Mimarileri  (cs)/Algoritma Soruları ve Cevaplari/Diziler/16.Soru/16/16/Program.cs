using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _16
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Ahmet", "ilyas", "Recep", "Hüseyin", "Seda",
            "Mehmet","Ali","Veli","Saban","Hayri"};
           
             string girilen;

            Console.Write("Aradığınız ismi giriniz = ");

            girilen = Console.ReadLine();
            int indeks = Array.IndexOf(isimler, girilen);

            if (indeks == -1)
                Console.Write(" Aradığınız isim bulunamadı");

            else Console.Write("Aradığınız isim {0}. sırada bulundu", indeks + 1);

            Console.ReadKey();
        }
    }
}
