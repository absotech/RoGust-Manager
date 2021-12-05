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

        internal static string DownloadData()
        {
            try
            {
                WebClient client = new WebClient();
                string downloadString = client.DownloadString(Vars.getcurrent);
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
            catch (Exception e)
            {
                return "";
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
            catch (Exception e)
            {
                return "";
            }

        }
    }
}