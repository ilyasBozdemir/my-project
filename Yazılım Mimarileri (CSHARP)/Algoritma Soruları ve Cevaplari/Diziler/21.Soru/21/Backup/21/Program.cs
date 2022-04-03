using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _21
{
    class Program
    {
        static void Main(string[] args)
        { //ilyas bozdemir
            int GirilenSayi;
Console.Write(" Bir sayi giriniz : ");
GirilenSayi = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Önceki Sayı {0} dır.", OncekiAsalSayi(GirilenSayi));
Console.WriteLine("Sonraki Sayı {0} dır.", SonrakiAsalSayi(GirilenSayi));
}
static int OncekiAsalSayi(int GirilenSayi)
{
int b, c, son = 0, d;
for (b = GirilenSayi - 1; b < GirilenSayi; b--)
{//ilyas bozdemir
d = 1;
for (c = 2; c < b; c++)
{
if (b % c == 0)
{
d = 0;
break;
}
}
if (d == 1)
{ son = b; b = GirilenSayi + 1; }
}
return son;//ilyas bozdemir
}
static int SonrakiAsalSayi(int GirilenSayi)
{
int b, c, son = 0, d;
for (b = GirilenSayi + 1; b > GirilenSayi; b++)
{
d = 1;
for (c = 2; c < b; c++)//ilyas bozdemir//ilyas bozdemir
            {
                if (b % c == 0)
                {
                    d = 0;

                    break;
                }
            }

            if (d == 1)
            { 
                son = b; 
                b = 0; 
            }
}//ilyas bozdemir
Console.ReadLine();
return son;
Console.ReadLine();
    }
        

        }
    }
