using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TetrisApp.GameHelper
{
    public class BlockToByte// block'lara göre  byte'larını göre  olusturur
    {
        public byte[,] GetBytes(Block[,] mainBlock)
        {
            int x = mainBlock.GetUpperBound(0) + 1, y = mainBlock.GetUpperBound(1) + 1;
            ShapeColor shapeColor = new ShapeColor();
            byte[,] blocks = new byte[x, y];

            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    blocks[i, j] = shapeColor.GetColorNumber(mainBlock[i, j].BackColor);
                }
            }
            return blocks;
        }
    }
}
