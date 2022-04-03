using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite.mail_sayfalari
{
    public partial class iletisim_mail : System.Web.UI.Page
    {
        OleDbConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            //
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
            //
            lblIPAdresi.Text = iletisim.ipAdresi;
            string bilgi = iletisim.bilgi;
            lblAdSoyad.Text = iletisim.adSoyad;
            lblWebAdres.Text = iletisim.web;

        }
        public string Home()
        {
            return string.Format("{0}/Anasayfa", HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority));
        }
        public string About()
        {
            return string.Format("{0}/Hakkımızda", HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority));
        }
        public string Contact()
        {
            return string.Format("{0}/Iletişim", HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority));
        }
    }
}