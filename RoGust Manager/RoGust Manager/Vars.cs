using System.Collections.Generic;
using Xamarin.Forms;

namespace RoGust_Manager
{
    internal static class Vars
    {
        internal static string Code = "7833";
        internal static double Version = 2.36;
        internal static double GotVersion = 0;

        #region Website
        internal static string upload2f = "http://ivanconnections.com/data/app/rogust/save2f.php";
        internal static string upload3f = "http://ivanconnections.com/data/app/rogust/save3f.php";


        internal static string getcurrent = "http://ivanconnections.com/data/app/rogust/getcurrent.php";
        internal static string genmsg = "http://ivanconnections.com/data/app/rogust/getmessage.php";

        internal static string uploadcutie = "http://ivanconnections.com/data/app/rogust/savecutii.php";
        internal static string getcutii = "http://ivanconnections.com/data/app/rogust/getcutii.php";
        internal static string schimbacutii = "http://ivanconnections.com/data/app/rogust/schimbacutii.php";
        internal static string fioleshare = "http://ivanconnections.com/data/app/rogust/fioleshare.php";
        internal static string genrap = "http://ivanconnections.com/data/app/rogust/genrap.php";
        internal static string persoaneWeb = "http://ivanconnections.com/data/app/rogust/getjson.php";
        internal static string persoaneUpload = "http://ivanconnections.com/data/app/rogust/putjson.php";
        internal static string versionLink = "http://ivanconnections.com/data/app/rogust/CurrentVersion.dat";
        internal static string updateLink = "http://ivanconnections.com/rm.apk";
        #endregion

        internal static string ciclu2f, ciclu3f, mentiuni2f, mentiuni3f, cutii2f, cutii3f = "";
        internal static string note = "";

    }

    public class Person
    {
        public int Id { get; set; }

        public string Nume { get; set; }
        public string Ore { get; set; }

    }
    public class RootObj
    {
        public List<Person> people { get; set; }
    }
}
