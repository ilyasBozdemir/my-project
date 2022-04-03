using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisApp.GameHelper;

namespace TetrisApp
{
    public class Tetronimo 
    {
        public Tetronimo(BlockType blockType)// istenilen bir tetronimo için
        {
            this.blockType = blockType;
        }
        public BlockType blockType;
        public enum BlockType
        {
            Z = 1,
            I,
            S,
            L,
            J,
            O,
            T
        }
        private Block[,] GetBlocks(byte[,] bytes)
        {
            ByteToBlock byteToBlock = new ByteToBlock();
            return byteToBlock.GetBlock(bytes);
        }
        public Block[,] GetTetronimo()
        {
            if (blockType == BlockType.S)
            {
                byte[,] bytes =
                {
                    {0, 0, 0, 0},
                    {0, 1, 1, 0},
                    {1, 1, 0, 0},
                    {0, 0, 0, 0}
                };
                return GetBlocks(bytes);
            }
            else if (blockType == BlockType.I)
            {
                byte[,] bytes =
                {
                    {0, 2, 0, 0},
                    {0, 2, 0, 0},
                    {0, 2, 0, 0},
                    {0, 2, 0, 0}
                };
                return GetBlocks(bytes);
            }
            else if (blockType == BlockType.Z)
            {
                byte[,] bytes =
                {
                    {0, 0, 0, 0},
                    {3, 3, 0, 0},
                    {0, 3, 3, 0},
                    {0, 0, 0, 0}
                };
                return GetBlocks(bytes);
            }
            else if (blockType == BlockType.L)
            {
                byte[,] bytes =
                {
                    {0, 4, 0, 0},
                    {0, 4, 0, 0},
                    {0, 4, 4, 0},
                    {0, 0, 0, 0}
                };
                return GetBlocks(bytes);
            }
            else if (blockType == BlockType.J)
            {
                byte[,] bytes =
                {
                    {0, 0, 5, 0},
                    {0, 0, 5, 0},
                    {0, 5, 5, 0},
                    {0, 0, 0, 0}
                };
                return GetBlocks(bytes);
            }
            else if (blockType == BlockType.O)
            {
                byte[,] bytes =
                {
                    {0, 0, 0, 0},
                    {0, 6, 6, 0},
                    {0, 6, 6, 0},
                    {0, 0, 0, 0}
                };
                return GetBlocks(bytes);
            }
            else if (blockType == BlockType.T)
            {
                byte[,] bytes =
                {
                    {0, 0, 0, 0},
                    {0, 0, 7, 0},
                    {0, 7, 7, 7},
                    {0, 0, 0, 0}
                };
                return GetBlocks(bytes);
            }
           throw new Exception("Tetronimo Error");
        }
    }
}
