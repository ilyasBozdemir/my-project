using chess_game.chessSettings;
using chess_game_v2;
using chess_game_v2.chessPieceTypes;
using chess_game_v2.chessSettings;
using chessSettings;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace chess_game
{
    public partial class chessBoard
    {
        private chessForm chessForm;
        public static PictureBox MainBoardContent = new PictureBox();
        public static NullPiece[,] pieces = new NullPiece[8, 8];
        public static PictureBox[,] BoardCellsContent = new PictureBox[8, 8];

        public static PictureBox[,] chessPiecesContent = new PictureBox[8, 8];

        public static Color BoardColor = Color.Teal, BoardColor2 = ColorTranslator.FromHtml("#bdbdbd");
        private Label[] Xlabels = new Label[8];
        private Label[] Ylabels = new Label[8];
        public static Size BoardCellsContentSize = new Size(64, 64);
        public static Size chessPiecesContentSize = new Size(48, 48);
    }
    public partial class chessBoard
    {
        public void getChessBoard()
        {
            chessForm = (chessForm)Application.OpenForms["chessForm"];
            // kenar hücre bilgileri yazdırma
            for (int i = 0; i < 8; i++)
            {
                Xlabels[i] = new Label();
                Xlabels[i].Size = new Size(20, 20);
                Xlabels[i].Location = chessBoardInfo.pointsX[i];
                Xlabels[i].Text = $"{chessBoardInfo.satir[i]}";
                Xlabels[i].Font = new Font("Corbel", 13);
                Xlabels[i].ForeColor = ColorTranslator.FromHtml("#000");
                //
                Ylabels[i] = new Label();
                Ylabels[i].Size = new Size(20, 20);
                Ylabels[i].Location = chessBoardInfo.pointsY[i];
                Ylabels[i].Text = $"{chessBoardInfo.sutun[i]}";
                Ylabels[i].Font = new Font("Corbel", 13);
                Ylabels[i].ForeColor = ColorTranslator.FromHtml("#000");
                // 
                chessForm.pnlChessBoardContent.Controls.Add(Xlabels[i]);
                chessForm.pnlChessBoardContent.Controls.Add(Ylabels[i]);
            }
            //
            MainBoardContent.Location = new Point(20, 20);
            MainBoardContent.Size = new Size(512, 512);
            MainBoardContent.Name = "chessboard";
            //
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    BoardCellsContent[i, j] = new PictureBox();
                    BoardCellsContent[i, j].Name = $"boardCell-{chessBoardInfo.satir[i]}{chessBoardInfo.sutun[j]}";
                    BoardCellsContent[i, j].Size = BoardCellsContentSize;
                    BoardCellsContent[i, j].Location
                        = new Point(i * BoardCellsContentSize.Width, j * BoardCellsContentSize.Height);
                    //taşların konumu
                    chessPiecesContent[i, j] = new PictureBox();
                    //chessPiecesContent[i, j].Name = $"Image_{pieces[i, j].PieceID}";
                    chessPiecesContent[i, j].Size = chessPiecesContentSize;
                    chessPiecesContent[i, j].Location = new Point(8, 8);


                    chessPiecesContent[i, j].MouseClick += chessPieces_MouseClick;
                    chessPiecesContent[i, j].MouseHover += ChessBoard_MouseHover;
                    chessPiecesContent[i, j].MouseLeave += ChessBoard_MouseLeave;

                    BoardCellsContent[i, j].Controls.Add(chessPiecesContent[i, j]);
                    MainBoardContent.Controls.Add(BoardCellsContent[i, j]);
                }
            }
            chessForm.pnlChessBoardContent.Controls.Add(MainBoardContent);
        }

        private void ChessBoard_MouseLeave(object sender, EventArgs e)
        {
            pieceEvents.pieceMouseLeave(sender, e);
        }
        private void ChessBoard_MouseHover(object sender, EventArgs e)
        {
            pieceEvents.pieceMouseHover(sender, e);
        }
        private void chessPieces_MouseClick(object sender, MouseEventArgs e)
        {
            pieceEvents.pieceClicked(sender, e);
        }

        public void propertySetValue(object container, string propertyName, object value)
        {
            var propertyInfo = container.GetType().GetProperty(propertyName);
            propertyInfo.SetValue(container, Convert.ChangeType(value, propertyInfo.PropertyType), null);
        }
        public static object propertyGetValue(object container, string propertyName)
        {
            return container.GetType().GetProperty(propertyName).GetValue(container, null);
        }
        public void getChessBoardCellColors(chessBoardCellColor boardCellColor = null)
        {
            if (boardCellColor != null)
            {
                BoardColor = boardCellColor.BoardColor;
                BoardColor2 = boardCellColor.BoardColor2;
            }
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    BoardCellsContent[i, j].BackColor = ((i + j) % 2 == 1) ? BoardColor : BoardColor2;
                }
            }
            MainBoardContent.Refresh();
        }
        public void setChessPieces()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    Color BackColor = ((i + j) % 2 == 1) ? BoardColor : BoardColor2;
                    chessPieceColor pieceColor = new chessPieceColor(Color.Transparent, BackColor);
                    chessPiecePoint piecePoint = new chessPiecePoint(i, j);
                    pieces[i, j] = new NullPiece(pieceColor, piecePoint);
                    pieces[i, j].PieceID = $"null{i}{j}";
                    pieces[i, j].PieceType = chessPieceType.Null;
                }
            }
            for (int i = 0; i < 4; i++)
            {
                Rook rook = chessPieces.Rooks()[i];
                pieces[rook.PiecePoint.Y, rook.PiecePoint.X] = rook;

                Knight knight = chessPieces.Knights()[i];
                pieces[knight.PiecePoint.Y, knight.PiecePoint.X] = knight;

                Bishop bishop = chessPieces.Bishops()[i];
                pieces[bishop.PiecePoint.Y, bishop.PiecePoint.X] = bishop;
            }
            for (int i = 0; i < 2; i++)
            {
                King king = chessPieces.Kings()[i];
                pieces[king.PiecePoint.Y, king.PiecePoint.X] = king;
                //
                Queen queen = chessPieces.Queens()[i];
                pieces[queen.PiecePoint.Y, queen.PiecePoint.X] = queen;
            }
            for (int i = 0; i < 16; i++)
            {
                Pawn pawn = chessPieces.Pawns()[i];
                pieces[pawn.PiecePoint.Y, pawn.PiecePoint.X] = pawn;
            }
            getChessPieces();
        }
        private void getChessPieces()
        {
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (!string.IsNullOrEmpty(pieces[i, j].PieceImagePath))
                    {
                        chessPiecesContent[i, j].BackgroundImage = pieceSetColor(pieces[i, j].PieceImagePath,
                            pieces[i, j].PieceColor);
                        chessPiecesContent[i, j].Name = $"Image_{pieces[i, j].PieceID}";
                        chessPiecesContent[i, j].Cursor = Cursors.Hand;
                    }
                }
            }
        }

        private Bitmap pieceSetColor(string filename, chessPieceColor pieceColor)
        {
            Bitmap bitmap = new Bitmap(filename);
            Color FirstPixel = bitmap.GetPixel(0, 0);
            for (int i = 0; i < bitmap.Width; i++)
            {
                for (int j = 0; j < bitmap.Height; j++)
                {
                    Color color = bitmap.GetPixel(i, j);
                    if (color != FirstPixel)
                        bitmap.SetPixel(i, j, pieceColor.ForeColor);
                    else if (color == FirstPixel)
                        bitmap.SetPixel(i, j, pieceColor.BackColor);
                }
            }
            return bitmap;
        }
        public void updateChessPiece(NullPiece clickedPiece, chessPiecePoint newPiecePoint)
        {
            getChessPieces();
        }
    }
}
