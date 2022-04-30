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
     
    string[] burclar = { "Oğlak", "Kova", "Balık", "Koç", "Boğa", "İkizler", "Yengeç", "Aslan", "Başak", "Terazi", "Akrep", "Yay" };
    int[] burcGunleri = { 21, 19, 20, 20, 21, 22, 22, 22, 22, 22, 21, 21 };
    string burc = "";

    for (int i = 1; i <= 12; i++)
        if (i == ay)
            burc = (gun > burcGunleri[(i - 1)])
                        ? burclar[(i - 1)]
                        : burclar[(i - 1) - 1];
    return burc;
}