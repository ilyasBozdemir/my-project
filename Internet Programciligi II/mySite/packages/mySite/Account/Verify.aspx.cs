using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite.Account
{
    public partial class Verify : System.Web.UI.Page
    {
        OleDbConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            string activationCode = activationCode = Request.QueryString["activationCode"].ToString();
            string email = email = Request.QueryString["e-mail"].ToString();
            if (activationCode != null & email != null)
            {
                if (kayit_ol.aktivasyonKodu == Request.QueryString["activationCode"].ToString())//rastgele yazarak
                {//siteye kabul ettiremesinler diye aynı mı değil mi kontrolü
                    baglanti = new OleDbConnection();
                    dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
                    string dogrula = "UPDATE Uyeler_Tablosu SET Uye_Dogrulama=@p1 WHERE Uye_Eposta=@p2";
                    OleDbCommand cmd = new OleDbCommand(dogrula, baglanti);
                    cmd.Parameters.AddWithValue("@p1", 1);//dogrulanan 1 oluyor.bu sekilde ayırt ediyoruz 
                    cmd.Parameters.AddWithValue("@p2", email);
                    lblBilgilendirme.Text = (cmd.ExecuteNonQuery() > 0) ? "Üyeliginiz Etkinleştirilmiştir."
                    : "Üyeliginiz Etkinleştirilememiştir.Tekrar Deneyiniz.";
                    baglanti.Close();
                }
                else
                    lblBilgilendirme.Text = " Hata : Geçersiz Aktivasyon Kodu";
            }
        }
    }
}