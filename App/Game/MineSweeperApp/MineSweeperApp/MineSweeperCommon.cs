using MineSweeperApp.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperApp
{
    /// <summary>
    /// burası hem console hem form platformu için ortak olan methodları barındırır.
    /// </summary>

    public partial class MineSweeper
    {
        /// <summary>
        /// oyun alanının 
        /// satır sütun temsil eden matrix değerleri alır.
        /// ve bu matrix değerinin içerisini doldurur.
        /// </summary>
        /// <param name="matrix">
        /// matrix değerinin maksimum row,col değerine kadar varsayılan oyun alanı olarak
        /// '-' karakteri ile besler
        /// </param>
        public void Seed(string[,] matrix)
        {
            #region Region Seed
            for (int i = 0; i < _matrixLength.row; i++)
            {
                for (int j = 0; j < _matrixLength.col; j++)
                {
                    matrix[i, j] = minelessShadowChar;
                }
            }
            #endregion
        }
        /// <summary>
        /// çift boyutlu matrix dizisini alır. Tek boyutlu metine çevirir.
        /// <seealso cref="matrix"/>
        /// </summary>
        /// <param name="matrix">cift boyutlu diziyi temsil eden matrix dizisi</param>
        /// <returns>
        /// Tek boyutlu olarak metinsel ifade döndürür.
        /// </returns>
        public string GetMatrix(string[,] matrix)
        {
            #region GetMatrix
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i <= matrix.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= matrix.GetUpperBound(1); j++)
                    sb.Append($"{matrix[i, j]} ");
                sb.AppendLine();
            }
            return sb.ToString();
            #endregion
        }
        /// <summary>
        /// bu alan kullanıcın seçtiği alanda mayın kontrolünü yapmaktadır
        /// </summary>
        /// <param name="mtrx">
        /// kullanıcın seçtiği alanı temsil eden matrix(row,col) yapısı
        /// </param>
        /// <returns>
        /// mayın varsa true, mayın yoksa false döner.
        /// </returns>
        public bool MineControl(Matrix mtrx) => mineMatrix[mtrx.row, mtrx.col] == mineChar;

        /// <summary>
        /// Bir nevi tek boyutlu sayıyı çift boyutlu sayıya çevirmek için yazılmıştır.
        /// </summary>
        /// <param name="number">
        /// number değeri 0 ile matrix'in satır ve sütun sayısı carpımı arasında bir değer alır.
        /// </param>
        /// <returns>
        /// parametre olarak aldığı sayıyı matrix'in satır ve sütundaki karşılığına çevirir.
        /// </returns>
        public Matrix GetNumberToMatrix(int number)
        {
            #region Get Number to Matrix
            //örnek 10 sayısını satır sütunu belli olan tabloda ki satır sütun karşılıgını alıyoruz.
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
        /// <summary>
        /// bu method kullanıcının ilerlemesini temsil eden bir sayı alır.
        /// puan bazında işler ve geri döndürür.
        /// </summary>
        /// <param name="counter">
        /// oyun ilerlemesini temsil eden sayı alır
        /// </param>
        /// <param name="coefficient">
        /// katsayı olarak bir sayı alır. verilmesi zorunlu değildir.
        /// varsayılan olarak 10 verilmiştir.
        /// değer vererek bu varsayılan değeri ezebiliriz.
        /// </param>
        /// <returns>
        ///Puan olarak counter ve coefficient parametrelerinin sonucu döndürür.
        /// </returns>
        public int GetScore(int counter, int coefficient = 10) => (counter + 1) * coefficient;

        /// <summary>
        /// bu alan ekranda mayınların konumu göstermek içindir.
        /// </summary>
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

        /// <summary>
        /// bu alanda ise rastgele konumlarak mayın yerleştirme işlemi yapılmaktadır.
        /// </summary>
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
                mineMatrix[matrix.row, matrix.col] = mineChar;//mayın olanlara '*' ekleme işi
                if (_IsDeveloper)
                    Console.WriteLine($"[{matrix.row},{matrix.col}] = {number}");
            }
            Console.WriteLine();
            #endregion
        }

        /// <summary>
        /// bu method kullanıcının seçtiği row,col değerine 1 birim çevresinde ki
        /// mayınların sayısını seçilen alana yazdırmak için kullanılmaktadır.
        /// </summary>
        /// <param name="matrix">
        /// kullanıcının seçtiği matrix(row,col) değeri
        /// </param>
        /// <param name="dataMatrix">
        /// oyun matrixinde ki alana mayın sayısını eklemek adına.
        /// </param>
        public void DataInput(Matrix matrix, string[,] dataMatrix, out bool state)
        {
            state = dataMatrix[matrix.row, matrix.col] == minelessShadowChar;
            dataMatrix[matrix.row, matrix.col] = CheckPoint(matrix).ToString();
        }


        /// <summary>
        /// seçilen birimin  komsularında mayın var mı yok mu kontrolunu yapar
        /// mayın yoksa 0 döner varsa mayın sayısını geri döner.
        /// </summary>
        /// 
        /// // example
        /// int row = 4, col = 4;
        /// string[,] mineMatrix = new string[row, col];
        /// string mineChar = "*", minelessChar = "-";
        /// for (int i = 0; i < row; i++)
        /// {
        ///     for (int j = 0; j < col; j++)
        ///     {
        ///         mineMatrix[i, j] = minelessChar;
        ///     }
        /// }   
        /// 
        /// mineMatrix[0, 0] = mineChar;
        /// mineMatrix[0, 2] = mineChar;
        /// mineMatrix[2, 1] = mineChar;
        /// mineMatrix[1, 2] = mineChar;
        /// mineMatrix[2, 3] = mineChar;
        /// 
        /// Console.WriteLine(count);// 3 yazar
        /// var count = checkPoint(1, 1)
        /// 
        /// <seealso cref="CheckPoint"/>
        ///[0,0][0,1][0,2][0,3]
        ///[1,0][1,1][1,2][1,3]
        ///[2,0][2,1][2,2][2,3]
        ///[3,0][3,1][3,2][3,3]
        ///
        /// 
        ///  * - * -
        ///  - x - -
        ///  - * - *
        ///  - - - -
        ///  
        ///  x = 3
        /// 
        /// <param name="point">x,y temsil eden matrix sınıfından nesne alır.</param>
        /// <returns>Geriye mayın adedini döner</returns>
        int CheckPoint(Matrix selectedMatrix)
        {
            #region CheckPoint
            ///  bu method asagıda ki örneği yapmaktadır.
            ///  ornek 4*4 matrixte olmaktadır.
            ///  
            ///   * - * -
            ///   - x - -
            ///   - * - *
            ///   - - - -
            ///  
            ///   x = ? (3)
            ///  
            ///  --Sonuç--
            ///    * - * -
            ///    - 3 - -
            ///    - * - *
            ///    - - - -
            /// 
            int mineCount = 0;

          
            Matrix[] matrices =
            {
                MatrixDirections(selectedMatrix,Directions.top),
                MatrixDirections(selectedMatrix,Directions.bottom),
                MatrixDirections(selectedMatrix,Directions.left),
                MatrixDirections(selectedMatrix,Directions.right),
                MatrixDirections(selectedMatrix,Directions.topLeft),
                MatrixDirections(selectedMatrix,Directions.topRight),
                MatrixDirections(selectedMatrix,Directions.bottomLeft),
                MatrixDirections(selectedMatrix,Directions.bottomRight)
            };

            for (int i = 0; i < matrices.Length; i++)
            {
                Matrix controlMatrix = matrices[i];
                if (RestrictData(controlMatrix))
                    if (MineControl(controlMatrix))
                    {
                        mineCount++;
                        if (_IsDeveloper)
                            Console.WriteLine($"[{(Directions)i}] = {true}");
                    }
            }
            return mineCount;
            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="top"></param>
        /// <returns></returns>
        /// <exception cref="NotImplementedException"></exception>
        private Matrix MatrixDirections(Matrix selectedMatrix, Directions direction)
        {   //bu method geliştirilip satranc altyapısında kullanılabilir.
            #region MatrixDirections
            int x = selectedMatrix.row, y = selectedMatrix.col;
            Matrix controlMatrix;
            switch (direction)
            {
                case Directions.top: controlMatrix = new Matrix(x - 1, y); break;
                case Directions.bottom: controlMatrix = new Matrix(x + 1, y); break;
                case Directions.left: controlMatrix = new Matrix(x, y - 1); break;
                case Directions.right: controlMatrix = new Matrix(x, y + 1); break;
                case Directions.topLeft: controlMatrix = new Matrix(x - 1, y - 1); break;
                case Directions.topRight: controlMatrix = new Matrix(x - 1, y + 1); break;
                case Directions.bottomLeft: controlMatrix = new Matrix(x + 1, y - 1); break;
                case Directions.bottomRight: controlMatrix = new Matrix(x + 1, y + 1); break;
                default: controlMatrix = new Matrix(); break;
            }
            return controlMatrix;

            #endregion
        }

        /// <summary>
        /// 
        /// </summary>
        private void NewGame()
        {
            RunConsoleApp();
        }


        /// <summary>
        /// verilen matrix değerinin matrix sınırları içinde olup olmadığını sorgular
        /// </summary>
        /// <param name="mtrx">satır ,sütun temsil eden matrix nesnesi alır.</param>
        /// <returns>Matrix değeri geçerli ise True, değilse False döner.</returns>
        public bool RestrictData(Matrix matrix)
        {
            #region RestrictData

            return matrix.col < _matrixLength.col
                && matrix.row < _matrixLength.row
                && matrix.row >= 0
                && matrix.col >= 0;

            #endregion
        }
    }
}
