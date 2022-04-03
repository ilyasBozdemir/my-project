using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;//input-out işlemi için kütüphane
namespace Klasörleme_işlemleri
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string yol = "", klasöradı;

        private void button1_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                yol = folderBrowserDialog1.SelectedPath;
                textBox2.Text = yol;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            klasöradı = textBox1.Text;
            if (klasöradı == "")
            {
                MessageBox.Show("Klasör Adı Boş Olamaz!!!", "Hata");
            }
            else if (yol == "")
            {
                MessageBox.Show("Klasör Dizini Belirtilmemiş", "Hata");
            }
            else
            {
                Directory.CreateDirectory(yol + "\\" + klasöradı);
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                yol = folderBrowserDialog1.SelectedPath;
                textBox2.Text = yol;
            }

            if (yol == "C:\\Windows")
            {
                MessageBox.Show("Windows Dosyasını silmeye yetkiniz yok", "Hata");
            }
            else if (yol == "C:\\Users")
            {
                MessageBox.Show("Windows Dosyasını silmeye yetkiniz yok", "Hata");
            }
            else if (yol == "C:\\MSI")
            {
                MessageBox.Show("Windows Dosyasını silmeye yetkiniz yok", "Hata");
            }
            else if (yol == "C:\\PerfLogs")
            {
                MessageBox.Show("Windows Dosyasını silmeye yetkiniz yok", "Hata");
            }
            else if (yol == "C:\\Program Files (x86)")
            {
                MessageBox.Show("Windows Dosyasını silmeye yetkiniz yok", "Hata");
            }
            else if (yol == "C:\\Program Files")
            {
                MessageBox.Show("Windows Dosyasını silmeye yetkiniz yok", "Hata");
            }
            else
            {
                if (yol == "")
                {
                    MessageBox.Show("Klasör Dizini Belirtilmemiş", "Hata");
                }
                else
                {
                    Directory.Delete(yol + "\\" + klasöradı);
                }
            }


        }

        private void button4_Click(object sender, EventArgs e)
        {
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            if (textBox3.Text == "ilyass")
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (textBox3.Text == "ilyass")
            {
                button3.Enabled = true;
            }
            else
            {
                button3.Enabled = false;
            }

        }


        private void label2_Click(object sender, EventArgs e)
        {

        }




    }
}
