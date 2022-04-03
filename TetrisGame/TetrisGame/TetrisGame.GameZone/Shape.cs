using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisGame
{
    public class Shape 
    {
        public Shape()
        {
          
        }
        public static string sekil_O()
        {
            StringBuilder O = new StringBuilder();
            O.AppendLine("0000");
            O.AppendLine("0110");
            O.AppendLine("0110");
            O.AppendLine("0000");
            return O.ToString();
        }
    }
}
