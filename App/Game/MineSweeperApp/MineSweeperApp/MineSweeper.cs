namespace MineSweeperApp
{
    ///<author>
    ///ilyas bozdemir
    ///</author>

    ///<summary>
    ///burası kurucu methodun ve field'ların olduğu olduğu kısmi sınıftır.
    ///</summary>

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

        /// <summary>
        /// MineSweeper sınıfı bir mayın tarlası oyununu temsil eden sınıftır.
        /// </summary>
        /// <param name="matrix">
        /// matrix değeri row,col adedini belirler oyun alanını büyüklüğünü temsilen
        /// </param>
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
    }
}