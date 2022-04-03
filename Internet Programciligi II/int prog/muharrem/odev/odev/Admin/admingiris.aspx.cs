using System;
using System.Data.OleDb;

namespace odev.Admin
{
    public partial class _default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btngiris_Click(object sender, EventArgs e)
        {
            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("../App_Data/vt1_admin.mdb"));
            baglan.Open();
            string email = kadi.Text;
            string sifrex = sifre.Text;
            OleDbCommand vericek = new OleDbCommand("SELECT * FROM kullanici Where kullanici_adi='" + email + "' and sifre='" + sifrex + "'", baglan);
            OleDbDataReader oku = vericek.ExecuteReader();
            if (oku.Read())
            {
                Session.Add("kullanici", email) 
                Response.Redirect("duyurular.aspx");
            }
            else
            { 
                lblInfo.Text = "Hatalı kullanıcı adı veya şifre";
            }

            baglan.Close();


        }
    }
}
