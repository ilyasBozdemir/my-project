using chess_game.chessSettings;
using chessSettings;
using System.Windows.Forms;

namespace chess_game_v2.chessPieceTypes
{
    public class Rook : NullPiece
    {
        public Rook(chessPieceColor pieceColor, chessPiecePoint chessPiecePoint) : base(pieceColor, chessPiecePoint)
        {
            base.PieceImagePath = $@"{Application.StartupPath}\Images\kale.png";
            base.PieceType = chessPieceType.Rook;
            base.PieceColor = pieceColor;
            base.PiecePoint = chessPiecePoint;
            base.PieceNotationPrefix = "K";
        }
    }
}
