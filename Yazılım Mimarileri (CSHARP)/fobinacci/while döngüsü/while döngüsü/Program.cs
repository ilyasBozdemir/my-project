using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace while_döngüsü
{
    class Program
    {
       public static void Main(string[] args)
        {
            int t = 0;
            int i = 0;
            while (i < 10)// fobinacci
            {
                t += i;
                Console.Write(t + " ");
                i++;
            }
            Console.Read();
        }
    }
}
