using chess_game;
using System;
using System.Windows.Forms;

namespace chess_game_v2
{
    public partial class chessForm : Form
    {
        int sayi = 0;
        public chessForm()
        {
            InitializeComponent();
        }
        private void chessForm_Load(object sender, EventArgs e)
        {
            chessPlay chessPlay = new chessPlay();
            chessPlay.StartGame();
        }
    }
}

