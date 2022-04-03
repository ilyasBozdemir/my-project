using mySite.Mail_Arayüzü;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite.Account
{
    public partial class forgot_password : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string aktivasyonKodu;
        protected void btnPasswReset_Click(object sender, EventArgs e)
        {
            aktivasyonKodu = Guid.NewGuid().ToString();
            string aktivasyonLinki = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority);
            aktivasyonLinki += "/Account/Sifremi-Yenile?reset-password=" + aktivasyonKodu + "&e-mail=" + tbE_posta.Text;
            SifreyiYenile(aktivasyonLinki);
            lblResult.Text = string.Format("\"{0}\" Adresinize Yenileme Kodu Gönderildi. Lütfen Kontrol Ediniz.", tbE_posta.Text);
        }
        void SifreyiYenile(string aktivasyonLinki)
        {
            string mesaj = "<h3>Şifre Yenileme Talebi</h3><br/>";
            mesaj += "Şifrenizi Yenilemek İçin Asagıdaki linke gidip şifrenizi yenileyiniz.<br/>";
            mesaj += @"Şifreyi yenilemek için buraya<a href=" + aktivasyonLinki + @">";
            mesaj += "tıklayınız</a>";
            string konu = "Üyelik Kaydı";
            string bilgi = "Site Üyelik Şifre Yenileme Formu";
            string baslik = "Şifrenizi mi Unuttunuz";
            Mail_Islemleri.MailAt(tbE_posta.Text, baslik, mesaj, konu, bilgi,null);
        }
    }
}