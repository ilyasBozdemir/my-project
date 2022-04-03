using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace csharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] ornekler = new int[20];
            Random random = new Random();
            int rastgele;

            for (int i = 0; i < ornekler.Length; i++)
            {
                rastgele= random.Next(0, 200);
                ornekler[i] = rastgele;
            }
            for (int i = 0; i < ornekler.Length; i++)
            {
                Console.WriteLine("ornekler[" + i + "] => " + ornekler[i]);
            }
            Console.ReadKey();
        } 
    }
}
