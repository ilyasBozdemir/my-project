using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace mySite.users
{
    public partial class profilim : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["üye"] == null)
            {
                Response.Redirect("~/Home.aspx");
            }
        }
    }
}