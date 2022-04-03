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
    public partial class Giris : Form
    {
        public Giris()
        {
            InitializeComponent();
        }
        bool sürükleme;
        Point lokasyon;
       
        int sayı = 0;
        public void GizleGoster()
        {
            sayı++;
            if (sayı % 2 == 0)
            {
                button1.Image = Properties.Resources.göz0;
                textBox2.PasswordChar = '*';
            }
            else
            {
                button1.Image = Properties.Resources.göz1;
                textBox2.PasswordChar = '\0';
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            GizleGoster();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AnaEkran ana = new AnaEkran();
            ana.Show();
            this.Hide();
        }

        private void button3_MouseMove(object sender, MouseEventArgs e)
        {
            button3.Image = Properties.Resources.çıkıs1;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.Image = Properties.Resources.çıkıs;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Giris_MouseDown(object sender, MouseEventArgs e)
        {
            sürükleme = true;
            lokasyon = e.Location;
        }

        private void Giris_MouseUp(object sender, MouseEventArgs e)
        {
            sürükleme = false;
        }

        private void Giris_MouseMove(object sender, MouseEventArgs e)
        {
            if (sürükleme)
            {
                Point currentScreenPos = PointToScreen(e.Location);
                Location = new Point(currentScreenPos.X - lokasyon.X,
               currentScreenPos.Y - lokasyon.Y);
            }
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.btn1;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.btn;

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Yenileme yeni = new Yenileme();
            yeni.ShowDialog();
            this.Hide();
        }

        private void Giris_Load(object sender, EventArgs e)
        {

        }

    }
}
