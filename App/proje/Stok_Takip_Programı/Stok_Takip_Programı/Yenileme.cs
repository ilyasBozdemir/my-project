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
    public partial class Yenileme : Form
    {
        public Yenileme()
        {
            InitializeComponent();
        }
        bool sürükleme;
        Point lokasyon;
        private void Yenileme_Load(object sender, EventArgs e)
        {

        }

        private void Yenileme_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükleme)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - lokasyon.X,
               currentScreenPos.Y - lokasyon.Y);
            }
        }

        private void Yenileme_MouseUp(object sender, MouseEventArgs e)
        {
            sürükleme = false;
        }

        private void Yenileme_MouseDown(object sender, MouseEventArgs e)
        {
            sürükleme = true;
            lokasyon = e.Location;
            
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {

        }

       
    }
}
