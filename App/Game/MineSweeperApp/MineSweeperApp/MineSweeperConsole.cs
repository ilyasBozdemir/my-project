using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperApp
{
    ///<summary>
    ///bu dosya consol platformu için methodları barındırır.
    ///</summary>

    #region class MineSweeper
    /// <summary>
    /// MineSweeper sınıfı bir mayın tarlası oyununu temsil eden sınıftır.
    /// </summary>
    public partial class MineSweeper
    {

        /// <summary>
        /// 
        /// </summary>
        public void RunConsoleApp()
        {
            #region Run Console App
            Console.WriteLine("Geliştirici modunda açmak ister misiniz e - h");
            string result = Console.ReadLine().ToLower();
            if (result == "e")
            {
                _IsDeveloper = true;
                Console.WriteLine("---Geliştirici modunda açıldı---");
            }
            if (result == "h")
                _IsDeveloper = false;

            Console.ForegroundColor = ConsoleColor.White;
            Place_a_Mine();
            ShowMine();
            Console.WriteLine("Mayın Tarlası Oyuna Hoşgeldiniz!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintField(dataMatrix);
            Console.ForegroundColor = ConsoleColor.White;
            while (counter != safeZoneCount)
            {
                /// <summary>
                /// while döngüsü mayınsız bölge sayısı kadar döngüde kalmamızı tekrar tekrar 
                /// kullanıcıdan row,col bilgisi almamız için
                /// kullandığımız döngüdür.
                /// counter != safeZoneCount ile kontrol ediyoruz.
                /// her döngüde bir arttırıyoruz sayacı
                /// </summary>
                score = GetScore(counter, 5);
                counter++;
                ///<summary>oynandığı başarılı sayıyı alır bir puan temsil eden sayı döndürür.</summary>
                remainingNumber = safeZoneCount - counter;
                ///<summary>remainingNumber: kalan hakkı temsil eder</summary>
                Console.ForegroundColor = ConsoleColor.Yellow;
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

                if (!MineControl(mtrx))///<summary>!MineControl(mtrx) yani mayına basmamıssak</summary>
                {
                    DataInput(mtrx, dataMatrix);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    PrintField(dataMatrix);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else///<summary>!MineControl(mtrx) yani mayına basmıssak oyun biter</summary>
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine($"Game Over! Puanınız : {score}");
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.ReadLine();
                    break;
                }
            }
            if (counter == safeZoneCount)
            {
                /// <summary>
                /// counter == safeZoneCount oyunun başarıyla tamamlanması anlamına gelir.
                /// </summary>
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Tebrikler Oyunu Kazandiniz! Puanınız : {score}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            #endregion
        }


        /// <summary>
        ///  matrix verisini ekrana yazdırmak içindir.
        /// </summary>
        /// <param name="matrix">
        /// matrix verisini alır ve ekrana yazdırır.
        /// </param>
        private void PrintField(string matrix)
        {
            #region print field
            Console.WriteLine();
            Console.Write($"{matrix} ");
            Console.WriteLine();
            #endregion
        }

        /// <summary>
        /// çift boyutlu matrix dizisini alır. <see cref="GetMatrix"/> methodu ile
        /// tek boyutlu metne çevirir ve ekrana yazdırır.
        /// </summary>
        /// <param name="matrix">
        /// çift boyutlu matrix dizisini temsil eden yapıyı ele alır.
        /// </param>
        private void PrintField(string[,] matrix)
        {
            #region print field
            PrintField(GetMatrix(matrix));
            #endregion
        }
    }
    #endregion
}
