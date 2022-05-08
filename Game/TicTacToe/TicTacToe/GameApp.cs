namespace TicTacToe
{
    public class GameApp
    {
        private Matrix _matrixLength;
        private Player _player1, _player2, currentPlayer;
        private string _gameAreaChar = "-";
        private string[,] _gameAreaMatrix;
        private int inputRow, inputCol, counter = 0;
        private string brace = "---------------------------";

        public GameApp(Player player1, Player player2)
        {
            this._player1 = player1;
            this._player2 = player2;
            currentPlayer = _player1;
            Console.ForegroundColor = ConsoleColor.White;
            _matrixLength = new Matrix(3, 3);
        }
        public void Start()
        {
            #region Start

            SetGameArea();
            //
            GetGameArea();
            //
            counter = 0;//yeni oyunda sayacı sıfırlamak için.
            do
            {
                currentPlayer = (counter % 2 == 0) ? _player1 : _player2;

                Console.WriteLine(brace);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Sıra {currentPlayer.Name}'de | İşareti : {currentPlayer.Sign}");
                Console.ForegroundColor = ConsoleColor.White;
                Matrix mtrx = GetRowCol();

                if (RestrictData(mtrx))
                {
                    if (CheckInput(mtrx, _gameAreaMatrix))
                    {
                        DataInput(mtrx, currentPlayer.Sign, _gameAreaMatrix);
                        counter++;
                        if (IsWinPlayer(currentPlayer))
                        {
                            GetGameArea();
                            currentPlayer.AddScore();
                            GameOver(currentPlayer);
                        }
                        Console.Clear();
                        GetGameArea();
                    }
                    else
                    {
                        PrintErrorMessage("Zaten bu hücreyi daha önce seçtiniz\nTekrar seçim yapın.");
                    }
                }
                else
                {
                    PrintErrorMessage("Dizi boyutundan büyük sayı veya dizi boyutundan küçük bir sayı girdiniz.");
                }

            } while (_matrixLength.row * _matrixLength.col != counter);

            #endregion
        }

        private bool IsWinPlayer(Player currentPlayer)
        {
            //döngü ve karar yapıları ile de yapılabilir. 9 hücre olduğu için böyle yazdım.
            #region IsWinPlayer
            /* 
             * 0,0 0,1 0,2 ** 0 1 2
             * 1,0 1,1 1,2 ** 3 4 5
             * 2,0 2,1 2,2 ** 6 7 8
             */
            #region cozum 1

            #region satır kontrol

            Matrix[] Row1 = { GetNumberToMatrix(0), GetNumberToMatrix(1), GetNumberToMatrix(2) };
            Matrix[] Row2 = { GetNumberToMatrix(3), GetNumberToMatrix(4), GetNumberToMatrix(5) };
            Matrix[] Row3 = { GetNumberToMatrix(6), GetNumberToMatrix(7), GetNumberToMatrix(8) };

            bool durum = CheckControl(Row1[0]) && CheckControl(Row1[1]) && CheckControl(Row1[2]);
            bool durum2 = CheckControl(Row2[0]) && CheckControl(Row2[1]) && CheckControl(Row2[2]);
            bool durum3 = CheckControl(Row3[0]) && CheckControl(Row3[1]) && CheckControl(Row3[2]);
            if (durum || durum2 || durum3)
            {
                return true;
            }
       
            #endregion

            #region sütun kontrol

            Matrix[] Column1 = { GetNumberToMatrix(0), GetNumberToMatrix(3), GetNumberToMatrix(6) };
            Matrix[] Column2 = { GetNumberToMatrix(1), GetNumberToMatrix(4), GetNumberToMatrix(7) };
            Matrix[] Column3 = { GetNumberToMatrix(2), GetNumberToMatrix(5), GetNumberToMatrix(8) };
            
            bool durum4 = CheckControl(Column1[0]) && CheckControl(Column1[1]) && CheckControl(Column1[2]);
            bool durum5 = CheckControl(Column2[0]) && CheckControl(Column2[1]) && CheckControl(Column2[2]);
            bool durum6 = CheckControl(Column3[0]) && CheckControl(Column3[1]) && CheckControl(Column3[2]);
          
            if (durum4 || durum5 || durum6)
            {
                return true;
            }
           
            #endregion

            #region caprazlama kontrol

            Matrix[] Cross1 = { GetNumberToMatrix(0), GetNumberToMatrix(4), GetNumberToMatrix(8) };
            Matrix[] Cross2 = { GetNumberToMatrix(2), GetNumberToMatrix(4), GetNumberToMatrix(6) };
            bool durum7 = CheckControl(Cross1[0]) && CheckControl(Cross1[1]) && CheckControl(Cross1[2]);
            bool durum8 = CheckControl(Cross2[0]) && CheckControl(Cross2[1]) && CheckControl(Cross2[2]);
            if (durum7 || durum8)
            {
                return true;
            }
            #endregion 

            #endregion

            #region cozum 2
           
            #endregion
       


            return false;
            #endregion
        }
        public Matrix GetNumberToMatrix(int number)
        {
            #region Get Number to Matrix
            int _number = 0, _row = 0, _col = 0;
            for (int row = 0; row < _matrixLength.row; row++)
                for (int col = 0; col < _matrixLength.col; col++)
                {
                    if (number == _number)
                    {
                        _row = row;
                        _col = col;
                    }
                    _number++;
                }
            return new Matrix(_row, _col);
            #endregion
        }
        private bool CheckControl(Matrix matrix)
        {
            #region CheckControl

            int rowIndex = matrix.row, columnIndex = matrix.col;
            return (_gameAreaMatrix[rowIndex, columnIndex] == currentPlayer.Sign + "");

            #endregion
        }
        private bool CheckInput(Matrix matrix, string[,] gameAreaMatrix)
        {
            #region CheckInput

            return gameAreaMatrix[matrix.row, matrix.col] == _gameAreaChar;

            #endregion
        }
        public void DataInput(Matrix matrix, Sign sign, string[,] gameAreaMatrix)
        {
            #region DataInput

            gameAreaMatrix[matrix.row, matrix.col] = sign.ToString();

            #endregion
        }
        private bool RestrictData(Matrix matrix)
        {
            #region RestrictData

            return matrix.col < _matrixLength.col
                && matrix.row < _matrixLength.row
                && matrix.row >= 0
                && matrix.col >= 0;

            #endregion
        }
        private void GameOver(Player WinnerPlayer)
        {
            #region GameOver
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine($"Game Over! {currentPlayer.Name} Kazandı."
                + $"Durum  {_player1.Score} - {_player2.Score}");

            Console.ForegroundColor = ConsoleColor.White;
            IsNewGame();
            Console.Read();
            #endregion
        }
        private void IsNewGame()
        {
            #region IsNewGame

            Console.Write("Yeni oyun için 'N' harfine basınız.");
            var result = Console.ReadLine();
            if (result.ToLower() == "n")
                Start();
            else
                Console.WriteLine("Çıkmak için herhangi bir tuşa basın.");

            #endregion
        }
        private void PrintErrorMessage(string message)
        {
            #region PrintErrorMessage
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
            #endregion
        }
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
        private int ConsoleRead(string text)
        {
            #region Console Read

            Console.Write(text);
            return int.Parse(Console.ReadLine());

            #endregion
        }
        private void GetGameArea()
        {
            #region get game area 
            Console.ForegroundColor = ConsoleColor.Cyan;
            //
            for (int i = 0; i <= _gameAreaMatrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= _gameAreaMatrix.GetUpperBound(1); j++)
                {
                    Console.Write($"{_gameAreaMatrix[i, j]} ");
                }
                Console.WriteLine();
            }

            Console.ForegroundColor = ConsoleColor.White;

            #endregion
        }
        private void SetGameArea()
        {
            #region set game area 

            _gameAreaMatrix = new string[_matrixLength.row, _matrixLength.col];

            for (int i = 0; i <= _gameAreaMatrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= _gameAreaMatrix.GetUpperBound(1); j++)
                {
                    _gameAreaMatrix[i, j] = _gameAreaChar;
                }
            }


            #endregion
        }
    }
}
