using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuFormApp
{
    public partial class GameStartForm : Form
    {
        public GameStartForm()
        {
            InitializeComponent();
        }
        private SudokuExperienceStatus deneyim;
        private GameForm gameForm = new GameForm();
        private void button1_Click(object sender, EventArgs e)
        {
            GameForm.experienceStatus = SudokuExperienceStatus.Beginner;
            this.Hide();
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            GameForm.experienceStatus = SudokuExperienceStatus.Intermediate;
            this.Hide();
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            GameForm.experienceStatus = SudokuExperienceStatus.Hard;
            this.Hide();
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            GameForm.experienceStatus = SudokuExperienceStatus.Expert;
            this.Hide();
            gameForm.StartPosition = FormStartPosition.CenterScreen;
            gameForm.Show();
        }

        private void GameStartForm_Load(object sender, EventArgs e)
        {

        }
    }
}
