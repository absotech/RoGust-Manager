using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                App.Current.MainPage = new Page1();
            else
            {
                DisplayAlert("Eroare!", "Cod incorect", "OK");
                login_pwd.Text = "";
            }
        }
    }
}
