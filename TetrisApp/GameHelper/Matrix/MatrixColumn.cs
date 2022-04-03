using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp.GameHelper.Matrix
{
    public class MatrixColumn
    {
        
    }
    public class MatrixColumnCollection
    {
        public List<MatrixColumn> rows = new List<MatrixColumn>();
        public void Add(MatrixColumn column)
        {
            rows.Add(column);
        }
        public void Remove(MatrixColumn column)
        {
            rows.Remove(column);
        }
        public void RemoveAt(int index)
        {
            rows.RemoveAt(index);
        }
    }
}
