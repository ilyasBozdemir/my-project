namespace TicTacToe
{
    internal class GameApp
    {
        private Matrix _matrixLength;
        private Player _player1, _player2, currentPlayer;
        private string _gameAreaChar = "-";
        private string[,] _gameAreaMatrix;
        private int inputRow,
                    inputCol,
                    counter = 0;
        private string brace = ">>>>>>>>>>>>>>>>>>>>>>>>>>>";
        public GameApp(Player player1, Player player2)
        {
            this._player1 = player1;
            this._player2 = player2;
            Console.ForegroundColor = ConsoleColor.White;
            _matrixLength = new Matrix(3, 3);
        }



        public void Start()
        {
            #region Start

            SetGameArea();
            //
            GetGameArea();

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
            int count = 0;

            /*
             * 0,0 0,1 0,2
             * 1,0 1,1 1,2
             * 2,0 2,1 2,2
             * 
             */
            int RowIndex = 0,
                ColumnIndex = 0;

            #region satır kontrolü

            for (int i = 0; i <= _gameAreaMatrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= _gameAreaMatrix.GetUpperBound(1); j++)
                {
                    if (_gameAreaMatrix[RowIndex, j] == currentPlayer.Sign + "")
                    {
                        count++;
                        if (count == 3)
                            return true;
                    }


                }
                RowIndex += 1;
            }
            count = 0;
            #endregion

            #region sütun kontrolü

            for (int i = 0; i <= _gameAreaMatrix.GetUpperBound(1); i++)
            {
                for (int j = 0; j <= _gameAreaMatrix.GetUpperBound(0); j++)
                {
                    if (_gameAreaMatrix[ColumnIndex, j] == currentPlayer.Sign + "")
                    {
                        count++;
                        if (count == 3)
                            return true;
                    }
                }
                ColumnIndex += 1;
            }
            count = 0;
            #endregion

            #region capraz kontrolü


            Matrix[] data = { new Matrix(0, 0), new Matrix(1, 1), new Matrix(2, 2) };
            //data sol üsten sağ alt için
            Matrix[] data2 = { new Matrix(0, 2), new Matrix(1, 1), new Matrix(2, 0) };
            //data sağ üsten sol alt için


            for (int i = 0; i <= _gameAreaMatrix.GetUpperBound(1); i++)
                for (int j = 0; j <= _gameAreaMatrix.GetUpperBound(0); j++)
                    if (i == 1 && j == 1)
                        if (CheckControl(i, j))
                            count++;
            if (count == 3)
                return true;
            //

            count = 0;

            const int row = 1, col = 1;

            RowIndex = row - 1;
            ColumnIndex = col + 1;
            count = CheckControl(RowIndex, ColumnIndex) ? count + 1 : count;
            RowIndex = row;
            ColumnIndex = col;
            count = CheckControl(RowIndex, ColumnIndex) ? count + 1 : count;
            RowIndex = row - 1;
            ColumnIndex = col - 1;
            count = CheckControl(RowIndex, ColumnIndex) ? count + 1 : count;

            if (count == 3)
                return true;
            #endregion

            return false;
        }

        private bool CheckControl(int rowIndex, int columnIndex)
        {
            return (_gameAreaMatrix[rowIndex, columnIndex] == currentPlayer.Sign + "");
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
            Console.Read();
            IsNewGame();
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