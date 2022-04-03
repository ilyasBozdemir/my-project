using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
namespace Stok_Takip
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı;
        OleDbCommand komut;
        OleDbDataReader okuma;

        int sayı = 0;
        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void Giris_btn_Click(object sender, EventArgs e)
        {
            string ad = textBox1.Text.Trim().ToLower();
            string sifre = textBox2.Text.Trim().ToLower();
            baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Kullanıcı_Paneli.accdb");
            komut = new OleDbCommand();
            baglantı.Open();
            komut.CommandText = "select * FROM Kullanici where Kullanici_Adı='" + ad + "' and Kullanici_Sifre='" + sifre + "'";
            komut.Connection = baglantı;
            okuma = komut.ExecuteReader();
            if (okuma.Read())
            {
                Form2 frm = new Form2();
                frm.ShowDialog();

            }
            else
            {
                this.Text = "Hata!!!";
                MessageBox.Show("Kullanıcı adı ya da şifre yanlış", this.Text);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sayı++;
            if (sayı % 2 == 0)
            {
                button1.Text = "Göster";
                textBox2.PasswordChar = '*';
            }
            else
            {
                button1.Text = "Gizle";
                textBox2.PasswordChar = '\0';
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            baglantı.Close();
        }
    }
}
