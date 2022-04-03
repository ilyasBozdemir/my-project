using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace deneme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Filtrelencek e-postayı girin : ");
            string eposta = Console.ReadLine();
            string filtrelieposta = null; int numara = 0;

            numara = eposta.IndexOf("@");
            if (true)
            {

            }
            for (int i = 1; i < numara; i++)
            {
                //filtrelieposta = eposta.Replace(eposta[i], '*');
                filtrelieposta = eposta.Substring(0, numara - 1);
            }
            Console.WriteLine("Filtrelenmiş hali : {0} ", filtrelieposta);
            Console.Read();
        }
    }
}
