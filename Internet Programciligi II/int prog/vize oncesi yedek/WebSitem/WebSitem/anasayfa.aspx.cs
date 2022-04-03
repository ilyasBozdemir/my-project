using System;
using System.Data.OleDb;

namespace WebSitem
{
    public partial class anasayfa : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti;
            string Baglantiyolu = @"Provider = Microsoft.ACE.OLEDB.12.0; Data Source = " + Server.MapPath("~/Veritabanı\\Db_Duyuru.accdb");
            baglanti = new OleDbConnection(Baglantiyolu);
            baglanti.Open();
            OleDbCommand cmd = new OleDbCommand("Select * From Tbl_duyurular", baglanti);
            cmd.ExecuteNonQuery();
            baglanti.Close();
        }
        
    }
}