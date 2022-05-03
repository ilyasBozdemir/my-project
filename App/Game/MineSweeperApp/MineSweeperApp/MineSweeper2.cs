using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperApp
{
    public enum AppType
    {
        #region AppType
        ConsoleApp,
        FormApp
        #endregion
    }
    public class Matrix
    {
        #region Region Fields
        public int row;
        public int col;
        #endregion
        public Matrix() { }
        public Matrix(int _row, int _col)
        {
            #region Matrix
            this.row = _row;
            this.col = _col;
            #endregion
        }
    }
    #region class MineSweeper
    public partial class MineSweeper
    {
        #region Region Fields
        private Matrix _matrix;
        bool _IsDeveloper;
        private int elemanSayisi,
                    mineCount,
                    safeZoneCount,
                    rndMaxValue,
                    inputRow,
                    inputCol,
                    score = 0,
                    counter = 0,
                    remainingNumber = 0;
        private string brace = "===========================";
        private string[,] dataMatrix,
                          mineMatrix;
        #endregion
        public MineSweeper(Matrix matrix)//kurucu method ile ön tanımlamalar ayağa kaldırılıyor.
        {
            #region MineSweeper
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
            #endregion
        }
        private void Seed(string[,] matrix)//matrixleri besleme alanı
        {
            #region Region Seed
            for (int i = 0; i < _matrix.row; i++)
            {
                for (int j = 0; j < _matrix.col; j++)
                {
                    matrix[i, j] = "-";
                }
            }
            #endregion
        }

        public void Run(AppType appType)
        {
            #region Region Run
            switch (appType)
            {
                case AppType.ConsoleApp:
                    RunConsoleApp();
                    break;
                case AppType.FormApp:
                    RunFormApp();
                    break;
            }
            #endregion
        }

        private void ShowMine()
        {
            #region ShowMine
            if (_IsDeveloper)
            {
                Console.WriteLine("Mayınların Konumu");
                Console.ForegroundColor = ConsoleColor.Magenta;
                PrintField(mineMatrix);
                Console.ForegroundColor = ConsoleColor.White;
            }
            #endregion
        }

        private int GetScore(int counter) => (counter - 1) * 10;

        private void Place_a_Mine()
        {
            #region Region Place a Mine
            int rndPoint, index = 0;
            int[] UniqueNumber = new int[mineCount];
            Random rnd = new Random(DateTime.Now.Millisecond);
            #region Unique number designation
            for (int i = 0; i < rndMaxValue; i++)//maksat aynı sayılar üretilmesinin önüne geçmek
            {// o yüzden satır sütun çarpımı kadar random sayı aldık
                rndPoint = rnd.Next(rndMaxValue);
                if (!UniqueNumber.Contains(rndPoint))
                {
                    if (index == mineCount)
                        break;
                    UniqueNumber[index] = rndPoint;
                    index++;
                }
            } 
            #endregion
            //
            Seed(mineMatrix);//tümüne '-' ekleme işi
            //
            if (_IsDeveloper)
            {
                Console.Clear();
                Console.WriteLine("Mayınların konumu : ");
            }
            for (int i = 0; i < UniqueNumber.Length; i++)
            {
                int number = UniqueNumber[i];
                Matrix matrix = GetNumberToMatrix(number);
                mineMatrix[matrix.row, matrix.col] = "*";//mayın olanlara '*' ekleme işi
                if (_IsDeveloper)
                    Console.WriteLine($"[{matrix.row},{matrix.col}] = {number}");
            }
            Console.WriteLine();
            #endregion
        }
        Matrix GetNumberToMatrix(int number)
        {
            #region Get Number to Matrix
            //örnek 10 sayısını satır sütunu belli olan tabloda ki satır sütun karşılıgını alıyoruz.
            int _number = 0, _row = 0, _col = 0;
            for (int row = 0; row < _matrix.row; row++)
                for (int col = 0; col < _matrix.col; col++)
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
        private string GetMatrix(string[,] matrix)
        {
            StringBuilder sb = new StringBuilder();

            return sb.ToString();
        }
        private void PrintField(string matrix)
        {
            Console.WriteLine();
            Console.Write($"{matrix} ");
            Console.WriteLine();
        }

        private void PrintField(string[,] matrix)
        {
            #region print field
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
            #endregion
        }

        private bool MineControl(Matrix mtrx) => mineMatrix[mtrx.row, mtrx.col] == "*";

        private void DataInput(Matrix matrix, string[,] dataMatrix)
           => dataMatrix[matrix.row, matrix.col] = CheckPoint(matrix, dataMatrix).ToString();

        private int CheckPoint(Matrix matrix, string[,] dataMatrix)
        {
            #region CheckPoint
            //bu method seçilen satır sütunda odan küçük ve max değerden fazla değer olma durumlarını
            //ve de sağ-sol-yukarı-aşağı-çapraz birimlerde mayın kontrolü yapılmaktadır.
            int count = 0, x = matrix.row, y = matrix.col;

            if (true)
            {

            }

            return count;
            #endregion
        }
    }
    #endregion
}
