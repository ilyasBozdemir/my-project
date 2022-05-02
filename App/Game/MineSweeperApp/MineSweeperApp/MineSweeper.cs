namespace MineSweeperApp
{
    /** 
     * @author ilyas 
    **/
    
    public partial class MineSweeper
    {
        private Matrix _matrix;

        private int elemanSayisi,
                    mineCount,
                    safeZoneCount;
        private int rndMaxValue;
        private string[,] dataMatrix;
        private string[,] mineMatrix;
        private string brace = "===========================";
        bool _IsDeveloper;
        private void RunConsoleApp()
        {
            //
            Console.WriteLine("Geliştirici modunda açmak ister misiniz e - h");
            string result = Console.ReadLine().ToLower();
            if (result == "e")
            {
                _IsDeveloper = true;
                Console.WriteLine("---Geliştirici modunda açıldı---");
            }
            if (result == "h")
                _IsDeveloper = false;
            //
            Console.ForegroundColor = ConsoleColor.White;
            Place_a_Mine();
            ShowMine();

            Console.WriteLine("Mayın Tarlası Oyuna Hoşgeldiniz!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintField(dataMatrix);
            Console.ForegroundColor = ConsoleColor.White;

            int count = 0, row, col, score = 0;

            while (count != safeZoneCount)
            {
                count++;
                Console.ForegroundColor = ConsoleColor.Yellow;
                score = (count - 1) * 10;
                string data = $"{safeZoneCount - count}/{safeZoneCount}";
                Console.WriteLine(data);
                Console.WriteLine($"Mayın Adedi : {mineCount} | Puan : {score}");

                Console.ForegroundColor = ConsoleColor.White;

                Console.WriteLine(brace);

                Console.Write("Satır Giriniz : ");
                row = int.Parse(Console.ReadLine());
                Console.Write("Sütun Giriniz : ");
                col = int.Parse(Console.ReadLine());

                Console.WriteLine(brace);

                Matrix mtrx = new Matrix(row, col);

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
            if (count == safeZoneCount)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Oyunu Kazandiniz! Puanınız : {score}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
        }
        private void RunFormApp()
        {
            // soon
        }
    }
}