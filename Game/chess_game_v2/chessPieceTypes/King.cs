using chess_game.chessSettings;
using chessSettings;
using System.Windows.Forms;

namespace chess_game_v2.chessPieceTypes
{
    public class King: NullPiece
    {
        public King(chessPieceColor pieceColor, chessPiecePoint chessPiecePoint) : base(pieceColor, chessPiecePoint)
        {
            base.PieceImagePath = $@"{Application.StartupPath}\Images\vezir.png";
            base.PieceType = chessPieceType.King;
            base.PieceColor = pieceColor;
            base.PiecePoint = chessPiecePoint;
            base.PieceNotationPrefix = "V";

        }
    }
}
