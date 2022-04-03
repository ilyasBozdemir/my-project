using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp.GameHelper.Matrix
{
    public class MatrixTable
    {
        public MatrixColumnCollection Columns;
        public MatrixRowCollection Rows;
        public byte[,] DataBytes;
    }
}
