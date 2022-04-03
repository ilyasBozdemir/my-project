using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_b
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Plaka Kodu Girin");
            string[] plakakodlari ={"Kayıt Yok", "Adana", 
        "Adıyaman", "Afyonkarahisar", "Ağrı", "Amasya", "Ankara"};
            int seçim = Convert.ToInt32(Console.ReadLine());
            switch (seçim)
            {//ilyas bozdemir
                case 1: Console.WriteLine(plakakodlari[1]); break;
                case 2: Console.WriteLine(plakakodlari[2]); break;
                case 3: Console.WriteLine(plakakodlari[3]); break;
                case 4: Console.WriteLine(plakakodlari[4]); break;
                case 5: Console.WriteLine(plakakodlari[5]); break;
                case 6: Console.WriteLine(plakakodlari[6]); break;
            }//ilyas bozdemir
            Console.ReadKey();
           
        }
    }
}
