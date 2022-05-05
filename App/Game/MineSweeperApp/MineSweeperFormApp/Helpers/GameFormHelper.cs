using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        private Stopwatch stopWatch;
        private TimeSpan ts;
        public static GameMode mode;
        private Matrix matrix1, clickedMatrix;
        private Size size;
        private Button[,] btns;
        private Rectangle rectangle;
        private List<string> btnlist;
        private MineSweeper mineSweeper;
        private Button clickedBtn;
        private string elapsedTime;
        private Color[] mineInfoColors = { 
            Color.Gray,
            Color.Green,
            Color.Turquoise,
            Color.Blue,
            Color.Yellow,
            Color.Orange,
            Color.DarkRed,
            Color.Red };
        public void GameRun()
        {
            InitializeGameComponent();
        }


        private void InitializeGameComponent()
        {
            #region InitializeGameComponent
            //

            stopWatch = new Stopwatch();
            timer1.Enabled = true;
            timer1.Interval = 50;
            timer1.Tick += timer1_Tick;
            stopWatch.Start();
            timer1.Start();

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

        private void timer1_Tick(object? sender, EventArgs e)
        {
            ts = stopWatch.Elapsed;

            elapsedTime = GetDuration(hours: ts.Hours, minutes: ts.Minutes, seconds: ts.Seconds, milliseconds: ts.Milliseconds);

            lblTimeElapsed.Text = elapsedTime;
        }

        private string GetDuration(int milliseconds = 0, int seconds = 0, int minutes = 0, int hours = 0)
        {
            string durationData = "";
            if (hours != 0)
                durationData += $"{string.Format("{0:00}", hours)}:";
            durationData += $"{string.Format("{0:00}", minutes)}:{string.Format("{0:00}", seconds)}";

           /* 
            if (milliseconds != 0)
            {
                durationData += $".{string.Format("{0:000}", milliseconds)}";
            }
           */


            return durationData;
        }

        private void AddGameArea()
        {
            #region Btns Adding

            int sayac = 0;
            FontFamily family = new FontFamily("Corbel");
            Font font = new Font(family, 15, FontStyle.Regular);


            for (int i = 0; i < btns.GetUpperBound(0); i++)
            {
                for (int j = 0; j < btns.GetUpperBound(1); j++)
                {
                    btns[i, j] = new Button();
                    btns[i, j].Click += btns_Click;

                    btns[i, j].Name = $"cell_{i}_{j}";
                    btns[i, j].Size = rectangle.Size;
                    btns[i, j].Font = font;

                    btns[i, j].Cursor = Cursors.Hand;
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

                if (true)
                {

                }


                if (!mineSweeper.MineControl(clickedMatrix))
                {
                    DataInput(clickedMatrix);
                    clickedBtn.Text = GetText();
                }
                else
                {
                    YouLostTheGame();
                    stopWatch.Stop();
                }
            }
            else
            {
                MessageBox.Show("Zaten bu hücreyi daha önce seçtiniz.", "Tekrar seçim yapın.", MessageBoxButtons.OK);
            }
            #endregion
        }

        private string GetText()
        {
            #region
            var data = mineSweeper.MinelessMatrix[clickedMatrix.row, clickedMatrix.col];

            for (int i = 0; i < mineInfoColors.Length; i++)
            {
                if (data == i + "")
                    clickedBtn.ForeColor = mineInfoColors[i];
            }

            return data;
            #endregion
        }

        private void QuitGame()
        {
            Application.Exit();
        }

        private void NewGame()
        {
            #region

            Form1 form1 = new Form1();
            form1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            form1.ShowDialog();

            #endregion
        }

        private void DataInput(Matrix clickedMatrix)
        {

            #region

            bool state = false;

            mineSweeper.DataInput(clickedMatrix, mineSweeper.MinelessMatrix, ref state);

            mineSweeper.Counter++;

            mineSweeper.Score = (mineSweeper.Counter + 1) * 5;


            lblScore.Text = $"Puan: {mineSweeper.Score}";

            if (mineSweeper.Counter == mineSweeper.SafeZoneCount)
                YouWinTheGame();

            #endregion

        }
        private void YouLostTheGame()
        {
            #region

            DialogResult result = MessageBox.Show($"Mayına bastınız.Puanınız : {mineSweeper.Score}.\nSüre : {elapsedTime}\nYeni oyuna başlamak ister misiniz?", "Game over", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
                NewGame();

            else if (result == DialogResult.No)
                QuitGame();

            #endregion
        }

        private void YouWinTheGame()
        {
            #region

<<<<<<< HEAD
            DialogResult result = MessageBox.Show($"Oyunu Kazandınız.Puanınız : {mineSweeper.Score}.\nSüre : {elapsedTime}\nYeni oyuna başlamak ister misiniz?", "Game over", MessageBoxButtons.YesNo);
=======
            DialogResult result = MessageBox.Show($"Oyunu Kazandınız.Yeni oyuna başlamak ister misiniz?", "Game Win", MessageBoxButtons.YesNo);
>>>>>>> f8edd4fb678d29a9876ac7de795c4e3f3882a941
            if (result == DialogResult.Yes)
                NewGame();

            else if (result == DialogResult.No)
                QuitGame();

            #endregion
        }

        private void MineShowHide(bool showHide)
        {
            #region 

            for (int i = 0; i < btns.GetUpperBound(0); i++)
            {
                for (int j = 0; j < btns.GetUpperBound(1); j++)
                {
                    if (mineSweeper.MineMatrix[i, j] == mineSweeper.MineChar)
                    {
                        btns[i, j].Text = showHide ? mineSweeper.MineChar : string.Empty;
                        btns[i, j].ForeColor = showHide ? Color.Red : Color.Black;
                        FontFamily family = new FontFamily("Verdana");
                        Font font = new Font(family, 20, FontStyle.Regular);
                        btns[i, j].Font = font;
                    }
                }
            }

            #endregion
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
