using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MineSweeperApp
{ 
    /// <summary>
    /// form uygulaması için ki kısım classtır
    /// </summary>
    ///  
    public partial class MineSweeper
    {
        #region Encapsulation 
        public int[] UniqueNumber
        {
            get { return uniqueNumber; }
            set { uniqueNumber = value; }
        }
        public bool _State
        {
            get { return _state; }
        }
        public string MineChar
        {
            get { return mineChar; }
        }
        public string MinelessShadowChar
        {
            get { return minelessShadowChar; }
        }
        public int ElemanSayisi
        {
            get { return elemanSayisi; }
        }
        public int RemainingNumber
        {
            get { return remainingNumber; }
        }
        public int MineCount
        {
            get { return mineCount; }
        }
        public int SafeZoneCount
        {
            get { return safeZoneCount; }
            set { safeZoneCount = value; }
        }
        public int Counter
        {
            get { return counter; }
            set { counter = value; }
        }
        public int Score
        {
            get { return score; }
            set { score = value; }
        }
        public string[,] MinelessMatrix
        {
            get { return minelessMatrix; }
        }
        public string[,] MineMatrix
        {
            get { return mineMatrix; }
        }

        #endregion


        /// <summary>
        /// 
        /// </summary>//out string[,] minelessMatrix, mineMatrix
        public void RunFormApp()
        {
            #region Run Form App

            Seed(minelessMatrix);
            Place_a_Mine();
            
            #endregion
        }
        
    }
}
