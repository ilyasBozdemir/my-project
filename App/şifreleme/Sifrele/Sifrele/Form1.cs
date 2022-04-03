using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;//şifreleme 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sifrele
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public static string MD5Sifrele(string sifrelenecekMetin)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] dizi = Encoding.UTF8.GetBytes(sifrelenecekMetin);
            dizi = md5.ComputeHash(dizi);
            StringBuilder sBuilder = new StringBuilder();

            foreach (byte ba in dizi)
            {
                sBuilder.Append(ba.ToString("x2").ToLower());
            }
            return sBuilder.ToString();
        }
        public string SHA1Sifrele(string sifrelenecekMetin)
        {

            SHA1 SHA1 = SHA1.Create();
            byte[] data = SHA1.ComputeHash(Encoding.Default.GetBytes(sifrelenecekMetin));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {

                sBuilder.Append(data[i].ToString("x2"));

            }

            return sBuilder.ToString();
        }
        public static string EncryptToBase64(string text)
        {
            byte[] EncryptAsBytes = System.Text.ASCIIEncoding.ASCII.GetBytes(text);
            string value = System.Convert.ToBase64String(EncryptAsBytes);
            return value;
        }
        public static string DecryptToBase64(string text)
        {
            byte[] DecryptAsBytes = System.Convert.FromBase64String(text);
            string value = System.Text.ASCIIEncoding.ASCII.GetString(DecryptAsBytes);
            return value;
        }
        private void btnSifrele_Click(object sender, EventArgs e)
        {
            string sifre = MD5Sifrele(txtsifrele.Text);
            txtmd5.Text = sifre.ToString();

            sifre = "";
            sifre = SHA1Sifrele(txtsifrele.Text);
            txtsha1.Text = sifre.ToString();
            sifre = EncryptToBase64(txtsifrele.Text);
            txtBaseSifre.Text = sifre.ToString();
        }

        private void btnSifreCoz_Click(object sender, EventArgs e)
        {
            string sifre = DecryptToBase64(txtsifrecoz.Text);
            txtBaseDesifre.Text = sifre.ToString();
        }
    }
}
