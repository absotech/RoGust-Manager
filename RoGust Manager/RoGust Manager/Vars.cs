using System.Collections.Generic;
using Xamarin.Forms;

namespace RoGust_Manager
{
    internal static class Vars
    {
        internal static bool EnableFingerprint = false;
        internal static string Code = "7833";
        internal static double Version = 2.52;
        internal static double GotVersion = 0;

        #region Website
        internal static string upload2f = "/rogust/save2f.php";
        internal static string upload3f = "/rogust/save3f.php";

        internal static string uploadstocweb = "/rogust/ulstoc.php";
        internal static string getstoc = "/rogust/getstoc.php";

        internal static string getpontaj = "/rogust/pontajcurent.php";
        internal static string pontajrap = "/rogust/pontajrap.php";

        internal static string getcurrent = "/rogust/getcurrent.php";
        internal static string genmsg = "/rogust/getmessage.php";

        internal static string uploadcutie = "/rogust/savecutii.php";
        internal static string getcutii = "/rogust/getcutii.php";
        internal static string schimbacutii = "/rogust/schimbacutii.php";
        internal static string fioleshare = "/rogust/fioleshare.php";
        internal static string genrap = "/rogust/genrap.php";
        internal static string persoaneWeb = "/rogust/getjson.php";
        internal static string persoaneUpload = "/rogust/putjson.php";
        internal static string versionLink = "/rogust/CurrentVersion.dat";
        internal static string updateLink = "/rm.apk";

        #endregion

        internal static string ciclu2f, ciclu3f, mentiuni2f, mentiuni3f, cutii2f, cutii3f = "";
        internal static string stoc_baz, stoc_pal1, stoc_pal15, stoc_cutii, stoc_note = "";
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
