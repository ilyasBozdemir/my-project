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
    public partial class AnaEkran : Form
    {
        public AnaEkran()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Satışlar satıs = new Satışlar(); satıs.ShowDialog();           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stoklar stok = new Stoklar(); stok.ShowDialog();
        }
        
        private void button3_Click(object sender, EventArgs e)
        {
            Personeller person = new Personeller(); person.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Müşteriler müşteri = new Müşteriler(); müşteri.ShowDialog();
        }

        private void button5_MouseMove(object sender, MouseEventArgs e)
        {
            button5.Image = Properties.Resources.çıkış1;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.Image = Properties.Resources.çıkış;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        bool sürükleme;
        Point lokasyon;
        private void AnaEkran_MouseDown(object sender, MouseEventArgs e)
        {
            sürükleme = true;
            lokasyon = e.Location;
        }

        private void AnaEkran_MouseUp(object sender, MouseEventArgs e)
        {
            sürükleme = false;
        }

        private void AnaEkran_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükleme)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - lokasyon.X,
               currentScreenPos.Y - lokasyon.Y);
            }
        }

        private void AnaEkran_Load(object sender, EventArgs e)
        {

        }
    }
}
