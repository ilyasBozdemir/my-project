using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite.users
{
    public partial class user : System.Web.UI.Page
    {
        OleDbConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            string getUser = "SELECT * FROM Uyeler_Tablosu WHERE Uye_ID=@id";
            OleDbCommand cmd = new OleDbCommand(getUser, baglanti);
            cmd.Parameters.AddWithValue("@id", Request.QueryString["u"]);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                string klasor = "../users/profile/";//klasorun adı
                lblUserName.Text = oku[1] + "";//1.indexteki sütun
                imgFoto.ImageUrl = klasor + oku[4];//4.indexteki sütun
                lblHakkinda.Text =oku["Uye_Hakkinda"].ToString();
            }
        }
    }
}