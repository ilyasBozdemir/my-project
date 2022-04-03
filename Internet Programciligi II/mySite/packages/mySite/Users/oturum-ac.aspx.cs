using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite
{
    public partial class oturum_ac : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["üye"] != null)
                Response.Redirect("../Home.aspx");
        }
        OleDbConnection baglanti;
        protected void btnOturumAc_Click(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            string KullaniciGetir = "SELECT * FROM Uyeler_Tablosu WHERE "
                + "Uye_Eposta=@eposta AND Uye_Sifre=@Sifre";
            OleDbCommand cmd = new OleDbCommand(KullaniciGetir, baglanti);
            cmd.Parameters.AddWithValue("@eposta", tbE_posta.Text);
            cmd.Parameters.AddWithValue("@Sifre", tbSifre.Text);
            OleDbDataReader read = cmd.ExecuteReader();
            if (read.Read())
            {
                string KlasörYolu = "../users/profile/";
                Session.Add("üye", read["Uye_adSoyad"].ToString());// 1.kullanım sekli
                Session["üyeFoto"] = KlasörYolu + read["Uye_Fotograf"].ToString();// 2.kullanım sekli
                Response.Redirect("../Home.aspx");
            }
            else
            {
                lblBilgi.Text = "E-posta veya şifreniz yanlıştır.";
            }
        }
    }
}