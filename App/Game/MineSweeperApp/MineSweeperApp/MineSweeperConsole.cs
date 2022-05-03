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

            AskForDeveloperMode();
            WelcomeToGame();

            do
            {
                /// <summary>
                /// while döngüsü mayınsız bölge sayısı kadar döngüde kalmamızı tekrar tekrar 
                /// kullanıcıdan row,col bilgisi almamız için
                /// kullandığımız döngüdür.
                /// gameState ile kontrol ediyoruz.
                /// her döngüde bir arttırıyoruz sayacı
                /// </summary>

                GameInfoPrint();
                Matrix mtrx = GetRowCol();

                if (DataComparison(mtrx))
                {
                    if (!MineControl(mtrx))///<summary>!MineControl(mtrx) yani mayına basmamıssak</summary>
                    {
                        DataInput(mtrx, dataMatrix, out _state);
                        score = GetScore(counter, 5);
                        if (_state)//kullanıcı önceden girdiği sayıyı tekrar girmediği sürece
                            counter++;//sayac arttır.
                        else
                            PrintErrorMessage("Zaten bu hücreyi daha önce seçtiniz\nTekrar seçim yapın.");

                        Console.ForegroundColor = ConsoleColor.Yellow;
                        PrintField(dataMatrix);//değişikliği ekrana yazdır.
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        GameOver();
                        break;
                    }
                }
                else
                    PrintErrorMessage("Dizi boyutundan büyük sayı veya dizi boyutundan küçük bir sayı girdiniz");
            }
            while (counter != safeZoneCount);

            if (counter == safeZoneCount)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Tebrikler Oyunu Kazandiniz! Puanınız : {score}");
                Console.ForegroundColor = ConsoleColor.White;
                Console.ReadLine();
            }
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private Matrix GetRowCol()
        {
            #region GetRowCol
            Console.WriteLine(brace);
            inputRow = ConsoleRead("Satır Giriniz : ");
            inputCol = ConsoleRead("Sütun Giriniz : ");
            Console.WriteLine(brace);
            return new Matrix(inputRow, inputCol);
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        private void GameInfoPrint()
        {
            #region GameInfoPrint
            Console.ForegroundColor = ConsoleColor.Yellow;
            remainingNumber = safeZoneCount - counter;
            Console.WriteLine($"{remainingNumber}/{safeZoneCount}");
            Console.WriteLine($"Mayın Adedi : {mineCount} | Puan : {score}");
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        private void PrintErrorMessage(string message)
        {
            #region PrintErrorMessage
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        private void GameOver()
        {
            #region GameOver
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Game Over! Puanınız : {score}");
            Console.ForegroundColor = ConsoleColor.White;
            Console.ReadLine();
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private int ConsoleRead(string text)
        {
            #region Console Read
            Console.Write(text);
            return int.Parse(Console.ReadLine());
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        private void AskForDeveloperMode()
        {
            #region AskForDeveloperMode
            Console.WriteLine("Geliştirici modunda açmak ister misiniz e - h");
            string result = Console.ReadLine();
            if (result.ToLower() == "e")
            {
                _IsDeveloper = true;
                Console.WriteLine("---Geliştirici modunda açıldı---");
            }
            if (result.ToLower() == "h")
                _IsDeveloper = false;
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        private void WelcomeToGame()
        {
            #region WelcomeToGame
            Console.ForegroundColor = ConsoleColor.White;
            Place_a_Mine();
            ShowMine();
            Console.WriteLine("Mayın Tarlası Oyuna Hoşgeldiniz!");
            Console.ForegroundColor = ConsoleColor.Yellow;
            PrintField(dataMatrix);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>

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
