namespace TicTacToe
{
    internal class GameApp
    {
        private Matrix _matrixLength;
        private Player _player1, _player2;
        private string _gameAreaChar = "-";
        private string[,] _gameAreaMatrix;
        private int inputRow,
                    inputCol,
                    counter = 0;
        private bool _state;
        private string brace = "===========================";
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
                Player mevcutOyuncu = (counter % 2 == 0) ? _player1 : _player2;
                Console.WriteLine(brace);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Sıra {mevcutOyuncu.Name}'de");
                Console.WriteLine($"İşareti : {mevcutOyuncu.Sign}");
                Console.ForegroundColor = ConsoleColor.White;
                Matrix mtrx = GetRowCol();

                if (RestrictData(mtrx))
                {
                    if (CheckInput(mtrx, _gameAreaMatrix))
                    {
                        DataInput(mtrx, mevcutOyuncu.Sign, _gameAreaMatrix);
                        counter++; 
                        GetGameArea();
                    }
                    else
                        PrintErrorMessage("Zaten bu hücreyi daha önce seçtiniz\nTekrar seçim yapın.");

                    Console.WriteLine(brace);
                }
                else
                    PrintErrorMessage("Dizi boyutundan büyük sayı veya dizi boyutundan küçük bir sayı girdiniz.");

            } while (_matrixLength.row * _matrixLength.col != counter);
                
            #endregion

        }

        private bool CheckInput(Matrix matrix, string[,] gameAreaMatrix)
        {
            return gameAreaMatrix[matrix.row, matrix.col] == _gameAreaChar;
        }

        public void DataInput(Matrix matrix, Sign sign, string[,] gameAreaMatrix)
        {
            gameAreaMatrix[matrix.row, matrix.col] = sign.ToString();
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

        private void GameOver()
        {
            #region GameOver
            Console.ForegroundColor = ConsoleColor.Red;

            //Console.WriteLine($"Game Over! Puanınız : {score}");

            Console.ForegroundColor = ConsoleColor.White;
            Console.Read();
            IsNewGame();
            #endregion
        }

        private void IsNewGame()
        {
        
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