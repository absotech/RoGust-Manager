using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoGust_Manager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Loading : ContentPage
    {


        public Loading()
        {
            InitializeComponent();
            ThreadPool.QueueUserWorkItem(o => LoadingThread());
        }


        void LoadingThread()
        {
            Device.BeginInvokeOnMainThread(() =>
            {
                curop.Text = "Generare cheie unica";
                loaded.Text = "10%";
                curop.Text = "Descărcare informații fiole";
            });
            if(AppInfo.RequestedTheme == AppTheme.Light)
            {
                Vars.primaryColor = Color.White;
                Vars.secondaryColor = Color.Black;
            }
            else
            {
                Vars.primaryColor = Color.Black;
                Vars.secondaryColor = Color.White;
            }
            
            string result = Dep.DownloadData();
            Device.BeginInvokeOnMainThread(() => loaded.Text = "35%");
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
            Device.BeginInvokeOnMainThread(() => loaded.Text = "50%");
            Device.BeginInvokeOnMainThread(() => curop.Text = "Descărcare informații cutii");
            string resultct2 = Dep.DownloadCutii("2", Vars.getcutii);

            if (resultct2 != "")
                Vars.cutii2f = resultct2;
            else
                Device.BeginInvokeOnMainThread(() => DisplayAlert("Eroare!", "Verificați conexiunea la internet!", "OK"));
            Device.BeginInvokeOnMainThread(() => loaded.Text = "70%");
            string resultct3 = Dep.DownloadCutii("3", Vars.getcutii);
            if (resultct3 != "")
                Vars.cutii3f = resultct3;
            else
                Device.BeginInvokeOnMainThread(() => DisplayAlert("Eroare!", "Verificați conexiunea la internet!", "OK"));
            Device.BeginInvokeOnMainThread(() =>
            {
                 loaded.Text = "90%";
                 curop.Text = "Terminat";
                 App.Current.MainPage = new Page1();
            }); 
            
        }
    }
}