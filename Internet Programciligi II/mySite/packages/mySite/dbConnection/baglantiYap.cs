using System;
using System.Data;
using System.Data.OleDb;
using System.Web;

namespace mySite.dbConnection
{
    public class baglantiYap
    {
        public static void BagKur(OleDbConnection dbconnection, string dbName)
        {
            OleDbConnectionStringBuilder baglantiAyar = new OleDbConnectionStringBuilder ();
            baglantiAyar.DataSource = HttpContext.Current.Server.MapPath("~/App_Data/" + dbName + ".accdb");
            baglantiAyar.Provider = "Microsoft.ACE.OLEDB.12.0";
            dbconnection.ConnectionString = baglantiAyar.ConnectionString;
            if (dbconnection.State == ConnectionState.Closed)
                dbconnection.Open();
        }
    }
}