using chess_game_v2;
using chessSettings;
using System.Drawing;
using System.Windows.Forms;

namespace chess_game
{
    public class chessPlay
    {
        public static bool IsGameStarted { get; set; }
        public static Timer timerBlack { get; set; }
        public static Timer timerWhite { get; set; }
        public static bool IsPlacePlayer1 { get; set; }
        public static bool IsPlacePlayer2 { get; set; }
        public static bool IsGameZone { get; set; }
        public static bool IsRok { get; set; }
        public static bool IsRok2 { get; set; }
        public static bool IsRok3 { get; set; }
        public static bool IsRok4 { get; set; }
        //public static bool Pawn_PieceMoving { get; set; }
        //public static bool Queen_PieceMoving { get; set; }
        //public static bool King_PieceMoving { get; set; }
        //public static bool Bishop_PieceMoving { get; set; }
        //public static bool Knight_PieceMoving { get; set; }
        //public static bool Rook_PieceMoving { get; set; }
        chessForm activeForm;
        chessBoard chessBoard;
        public chessPlay()
        {
            activeForm = (chessForm)Application.OpenForms["chessForm"];
            activeForm.Text = "Chess 2D";
            chessBoard = new chessBoard();
        }
        public void StartGame()
        {
            chessBoard.getChessBoard();
            chessBoard.getChessBoardCellColors(/*new chessBoardCellColor(Color.Red, Color.White)*/);
            chessBoard.setChessPieces();
            

            IsGameStarted = true;
            IsRok = true;//siyah
            IsRok2 = true;//siyah
            IsRok3 = true;//beyaz
            IsRok4 = true;//beyaz
            IsPlacePlayer1 = true;
            IsPlacePlayer2 = false;

        }
        public void PauseGame()
        {

        }
        public void EndGame()
        {

        }
    }
}
