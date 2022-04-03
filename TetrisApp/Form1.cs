using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TetrisApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Panel pnl = new Panel();
            pnl.Size = new Size(100, 100);
            Panel childPanel = new Panel();
            childPanel.Size = new Size(40, 40);
            childPanel.BackColor = Color.Red;
            childPanel.Location = new Point(10, 10);

            Panel childPanel2 = new Panel();
            childPanel2.Size = new Size(40, 40);
            childPanel2.BackColor = Color.Red;
            childPanel2.Location = new Point(60, 60);

            pnl.Controls.Add(childPanel);
            pnl.Controls.Add(childPanel2);
            this.Controls.Add(pnl);
        }
    }
}
