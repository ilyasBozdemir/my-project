using System;
using System.Web.UI;
using System.Data;
using System.Data.OleDb;
using System.Web.UI.WebControls;
using System.IO;

namespace mySite
{
    public partial class index : System.Web.UI.MasterPage
    {
        OleDbConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            getir();
        }
        void getir()
        {
            slider();
            slider_tn();
            LogoGetir();
            DuyuruGetir();
            PageTitleGetir();
            string baglantiyolu = null, baglantiyolu2 = null;
            if (Session["üye"] != null)
            {
                string uyeAdi = Session["üye"].ToString();
                string uyeFoto = Session["üyeFoto"].ToString();
                lblUyeAdSoyad.Text = uyeAdi;
                imgProfile.ImageUrl = uyeFoto;
                imgProfile.Width = 35;
                lblUyeAdSoyad.CssClass = "uyeAdsoyad";
            }
            else
            {
                baglantiyolu = "../users/Kaydol";//kaydol linkine tıklayınca gidecegi sayfa adresi
                baglantiyolu2 = "../users/Oturum-Aç";//oturum aç linkine tıklayınca gidecegi sayfa adresi
                lblKaydol.Text = @"<a href=" + baglantiyolu + @" id =" + "Kaydol" + ">Kaydol<a/>";
                lblOturumAc.Text = $"<a href= {baglantiyolu2}id=\"oturumAc\">Oturum Aç<a/>";

            }
        }
        void slider()
        {
            baglanti = new OleDbConnection();
            mySite.dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand komut = new OleDbCommand("Select * From Slider_Tablosu", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            dlSlider.DataSource = oku;
            dlSlider.DataBind();
            baglanti.Close();
        }
        void slider_tn()//tn kucuk resim için
        {
            baglanti = new OleDbConnection();
            mySite.dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand komut = new OleDbCommand("Select * From Slider_Tablosu", baglanti);
            OleDbDataReader oku = komut.ExecuteReader();
            dlSlider_tn.DataSource = oku;
            dlSlider_tn.DataBind();
            baglanti.Close();
        }
        void LogoGetir()
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT TOP 1 * FROM Logo_Tablosu ORDER BY Logo_id DESC";//en son ki kaydı al
            komut.Connection = baglanti;
            OleDbDataReader read = komut.ExecuteReader();
            string klasor = "images/Logo/";
            if (read.Read())
            {
                imgLogo.ImageUrl = klasor + read["Logo_DosyaAdi"];
                logoAciklama.Text = read["Logo_Aciklamasi"] + "";
            }
        }
        void DuyuruGetir()
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand cmd = new OleDbCommand("Select * From Duyuru_Tablosu", baglanti);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(cmd);
            DataSet ds = new DataSet();
            cmd.ExecuteNonQuery();
            baglanti.Close();
            dataadapter.Fill(ds);
            dl_duyuru.DataSource = ds;
            dl_duyuru.DataBind();
        }
        void PageTitleGetir()
        {
            string dosyaAdi = Request.RawUrl;
            //int index = dosyaAdi.IndexOf(".");
            //Page.Title = dosyaAdi.Substring(1, index - 1) + " | MySite";
            Page.Title = dosyaAdi.Remove(0, 1) + " | MySite";
        }
        protected void btnSearch_Click(object sender, EventArgs e)
        {

        }
    }
}