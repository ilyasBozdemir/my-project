using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MineSweeperFormApp
{
    public partial class GameModeForm : Form
    {
      
        public GameModeForm()
        {
            InitializeComponent();
        }
       
        private void GameModeForm_Load(object sender, EventArgs e)
        {

        }
        GameForm gameForm = new GameForm();
        private void button1_Click(object sender, EventArgs e)
        {
            //kolay
            this.Hide();
            GameForm.mode = GameMode.basic;
            gameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //orta
            this.Hide();
            GameForm.mode = GameMode.middle;
            gameForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //zor
            this.Hide();
            GameForm.mode = GameMode.hard;
            gameForm.Show();
        }

        private void GameModeForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
