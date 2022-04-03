using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru7
{
    class Program
    {
        static void Main(string[] args)
        {

Random rastgele = new Random();
StringBuilder sb = new StringBuilder();
for (int i = 0; i <8; i++)
{//ilyas bozdemi
        int ascii = rastgele.Next(32, 127);
        char karakter = Convert.ToChar(ascii);
        sb.Append(karakter);

}//ilyas bozdemi
Console.WriteLine(sb.ToString());
            Console.ReadLine();
        }
    }
}
