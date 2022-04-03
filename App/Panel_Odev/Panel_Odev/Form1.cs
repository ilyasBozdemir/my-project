using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
namespace Panel_Odev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Aç Butonu
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textBox1.Text = "";
                StreamReader oku = new StreamReader(openFileDialog1.FileName);
                string satir = oku.ReadLine();
                while (satir != null)
                {
                    listBox1.Items.Add(satir);
                    satir = oku.ReadLine();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kaydedilecek veri yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                openFileDialog1.Title = "Kaydet";
                //Kaydet Butonu - dosya acıp üzerinde değişkilik yapmak bunu kaydetmek
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    string DosyaYolu = saveFileDialog1.FileName;
                    saveFileDialog1.Filter = "Text Dosyası (.txt)|*.txt";
                    FileStream Dosya = new FileStream(DosyaYolu, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                    StreamWriter Yazdır = new StreamWriter(Dosya);
                    Yazdır.Write(textBox1.Text);
                    Yazdır.Close();
                    Dosya.Close();
                }
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Kaydedilecek veri yok", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            else
            {
                saveFileDialog1.Title = "Farklı Kaydet";
                //Farklı Kaydet Butonu-var olan dosyayı farklı isimde kaydetmek
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    listBox1.Items.Clear();
                    string DosyaYolu = saveFileDialog1.FileName;
                    saveFileDialog1.Filter = "Text Dosyası (.txt)|*.txt";
                    FileStream Dosya = new FileStream(DosyaYolu, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.None);
                    StreamWriter Yazdır = new StreamWriter(Dosya);
                    Yazdır.Write(textBox1.Text);
                    Yazdır.Close();
                    Dosya.Close();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
