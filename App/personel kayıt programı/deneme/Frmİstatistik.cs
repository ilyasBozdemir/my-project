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
namespace deneme
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanım.accdb");
        private void Frmİstatistik_Load(object sender, EventArgs e)
        {  
            //toplam personel
            baglantı.Open();
            OleDbCommand komut1 = new OleDbCommand("select Count (*) from Tbl_Personel",baglantı);
            OleDbDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                lblTopPer.Text = dr1[0].ToString();
            }
            baglantı.Close();
            //evli personel
            baglantı.Open();
            OleDbCommand komut2 = new OleDbCommand("select Count (*) from Tbl_Personel where PerDurum='Evli'", baglantı);
            OleDbDataReader dr2 = komut2.ExecuteReader();
            while (dr2.Read())
            {
                lblEvPer.Text = dr2[0].ToString();
            }
            baglantı.Close();
            //bekar personel
            baglantı.Open();
            OleDbCommand komut3 = new OleDbCommand("select Count (*) from Tbl_Personel where PerDurum='Bekar'", baglantı);
            OleDbDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                lblBekPer.Text = dr3[0].ToString();
            }
            baglantı.Close();
          //sehir sayısı
            baglantı.Open();
            OleDbCommand komut4 = new OleDbCommand("select Count  (PerSehir) from Tbl_Personel", baglantı);
            OleDbDataReader dr4 = komut4.ExecuteReader(); 
            while (dr4.Read())
            {
                lblŞehir.Text = dr4[0].ToString();
            }
         
            baglantı.Close();
            //toplam maas sayısı
            baglantı.Open();
            OleDbCommand komut5 = new OleDbCommand("select Sum(PerMaas) from Tbl_Personel", baglantı);
            OleDbDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                lblTopMaaş.Text = dr5[0].ToString();
            }

            baglantı.Close();
            //toplam maas sayısı
            baglantı.Open();
            OleDbCommand komut6 = new OleDbCommand("select Avg(PerMaas) from Tbl_Personel", baglantı);
            OleDbDataReader dr6 = komut6.ExecuteReader();
            while (dr6.Read())
            {
                lblOrtMaaş.Text = dr6[0].ToString();
            }

            baglantı.Close();
        }
    }
}
