using System;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using TetrisApp.GameHelper.Matrix;

namespace TetrisApp
{
    public partial class TetrisAppForm : Form
    {
        public TetrisAppForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            game = new Game();
            game.StartGame();
        }
        private void TetrisAppForm_KeyDown(object sender, KeyEventArgs e)
        {
            ShapeControl control = new ShapeControl(pnlCurrentShape);
            switch (e.KeyCode)
            {
                case Keys.Left:
                    if (control.isLeft())
                        pnlCurrentShape.Left -= 30;
                    break;
                case Keys.Right:
                    if (control.isRight())
                        pnlCurrentShape.Left += 30;
                    break;
                case Keys.Up:
                    if (control.isUp())
                        game.ShapeRotate();
                    break;
                case Keys.Down:
                    if (control.isDown())
                        pnlCurrentShape.Top += 30;
                    break;
                case Keys.P:
                    sayac += 1;
                    if (sayac % 2 == 1)
                        game.PauseGame();
                    else
                        game.ContinueGame();
                    break;
                case Keys.Space:
                    //direkt dolu hücrenin üzsütne bırakma tuşu olcak.d
                    break;
            }
        }
    }
}