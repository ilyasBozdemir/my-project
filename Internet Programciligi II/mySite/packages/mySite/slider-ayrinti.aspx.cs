using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite
{
    public partial class slider_ayrinti1 : System.Web.UI.Page
    {
        OleDbConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            ayrintiGetir();
        }
        private void ayrintiGetir()
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = "SELECT * FROM Slider_Tablosu WHERE Slider_ID=@ID";
            komut.Parameters.AddWithValue("@ID", Request.QueryString["slider-id"]);
            komut.Connection = baglanti;
            OleDbDataReader read = komut.ExecuteReader();
            Image imgSlider = (Image)this.Master.FindControl("ContentPlaceHolder1").FindControl("imgSlider");
            Label imgAdi = (Label)this.Master.FindControl("ContentPlaceHolder1").FindControl("lblSliderAdi");
            Label imgAciklama = (Label)this.Master.FindControl("ContentPlaceHolder1").FindControl("lblSliderAciklama");
            string klasor = "slider";//dosya serverde ki slider klasorunde oldugu için buraya adını yazdık.
            if (read.Read())
            {
                imgSlider.ImageUrl = klasor + "/" + read["Slider_DosyaAdi"];
                imgAdi.Text = "<b>Adı : </b>" + read["Slider_Adi"];
                imgAciklama.Text = "<b>Açıklaması : </b> " + read["Slider_Aciklama"];
            }
        }
    }
}