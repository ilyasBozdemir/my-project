using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
        string[] Gün ={"Pazartesi","Salı","Carsamba","Persembe","Cuma","Cumartesi","Pazar"};
        Console.Write(" index numarası girin : ");
            int index = Convert.ToInt32(Console.ReadLine());
            int sonuc = index % 7;
            //6'dan buyuk değer girldiğinde hata vermemesi için döngü yapıyoruz.  
            switch (sonuc)
            {//ilyas bozdemir
            case 0: Console.WriteLine(Gün[0]); break;
            case 1: Console.WriteLine(Gün[1]); break;
            case 2: Console.WriteLine(Gün[2]); break;
            case 3: Console.WriteLine(Gün[3]); break;
            case 4: Console.WriteLine(Gün[4]); break;
            case 5: Console.WriteLine(Gün[5]); break;
            case 6: Console.WriteLine(Gün[6]); break;
            }//ilyas bozdemir
        Console.ReadKey();
        }
    }
}
