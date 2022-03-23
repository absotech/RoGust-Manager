using System;
using System.Text;
using System.Collections.Specialized;
using System.Net;

namespace RoGust_Manager
{
    internal static class Dep
    {
        internal static string UploadData2f(string cicluri, string peturi, string mentiuni)
        {

            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["cicluri"] = cicluri,
                    //["cutii"] = cutii,
                    ["mentiuni"] = mentiuni,
                    ["peturi"] = peturi
                };

                byte[] responseBytes = webClient.UploadValues(Vars.upload2f, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }



        internal static string UploadData3f(string cicluri, string peturi, string mentiuni)
        {
            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["cicluri"] = cicluri,
                    //["cutii"] = cutii,
                    ["mentiuni"] = mentiuni,
                    ["peturi"] = peturi
                };

                byte[] responseBytes = webClient.UploadValues(Vars.upload3f, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        internal static string DownloadData(string site)
        {
            try
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString(site);
                client.Dispose();
                return downloadString;
            }
            catch
            {
                return "";
            }
        }


        internal static string UploadCutii(string tip, string cutie)
        {
            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["tip"] = tip,
                    ["cutii"] = cutie
                };

                byte[] responseBytes = webClient.UploadValues(Vars.uploadcutie, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        internal static string SchimbaCutii(string tip)
        {
            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["tip"] = tip,
                };

                byte[] responseBytes = webClient.UploadValues(Vars.schimbacutii, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }

        internal static string DownloadCutii(string tip, string addr)
        {
            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["tip"] = tip
                };

                byte[] responseBytes = webClient.UploadValues(addr, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return responsefromserver;
            }
            catch /*(Exception e)*/
            {
                return "";
            }
        }


        internal static string PreluareNote()
        {
            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["action"] = "get",
                    
                };

                byte[] responseBytes = webClient.UploadValues(Vars.genmsg, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return responsefromserver;
            }
            catch /*(Exception e)*/
            {
                return "";
            }

        }

        internal static string DescarcarePersoane(string action)
        {
            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["action"] = action,

                };

                byte[] responseBytes = webClient.UploadValues(Vars.persoaneWeb, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return responsefromserver;
            }
            catch /*(Exception e)*/
            {
                return "";
            }

        }

        internal static string IncarcarePersoane(string data)
        {
            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["data"] = data,

                };

                byte[] responseBytes = webClient.UploadValues(Vars.persoaneUpload, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return responsefromserver;
            }
            catch (Exception e)
            {
                return e.ToString();
            }

        }

        

        internal static string GenerareRaport(string week, string tip, string lines)
        {
            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["week"] = week,
                    ["tip"] = tip,
                    ["lines"] = lines
                };

                byte[] responseBytes = webClient.UploadValues(Vars.genrap, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return responsefromserver;
            }
            catch /*(Exception e)*/
            {
                return "";
            }

        }

        internal static string UploadStoc(string bazine, string paleti1, string paleti15, string cutii, string note)
        {

            try
            {
                WebClient webClient = new WebClient();
                NameValueCollection formData = new NameValueCollection
                {
                    ["bazine"] = bazine,
                    ["paleti1"] = paleti1,
                    ["paleti15"] = paleti15,
                    ["cutii"] = cutii,
                    ["note"] = note
                };

                byte[] responseBytes = webClient.UploadValues(Vars.uploadstocweb, "POST", formData);
                string responsefromserver = Encoding.UTF8.GetString(responseBytes);
                webClient.Dispose();
                return "";
            }
            catch (Exception e)
            {
                return e.ToString();
            }
        }
    }
}