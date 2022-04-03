using System;
using System.Data.OleDb;
namespace odev.Admin
{
    public partial class WebForm3 : System.Web.UI.Page
    {
       
        protected void Page_Load(object sender, EventArgs e)
        {
            

        }
      
        protected void Button1_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("~/App_Data/vt1_admin.mdb") + "");
            baglanti.Open();
            if (fuResim.HasFile)
            {
                fuResim.SaveAs(Server.MapPath("/Admin/resim/" + fuResim.FileName));
                OleDbCommand komut = new OleDbCommand("insert into slider(resim_yolu)values('" + fuResim.FileName + "')", baglanti);
                komut.ExecuteNonQuery();
                Button1.Text =("Başarıyla Eklendi...");
            }
            else
                Button1.Text="Resim Ekle..!";
            baglanti.Close();
            

        }
    }
}
