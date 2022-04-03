using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace soru8
{
    class Program
    {
        static void Main(string[] args)
        {/*8.	Klavyeden önceden belirlenmiş bir PIN kodu girilmesini 
          * isteyin. Üç defa PIN numarasını yanlış girilmiş ise 
          * “Uygulama Bloke Olmuştur” mesajını, kullanıcı üç deneme 
          * hakkı içinde PIN kodunu doğru girerse
          * “Hoş Geldiniz…” mesajını veren programı yapınız. */
             string pin = "12345";
            byte cs = 0;
            while (cs <3)
            {
                Console.Write("Pin Kodu giriniz:");
                string gpin = Console.ReadLine();
                if (gpin == pin)
                { Console.WriteLine("Hoşgeldiniz"); break; }//ilyas bozdemir
                else if (cs == 1)
                { Console.Write("Uygulamanız bloke olmuştur."); break; }
                else
                { Console.WriteLine("Pin Kodunu hatalı girdiniz tekrar deneyiniz");

                }//ilyas bozdemir
                cs++;
            }
                    Console.ReadKey(); }
        }
    }

