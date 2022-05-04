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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        GameForm gameForm = new GameForm();
        private void button1_Click(object sender, EventArgs e)
        {
            //kolay
            this.Hide();
            GameForm.mode = Helpers.GameMode.basic;
            gameForm.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //orta
            this.Hide();
            GameForm.mode = Helpers.GameMode.middle;
            gameForm.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //zor
            this.Hide();
            GameForm.mode = Helpers.GameMode.hard;
            gameForm.Show();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
