using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MineSweeperApp;
using MineSweeperFormApp.Helpers;

namespace MineSweeperFormApp
{
    partial class GameForm
    {
        static public GameMode mode;
        private Matrix matrix1,clickedMatrix;
        private Size size;
        private Button[,] btns;
        private Rectangle rectangle;
        private List<string> btnlist;
        private MineSweeper mineSweeper;
        private Button clickedBtn;
        private Color[] mineInfoColors = { Color.Green, Color.Yellow, Color.Orange, Color.Blue, Color.Red };
        public void GameRun()
        {
            InitializeGameComponent();
        }

        private void InitializeGameComponent()
        {
            #region InitializeGameComponent
            //
            GetGameAreaLength();
            //
            mineSweeper = new MineSweeper(matrix1);
            mineSweeper.RunFormApp();
            //
            rectangle = new Rectangle(new Point(0, 0), size);
            //
            btns = new Button[matrix1.row, matrix1.col];
            //
            AddGameArea();

            btnlist = new List<string>(matrix1.row * matrix1.col);
            #endregion
        }

        private void AddGameArea()
        {
            #region Btns Adding

            int sayac = 0;
            for (int i = 0; i < btns.GetUpperBound(0); i++)
            {
                for (int j = 0; j < btns.GetUpperBound(1); j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Click += btns_Click;

                    btns[i, j].Name = $"cell_{i}_{j}";
                    btns[i, j].Size = rectangle.Size;
                    btns[i,j].Cursor = Cursors.Hand;
                    int x = rectangle.Size.Width * i,
                        y = rectangle.Size.Height * j;

                    btns[i, j].Location = new Point(x, y);

                    this.areaPanel.Controls.Add(btns[i, j]);
                }
            }

            #endregion
        }
        private void btns_Click(object sender, EventArgs e)
        {
            #region clicked button
            clickedBtn = (Button)sender;
            var data = clickedBtn.Name.Split('_');
            clickedMatrix = new Matrix(int.Parse(data[1]), int.Parse(data[2]));
            if (!btnlist.Contains(clickedBtn.Name))
            {
                btnlist.Add(clickedBtn.Name);
                DataInput();
            }
            
            #endregion
        }

        private void DataInput()
        {



            //if (mineSweeper.MineControl(clickedMatrix))//mayın varsa tıklanılan alanda
            //{
            //    MessageBox.Show("Game Over");
            //}
            //else
            //{
            //    for (int i = 0; i < mineInfoColors.Length; i++)
            //    {
            //        if (GetMineInfo(clickedMatrix) == i + "")
            //            clickedBtn.ForeColor = mineInfoColors[i];
            //    }
            //    clickedBtn.Text = GetMineInfo(clickedMatrix);
            //}



        }

        private void GetGameAreaLength()
        {
            #region GetGameAreaLength

            switch (mode)
            {
                case GameMode.basic:
                    matrix1 = new Matrix(10, 10);
                    size = new Size(40, 40);
                    this.Size = new Size(815, 530);
                    this.MaximumSize = new Size(815, 530);
                    this.MinimumSize = new Size(815, 530);
                    break;
                case GameMode.middle:
                    matrix1 = new Matrix(15, 15);
                    size = new Size(30, 30);
                    this.Size = new Size(815, 630);
                    this.MaximumSize = new Size(815, 630);
                    this.MinimumSize = new Size(815, 630);
                    this.areaPanel.Size = new Size(815, 630);
                    break;
                case GameMode.hard:
                    matrix1 = new Matrix(20, 20);
                    size = new Size(30, 30);
                    this.Size = new Size(815, 815);
                    this.MinimumSize = new Size(815, 815);
                    this.MaximumSize = new Size(815, 815);
                    break;
            }

            #endregion
        }
    }
}
