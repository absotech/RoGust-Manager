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
            if (cicluri2f_text.Text.Length > 0 && Convert.ToInt32(cicluri2f_text.Text) >= 0)
                cicluri2f_text.Text = (Convert.ToInt32(cicluri2f_text.Text) - 1).ToString();
        }

        private void plus_ciclu2f_Pressed(object sender, EventArgs e)
        {
            if (cicluri2f_text.Text.Length > 0)
                cicluri2f_text.Text = (Convert.ToInt32(cicluri2f_text.Text) + 1).ToString();
        }

        private void minus_cutii2f_Pressed(object sender, EventArgs e)
        {
            string ex;
            if (cutii2f_text.Text.Length > 0 && Convert.ToInt32(cutii2f_text.Text) >= 0)
            {
                cutii2f_text.Text = (Convert.ToInt32(cutii2f_text.Text) - 1).ToString();
                ex = Dep.UploadCutii("2", cutii2f_text.Text);
                if (ex != "")
                    DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
            }
        }

        private void plus_cutii_Pressed(object sender, EventArgs e)
        {
            string ex;
            if (cutii2f_text.Text.Length > 0)
            {
                cutii2f_text.Text = (Convert.ToInt32(cutii2f_text.Text) + 1).ToString();
                ex = Dep.UploadCutii("2", cutii2f_text.Text);
                if (ex != "")
                    DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
            }
        }

        private void save2f_Pressed(object sender, EventArgs e)
        {
            string ex;
            ex = Dep.UploadData2f(cicluri2f_text.Text, peturi2f_text.Text, mentiuni_text2f.Text);
            if ( ex == "")
                DisplayAlert("Succes!", "Trimis către server!", "OK");
            else
                DisplayAlert("Eroare!", "Nu s-au putut trimite datele!" , "OK");
        }

        private void minus_ciclu3f_Pressed(object sender, EventArgs e)
        {
            if (cicluri3f_text.Text.Length > 0 && Convert.ToInt32(cicluri3f_text.Text) >= 0)
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
            string ex;
            if (cutii3f_text.Text.Length > 0 && Convert.ToInt32(cutii3f_text.Text) >= 0)
            {
                cutii3f_text.Text = (Convert.ToInt32(cutii3f_text.Text) - 1).ToString();
                ex = Dep.UploadCutii("3", cutii3f_text.Text);
                if (ex != "")
                    DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
            }
        }

        private void plus_cutii3f_Pressed(object sender, EventArgs e)
        {
            string ex;
            if (cutii3f_text.Text.Length > 0)
            {
                cutii3f_text.Text = (Convert.ToInt32(cutii3f_text.Text) + 1).ToString();
                ex = Dep.UploadCutii("3", cutii3f_text.Text);
                if (ex != "")
                    DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
            }
        }

        private void save3f_Pressed(object sender, EventArgs e)
        {
            string ex;
            ex = Dep.UploadData3f(cicluri3f_text.Text, peturi3f_text.Text, mentiuni_text3f.Text);
            if (ex == "")
                DisplayAlert("Succes!", "Trimis către server!", "OK");
            else
                DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
        }

        private void FioleTab_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {
            string result = Dep.DownloadData();
            string[] resultArray = result.Split('#');
            if (result != "")
            {
                if (resultArray.Length > 0)
                {
                    try
                    {
                        string split2f = resultArray[0];
                        string split3f = resultArray[1];
                        cicluri2f_text.Text = split2f.Split('^')[0];
                        mentiuni_text2f.Text = split2f.Split('^')[2];
                        cicluri3f_text.Text = split3f.Split('^')[0];
                        mentiuni_text3f.Text = split3f.Split('^')[2];
                    }
                    catch
                    {
                        cicluri2f_text.Text = "0";
                        mentiuni_text2f.Text = "0";
                        cicluri3f_text.Text = "0";
                        mentiuni_text3f.Text = "0";
                    }
                }
                else
                {
                    DisplayAlert("Eroare fatală!", "Fișierul citit este corupt!", "OK");
                }
            }
            else
            {
                DisplayAlert("Eroare!", "Verificați conexiunea la internet!", "OK");
            }
            string resultct2 = Dep.DownloadCutii("2");
            string[] resultArrayct2 = resultct2.Split('#');
            if (resultct2 != "")
            {
                if (resultArrayct2.Length > 0)
                {
                    string split2f = resultArrayct2[0];
                    try
                    {
                        cutii2f_text.Text = split2f.Split(':')[1];
                        
                    }
                    catch
                    {
                        cutii2f_text.Text = "0";
                    }
                }
                else
                {
                    DisplayAlert("Eroare fatală!", "Fișierul citit este corupt!", "OK");
                }
            }
            else
            {
                DisplayAlert("Eroare!", "Verificați conexiunea la internet!", "OK");
            }
            string resultct3 = Dep.DownloadCutii("3");
            string[] resultArrayct3 = resultct3.Split('#');
            if (resultct3 != "")
            {
                if (resultArrayct3.Length > 0)
                {
                    try
                    {
                        string split3f = resultArrayct3[0];
                        cutii3f_text.Text = split3f.Split(':')[1];
                    }
                    catch
                    {
                        cutii3f_text.Text = "0";
                    }
                }
                else
                {
                    DisplayAlert("Eroare fatală!", "Fișierul citit este corupt!", "OK");
                }
            }
            else
            {
                DisplayAlert("Eroare!", "Verificați conexiunea la internet!", "OK");
            }
        }
    }
}