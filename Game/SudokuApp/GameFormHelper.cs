using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuFormApp
{
    public partial class GameForm
    {
        private GameState _state;
        private Stopwatch stopwatch;
        SudokuCell[,] cells = new SudokuCell[9, 9]; 
        Random rnd = new Random();
        private int hintsCount = 0;
        public static SudokuExperienceStatus experienceStatus;
        private void StartGame()
        {
            //GetTimeElapsed();
            _state = GameState.Continues;
            CreateCells();
            LoadValues();
            switch (experienceStatus)
            {
                case SudokuExperienceStatus.Null:
                    break;
                case SudokuExperienceStatus.Beginner:
                    hintsCount = 50;
                    break;
                case SudokuExperienceStatus.Intermediate:
                    hintsCount = 40;
                    break;
                case SudokuExperienceStatus.Hard:
                    hintsCount = 30;
                    break;
                case SudokuExperienceStatus.Expert:
                    hintsCount = 20;
                    break;
            }
            ShowRandomValuesHints(hintsCount);
            Text = hintsCount + "";
        }
        private void FinishGame()
        {
            _state = GameState.Finished;
        }
        private void CheckIn()
        {
            var wrongCells = new List<SudokuCell>();
            foreach (var cell in cells)
            {
                if (!string.Equals(cell.Value.ToString(), cell.Text))
                {
                    wrongCells.Add(cell);
                }
            }
            if (wrongCells.Any())
            {
                wrongCells.ForEach(x => x.ForeColor = Color.Red);
                MessageBox.Show("Wrong inputs");
            }
            else
            {
                MessageBox.Show("You Wins");
            }
        }
        private void ShowSolution()
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = rnd.Next(9);
                var rY = rnd.Next(9);

                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }

        }

        private void GetTimeElapsed()
        {
            stopwatch = new Stopwatch();
            stopwatch.Start();
            timer1.Enabled = true;
            timer1.Interval = 100;
            timer1.Tick += timer1_Tick;
            timer1.Start();
            lblTimeElapsed.Text = "Süre : ";
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }
        private void CreateCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    cells[i, j] = new SudokuCell();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(40, 40);
                    cells[i, j].ForeColor = SystemColors.ControlDarkDark;
                    cells[i, j].Location = new Point(i * 40, j * 40);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 
                        ? SystemColors.Control
                        : Color.LightSlateGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    cells[i, j].FlatAppearance.BorderColor = Color.Black;
                    cells[i, j].X = i;
                    cells[i, j].Y = j;

                    cells[i, j].KeyPress += cell_KeyPressed;

                    this.pnlSudoku.Controls.Add(cells[i, j]);
                }
            }
        }
        private void LoadValues()
        {
            foreach (var cell in cells)
            {
                cell.Value = 0;
                cell.Clear();
            }

            FindValueForNextCell(0, -1);
        }
        private void ShowRandomValuesHints(int hintsCount)
        {
            for (int i = 0; i < hintsCount; i++)
            {
                var rX = rnd.Next(9);
                var rY = rnd.Next(9);

                cells[rX, rY].Text = cells[rX, rY].Value.ToString();
                cells[rX, rY].ForeColor = Color.Black;
                cells[rX, rY].IsLocked = true;
            }
        }
        private bool FindValueForNextCell(int i, int j)
        {
            if (++j > 8)
            {
                j = 0;

                if (++i > 8)
                    return true;
            }

            var value = 0;
            var numsLeft = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            do
            {
                if (numsLeft.Count < 1)
                {
                    cells[i, j].Value = 0;
                    return false;
                }

                value = numsLeft[rnd.Next(0, numsLeft.Count)];
                cells[i, j].Value = value;

                numsLeft.Remove(value);
            }
            while (!IsValidNumber(value, i, j) || !FindValueForNextCell(i, j));

            cells[i, j].Text = value.ToString();

            return true;
        }

        private bool IsValidNumber(int value, int x, int y)
        {
            for (int i = 0; i < 9; i++)
            {
                if (i != y && cells[x, i].Value == value)
                    return false;

                if (i != x && cells[i, y].Value == value)
                    return false;
            }

            for (int i = x - (x % 3); i < x - (x % 3) + 3; i++)
            {
                for (int j = y - (y % 3); j < y - (y % 3) + 3; j++)
                {
                    if (i != x && j != y && cells[i, j].Value == value)
                        return false;
                }
            }

            return true;
        }

        private void cell_KeyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCell;
            if (cell.IsLocked)
                return;
            int value;
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                if (value == 0)
                    cell.Clear();
                else
                    cell.Text = value.ToString();
                cell.ForeColor = SystemColors.ControlDarkDark;
            }
        }
    }
}

