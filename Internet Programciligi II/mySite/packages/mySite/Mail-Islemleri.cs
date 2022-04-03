using System.Net;
using System.Net.Mail;

namespace mySite.Mail_Arayüzü
{
    public class Mail_Islemleri
    {
        public static void MailAt(string kime, string baslik, string mesaj, string konu, string bilgi,string file)
        {
            string userName = "sinemadunyasi.sd@gmail.com", password = "sinema.dunyasi70";
            SmtpClient Istemci = new SmtpClient("smtp.gmail.com", 587);
            Istemci.EnableSsl = true;
            Istemci.UseDefaultCredentials = true;
            Istemci.Credentials = new NetworkCredential(userName, password);
            MailMessage Mail = new MailMessage();
            Mail.From = new MailAddress(userName/*kimden geldigini gosterir*/, bilgi/* en üstte yazmasını istenilen yazı*/);
            Mail.To.Add(kime);
            Mail.Subject = baslik;
            Mail.IsBodyHtml = true;
            Attachment attachment;
            attachment = new Attachment(file);
            Mail.Attachments.Add(attachment);
            Mail.Body = string.Format("{0}", mesaj);
            Istemci.Send(Mail);
        }
    }
}