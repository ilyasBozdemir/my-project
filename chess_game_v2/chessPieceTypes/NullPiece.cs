using chess_game.chessSettings;
using chessSettings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess_game_v2.chessPieceTypes
{
    //public delegate void chessGameEventHandler(object sender, chessGameEventArgs e);
    public class NullPiece : ChessPiece
    {
     
        public NullPiece(chessPieceColor pieceColor, chessPiecePoint chessPiecePoint)
        {
            base.PieceType = chessPieceType.Null;
            base.PieceColor = pieceColor;
            base.PieceImagePath = null;
            base.PiecePoint = chessPiecePoint;
            base.PieceNotationPrefix = "";
        }

        public static NullPiece CreatePiece(chessPieceType pieceType, chessPieceColor pieceColor, chessPiecePoint chessPiecePoint)
        {
            NullPiece newPiece = new NullPiece(pieceColor, chessPiecePoint);

            switch (pieceType)
            {
                case chessPieceType.Null:
                    newPiece = new NullPiece(pieceColor, chessPiecePoint);
                    break;
                case chessPieceType.King:
                    newPiece = new King(pieceColor, chessPiecePoint);
                    break;
                case chessPieceType.Queen:
                    newPiece = new Queen(pieceColor, chessPiecePoint);
                    break;
                case chessPieceType.Bishop:
                    newPiece = new Bishop(pieceColor, chessPiecePoint);
                    break;
                case chessPieceType.Knight:
                    newPiece = new Knight(pieceColor, chessPiecePoint);
                    break;
                case chessPieceType.Rook:
                    newPiece = new Rook(pieceColor, chessPiecePoint);
                    break;
                case chessPieceType.Pawn:
                    newPiece = new Pawn(pieceColor, chessPiecePoint);
                    break;
            }
            return newPiece;
        }
        public override string ToString()
        {
            return $"{this.PieceID}\n{this.PieceColor}\n{this.PiecePoint}";
        }
    }
}
