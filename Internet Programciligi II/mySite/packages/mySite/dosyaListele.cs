using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;

namespace mySite
{
    public class dosyaListele
    {
        public static string[] getFile(string MapPath, string fileExtension)
        {
            string dizin = HttpContext.Current.Server.MapPath("~/" + MapPath);
            string klasoryolu = dizin;
            string[] klasordekiler = Directory.GetFiles(klasoryolu);
            string[] istenilenDosya = new string[klasordekiler.Length];
            string dosyalar = null;
            for (int i = 0; i < klasordekiler.Length; i++)
            {
              FileInfo  dosya = new FileInfo(klasordekiler[i]);
                if (dosya.Extension == fileExtension)
                    dosyalar += dosya.Name + "#";
            }
            return istenilenDosya = dosyalar.Split('#');
        }
    }
}