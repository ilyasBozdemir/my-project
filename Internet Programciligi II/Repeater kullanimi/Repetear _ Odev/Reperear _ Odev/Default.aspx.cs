using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Reperear___Odev
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\Users\İlyas70\Desktop\Reperear _ Odev\Reperear _ Odev\App_Data\personelVeritabanı.accdb");
            baglanti.Open();
            OleDbCommand komut = new OleDbCommand("Select * from personel", baglanti);
            Repeater1.DataSource = komut.ExecuteReader();
            Repeater1.DataBind();
            baglanti.Close();
           
        }
    }
}