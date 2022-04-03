using mySite;
using System;
using System.Web;
using System.Web.Routing;

namespace SiteOdev.App_Start
{
    public static class RouteConfig
    {
        public static void RegisterRoutes(RouteCollection routes)
        {
            //kullanıcı tarafında ki sayfa url'leri
            /* routes.MapPageRoute(Route ismi, Route URL,/*Fiziksel Yolu); */
            string[] klasoryollari = { "~/", "~/Account/", "~/Author/", "~/Users/", "~/management/" };
            string[] RouteIsmi = { "Route01", "Route02", "Route03", "Route04", "Route05",
                                   "Route06", "Route07", "Route08", "Route09", "Route10" };

            string[] RouteURL = { "Anasayfa", "Hakkımızda", "Iletişim", "Resim_ayrıntı", "Slider_ayrıntı",
                                  "Hesap-Doğrulama","Sifremi-Unuttum","Sifremi-Yenile",
                                  "Admin",
                                  "Kaydol" ,"Oturum-Aç","Profilim"};

            string[] FizikselYolu = { "~/Anasayfa.aspx", "~/hakkimizda.aspx", "~/iletisim.aspx", "~/resim-ayrinti.aspx",
                                      "~/slider-ayrinti.aspx",
                                       "/verify.aspx","/forgot-password.aspx","/reset-password.aspx",
                                       "/admin.aspx" ,
                                       "/kayit-ol.aspx","/oturum-ac.aspx","/profilim.aspx",};
            for (int i = 0; i < RouteIsmi.Length; i++)
                if (i < 5) routes.MapPageRoute(RouteIsmi[i], RouteURL[i], FizikselYolu[i]);
            /*5 kok dizin var*/
            for (int i = 5; i < RouteIsmi.Length; i++)
            {
                switch (i)
                {
                    case 5: routes.MapPageRoute(RouteIsmi[i], "{0}/" + RouteURL[i], klasoryollari[1] + FizikselYolu[i]); break;//account
                    case 6: routes.MapPageRoute(RouteIsmi[i], "{0}/" + RouteURL[i], klasoryollari[1] + FizikselYolu[i]); break;
                    case 7: routes.MapPageRoute(RouteIsmi[i], "{0}/" + RouteURL[i], klasoryollari[1] + FizikselYolu[i]); break;

                    case 8: routes.MapPageRoute(RouteIsmi[i], "{0}/" + RouteURL[i], klasoryollari[2] + FizikselYolu[i]); break;//author

                    case 9: routes.MapPageRoute(RouteIsmi[i], "{0}/" + RouteURL[i], klasoryollari[3] + FizikselYolu[i]); break;//users
                    case 10: routes.MapPageRoute(RouteIsmi[i], "{0}/" + RouteURL[i], klasoryollari[3] + FizikselYolu[i]); break;
                    case 11: routes.MapPageRoute(RouteIsmi[i], "{0}/" + RouteURL[i], klasoryollari[3] + FizikselYolu[i]); break;
                }
            }
        }
    }
}