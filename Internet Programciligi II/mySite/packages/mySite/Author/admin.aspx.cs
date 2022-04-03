using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite.author
{
    public partial class admin : System.Web.UI.Page
    {
        OleDbConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            string getUser = "SELECT * FROM Yonetim_Tablosu WHERE Yonetim_ID=@id";
            OleDbCommand cmd = new OleDbCommand(getUser, baglanti);
            cmd.Parameters.AddWithValue("@id", Request.QueryString["a"]);
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
            {
                string klasor = "../management/profile/";//klasorun adı
                lbladminName.Text = oku["Yonetim_adSoyad"] + "";
                imgFoto.ImageUrl = klasor + oku[4];//4.indexteki sütun
            }
        }
    }
}