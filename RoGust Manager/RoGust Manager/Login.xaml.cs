using System;
using System.IO;
using Xamarin.Forms;

namespace RoGust_Manager
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (login_pwd.Text == Vars.Code)
            {
                File.WriteAllText(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/logged", "");
                App.Current.MainPage = new Loading();
            }
            else
            {
                DisplayAlert("Eroare!", "Cod incorect", "OK");
                login_pwd.Text = "";
            }
        }
    }
}
