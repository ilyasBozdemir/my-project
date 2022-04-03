using System;
using System.Data;
using System.Data.OleDb;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite
{
    public partial class resim_ayrinti : System.Web.UI.Page
    {
        OleDbConnection baglanti;
        protected void Page_Load(object sender, EventArgs e)
        {
            Delegate t = new Delegate(Getir);
            t += YorumGetir;
            t += ayrintiGetir;
            t += yorumSayisiGetir;
            resimID = Request.QueryString["resim-id"];
            t(resimID);//nesne sayesinde birden fazla aynı parametre alan methodları temsilicyle tek yerden kontrol etme
        }
        public delegate void Delegate(string resimID);
        public string resimID = "";
        public void Getir(string resimID)
        {
            resimID = Request.QueryString["resim-id"];
        }
        private void ayrintiGetir(string resimID)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand komut = new OleDbCommand();
            komut.CommandText = string.Format("SELECT * FROM Resim_Tablosu WHERE Resim_ID={0}", resimID);
            komut.Connection = baglanti;
            OleDbDataReader read = komut.ExecuteReader();
            Image imgSlider = (Image)this.Master.FindControl("ContentPlaceHolder1").FindControl("imgResim");
            Label lblAdi = (Label)this.Master.FindControl("ContentPlaceHolder1").FindControl("lblAdi");
            Label lblAciklama = (Label)this.Master.FindControl("ContentPlaceHolder1").FindControl("lblAciklamasi");
            string klasor = "images";//dosya serverde ki slider klasorunde oldugu için buraya adını yazdık.
            if (read.Read())
            {
                imgSlider.ImageUrl = klasor + "/" + read["Resim_DosyaAdi"];
                lblAdi.Text = "<b>Adı : </b>" + read["Resim_DosyaAdi"];
                lblAciklama.Text = "<b>Açıklaması : </b> " + read["Resim_Aciklamasi"];
            }
            baglanti.Close();
        }
        /*---*/
        //isimden sorguladık aynı isimden olsa ilk ismin kaydını alır bu öğrenme amaclıdır geliştirilebilir.
        //cogu kayıt için oyle yapıldı.
        /*---*/
        void yorumlariGetir(string query, DataList dataList)//ana ve alt yorumlar için aynı kod satırlarını yazmaktansa bu daha mantıklı :)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbDataAdapter adp = new OleDbDataAdapter(query, baglanti);
            DataTable table = new DataTable();
            adp.Fill(table);
            dataList.DataSource = table;
            dataList.DataBind();
            baglanti.Close();
        }
        void YorumGetir(string resimID)
        {
            string query = string.Format("SELECT * FROM Yorumlar_Tablosu WHERE Resim_ID={0} AND Ana_Alt_Yorum = 0 ORDER BY Yorum_Tarihi ASC", resimID);//0 olan ana yorum :)
            yorumlariGetir(query, dl_yorum);
        }
        void AltYorumGetir(string resimID, DataList dl_alt_yorum, int AnaYorumID)
        {
            string query = string.Format("SELECT * FROM Yorumlar_Tablosu WHERE Resim_ID = {0} AND Ana_Alt_Yorum = {1}"
                + " AND Ana_Yorum_ID={2} ORDER BY Yorum_Tarihi ASC", resimID, 1, AnaYorumID);//1 olan alt yorum :)
            yorumlariGetir(query, dl_alt_yorum);
        }
        void yorumSayisiGetir(string resimID)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            string yorumGetir = string.Format("SELECT COUNT (*) FROM Yorumlar_Tablosu WHERE Resim_ID = {0}", resimID);
            OleDbCommand cmd = new OleDbCommand(yorumGetir, baglanti);
            OleDbDataReader reader = cmd.ExecuteReader();
            if (reader.Read())
                lblYorumSayisi.Text = "Yorum Sayısı : " + reader[0];
            baglanti.Close();
        }
        protected void dl_yorum_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem)
            {
                DataList dl_alt_yorum = (DataList)e.Item.FindControl("dl_alt_yorum");//içte ki datalisti çektik
                anaYorumID = Convert.ToInt32(DataBinder.Eval(e.Item.DataItem, "Yorum_ID").ToString());
                AltYorumGetir(resimID, dl_alt_yorum, anaYorumID);
                Label lblYorumID = (Label)e.Item.FindControl("lblYorumID");

            }
        }
        int anaYorumID = 0;
        protected void dl_alt_yorum_ItemDataBound(object sender, DataListItemEventArgs e)
        {
            string yanitVerilenKisiAdi = Sorgulamayap(anaYorumID);
            Label lblYanitVerilen = (Label)e.Item.FindControl("lblYanitVerilen");
            if (lblYanitVerilen != null)
                lblYanitVerilen.Text = "@" + yanitVerilenKisiAdi;
            if (e.Item.ItemType == ListItemType.Item || e.Item.ItemType == ListItemType.AlternatingItem) { }
            Label lblYorumID = (Label)e.Item.FindControl("lblYorumID");

        }
        private string Sorgulamayap(int id)
        {
            string isim = null;
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            string SqlSorgusu = $"SELECT Yorumcu_AdSoyad as adSoyad FROM Yorumlar_Tablosu WHERE Yorum_ID = {id}";
            OleDbCommand newCommand = new OleDbCommand(SqlSorgusu, baglanti);
            OleDbDataReader oku = newCommand.ExecuteReader();
            if (oku.Read())
                isim = "" + oku["adSoyad"];
            baglanti.Close();
            return isim;
        }
        protected void btnYorumYap_Click(object sender, EventArgs e)//bu buton denenmedi test asamasında
        {
            #region a
            string adSoyad, Mail, Mesaj;
            adSoyad = tbAdSoyadtxt.Text;
            Mail = tbEmailtxt.Text;
            Mesaj = tbYorumtxt.Text;
            if (adSoyad != null & Mail != null & Mesaj != null)
            {
                baglanti = new OleDbConnection();
                dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
                string cmdText = string.Format("SELECT * FROM Uyeler_Tablosu WHERE Uye_Eposta = {0}", "@mail");
                OleDbCommand cmd = new OleDbCommand(cmdText, baglanti);
                cmd.Parameters.AddWithValue("@mail", Mail);
                OleDbDataReader üyeKontrolEt = cmd.ExecuteReader();
                string rol = "Üye";//bu sayfadan üyeler mesaj attığı için - yetkililer admin sayfasından takip edip atıcak :))
                if (üyeKontrolEt.Read())//üyeyse
                {
                    lblKontrol.Text = "";
                    string altDurumID = Request.QueryString["alt-yorum-id"];
                    string yorumuBelirle = null;
                    string yorumID = null;
                    if (altDurumID == null)
                    {
                        yorumuBelirle = yorumID = "0";
                    }
                    else
                    {
                        yorumuBelirle = "1";
                        yorumID = YorumidGetir();
                    }
                    //
                    string SQL = "INSERT INTO Yorumlar_Tablosu "
                         + "(Resim_ID,Yorumcu_AdSoyad,Yorumcu_Fotograf,Yorum_Mesaji,"
                         + "Yorum_Tarihi,Yorum_Yetki,Ana_Alt_Yorum,Ana_Yorum_ID)"
                         + "VALUES "
                         + "( @p1,@p2,@p3,@p4,@p5,@p6,@p7,@p8 )";
                    OleDbCommand cmd2 = new OleDbCommand(SQL, baglanti);
                    cmd2.Parameters.AddWithValue("@p1", resimID);
                    cmd2.Parameters.AddWithValue("@p2", adSoyad);
                    cmd2.Parameters.AddWithValue("@p3", "yorum-profil.jpg");//varsayılan pp
                    cmd2.Parameters.AddWithValue("@p4", Mesaj);
                    cmd2.Parameters.AddWithValue("@p5", DateTime.Now.ToString());
                    cmd2.Parameters.AddWithValue("@p6", rol);
                    cmd2.Parameters.AddWithValue("@p7", yorumuBelirle);
                    cmd2.Parameters.AddWithValue("@p8", yorumID);
                    cmd2.ExecuteNonQuery();
                    Response.Redirect(Request.RawUrl, true);
                }
            }
            else
                lblKontrol.Text = "İlgili Yerleri Doldurunuz.";
            baglanti.Close();
            #endregion

        }

        private string YorumidGetir()
        {
            string id = null;
            return id;
        }

        public string idGetir(string sql, string parameter)
        {
            baglanti = new OleDbConnection();
            dbConnection.baglantiYap.BagKur(baglanti, "veritabanim");
            OleDbCommand cmd = new OleDbCommand(sql, baglanti);
            cmd.Parameters.AddWithValue("@p1", parameter);
            string id = null;
            OleDbDataReader oku = cmd.ExecuteReader();
            if (oku.Read())
                id = oku[0].ToString();
            baglanti.Close();
            return id;
        }
        public string userIDGetir(string user)
        {
            return idGetir("SELECT Uye_ID as use FROM Uyeler_Tablosu WHERE Uye_adSoyad=@p1", user);
        }
        public string adminIDGetir(string admin)
        {
            return idGetir("SELECT Yonetim_ID FROM Yonetim_Tablosu WHERE Yonetim_adSoyad=@p1", admin);
        }
        public string users()
        {
            return "../users/user?u=" + userIDGetir(Eval("Yorumcu_AdSoyad") + "");
        }
        public string admin()
        {
            return "../author/admin?a=" + adminIDGetir(Eval("Yorumcu_AdSoyad") + ""); ;
        }

    }
}

