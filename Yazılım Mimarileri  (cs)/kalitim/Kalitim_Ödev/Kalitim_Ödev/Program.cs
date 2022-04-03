using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalitim_Ödev
{
    class ev
    {
        public string ilce;
        public int alan;
        public string adres;
        public int oda;
        public string isinma;
        public void ozellikgoster()
        {
            Console.WriteLine("***evin ozellikleri***\nilcesi={0}\nalanı={1}\nadresi={2}\noda sayısı={3}\nisinmasi={4}", ilce, alan, adres, oda, isinma);
        }
    }
    class satilikev : ev
    {
        public int fiyat;
        public int tel;
        public void satilikozellik()
        {
            Console.WriteLine("fiyatı={0} TL\nsatan kisi tel={1}", fiyat, tel);
        }
    }
    class kiralikev : ev
    {
        public int fiyat;
        public int depozito;
        public int sozlesmezamani;
        public int tel;
        public void kiralikozellik()
        {
            Console.WriteLine("fiyatı={0} TL\ndepozitosu={1} TL\nsozlesme zamanı={2} yıl\nsatan kisi tel={3}", fiyat, depozito, sozlesmezamani, tel);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            satilikev satilik = new satilikev();
            kiralikev kiralik = new kiralikev();
            Console.WriteLine("kiralik? - satilik? hangi işlemi yapmak istiyorsunuz?");
            string durum = Console.ReadLine();
            if (durum == "satilik")
            {
                Console.WriteLine("sırasıyla ilce alan adres odasayısı ısınma fiyat ve teli yazınız");
                satilik.ilce = Console.ReadLine();
                satilik.alan = Convert.ToInt32(Console.ReadLine());
                satilik.adres = Console.ReadLine();
                satilik.oda = Convert.ToInt32(Console.ReadLine());
                satilik.isinma = Console.ReadLine();
                satilik.fiyat = Convert.ToInt32(Console.ReadLine());
                satilik.tel = Convert.ToInt32(Console.ReadLine());
                satilik.ozellikgoster();
                satilik.satilikozellik();
            }
            else if (durum == "kiralik")
            {
                Console.WriteLine("sırasıyla ilce, alan ,adres ,odasayısı ,ısınma, fiyat, depozito ,sozlesme zamanı, ve teli yazınız");
                kiralik.ilce = Console.ReadLine();
                kiralik.alan = Convert.ToInt32(Console.ReadLine());
                kiralik.adres = Console.ReadLine();
                kiralik.oda = Convert.ToInt32(Console.ReadLine());
                kiralik.isinma = Console.ReadLine();
                kiralik.fiyat = Convert.ToInt32(Console.ReadLine());
                kiralik.depozito = Convert.ToInt32(Console.ReadLine());
                kiralik.sozlesmezamani = Convert.ToInt32(Console.ReadLine());
                kiralik.tel = Convert.ToInt32(Console.ReadLine());
                kiralik.ozellikgoster();
                kiralik.kiralikozellik();
            }
            else
            {
                Console.WriteLine("yanlıs bir ifade girdiniz");
            }
            Console.ReadKey();
        }
    }
}