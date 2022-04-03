using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite
{
    public partial class users_chat : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection Baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(Baglanti, "veritabanim");
            string sql = "SELECT * FROM Mesajlar_Tablosu" /* WHERE Kimden=@kimden"*/;
            OleDbCommand cmd = new OleDbCommand(sql, Baglanti);
            string User = Session["üye"] != null ? Session["üye"].ToString() : "Hata";
            if (User == "Hata") Response.Write("Lütfen Oturum Açın");
            cmd.Parameters.AddWithValue("@kimden", User);
            OleDbDataReader oku = cmd.ExecuteReader();
           
            if (oku.Read())
            {
                //    GelenMesaj.Text = oku["Kimden"].ToString();
                //    GidenMesaj.Text = oku["Kime"].ToString();
            }
        }

       Label gelenmesaj(Label gelenMesaj)
        {
            return gelenMesaj;
        }
        
        public static List<string> GetUserName(string userName)
        {
            OleDbConnection Baglanti = new OleDbConnection();
            List<string> userResult = new List<string>();
            dbConnection.baglantiYap.BagKur(Baglanti, "veritabanim");
            string sql = "";
            OleDbCommand cmd = new OleDbCommand(sql, Baglanti);
            return userResult;

        }

        protected void dlMesajlar_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                Label GelenMesaj = (Label)this.Master.FindControl("dlMesajlar").FindControl("lblgelen");
                Label GidenMesaj = (Label)this.Master.FindControl("dlMesajlar").FindControl("lblgiden");
                gelenmesaj(GelenMesaj);
            }
        }
    }
}