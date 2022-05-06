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
        private int[] uniqueNumber;
        private Matrix _matrixLength;
        bool _IsDeveloper = false,
             _state = false;
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
        private string[,] minelessMatrix,
                          mineMatrix;
        private string mineChar = "*", minelessShadowChar = "-";
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
            this._matrixLength = matrix;
            elemanSayisi = _matrixLength.row * _matrixLength.col;
            mineCount = elemanSayisi / 4;
            safeZoneCount = elemanSayisi - mineCount;
            //
            minelessMatrix = new string[_matrixLength.row, _matrixLength.col];
            mineMatrix = new string[_matrixLength.row, _matrixLength.col];
            //
            rndMaxValue = _matrixLength.row * _matrixLength.col;
            Seed(minelessMatrix);
            #endregion
        }
    }
}