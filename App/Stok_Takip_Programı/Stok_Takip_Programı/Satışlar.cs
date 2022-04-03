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
    public partial class Satışlar : Form
    {
        public Satışlar()
        {
            InitializeComponent();
        }

        private void Ürünler_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükleme)//fare ile basılı tutunca  sürükelme tetikleniyo 
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - lokasyon.X,
               currentScreenPos.Y - lokasyon.Y);//ve istedigimiz yere form harekete ediyo
            }
        }

        bool sürükleme;//sürükleme ac kapa :D
        Point lokasyon;//sürükleme için x-y korrdinatı
        private void Ürünler_MouseUp(object sender, MouseEventArgs e)
        {
            sürükleme = false;
        }

        private void Ürünler_MouseDown(object sender, MouseEventArgs e)
        {
            sürükleme = true;
            lokasyon = e.Location;//mouse dan alıyo x-y koordinatını
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)//butonun üzerine fare gelirse
        {
            button1.Image = Properties.Resources.çıkış1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)//butonun üzerinden fare ayrılırsa
        {
            button1.Image = Properties.Resources.çıkış;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Ürünler_Load(object sender, EventArgs e)
        {

        }
    }
}
