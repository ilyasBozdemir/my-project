using chess_game;
using chess_game.chessSettings;
using System;
using System.Windows.Forms;

namespace chessSettings
{
    public abstract class ChessPiece
    {
        public string PieceID { get; set; } 
        public string PieceNotationPrefix { get; set; }
        public chessPieceColor PieceColor { get; set; }
        public chessPiecePoint PiecePoint { get; set; }
        public chessPieceType PieceType { get; set; }
        public string PieceImagePath { get; set; }
    }
}
