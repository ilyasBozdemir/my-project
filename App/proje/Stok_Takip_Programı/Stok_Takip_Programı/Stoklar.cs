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
    public partial class Stoklar : Form
    {
        public Stoklar()
        {
            InitializeComponent();
        }

        private void Stoklar_FormClosed(object sender, FormClosedEventArgs e)
        {

        }
        bool sürükleme;
        Point lokasyon;
        
        private void Stoklar_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükleme)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - lokasyon.X,
               currentScreenPos.Y - lokasyon.Y);
            }
        }

        private void Stoklar_MouseUp(object sender, MouseEventArgs e)
        {
            sürükleme = false;
        }

        private void Stoklar_MouseDown(object sender, MouseEventArgs e)
        {
            sürükleme = true;
            lokasyon = e.Location;
        }

        private void button4_MouseMove(object sender, MouseEventArgs e)
        {
            button4.Image = Properties.Resources.çıkış1;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.Image = Properties.Resources.çıkış;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Stoklar_Load(object sender, EventArgs e)
        {

        }

    }
}
