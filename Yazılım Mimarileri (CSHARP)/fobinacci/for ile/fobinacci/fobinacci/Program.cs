using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace fobinacci
{
    class Program
    {
        static void Main(string[] args)
        {
            int t = 0;
            int i = 0;
            string fobinacciToString = "";
            while (i < 10)
            {
                t = t + i;
                fobinacciToString += t + " ";
                i++;
            }
            Console.Write(fobinacciToString);
            Console.ReadLine();
        }
    }
}
