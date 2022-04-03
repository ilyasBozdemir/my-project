using System;
using System.Collections;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Web.UI.HtmlControls;
using System.Xml.Linq;
using System.Data.OleDb;

namespace odev.Admin
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                griddoldur();
            }

        }

        private void griddoldur()
        {

            DataTable dt;
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; DATA Source=" + Server.MapPath("../App_Data/vt1_admin.mdb"));
            baglanti.Open();

            string komut = "Select * from odalar";
            OleDbDataAdapter dAdapter = new OleDbDataAdapter(komut, baglanti);
            DataSet ds = new DataSet();
            dAdapter.Fill(ds);

            dt = ds.Tables[0];
            GridView1.DataSource = dt;
            GridView1.DataBind();
            baglanti.Close();

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            
            
            if (odaresmi.HasFile)
            {
                
                odaresmi.SaveAs(Server.MapPath("~/odaresimleri/") + odaresmi.FileName);


            }

            OleDbConnection baglan = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Server.MapPath("../App_Data/vt1_admin.mdb"));
            baglan.Open();
            string odaadix = txtodaadi.Text;
            string fiyatx = txtfiyat.Text;
            string resimx = odaresmi.PostedFile.FileName;


            OleDbCommand add = new OleDbCommand("INSERT INTO odalar (oda_adi,fiyat,resim) values ('" + odaadix + "','" + fiyatx + "','../odaresimleri/" + resimx + "')", baglan);
            int durum = add.ExecuteNonQuery();

            if (durum > 0)
            {

                Label1.Text = "kayıt eklendi";
            }
            else
            {
                Label1.Text = "kayıt eklenemedi";
            }
            baglan.Close();
        }

        protected void btnsil_Click(object sender, EventArgs e)
        {
            OleDbConnection baglanti = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; DATA Source=" + Server.MapPath("../App_Data/vt1_admin.mdb"));
            string silinecekler = "";
            foreach (GridViewRow satirbilgi in GridView1.Rows)
            {
                CheckBox chk = (CheckBox)satirbilgi.FindControl("chksec");
                if (chk != null & chk.Checked)
                {
                    silinecekler += satirbilgi.Cells[1].Text + ",";
                }
            }
            baglanti.Open();
            string komut = "delete * from  odalar where oda_id in (" + silinecekler.Remove(silinecekler.Length - 1, 1) + ")";
            OleDbCommand cmd = new OleDbCommand();
            cmd = new OleDbCommand(komut, baglanti);

            cmd.ExecuteNonQuery();
            cmd.Connection.Close();
            griddoldur();
        }





    }





}
