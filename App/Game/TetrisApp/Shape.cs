using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static TetrisApp.Tetronimo;

namespace TetrisApp
{
    /// <summary>
    /// 
    /// </summary>
    public class Shape
    {
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public static Block GetRandomShape()
        {
            Block mainBlock = new Block();
            GameSetting setting = new GameSetting();
            mainBlock.Name = setting.BlockName;
            mainBlock.Size = new Size(120, 120);
            //mainBlock.Location = new Point(0, 0);
            mainBlock.BackColor = Color.White;
            Random rnd = new Random();
            Tetronimo tetronimo = new Tetronimo((BlockType) rnd.Next(1, 7));//7 farklı renk var ondan :D
            Block[,] blocks = tetronimo.GetTetronimo();
            return ShapeHelper(mainBlock, blocks);
        }
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="cells"></param>
        /// <returns></returns>
        public static Block CreateShape(Block[,] cells)
        {
            Block mainBlock = new Block();
            GameSetting setting = new GameSetting();
            mainBlock.Name = setting.BlockName;
            mainBlock.Size = new Size(120, 120);
            mainBlock.BackColor = Color.White;
            return ShapeHelper(mainBlock, cells);
        }
        /// <remarks>
        /// 
        /// </remarks>
        /// <param name="mainBlock"></param>
        /// <param name="cells"></param>
        /// <returns></returns>
        public static Block ShapeHelper(Block mainBlock, Block[,] cells)//amac donguleri tekrar tekrar yazmamak
        {
            for (int i = 0; i <= cells.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= cells.GetUpperBound(1); j++)
                {
                    cells[i, j].Name = $"Cell{i}_{j}";
                    mainBlock.Controls.Add(cells[i, j]);
                }
            }
            return mainBlock;
        }
    }
}
