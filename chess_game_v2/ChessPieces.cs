using chess_game.chessSettings;
using chess_game_v2.chessPieceTypes;
using chessSettings;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chess_game
{
    public class chessPieces
    {
        static Color PieceColor = ColorTranslator.FromHtml("#eee"), PieceColor2 = ColorTranslator.FromHtml("#111");

        private static Color Hesapla(int i, int j)
        {
            return ((i + j) % 2 == 1) ? chessBoard.BoardColor : chessBoard.BoardColor2;
        }
        public static Rook[] Rooks()
        {
            Rook BlackLeftRook = new Rook(new chessPieceColor(PieceColor, Color.Transparent), new chessPiecePoint(0, 0));
            BlackLeftRook.PieceID = $"{PieceColor.Name}_Rook";
            Rook BlackRightRook = new Rook(new chessPieceColor(PieceColor, Color.Transparent), new chessPiecePoint(0, 7));
            BlackRightRook.PieceID = $"{PieceColor.Name}_Rook2";

            Rook WhiteLeftRook = new Rook(new chessPieceColor(PieceColor2, Color.Transparent), new chessPiecePoint(7, 0));
            WhiteLeftRook.PieceID = $"{PieceColor2.Name}_Rook";
            Rook WhiteRightRook = new Rook(new chessPieceColor(PieceColor2, Color.Transparent), new chessPiecePoint(7, 7));
            WhiteRightRook.PieceID = $"{PieceColor2.Name}_Rook2";

            return new Rook[] { BlackLeftRook, BlackRightRook, WhiteLeftRook, WhiteRightRook };
        }
        public static Knight[] Knights()
        {
            Knight BlackLeftKnight = new Knight(new chessPieceColor(PieceColor, Hesapla(0, 1)), new chessPiecePoint(0, 1));
            BlackLeftKnight.PieceID = $"{PieceColor.Name}_Knight";
            Knight BlackRightKnight = new Knight(new chessPieceColor(PieceColor, Hesapla(0, 6)), new chessPiecePoint(0, 6));
            BlackRightKnight.PieceID = $"{PieceColor.Name}_Knight2";

            Knight WhiteLeftKnight = new Knight(new chessPieceColor(PieceColor2, Hesapla(7, 1)), new chessPiecePoint(7, 1));
            WhiteLeftKnight.PieceID = $"{PieceColor2.Name}_Knight";
            Knight WhiteRightKnight = new Knight(new chessPieceColor(PieceColor2, Hesapla(7, 6)), new chessPiecePoint(7, 6));
            WhiteRightKnight.PieceID = $"{PieceColor2.Name}_Knight2";

            return new Knight[] { BlackLeftKnight, BlackRightKnight, WhiteLeftKnight, WhiteRightKnight };
        }
        public static Bishop[] Bishops()
        {
            Bishop BlackLeftBishop = new Bishop(new chessPieceColor(PieceColor, Color.Transparent), new chessPiecePoint(0, 2));
            BlackLeftBishop.PieceID = $"{PieceColor.Name}_Bishop";
            Bishop BlackRightBishop = new Bishop(new chessPieceColor(PieceColor, Color.Transparent), new chessPiecePoint(0, 5));
            BlackRightBishop.PieceID = $"{PieceColor.Name}_Bishop2";

            Bishop WhiteLeftBishop = new Bishop(new chessPieceColor(PieceColor2, Color.Transparent), new chessPiecePoint(7, 2));
            WhiteLeftBishop.PieceID = $"{PieceColor2.Name}_Bishop";
            Bishop WhiteRightBishop = new Bishop(new chessPieceColor(PieceColor2, Color.Transparent), new chessPiecePoint(7, 5));
            WhiteRightBishop.PieceID = $"{PieceColor2.Name}_Bishop2";

            return new Bishop[] { BlackLeftBishop, BlackRightBishop, WhiteLeftBishop, WhiteRightBishop };
        }
        public static King[] Kings()
        {
            King BlackKing = new King(new chessPieceColor(PieceColor, Color.Transparent), new chessPiecePoint(0, 3));
            BlackKing.PieceID = $"{PieceColor.Name}_King";

            King WhiteKing = new King(new chessPieceColor(PieceColor2, Color.Transparent), new chessPiecePoint(7, 3));
            WhiteKing.PieceID = $"{PieceColor2.Name}_King";

            return new King[] { BlackKing, WhiteKing };
        }
        public static Queen[] Queens()
        {
            Queen BlackQueen = new Queen(new chessPieceColor(PieceColor, Color.Transparent), new chessPiecePoint(0, 4));
            BlackQueen.PieceID = $"{PieceColor.Name}_Queen";

            Queen WhiteQueen = new Queen(new chessPieceColor(PieceColor2, Color.Transparent), new chessPiecePoint(7, 4));
            WhiteQueen.PieceID = $"{PieceColor2.Name}_Queen";

            return new Queen[] { BlackQueen, WhiteQueen };
        }
        public static Pawn[] Pawns()
        {
            Pawn[] pawns = new Pawn[16];
            for (int i = 0; i < pawns.Length; i++)
            {
                if (i < 8)
                {
                    pawns[i] = new Pawn(new chessPieceColor(PieceColor, Color.Transparent), new chessPiecePoint(1, i));
                    pawns[i].PieceID = $"{PieceColor.Name}_Pawn{(i == 0 ? (i + 1) : (i + 1))}";
                }
                else
                {
                    pawns[i] = new Pawn(new chessPieceColor(PieceColor2, Color.Transparent), new chessPiecePoint(6, (i - 8)));
                    pawns[i].PieceID = $"{PieceColor2.Name}_Pawn{(i == 0 ? (i + 1) : (i - 7))}";
                }
            }
            return pawns;
        }

    }
}
