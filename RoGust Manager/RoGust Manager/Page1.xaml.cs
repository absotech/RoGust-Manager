using System;
using System.IO;
using System.Globalization;
using Xamarin.Essentials;
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

        public int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        #region -FIRST PAGE-
        //FIRST PAGE
        //entry no.1
        private void minus_pers1_Pressed(object sender, EventArgs e)
        {
            pers1_nr.Text = (Convert.ToDouble(pers1_nr.Text) - 0.5).ToString();
        }
        private void plus_pers1_Pressed(object sender, EventArgs e)
        {
            pers1_nr.Text = (Convert.ToDouble(pers1_nr.Text) + 0.5).ToString();
        }


        //entry no.2
        #endregion








        //SECOND PAGE
        






        #region -THIRD PAGE-

        //THIRD PAGE
        private void Entry_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (cicluri2f_text.Text.Length > 0)
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
            //string ex;
            if (cutii2f_text.Text.Length > 0)
            {
                cutii2f_text.Text = (Convert.ToInt32(cutii2f_text.Text) + 1).ToString();
                //ex = Dep.UploadCutii("2", cutii2f_text.Text);
                //if (ex != "")
                //    DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
            }
        }

        private void save2f_Pressed(object sender, EventArgs e)
        {
            string ex;
            ex = Dep.UploadData2f(cicluri2f_text.Text, peturi2f_text.Text, mentiuni_text2f.Text);
            if (ex == "")
                DisplayAlert("Succes!", "Trimis către server!", "OK");
            else
                DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
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
            //string ex;
            if (cutii3f_text.Text.Length > 0)
            {
                cutii3f_text.Text = (Convert.ToInt32(cutii3f_text.Text) + 1).ToString();
                //ex = Dep.UploadCutii("3", cutii3f_text.Text);
                //if (ex != "")
                //    DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
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
          
            cicluri2f_text.Text = Vars.ciclu2f;
            mentiuni_text2f.Text = Vars.mentiuni2f;
            cicluri3f_text.Text = Vars.ciclu3f;
            mentiuni_text3f.Text = Vars.mentiuni3f;
            cutii2f_text.Text = Vars.cutii2f;
            cutii3f_text.Text = Vars.cutii3f;
        }

        private void save_cutii2f_Pressed(object sender, EventArgs e)
        {
            Share.RequestAsync(new ShareTextRequest
            {
                Text = Dep.DownloadCutii("4", Vars.getcutii),
                Title = "Cutii 20.5"
            });
        }

        private void save_cutii3f_Pressed(object sender, EventArgs e)
        {
            Share.RequestAsync(new ShareTextRequest
            {
                Text = Dep.DownloadCutii("6", Vars.getcutii),
                Title = "Cutii 30.5"
            });
        }

        private void schimbacutie2f_Pressed(object sender, EventArgs e)
        {
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "2f";
            if (!File.Exists(file))
            {
                File.WriteAllText(file, "1");
            }
            else
            {
                string nrch = File.ReadAllText(file);
                File.WriteAllText(file, (Convert.ToInt32(nrch)+1).ToString() );
            }
            Dep.SchimbaCutii("2");
        }

        private void schimbacutie3f_Pressed(object sender, EventArgs e)
        {
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "3f";
            if (!File.Exists(file))
            {
                File.WriteAllText(file, "1");
            }
            else
            {
                string nrch = File.ReadAllText(file);
                File.WriteAllText(file, (Convert.ToInt32(nrch) + 1).ToString());
            }
            Dep.SchimbaCutii("3");
        }


        private void sendcicluri2f_Pressed(object sender, EventArgs e)
        {
            Share.RequestAsync(new ShareTextRequest
            {
                Text = Dep.DownloadCutii("2", Vars.fioleshare),
                Title = "Fiole 20.5"
            });
        }

        private void sendcicluri3f_Pressed(object sender, EventArgs e)
        {
            Share.RequestAsync(new ShareTextRequest
            {
                Text = Dep.DownloadCutii("3", Vars.fioleshare),
                Title = "Fiole 30.5"
            });
        }


        private void ppet_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (ppet.Text.Length == 3)
            {
                int a, b, c, d;
                a = Convert.ToInt32(ppet.Text) / 100;
                b = Convert.ToInt32(ppet.Text) / 10 % 10;
                c = Convert.ToInt32(ppet.Text) % 10;
                string strimg;
                strimg = a.ToString() + b.ToString() + "." + c.ToString();
                ppet.Text = a.ToString() + b.ToString() + "." + c.ToString();
                double asd;
                Double.TryParse(strimg, out asd);
                result_ppet.Text ="Producție pe oră: " + Math.Round(asd*194/40.5*5, 2).ToString();
                
            }
        }

        private void ppet_Focused(object sender, FocusEventArgs e)
        {
            ppet.Text = "";
        }

        #endregion


        //FORTH PAGE

        private void SetariTab_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {
            current_week.Text = "Săptămâna curentă:" +GetWeekNumber().ToString();
            week_to_generate.Text = GetWeekNumber().ToString();
        }

        private void generate_report20_Pressed(object sender, EventArgs e)
        {
            string rap;
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "2f";
            if (File.Exists(file))
            {
                rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "2", File.ReadAllText(file));
            }
            else
            {
                rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "2", "0");
            }
            
            Share.RequestAsync(new ShareTextRequest
            {
                Text = rap,
                Title = "Raport 20.5"
            });

        }

        private void generate_report30_Pressed(object sender, EventArgs e)
        {
            string rap;
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "3f";
            if (File.Exists(file))
            {
                rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "3", File.ReadAllText(file));
            }
            else
            {
                rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "3", "0");
            }

            Share.RequestAsync(new ShareTextRequest
            {
                Text = rap,
                Title = "Raport 30.5"
            });
        }

        private void generate_report_Pressed(object sender, EventArgs e)
        {
            string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "2f";
            if (File.Exists(file))
            {
                Dep.GenerareRaport(week_to_generate.Text.ToString(), "1", File.ReadAllText(file));
            }
            else
            {
                Dep.GenerareRaport(week_to_generate.Text.ToString(), "1", "0");
            }
        }


    }
}