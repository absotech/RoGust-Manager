using System.Threading;
using Xamarin.Forms;
using System.IO;
using Xamarin.Forms.Xaml;
using System;
using System.Threading.Tasks;
using Plugin.Fingerprint;
using Plugin.Fingerprint.Abstractions;

namespace RoGust_Manager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loading : ContentPage
    {
        private bool notOk;

        public Loading()
        {
            InitializeComponent();
            getAuthAsync();
            

        }


        private async Task getAuthAsync()
        {
            var request = new AuthenticationRequestConfiguration("Fingerprint required", "Please authenticate.");
            var result = await CrossFingerprint.Current.AuthenticateAsync(request);
            if (result.Authenticated)
            {
                ThreadPool.QueueUserWorkItem(o => LoadingThread());
            }
            else
            {
                await DisplayAlert("Eroare!", "Citirea amprentei a fost anulată!\nAplicația se va închide!", "OK");
                notOk = true;
                Android.OS.Process.KillProcess(Android.OS.Process.MyPid());

            }

        }

        void LoadingThread()
        {


            Device.BeginInvokeOnMainThread(() =>
            {
                curop.Text = "Generare cheie unica";
                loaded.Text = "10%";
            });
            Device.BeginInvokeOnMainThread(() => curop.Text = "Descărcare informații fiole");
            if (!Directory.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc"))
                Directory.CreateDirectory(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc");
            string name = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/person.json";
            if (!File.Exists(name))
            {
                File.WriteAllText(name, Dep.DescarcarePersoane("new"));
            }
            Vars.GotVersion = Convert.ToDouble(Dep.DownloadData(Vars.versionLink));
            //Device.BeginInvokeOnMainThread(() => DisplayAlert("o", File.ReadAllText(name), "sss"));
            string result = Dep.DownloadData(Vars.getcurrent);
            Device.BeginInvokeOnMainThread(() => loaded.Text = "35%");
            Vars.genmsg = Dep.PreluareNote();
            string[] resultArray = result.Split('#');
            if (result != "")
            {
                if (resultArray.Length > 0)
                {
                    try
                    {
                        string split2f = resultArray[0];
                        string split3f = resultArray[1];
                        Vars.ciclu2f = split2f.Split('^')[0];
                        Vars.mentiuni2f = split2f.Split('^')[2];
                        Vars.ciclu3f = split3f.Split('^')[0];
                        Vars.mentiuni3f = split3f.Split('^')[2];
                    }
                    catch
                    {
                        //Device.BeginInvokeOnMainThread(() => DisplayAlert("Eroare fatală!", e.ToString(), "OK"));
                        Vars.ciclu2f = "0";
                        Vars.mentiuni2f = "0";
                        Vars.ciclu3f = "0";
                        Vars.mentiuni3f = "0";
                    }
                }
                else
                {
                    Device.BeginInvokeOnMainThread(() => DisplayAlert("Eroare fatală!", "Fișierul citit este corupt!", "OK"));
                }

            }
            string resultstoc = Dep.DownloadData(Vars.getstoc);
            Device.BeginInvokeOnMainThread(() => loaded.Text = "40%");
            Vars.genmsg = Dep.PreluareNote();
            if (resultstoc != "")
            {
                try
                {
                    Vars.stoc_baz = resultstoc.Split('^')[0];
                    Vars.stoc_pal1 = resultstoc.Split('^')[1];
                    Vars.stoc_pal15 = resultstoc.Split('^')[2];
                    Vars.stoc_cutii = resultstoc.Split('^')[3];
                    Vars.stoc_note = resultstoc.Split('^')[4];
                }
                catch
                {
                    //Device.BeginInvokeOnMainThread(() => DisplayAlert("Eroare fatală!", e.ToString(), "OK"));
                    Vars.stoc_baz = "0";
                    Vars.stoc_pal1 = "0";
                    Vars.stoc_pal15 = "0";
                    Vars.stoc_cutii = "0";
                    Vars.stoc_note= " ";
                }

            }
            Device.BeginInvokeOnMainThread(() => loaded.Text = "50%");
            Device.BeginInvokeOnMainThread(() => loading_dot.Text += ".");
            Device.BeginInvokeOnMainThread(() => curop.Text = "Descărcare informații cutii");
            string resultct2 = Dep.DownloadCutii("2", Vars.getcutii);

            if (resultct2 != "")
                Vars.cutii2f = resultct2;
            else
                Device.BeginInvokeOnMainThread(() => DisplayAlert("Eroare!", "Verificați conexiunea la internet!", "OK"));
            Device.BeginInvokeOnMainThread(() => loaded.Text = "70%");
            Device.BeginInvokeOnMainThread(() => loading_dot.Text += ".");
            string resultct3 = Dep.DownloadCutii("3", Vars.getcutii);
            if (resultct3 != "")
                Vars.cutii3f = resultct3;
            else
                Device.BeginInvokeOnMainThread(() => DisplayAlert("Eroare!", "Verificați conexiunea la internet!", "OK"));
            Device.BeginInvokeOnMainThread(() =>
            {
                 loaded.Text = "90%";
                 curop.Text = "Terminat";
                 loading_dot.Text += ".";
                App.Current.MainPage = new Page1();
            }); 
            
        }
    }
}