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
    public partial class FrmGrafikler : Form
    {
        OleDbConnection baglantı = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Veritabanım.accdb");
        public FrmGrafikler()
        {
            InitializeComponent();
        }



        private void FrmGrafikler_Load(object sender, EventArgs e)
        {
            //grafik1
            baglantı.Open();
            OleDbCommand komutg1 = new OleDbCommand("select PerSehir,Count(*) From Tbl_Personel Group By PerSehir", baglantı);
            OleDbDataReader dr1 = komutg1.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Sehirler"].Points.AddXY(dr1[0], dr1[1]);
            }
            baglantı.Close();
            //grafik2
            baglantı.Open();
            OleDbCommand komutg2 = new OleDbCommand("select PerMeslek,Avg(PerMaas) From Tbl_Personel Group By PerMeslek", baglantı);
            OleDbDataReader dr2 = komutg2.ExecuteReader();
            while (dr2.Read())
            {
                chart2.Series["Meslek-Maas"].Points.AddXY(dr2[0], dr2[1]);
            }
            baglantı.Close();
        }
    }
}
