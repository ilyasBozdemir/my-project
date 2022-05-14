using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.InteropServices.ComTypes;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuFormApp
{
    public partial class GameForm : Form
    {
       
        public GameForm()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            StartGame();
        }
        private void btnNewGame_Click(object sender, EventArgs e)
        {
            GameStartForm startForm = new GameStartForm();
            startForm.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            startForm.Show();
        }
        
        private void btnShowSolution_Click(object sender, EventArgs e)
        {
            ShowSolution();
        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            CheckIn();
        }
       
    }
}
