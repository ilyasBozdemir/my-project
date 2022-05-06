using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TetrisGame.GameZone;
using TetrisGame.TetrisGame.GameZoneCodeBehind;

namespace TetrisGame
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            Panel pnl = pnlMainPanel;
            switch (e.KeyCode)
            {
                case Keys.Left:
                        pnl.Left -= 30;
                    break;
                case Keys.Right:
                    pnl.Left+= 30;
                    break;
                case Keys.Down:
                        pnl.Top += 30;
                    break;
                case Keys.Up:
                        pnl.Top -= 30;
                    break;
                case Keys.Space:
                    break;   
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            GamePlay gamePlay = new GamePlay();
            gamePlay.GetPlayzone();
        }
        private byte[,] _90DegRotateMatrix(byte[,] matrix)
        {
            byte[,] NewMatrix = new byte[4, 4];
            for (int i = 3; i >= 0; --i)
            {
                for (int j = 0; j < 4; ++j)
                {
                    NewMatrix[j, 3 - i] = matrix[i, j];
                }
            }
            return NewMatrix;
        }
    }
}

