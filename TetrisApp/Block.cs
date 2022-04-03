using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisApp
{
    public class Block : Panel
    {
        public Block()
        { 

        }
        public Block(String Name,Point location, Size size, Color color)
        {
            base.Name = Name;
            base.Location = location;
            base.Size = size;
            base.BackColor = color;
        }
    }
}


