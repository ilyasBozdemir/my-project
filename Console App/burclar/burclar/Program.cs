try
{
    Console.Write("Doğum tarihini gün.ay şeklinde giriniz : ");
    string tarih = Console.ReadLine();
    var tarihParcala = tarih.Split('.', ',', '/', '-');
    int gun = int.Parse(tarihParcala[0]), ay = int.Parse(tarihParcala[1]);
    string burc = BurcuGetir(gun, ay);
    Console.WriteLine($"{gun}.{ay} -> {burc} Burcu");
}
catch (Exception e)
{
    Console.WriteLine($"Hata : {e.Message}");
}
string BurcuGetir(int gun, int ay)
{
    //Burç: Oğlak (22.12 - 21.01)
    //Burç: Kova (22.01 - 19.02)
    //Burç: Balık (20.02 - 20.03)
    //Burç: Koç (21.03 - 20.04)
    //Burç: Boğa (21.04 - 21.05)
    //Burç: İkizler (22.05 - 22.06)
    //Burç: Yengeç (23.06 - 22.07)
    //Burç: Aslan (23.07 - 22.08)
    //Burç: Başak (23.08 - 22.09)
    //Burç: Terazi (23.09 - 22.10)
    //Burç: Akrep (23.10 - 21.11)
    //Burç: Yay (22.11 - 21.12)

    string[] burclar = { "Oğlak", "Kova", "Balık", "Koç", "Boğa", "İkizler",
                         "Yengeç", "Aslan", "Başak", "Terazi", "Akrep", "Yay"
                       };
    int[] burcGunleri = { 21, 19, 20, 20, 21, 22, 22, 22, 22, 22, 21, 21 };
    string burc = "";

    for (int i = 0; i < burclar.Length; i++)
        if (ay == i)
            burc = (gun > burcGunleri[i - 1]) ? burclar[i] : burclar[i - 1];
        //bu kod asagıda ki switch - case bloguna bedeldir.
    
    //switch (ay)
    //{
    //    case 1:
    //        burc = (gun > burcGunleri[0]) ? burclar[1] : burclar[0];
    //        break;
    //    case 2:
    //        burc = (gun > burcGunleri[1]) ? burclar[2] : burclar[1];
    //        break;
    //    case 3:
    //        burc = (gun > burcGunleri[2]) ? burclar[3] : burclar[2];
    //        break;
    //    case 4:
    //        burc = (gun > burcGunleri[3]) ? burclar[4] : burclar[3];
    //        break;
    //    case 5:
    //        burc = (gun > burcGunleri[4]) ? burclar[5] : burclar[4];
    //        break;
    //    case 6:
    //        burc = (gun > burcGunleri[5]) ? burclar[6] : burclar[5];
    //        break;
    //    case 7:
    //        burc = (gun > burcGunleri[6]) ? burclar[7] : burclar[6];
    //        break;
    //    case 8:
    //        burc = (gun > burcGunleri[7]) ? burclar[8] : burclar[7];
    //        break;
    //    case 9:
    //        burc = (gun > burcGunleri[8]) ? burclar[9] : burclar[8];
    //        break;
    //    case 10:
    //        burc = (gun > burcGunleri[9]) ? burclar[10] : burclar[9];
    //        break;
    //    case 11:
    //        burc = (gun > burcGunleri[10]) ? burclar[11] : burclar[10];
    //        break;
    //    case 12:
    //        burc = (gun > burcGunleri[11]) ? burclar[12] : burclar[11];
    //        break;
    //}

    return burc;
}