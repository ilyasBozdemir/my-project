using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp.GameHelper.Matrix
{

    public class MatrixRow
    {
      

    }
    public class MatrixRowCollection
    {
        public List<MatrixRow> rows = new List<MatrixRow>();
        public void Add(MatrixRow row)
        {
            rows.Add(row);
        }
        public void Remove(MatrixRow row)
        {
            rows.Remove(row);
        }
        public void RemoveAt(int index)
        {
            rows.RemoveAt(index);
        }
    }

}
