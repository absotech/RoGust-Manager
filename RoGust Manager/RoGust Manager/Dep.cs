using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.Specialized;
using System.Net;
using System.IO;

namespace RoGust_Manager
{
    internal static class Dep
    {
        internal static bool UploadData2f(string cicluri, string cutii, string mentiuni)
        {
            try
            {
                WebClient webClient = new WebClient();

                NameValueCollection formData = new NameValueCollection();
                formData["cicluri"] = cicluri;
                formData["cutii"] = cutii;
                formData["mentiuni"] = mentiuni;

                byte[] responseBytes = webClient.UploadValues(Vars.upload2f, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                Console.WriteLine(responsefromserver);
                webClient.Dispose();
                return true;
            }
            catch
            {
                return false;
            }
        }
    }
}