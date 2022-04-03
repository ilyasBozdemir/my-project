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
using System.Security.Cryptography;//ekleyin
namespace Örnek_VeriTabanı
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı;
        OleDbDataReader okuma;
        public static string MD5Sifrele(string sifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sb = new StringBuilder();

            foreach (byte ba in dizi)
            {
                sb.Append(ba.ToString("x2").ToLower());
            }
            return sb.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            baglantı= new OleDbConnection ("Provider = Microsoft.ACE.OLEDB.12.0 ; Data Source = Veritabanım.accdb");
            baglantı.Open();
            string sorgu = "select * from Kullanici where Kullanici_Adi=@p1 and Kullanici_Sifre=@p2";
            OleDbCommand komut = new OleDbCommand(sorgu,baglantı);
            //
            string sifre = MD5Sifrele(textBox2.Text);//kullanici şifre alanı
            //
            komut.Parameters.AddWithValue("@p1",textBox1.Text);
            komut.Parameters.AddWithValue("@p2", sifre);
            okuma = komut.ExecuteReader();
          
            if (okuma.Read())
            {
                MessageBox.Show("Kullanici adı & şifre dogru ");
                //k.adı = admin 
                //k.şifre = admin
            }
            else
            {
                MessageBox.Show("Kullanici adı & şifre yanlıs !");
            }
        
            baglantı.Close();
           
        }
    }
}
