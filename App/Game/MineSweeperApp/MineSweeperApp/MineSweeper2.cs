using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperApp
{
    public enum AppType
    {
        ConsoleApp,
        FormApp
    }
    public class Matrix
    {
        public int row;
        public int col;
        public Matrix() { }
        public Matrix(int _row, int _col)
        {
            this.row = _row;
            this.col = _col;
        }
    }
    public partial class MineSweeper
    {
        public MineSweeper(Matrix matrix)
        {
            this._matrix = matrix;

            elemanSayisi = _matrix.row * _matrix.col;
            mineCount = elemanSayisi / 4;
            safeZoneCount = elemanSayisi - mineCount;
            //
            dataMatrix = new string[_matrix.row, _matrix.col];

            mineMatrix = new string[_matrix.row, _matrix.col];
            //
            rndMaxValue = _matrix.row * _matrix.col;

            Seed(dataMatrix);
        }
        private void Seed(string[,] matrix)
        {
            for (int i = 0; i < _matrix.row; i++)
            {
                for (int j = 0; j < _matrix.col; j++)
                {
                    matrix[i, j] = "-";
                }
            }
        }

        public void Run(AppType appType)
        {
            switch (appType)
            {
                case AppType.ConsoleApp:
                    RunConsoleApp();
                    break;
                case AppType.FormApp:
                    RunFormApp();
                    break;
            }
        }

        private void ShowMine()
        {
            Console.WriteLine("Mayınların Konumu");
            Console.ForegroundColor = ConsoleColor.Magenta;
            PrintField(mineMatrix);
            Console.ForegroundColor = ConsoleColor.White;
        }
        private void Place_a_Mine()
        {
            int rndPoint, x = 0, y = 0, index = 0;
            int[] UniqueNumber = new int[mineCount];
            Random rnd = new Random(DateTime.Now.Millisecond);
            //
            for (int i = 0; i < rndMaxValue; i++)
            {

                rndPoint = rnd.Next(rndMaxValue);
                if (!UniqueNumber.Contains(rndPoint))
                {
                    if (index == mineCount)
                        break;
                    UniqueNumber[index] = rndPoint;
                    index++;
                }
            }
            //
            Seed(mineMatrix);
            //
            Console.WriteLine("Mayınların tek boyutta ki konumu : ");
            for (int i = 0; i < UniqueNumber.Length; i++)
            {
                int number = UniqueNumber[i];
                Matrix matrix = GetMatrix(number);
                mineMatrix[matrix.row, matrix.col] = "*";
                Console.WriteLine($"[{matrix.row},{matrix.col}]={number}");
            }
            Console.WriteLine();

        }
        Matrix GetMatrix(int number)
        {
            Matrix matrix = new Matrix();
            int _number = 0;
            for (int row = 0; row < _matrix.row; row++)
            {
                for (int col = 0; col < _matrix.col; col++)
                {
                    if (number == _number)
                    {
                        matrix.row = row;
                        matrix.col = col;
                    }
                    _number++;
                }
            }
            return matrix;
        }

        private void PrintField(string[,] matrix)
        {
            Console.WriteLine();
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                {
                    Console.Write($"{matrix[i, j]} ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        private bool MineControl(Matrix mtrx) => mineMatrix[mtrx.row, mtrx.col] == "*";
        private void DataInput(Matrix matrix, string[,] dataMatrix)
        {
            int count = 0;
            bool[] durumlar =
            {
                Top(matrix),
                Bottom(matrix),
                Left(matrix),
                Right(matrix),
                LeftTop(matrix),
                RightTop(matrix),
                LeftBottom(matrix),
                RightBottom(matrix),
            };
            foreach (var durum in durumlar)
            {
                if (durum)
                    count++;
                    Console.WriteLine(durum); 
            }
            dataMatrix[matrix.row, matrix.col] = count + "";
        }

        private bool Top(Matrix matrix)
        {
            int _row = SmallControl(matrix.row);

            return mineMatrix[_row, matrix.col] == "*";

        }

        private bool Bottom(Matrix matrix)
        {
            int _row = BigControl(matrix.row, _matrix.row);

            return mineMatrix[_row, matrix.col] == "*";
        }

        private bool Right(Matrix matrix)
        {
            int _col = BigControl(matrix.col, _matrix.col);

            return mineMatrix[matrix.row, _col] == "*";
        }
        private bool Left(Matrix matrix)
        {
            int _col = SmallControl(matrix.col);

            return mineMatrix[matrix.row, _col] == "*";
        }
        private bool LeftBottom(Matrix matrix)
        {
            int _col = SmallControl(matrix.col);
            int _row = BigControl(matrix.row, _matrix.row);
            return mineMatrix[_row, _col] == "*";
        }
        private bool RightBottom(Matrix matrix)
        {
            int _col = BigControl(matrix.col, _matrix.col);
            int _row = BigControl(matrix.row, _matrix.row);
            return mineMatrix[_row, _col] == "*";
        }
        private bool LeftTop(Matrix matrix)
        {
            int _col = SmallControl(matrix.col);
            int _row = SmallControl(matrix.row);
            return mineMatrix[_row, _col] == "*";
        }
        private bool RightTop(Matrix matrix)
        {
            int _col = BigControl(matrix.col, _matrix.col);
            int _row = SmallControl(matrix.row);
            return mineMatrix[_row, _col] == "*";
        }

        private int SmallControl(int i)
            => (i - 1 <= 0) ? 0 : i - 1;
        
        private int BigControl(int i, int maxValue)
            => (i + 1 >= maxValue) ? maxValue : i + 1;
        
    }
}
