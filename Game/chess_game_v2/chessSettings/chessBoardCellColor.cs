using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_game_v2.chessSettings
{
    public class chessBoardCellColor
    {
        public Color BoardColor { get; set; }
        public Color BoardColor2 { get; set; }
        public chessBoardCellColor(Color BoardColor, Color BoardColor2)
        {
            this.BoardColor = BoardColor;
            this.BoardColor2 = BoardColor2;
        }
        public override string ToString()
        {
            return $"BoardColor :{BoardColor2} BoardColor2 :{BoardColor2}";
        }
    }
}
