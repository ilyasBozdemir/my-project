using mySite.Mail_Arayüzü;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite
{
    public partial class iletisim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public static string konu = "";
        public static string bilgi = "";
        public static string baslik = "";
        public static string ipAdresi = "";
        public static string adSoyad;
        public static string web;

        void MailTo()
        {
            konu = "iletişim Mesajı";
            bilgi = "Site iletişm Mesajı";
            baslik = "Yeni iletişim Mesajı Geldi";
            string mesaj = string.Format("Adı Soyadı : {0}<br/>E-posta adresi : {1}<br/>Web-Sitesi : {2}<br/>Mesajı : {3}<br/>Mesaj Tarihi : {4}",
             tbAdSoyad.Text, tbMail.Text, tbSite.Text, tbMesaj.Text, DateTime.Now.ToString());

            if (HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"] != null)
                ipAdresi = HttpContext.Current.Request.ServerVariables["HTTP_X_FORWARDED_FOR"].ToString();
            else if (HttpContext.Current.Request.UserHostAddress.Length != 0)
                ipAdresi = HttpContext.Current.Request.UserHostAddress;
            string alanAdi = HttpContext.Current.Request.Url.GetLeftPart(UriPartial.Authority) + "/mail-sayfalari/iletisim-mail.aspx";//bu sayfayı postalayacaz mail'le
            WebRequest webIstegi = WebRequest.Create(alanAdi);
            webIstegi.Proxy = WebRequest.GetSystemWebProxy();
            webIstegi.Timeout = 15000;
            WebResponse webYaniti = webIstegi.GetResponse();
            StreamReader reader = new StreamReader(webYaniti.GetResponseStream());

            Mail_Islemleri.MailAt("bozdemir.ib70@gmail.com", baslik,reader.ReadToEnd(), konu, bilgi, "");
        }

        protected void btnGonder_Click(object sender, EventArgs e)
        {
            MailTo();
        }
    }
}