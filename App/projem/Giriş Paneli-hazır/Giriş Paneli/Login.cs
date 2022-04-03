using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Giriş_Paneli
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_MouseMove(object sender, MouseEventArgs e)
        {
            button1.Image = Properties.Resources.giriş1;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.Image = Properties.Resources.giriş;//mouse ayrıldıgında
        }

        private void button2_MouseMove(object sender, MouseEventArgs e)
        {
            button2.Image = Properties.Resources.çıkıs11;//mouse geldiğinde
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.Image = Properties.Resources.çıkıs2;
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
     
        private void button1_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text;
            string sifre = textBox2.Text;
            con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Db.accdb");
            cmd = new OleDbCommand();
            con.Open();
            cmd.Connection = con;
            cmd.CommandText = "select * FROM kullanici where kul_adi='" + ad + "' and kul_sifre='" + sifre + "'";
            dr = cmd.ExecuteReader();
            if(dr.Read())
            {
                Anaform f2 = new Anaform();
                f2.Show();
                this.Hide();
            }
            else
            {
                this.Text = "Hata!!!";
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış",this.Text);
            }
 
            con.Close();
        }
    }
}
