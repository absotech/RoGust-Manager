using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.IO;

namespace RoGust_Manager
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            if (!File.Exists(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/logged"))
                MainPage = new NavigationPage(new MainPage());
            else
            {
                MainPage = new NavigationPage(new MainPage());
                App.Current.MainPage = new Loading();
            }
        }

        protected override void OnStart()
        {

        }

        protected override void OnSleep()
        {

        }

        protected override void OnResume()
        {

        }
    }
}
