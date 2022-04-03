using chessSettings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess_game
{
    public class pieceEvents
    {
        static chessBoard chessBoard;
        static Color clickedColor = ColorTranslator.FromHtml("#de8a0b");
        static pieceInfo pieceInfo;
        public static void  pieceClicked(object sender, MouseEventArgs e)
        {
            pieceInfo = new pieceInfo(sender as PictureBox);
            chessBoard = new chessBoard();
            if (e.Button == MouseButtons.Left)
            {
                chessBoard.getChessBoardCellColors();
                //pieceInfo.PieceBox.BackColor = clickedColor;
                chessBoard.propertySetValue(pieceInfo.PieceBox, "BackColor", clickedColor);
            }
            else if (e.Button == MouseButtons.Middle)
            {

            }
            else if (e.Button == MouseButtons.Right)
            {

            }
        }

        public static void pieceMouseHover(object sender, EventArgs e)
        {
            //pieceInfo pieceInfo = new pieceInfo(sender as PictureBox);
            //pieceInfo.PieceBox.BackColor = ColorTranslator.FromHtml("#454545");
        }
        public static void pieceMouseLeave(object sender, EventArgs e)
        {
            //chessBoard = new chessBoard();
            //chessBoard.getChessBoardCellColors();
        }
    }
}
