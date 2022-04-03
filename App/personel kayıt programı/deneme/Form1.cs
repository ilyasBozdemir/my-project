using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace deneme
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanım.accdb");
      
        void temizle()
        {
            txtPerAd.Text = "";
            txtPerMeslek.Text = "";
            txtPerSoyad.Text = "";
            comboPerSehir.Text = "";
            maskPerMaas.Text = "";
            radioBekar.Checked = false;
            radioEvli.Checked = false;
            txtPerAd.Focus();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter1.Fill(this.veritabanımDataSet1.Tbl_Personel);
        } 

        private void radioEvli_CheckedChanged(object sender, EventArgs e)
        {
          
            if (radioEvli.Checked==true)
            {
                label8.Text = "Evli";
            }
        }

        private void radioBekar_CheckedChanged(object sender, EventArgs e)
        {
            if (radioBekar.Checked == true)
            {
                label8.Text = "Bekar";
            }
        }

        private void btnListele_Click(object sender, EventArgs e)
        {
            this.tbl_PersonelTableAdapter1.Fill(this.veritabanımDataSet1.Tbl_Personel);
        }

        private void btnGüncelle_Click(object sender, EventArgs e)
        {
            DialogResult cevap = MessageBox.Show("Emin misin ", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
               baglantı.Open();
            string güncelle = "Update Tbl_Personel"
         + " set PerAd=@a1,PerSoyad=@a2,PerSehir=@a3,PerMaas=@a4,PerDurum=@a5,PerMeslek=@a6 ";
            OleDbCommand komut = new OleDbCommand(güncelle, baglantı);
            komut.Parameters.AddWithValue("@a1", txtPerAd.Text);
            komut.Parameters.AddWithValue("@a2", txtPerSoyad.Text);
            komut.Parameters.AddWithValue("@a3", comboPerSehir.Text);
            komut.Parameters.AddWithValue("@a4", maskPerMaas.Text);
            komut.Parameters.AddWithValue("@a5", label8.Text);
            komut.Parameters.AddWithValue("@a6", txtPerMeslek.Text);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Kayıt Güncellendi");
            }
            
            
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
                baglantı.Open();
                string kaydet = "insert into Tbl_Personel (PerAd,PerSoyad,PerSehir,PerMaas,PerDurum,PerMeslek) values (@p1,@p2,@p3,@p4,@p5,@p6)";
                OleDbCommand komut = new OleDbCommand(kaydet, baglantı);
                komut.Parameters.AddWithValue("@p1", txtPerAd.Text);
                komut.Parameters.AddWithValue("@p2", txtPerSoyad.Text);
                komut.Parameters.AddWithValue("@p3", comboPerSehir.Text);
                komut.Parameters.AddWithValue("@p4", maskPerMaas.Text);
                komut.Parameters.AddWithValue("@p5", label8.Text);
                komut.Parameters.AddWithValue("@p6", txtPerMeslek.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kayıt Eklendi");
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DialogResult cevap= MessageBox.Show("Emin misin ","Uyarı",MessageBoxButtons.YesNo,MessageBoxIcon.Warning);
            if (cevap == DialogResult.Yes)
            {
                baglantı.Open();
                string sil = "Delete from Tbl_Personel where PerAd=@k1";
                OleDbCommand komut = new OleDbCommand(sil, baglantı);
                komut.Parameters.AddWithValue("@k1", txtPerAd.Text);
                komut.ExecuteNonQuery();
                baglantı.Close();
                MessageBox.Show("Kayıt Silindi");
            }
        }

        private void btnTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int seçilendeğer = dataGridView1.SelectedCells[0].RowIndex;
            txtPerId.Text = dataGridView1.Rows[seçilendeğer].Cells[0].Value.ToString();
            txtPerAd.Text = dataGridView1.Rows[seçilendeğer].Cells[1].Value.ToString();
            txtPerSoyad.Text = dataGridView1.Rows[seçilendeğer].Cells[2].Value.ToString();
            comboPerSehir.Text = dataGridView1.Rows[seçilendeğer].Cells[3].Value.ToString();
            maskPerMaas.Text = dataGridView1.Rows[seçilendeğer].Cells[4].Value.ToString();
            label8.Text = dataGridView1.Rows[seçilendeğer].Cells[5].Value.ToString();
            txtPerMeslek.Text = dataGridView1.Rows[seçilendeğer].Cells[6].Value.ToString();

        }

        private void label8_TextChanged(object sender, EventArgs e)
        {
            if (label8.Text == "Evli")
            {
                radioEvli.Checked = true;
            }
            else
            {
                radioBekar.Checked = true;
            }
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void btnİstatistik_Click(object sender, EventArgs e)
        {
            Frmİstatistik fr = new Frmİstatistik();
            fr.ShowDialog();
        }

        private void btnGrafikler_Click(object sender, EventArgs e)
        {
            FrmGrafikler fr = new FrmGrafikler();
            fr.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRaporlama fr = new FrmRaporlama();
            fr.ShowDialog();
        }

     

      
    }
}
