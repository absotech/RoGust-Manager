using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace RoGust_Manager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(cicluri2f_text.Text.Length > 0)
                peturi2f_text.Text = (Convert.ToInt32(cicluri2f_text.Text) * 2).ToString();
        }

        private void minus_ciclu2f_Pressed(object sender, EventArgs e)
        {
            if (cicluri2f_text.Text.Length > 0)
                cicluri2f_text.Text = (Convert.ToInt32(cicluri2f_text.Text) - 1).ToString();
        }

        private void plus_ciclu2f_Pressed(object sender, EventArgs e)
        {
            if (cicluri2f_text.Text.Length > 0)
                cicluri2f_text.Text = (Convert.ToInt32(cicluri2f_text.Text) + 1).ToString();
        }

        private void minus_cutii2f_Pressed(object sender, EventArgs e)
        {
            if (cutii2f_text.Text.Length > 0)
                cutii2f_text.Text = (Convert.ToInt32(cutii2f_text.Text) - 1).ToString();
        }

        private void plus_cutii_Pressed(object sender, EventArgs e)
        {
            if (cutii2f_text.Text.Length > 0)
                cutii2f_text.Text = (Convert.ToInt32(cutii2f_text.Text) + 1).ToString();
        }

        private void save2f_Pressed(object sender, EventArgs e)
        {
            string ex;
            ex = Dep.UploadData2f(cicluri2f_text.Text, peturi2f_text.Text, cutii2f_text.Text, mentiuni_text2f.Text);
            if ( ex == "")
                DisplayAlert("Succes!", "Trimis către server!", "OK");
            else
                DisplayAlert("Eroare!", "Nu s-au putut trimite datele!" , "OK");
        }

        private void minus_ciclu3f_Pressed(object sender, EventArgs e)
        {
            if (cicluri3f_text.Text.Length > 0)
                cicluri3f_text.Text = (Convert.ToInt32(cicluri3f_text.Text) - 1).ToString(); 
        }

        private void cicluri3f_text_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cicluri3f_text.Text.Length > 0)
                peturi3f_text.Text = (Convert.ToInt32(cicluri3f_text.Text) * 2).ToString();
        }

        private void plus_ciclu3f_Pressed(object sender, EventArgs e)
        {
            if (cicluri3f_text.Text.Length > 0)
                cicluri3f_text.Text = (Convert.ToInt32(cicluri3f_text.Text) + 1).ToString();
        }

        private void minus_cutii3f_Pressed(object sender, EventArgs e)
        {
            if (cutii3f_text.Text.Length > 0)
                cutii3f_text.Text = (Convert.ToInt32(cutii3f_text.Text) - 1).ToString();
        }

        private void plus_cutii3f_Pressed(object sender, EventArgs e)
        {
            if (cutii3f_text.Text.Length > 0)
                cutii3f_text.Text = (Convert.ToInt32(cutii3f_text.Text) + 1).ToString();
        }

        private void save3f_Pressed(object sender, EventArgs e)
        {
            string ex;
            ex = Dep.UploadData3f(cicluri3f_text.Text, peturi3f_text.Text, cutii3f_text.Text, mentiuni_text3f.Text);
            if (ex == "")
                DisplayAlert("Succes!", "Trimis către server!", "OK");
            else
                DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
        }

        private void FioleTab_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {
            string result = Dep.DownloadData();
            string[] resultArray = result.Split('#');
            if (resultArray.Length > 0)
            {
                string split2f = resultArray[0];
                string split3f = resultArray[1];
                cicluri2f_text.Text = split2f.Split('-')[0];
                cutii2f_text.Text = split2f.Split('-')[1];
                mentiuni_text2f.Text = split2f.Split('-')[3];
                cicluri3f_text.Text = split3f.Split('-')[0];
                cutii3f_text.Text = split3f.Split('-')[1];
                mentiuni_text3f.Text = split3f.Split('-')[3];
            }

        }
    }
}