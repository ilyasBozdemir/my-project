using chess_game.chessSettings;
using chessSettings;
using System.Windows.Forms;

namespace chess_game_v2.chessPieceTypes
{
    public class Bishop : NullPiece
    {
        public Bishop(chessPieceColor pieceColor, chessPiecePoint chessPiecePoint) : base(pieceColor, chessPiecePoint)
        {
            base.PieceImagePath = $@"{Application.StartupPath}\Images\fil.png";
            base.PieceType = chessPieceType.Bishop;
            base.PieceColor = pieceColor;
            base.PiecePoint = chessPiecePoint;
            base.PieceNotationPrefix = "F";
        }
    }
}
