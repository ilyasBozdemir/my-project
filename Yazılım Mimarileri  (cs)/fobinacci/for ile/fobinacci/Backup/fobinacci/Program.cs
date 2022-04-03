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

            int t=0;
            int i = 0;
            while (i < 10)
            {
                t = t + i;
                Console.WriteLine(t.ToString());
                i++;
            }
            Console.ReadKey();
            
        }
    }
}
