using System;
using System.Drawing;
using System.Windows.Forms;

namespace TetrisApp.GameHelper
{
    public class ByteToBlock// matris byte'larına göre block olusturur.
    {
        public Block[,] GetBlock(byte[,] bytes)
        {
            int x = bytes.GetUpperBound(0) + 1, y = bytes.GetUpperBound(1) + 1;
            Block[,] blocks = new Block[x, y];
            GameSetting setting = new GameSetting();
            Size blockSize = setting.BlockSize;
            int loc = blockSize.Height;
            // int loc = blockSize.Width //blocklar kare oldugu için genişlik yükseklik fark etmez :d
            for (int i = 0; i < x; i++)
            {
                for (int j = 0; j < y; j++)
                {
                    blocks[i, j] = new Block();
                    blocks[i, j].Size = blockSize;
                    blocks[i, j].Location = new Point(loc * j, loc * i);
                    ShapeColor shapeColor = new ShapeColor();
                    blocks[i, j].BackColor = shapeColor.GetShapeColor(bytes[i, j]);
                }
            }
            return blocks;
        }
    }
}

