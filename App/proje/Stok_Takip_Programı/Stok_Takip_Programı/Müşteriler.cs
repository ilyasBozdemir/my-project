using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stok_Takip_Programı
{
    public partial class Müşteriler : Form
    {
        public Müşteriler()
        {
            InitializeComponent();
        }

        private void Müşteriler_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        bool sürükleme;
        Point lokasyon;
        private void Müşteriler_Load(object sender, EventArgs e)
        {

        }

        private void Müşteriler_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükleme)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - lokasyon.X,
               currentScreenPos.Y - lokasyon.Y);
            }
        }

        private void Müşteriler_MouseDown(object sender, MouseEventArgs e)
        {
            sürükleme = true;
            lokasyon = e.Location;
        }

        private void Müşteriler_MouseUp(object sender, MouseEventArgs e)
        {
            sürükleme = false;
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.çıkış1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.çıkış;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
