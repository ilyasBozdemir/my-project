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
        private void Seed(string[,] matrix)
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
        private string GetMatrix(string[,] matrix)
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
        private bool MineControl(Matrix mtrx) => mineMatrix[mtrx.row, mtrx.col] == mineChar;

        /// <summary>
        /// Bir nevi tek boyutlu sayıyı çift boyutlu sayıya çevirmek için yazılmıştır.
        /// </summary>
        /// <param name="number">
        /// number değeri 0 ile matrix'in satır ve sütun sayısı carpımı arasında bir değer alır.
        /// </param>
        /// <returns>
        /// parametre olarak aldığı sayıyı matrix'in satır ve sütundaki karşılığına çevirir.
        /// </returns>
        Matrix GetNumberToMatrix(int number)
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
        private int GetScore(int counter, int coefficient = 10) => (counter + 1) * coefficient;

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
        private void DataInput(Matrix matrix, string[,] dataMatrix, out bool state)
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
        /// <param name="matrix">x,y temsil eden matrix sınıfından nesne alır.</param>
        /// <returns>Geriye mayın adedini döner</returns>
        int CheckPoint(Matrix matrix)
        {
            #region CheckPoint

            int mineCount = 0;//bulunan mayın sayısı

            bool top = false, bottom = false, left = false, right = false,
                 topLeft = false, topRight = false, bottomLeft = false, bottomRight = false;

            Matrix controlMatrix = new Matrix(); 
            ///  * - * -
            ///  - x - -
            ///  - * - *
            ///  - - - -
            ///  
            ///  x = ? (3)
            ///  

            bool[] states = { top, bottom, left, right, topLeft, topRight, bottomLeft, bottomRight };
            string[] directions = { "top", "bottom", "left", "right", "top Left", "top Right", "bottom Left", "bottom Right" };


            for (int i = 0; i < states.Length; i++)
            {
                if (RestrictData(controlMatrix))
                {
                    if (MineControl(controlMatrix))
                    {
                        mineCount++;
                        states[i] = true;
                    }
                }
            }
         
            #region _IsDeveloper 
            if (_IsDeveloper)
                for (int i = 0; i < states.Length; i++)
                    Console.WriteLine($"[{directions[i].ToLower()}] = {states[i]}");

            #endregion

            return mineCount;
            #endregion
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="mtrx"></param>
        /// <returns></returns>
        private bool RestrictData(Matrix mtrx)
        {
            #region RestrictData

            return mtrx.col < _matrixLength.col
                && mtrx.row < _matrixLength.row
                && mtrx.row >= 0
                && mtrx.col >= 0;

            #endregion
        }
    }
}
