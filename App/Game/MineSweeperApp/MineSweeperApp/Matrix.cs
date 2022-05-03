using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MineSweeperApp
{
    /// <summary>
    /// satır sütunu temsil eden row,col değerini alır
    /// </summary>
    public class Matrix
    {
        #region Region Fields
        public int row;
        public int col;
        #endregion
        public Matrix() { }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="_row"></param>
        /// <param name="_col"></param>
        public Matrix(int _row, int _col)
        {
            #region Matrix
            this.row = _row;
            this.col = _col;
            #endregion
        }
    }
}
