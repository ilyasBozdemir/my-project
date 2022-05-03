namespace MineSweeperApp
{
    /** 
     * @author ilyas 
    **/
    public partial class MineSweeper
    {
        private void RunConsoleApp()
        {
            #region isDeveloper
            Console.WriteLine("Geliştirici modunda açmak ister misiniz e - h");
            string result = Console.ReadLine().ToLower();
            if (result == "e")
            {
                _IsDeveloper = true;
                Console.WriteLine("---Geliştirici modunda açıldı---");
            }
            if (result == "h")
                _IsDeveloper = false;
            #endregion
            #region game started
            Console.ForegroundColor = ConsoleColor.White;
            Place_a_Mine();
            ShowMine();
            Console.WriteLine("Mayın Tarlası Oyuna Hoşgeldiniz!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintField(dataMatrix);
            Console.ForegroundColor = ConsoleColor.White;
           
            while (counter != safeZoneCount)//sayac mayınsız bölge sayısı oluncaya kadar devam et
            {
                counter++;

                Console.ForegroundColor = ConsoleColor.Yellow;

                remainingNumber = safeZoneCount - counter;//kalan hakkı temsil eder.

                score = GetScore(counter);
                //oynandığı başarılı sayıyı alır bir puan temsil eden sayı döndürür.

                Console.WriteLine($"{remainingNumber}/{safeZoneCount}");// kalan hak / max hak
                Console.WriteLine($"Mayın Adedi : {mineCount} | Puan : {score}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine(brace);//brace ayraç atmak adına

                Console.Write("Satır Giriniz : ");
                inputRow = int.Parse(Console.ReadLine());
                Console.Write("Sütun Giriniz : ");
                inputCol = int.Parse(Console.ReadLine());

                Console.WriteLine(brace);

                Matrix mtrx = new Matrix(inputRow, inputCol);

                if (!MineControl(mtrx))
                {
                    DataInput(mtrx, dataMatrix);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    PrintField(dataMatrix);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Game Over! Puanınız : {score}");
                    Console.ForegroundColor = ConsoleColor.White;
                    break;
                    Console.ReadLine();
                }
            }
            if (counter == safeZoneCount)//burda remainingNumber değişkeni 0 olunca aynı anlama gelir
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Tebrikler Oyunu Kazandiniz! Puanınız : {score}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            #endregion
        }
        private void RunFormApp()
        {
            // soon
        }
    }
}