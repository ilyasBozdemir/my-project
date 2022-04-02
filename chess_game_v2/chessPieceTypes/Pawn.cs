using chess_game.chessSettings;
using chessSettings;
using System.Windows.Forms;

namespace chess_game_v2
    .chessPieceTypes
{
    public class Pawn : NullPiece
    {
        public Pawn(chessPieceColor pieceColor, chessPiecePoint chessPiecePoint) : base(pieceColor, chessPiecePoint)
        {
            base.PieceImagePath = $@"{Application.StartupPath}\Images\piyon.png";
            base.PieceType = chessPieceType.Pawn;
            base.PieceColor = pieceColor;
            base.PiecePoint = chessPiecePoint;
            base.PieceNotationPrefix = "P";

        }
    }
}
