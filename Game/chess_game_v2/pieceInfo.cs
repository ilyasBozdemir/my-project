using chess_game.chessSettings;
using System.Windows.Forms;
using System.Drawing;
using chess_game_v2.chessPieceTypes;

namespace chess_game
{
    public class pieceInfo
    {
        public PictureBox BoardBox { get; private set; }//satranç tahtasını temsil eden control
        public PictureBox PieceBox { get; private set; }//satranç tahtasının hücrelerinin her birini temsil eden control
        public NullPiece SelectedPiece { get; private set; }//satranç taşlarını temsil eden  sınıf
        public chessPiecePoint SelectedPiecePoint { get; private set; }//satranç taşlarının koordinatlarını temsil eden  sınıf
        public string SelectedPieceNotation { get; private set; }
        public NullPiece[,] pieces { get; set; }

        public pieceInfo (PictureBox Piece)
        {
            this.PieceBox = Piece.Parent as PictureBox;
            this.BoardBox = PieceBox.Parent as PictureBox;
            SelectedPiecePoint = chessPiecePoint.GetPointByName(Piece.Name);
            SelectedPiece = chessBoard.pieces[SelectedPiecePoint.Y, SelectedPiecePoint.X];
            SelectedPieceNotation = chessPiecePoint.GetNotationByName(Piece.Name);
            pieces = chessBoard.pieces;
        }
    }
}
