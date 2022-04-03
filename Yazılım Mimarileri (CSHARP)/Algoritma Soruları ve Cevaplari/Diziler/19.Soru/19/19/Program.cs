using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _19
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] tahmin = new int[5];
            int[] tahmin1 = new int[1];
            int tahminsay = 0;
            int tahminsay1 = 0;
            int sonuc = 0;
            Random rastgel = new Random();
            Random rastgel1 = new Random();
            for (int i = 0; i < tahmin.Length; i++)
            {
                Console.Write("{0}. tahmini girin :", i + 1);
                tahmin[i] = Convert.ToInt32(Console.ReadLine());
                //tahmin[i] = rastgel.Next(1, 34);

            }
            for (int i = 0; i < 1; i++)
            {
                Console.Write("+ tahmini girin :");
                tahmin1[i] = Convert.ToInt32(Console.ReadLine());
                //tahmin1[i] = rastgel1.Next(1, 14);
            }

            Random rastgele = new Random();
            Random rastgele1 = new Random();
            int[] sans = new int[5];
            int[] sans1 = new int[1];
            for (int i = 0; i < sans.Length; i++)
            {
                sans[i] = rastgele.Next(1, 34);
            }
            for (int i = 0; i < sans1.Length; i++)
            {
                sans1[i] = rastgele1.Next(1, 14);
            }
            Console.WriteLine(" ");
            Console.Write("Benim tahminim : ");
            foreach (var tahminn in tahmin)
            {
                Console.Write("{0} ", tahminn);
            }
            foreach (var tahmn in tahmin1)
            {
                Console.Write(" +{0}", tahmn);
            }
            Console.WriteLine(" ");
            Console.Write("Pc'nin tahmini : ");
            foreach (var sayısal in sans)
            {
                Console.Write("{0} ", sayısal);
            }
            foreach (var sayısal1 in sans1)
            {
                Console.Write("+{0} ", sayısal1);
            }
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            for (int i = 0; i < tahmin.Length; i++)
            {
                for (int j = 0; j < tahmin.Length; j++)
                {
                    if (tahmin[i] == sans[j])
                    {
                        tahminsay++;
                    }
                }
            }
            for (int i = 0; i < tahmin1.Length; i++)
            {
                for (int j = 0; j < tahmin1.Length; j++)
                {
                    if (tahmin1 == sans1)
                    {
                        tahminsay1++;
                    }
                }
            }
            sonuc = tahminsay + tahminsay1;
            if (sonuc > 2 && sonuc < 7)
            {
                Console.WriteLine("Tebrikler  İkramiye Kazandınız !!!");
            }
            else
            {
                Console.WriteLine(" İkramiye kazanamadınız");
            }
            Console.ReadLine();
            
        }
    }
}
