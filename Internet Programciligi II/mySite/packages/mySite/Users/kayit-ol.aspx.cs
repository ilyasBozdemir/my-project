using mySite.Mail_Arayüzü;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite
{
    public partial class kayit_ol : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //string sdf = "ilyas";
            //string a = $" merhaba {sdf}!";
            //Response.Write(a);

        }

        OleDbConnection baglanti;
        public static string aktivasyonKodu = null;
        protected void btnKaydol_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            string uyeEkle = "INSERT INTO Uyeler_Tablosu  (Uye_adSoyad,Uye_Eposta,Uye_Sifre,Uye_Dogrulama) "
                + "VALUES (@adSoyad,@Eposta,@Sifre,@dogrulama)";
            OleDbCommand cmd = new OleDbCommand(uyeEkle, baglanti);
            cmd.Parameters.AddWithValue("@adSoyad", tbAdSoyad.Text);
            cmd.Parameters.AddWithValue("@Eposta", tbEposta.Text);
            cmd.Parameters.AddWithValue("@Sifre", tbSifre.Text);
            cmd.Parameters.AddWithValue("@dogrulama", tbSifre.Text);
            cmd.ExecuteNonQuery();
            aktivasyonKodu = Guid.NewGuid().ToString();
            string aktivasyonLinki = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority);
            //sitenin adını alır.
            aktivasyonLinki += $"/Account/Verify?activationCode={aktivasyonKodu}&e-mail={tbEposta.Text}";
            BilgiMailiGonder(aktivasyonLinki);
            tbAdSoyad.Text = tbEposta.Text = tbSifre.Text = tbSifreTekrar.Text = "";
            Response.Redirect("Oturum-Aç");
            baglanti.Close();
        }
        private void BilgiMailiGonder(string aktivasyonLinki)
        {
            string mesaj = null;
            mesaj = "Sayın " + tbAdSoyad.Text + ";<br/>";
            mesaj += "Sitemize Üyeliginiz Olusturulmustur.Aşagıdaki linke tıklayarak üyeliğinizi doğrulayınız.<br/>";
            mesaj += aktivasyonLinki;
            string konu = "Üyelik Kaydı";
            string bilgi = "Site Üyelik Kayıt Doğrulama Formu";
            string baslik = "Üyelik Olusturdunuz.";
            Mail_Islemleri.MailAt(tbEposta.Text, baslik, mesaj, konu, bilgi, null);
        }
    }
}