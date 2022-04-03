using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite.Account
{
    public partial class reset_password : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            string reset_passwordCode = Request.QueryString["reset-password"].ToString();
            if (forgot_password.aktivasyonKodu == reset_passwordCode)
            {
              //yeni şifre Vermek için alan olustur
            }
            else
            {
                //hata mesajı ver /guvenlik amaclı :))
            }
        }
    }
}