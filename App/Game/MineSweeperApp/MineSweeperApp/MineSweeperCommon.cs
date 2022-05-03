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
            for (int i = 0; i < _matrix.row; i++)
            {
                for (int j = 0; j < _matrix.col; j++)
                {
                    matrix[i, j] = "-";
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
        private bool MineControl(Matrix mtrx) => mineMatrix[mtrx.row, mtrx.col] == "*";
               
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
        private int GetScore(int counter, int coefficient = 10) => (counter) * coefficient;

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
                mineMatrix[matrix.row, matrix.col] = "*";//mayın olanlara '*' ekleme işi
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
        private void DataInput(Matrix matrix, string[,] dataMatrix)
           => dataMatrix[matrix.row, matrix.col] = CheckPoint(matrix, dataMatrix).ToString();


        /// <summary>
        /// <seealso cref="DataInput(Matrix, string[,])"/> methodunu yardımcı methodu olması için yazılmıştır.
        /// Bu method seçilen satır sütunda odan küçük ve max değerden fazla değer olma durumlarını
        /// ve de sağ-sol-yukarı-aşağı-çapraz birimlerde mayın kontrolü yapılmaktadır.
        /// </summary>
        /// <param name="matrix">
        /// ikinci paramtrede ki matrix'te kontrol sağlamak için matrix(row,col) değerini alır. 
        /// </param>
        /// <param name="dataMatrix">
        /// oyun alanını temsil eden matrix yapısını alır.
        /// </param>
        /// <returns>
        /// Seçilen bölgede mayın yoksa mayın sayısını döndürür.
        /// </returns>
        private int CheckPoint(Matrix matrix, string[,] dataMatrix)
        {
            #region CheckPoint
            int count = 0, _row = matrix.row, _col = matrix.col;
            bool[] durumlar = { Top(matrix, dataMatrix), Bottom(matrix, dataMatrix), Left(matrix, dataMatrix), Right(matrix, dataMatrix), LeftTop(matrix, dataMatrix), RightTop(matrix, dataMatrix), LeftBottom(matrix, dataMatrix), RightBottom(matrix, dataMatrix) };
            string[] yonler = { $"Top({_row},{_col})", $"Bottom({_row},{_col})", $"Left({_row},{_col})", $"Right({_row},{_col})", $"LeftTop({_row},{_col})", $"RightTop({_row},{_col})", $"LeftBottom({_row},{_col})", $"RightBottom({_row},{_col})" };
            for (int i = 0; i < durumlar.Length; i++)
            {
                string yon = yonler[i];
                bool durum = durumlar[i];
                if (durumlar[i])
                    count++;
                if (_IsDeveloper)
                    Console.WriteLine($"{yon} : {durum}");
            }
            return count;
            #endregion
        }
        private bool Top(Matrix matrix, string[,] dataMatrix)
        {
            
            if (true)
            {

            }
            return false;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="matrix"></param>
        /// <param name="dataMatrix"></param>
        /// <returns></returns>
        private bool Bottom(Matrix matrix, string[,] dataMatrix)
        {
            return false;
        }
        private bool Left(Matrix matrix, string[,] dataMatrix)
        {
            return false;
        }
        private bool Right(Matrix matrix, string[,] dataMatrix)
        {
            return false;
        }
        private bool LeftTop(Matrix matrix, string[,] dataMatrix)
        {
            return false;
        }
        private bool RightTop(Matrix matrix, string[,] dataMatrix)
        {
            return false;
        }
        private bool LeftBottom(Matrix matrix, string[,] dataMatrix)
        {
            return false;
        }
        private bool RightBottom(Matrix matrix, string[,] dataMatrix)
        {
            return false;
        }
       

        /// <summary>
        /// bir eksiğinin 0dan küçük olup olmadığını temsil eden methoddur.
        /// </summary>
        /// <param name="i"> 
        /// /// sayıyı alır sayının bir eksiği 0 veya 0'dan küçükse
        /// geriye 0 döndürür.değilse sayının -1 değerini döndürür.
        /// </param>
        /// <returns>
        /// verilen sayının 0 ve 0'dan büyük olcak şekilde geriye bir eksiğini döndürür.
        /// </returns>
        private int SmallControl(int i)
         => (i - 1 <= 0) ? 0 : i - 1;

        /// <summary>
        /// bir fazlasının ikinci parametredeki sayıdan büyük olma durumu 
        /// kontrol eden methoddur.
        /// </summary>
        /// <param name="i">
        /// sayı alır ve ikinci parametreye göre kontrolü yapılır.
        /// </param>
        /// <param name="maxValue">
        /// maximum sayının sınırını temsil eden sayı alır
        /// </param>
        /// <returns>
        /// sayıyı alır sayının bir fazlası maxValue veya maxValue'dan büyükse
        /// geriye maxValue döndürür.değilse sayının +1 değerini döndürür. 
        /// </returns>
        private int BigControl(int i, int maxValue)
            => (i + 1 >= maxValue) ? maxValue : i + 1;

    }
}
