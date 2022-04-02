using chess_game.chessSettings;
using chessSettings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace chess_game_v2
    .chessPieceTypes
{
   public class Knight : NullPiece
    {
        public Knight(chessPieceColor pieceColor, chessPiecePoint chessPiecePoint) : base(pieceColor, chessPiecePoint)
        {
            base.PieceImagePath = $@"{Application.StartupPath}\Images\at.png";
            base.PieceType = chessPieceType.Knight;
            base.PieceColor = pieceColor;
            base.PiecePoint = chessPiecePoint;
            base.PieceNotationPrefix = "A";

        }
    }
}
