using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
namespace odev
{
    public partial class _Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        OleDbConnection baglan;
        OleDbDataAdapter adaptor;
        protected void Button1_Click(object sender, EventArgs e)
        {
            string veriYolu = Server.MapPath("/App_Data/tablom.accdb");
            string yol = $@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={veriYolu}";
            baglan = new OleDbConnection(yol);
            string sql = "select * from Kişiler";
            adaptor = new OleDbDataAdapter(sql,baglan);
            DataSet ds = new DataSet();
            adaptor.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }
    }
}