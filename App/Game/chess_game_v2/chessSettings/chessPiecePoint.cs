using chessSettings;
using System;

namespace chess_game.chessSettings
{
    public class chessPiecePoint
    {
        public int X { get; set; }
        public int Y { get; set; }
        private static ChessPiece[,] pieces;
        private static chessPiecePoint piecePoint { get; set; }
        public chessPiecePoint(int X, int Y)
        {
            this.X = X;
            this.Y = Y;
        }
        public static chessPiecePoint GetPointByName(string pieceName)
        {
            pieces = chessBoard.pieces;
            for (int i = 0; i <= pieces.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= pieces.GetUpperBound(1); j++)
                {
                    if ($"Image_{pieces[i, j].PieceID}" == pieceName)
                    //picturebox controlüne atarken "Image_" eklemiştik              
                    {
                        piecePoint = pieces[i, j].PiecePoint;
                    }
                }
            }
            return piecePoint;
        }

        public static string GetNotationByPoint(chessPiecePoint piecePoint)
        {
            char[] satir = chessBoardInfo.satir;
            char[] sutun = chessBoardInfo.sutun;

            return $"{satir[piecePoint.Y]}{sutun[piecePoint.X]}";
        }
        public static chessPiecePoint GetPointByNotation(string notation)
        {
            char Row = notation[0];
            char Column = notation[1];
            int resultCode = Array.IndexOf(chessBoardInfo.satir, Row);
            int resultCode2 = Array.IndexOf(chessBoardInfo.sutun, Column);
            chessPiecePoint piecePoint = new chessPiecePoint(-1, -1);
            if (resultCode != -1 && resultCode2 != -1)
            {
                piecePoint.X = resultCode;
                piecePoint.Y = resultCode2;
            }
            return piecePoint;
        }
        public static string GetNotationByName(string pieceName) => GetNotationByPoint(GetPointByName(pieceName));
        public override string ToString()
        {
            return $"X={X} Y={Y}";
        }
    }
}
