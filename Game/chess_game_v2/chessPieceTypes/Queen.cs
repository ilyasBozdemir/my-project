using chess_game.chessSettings;
using chessSettings;
using System.Windows.Forms;

namespace chess_game_v2.chessPieceTypes
{
    public class Queen : NullPiece
    {
        public Queen(chessPieceColor pieceColor, chessPiecePoint chessPiecePoint) : base(pieceColor, chessPiecePoint)
        {
            base.PieceImagePath =  $@"{Application.StartupPath}\Images\şah.png";
            base.PieceType = chessPieceType.Queen;
            base.PieceColor = pieceColor;
            base.PiecePoint = chessPiecePoint;
            base.PieceNotationPrefix = "Ş";

        }
    }
}
