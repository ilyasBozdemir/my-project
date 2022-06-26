﻿using System;
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
    public partial class GameForm : Form
    {

        public GameForm()
        {
            InitializeComponent();
        }

        private void GameForm_Load(object sender, EventArgs e)
        {
            GameRun();

        }
        private void GameForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void btnRestart_Click(object sender, EventArgs e)
        {
            GameModeForm form1 = new GameModeForm();
            form1.StartPosition = FormStartPosition.CenterScreen;
            this.Hide();
            form1.ShowDialog();
        }
        int showHide = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            bool state = showHide % 2 == 0;
            button1.Text = state ? "Mayınları göster" : "Mayınları gizle";
            MineShowHide(state);
            showHide++;
        }
        private void timer1_Tick(object? sender, EventArgs e)
        {
            ts = stopWatch.Elapsed;

            elapsedTime = GetDuration(hours: ts.Hours, minutes: ts.Minutes, seconds: ts.Seconds, milliseconds: ts.Milliseconds);

            lblTimeElapsed.Text = elapsedTime;
        }

        private void GameForm_Resize(object sender, EventArgs e)
        {
            //Text = "W: " +this.Width + " H: " + this.Height;
        }
    }
}
