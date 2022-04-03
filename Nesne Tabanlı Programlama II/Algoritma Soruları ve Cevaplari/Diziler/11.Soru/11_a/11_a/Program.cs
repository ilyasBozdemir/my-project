using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11_a
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write("İl Girin :");
           string[] plakakodlari ={"Kayıt Yok", "01", 
           "02", "03", "04", "05", "06"};
            string seçim = Console.ReadLine();
            switch (seçim)
            {//ilyas bozdemir
                case "Adana": Console.WriteLine(plakakodlari[1]); break;
                case "Adıyaman": Console.WriteLine(plakakodlari[2]); break;
                case "Afyonkarahisar": Console.WriteLine(plakakodlari[3]); break;
                case "Ağrı": Console.WriteLine(plakakodlari[4]); break;
                case "Amasya": Console.WriteLine(plakakodlari[5]); break;
                case "Ankara": Console.WriteLine(plakakodlari[6]); break;
                default : Console.WriteLine(plakakodlari[0]); break;
            }//ilyas bozdemir
            Console.ReadKey();
           
        }
    }
}
