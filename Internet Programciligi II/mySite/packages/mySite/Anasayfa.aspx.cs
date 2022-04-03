using System;
using System.Data;
using System.Data.OleDb;
using System.Web.UI.WebControls;

namespace mySite
{
    public partial class Home : System.Web.UI.Page
    {
        OleDbConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            ResimGetir();
            //DinamikResimleriGetir();//2.secenek
            //
            
        }
        public string[] resimID = new string[9];
        void ResimGetir()
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT * FROM Resim_Tablosu";
            komut.Connection = baglanti;
            OleDbDataReader read = komut.ExecuteReader();
            Image imgResim;
            string klasor = "images/";
            for (int i = 1; i < 10; i++)
            {
                if (read.Read())
                {
                    imgResim = (Image)this.Master.FindControl("ContentPlaceHolder1").FindControl("Image" + i);
                    if (imgResim != null)
                    {
                        imgResim.ImageUrl = klasor + read["Resim_DosyaAdi"];
                        imgResim.Width = 150;
                        imgResim.Height = 100;
                        resimID[i - 1] = read["Resim_ID"] + "";
                    }
                }
            }
            baglanti.Close();
        }
        public string resimIDGetir(string resim)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            string sql = string.Format("SELECT Resim_ID FROM Resim_Tablosu WHERE Resim_DosyaAdi=@resim ", resim);
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@resim", resim);
            string id = null;
            OleDbDataReader okuveGetir = cmd.ExecuteReader();
            if (okuveGetir.Read())
                id = okuveGetir["Resim_ID"].ToString();
            return id;
        }
        void DinamikResimleriGetir()
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT * FROM Resim_Tablosu";
            komut.Connection = baglanti;
            OleDbDataReader read = komut.ExecuteReader();
            //
            int satirSayisi = 3;//  istenilirse veritabanından satır sütun ogrenlir ona göre dinamik ayarlanır :)
            int SütunSayisi = 3;// 3*3 tablo 
            for (int row = 0; row < satirSayisi; row++)
            {
                TableRow newRow = new TableRow();//satir
                Table1.Controls.Add(newRow);
                for (int column = 0; column < SütunSayisi; column++)
                {
                    TableCell newCell = new TableCell();//sütun
                    Image imgResim = new Image();
                    string klasor = "images/";
                    if (read.Read())
                    {
                        imgResim.ImageUrl = klasor + read["Resim_DosyaAdi"];
                        imgResim.Width = 150;
                        imgResim.Height = 100;
                    }
                    newCell.Controls.Add(imgResim);
                    newRow.Controls.Add(newCell);
                }
            }
            baglanti.Close();
        }
    }
}