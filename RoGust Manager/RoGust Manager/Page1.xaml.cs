using System;
using System.Globalization;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Newtonsoft.Json;
using System.IO;
using System.Threading.Tasks;

namespace RoGust_Manager
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            if(Vars.genmsg != "")
            {
                DisplayAlert("Notă", Vars.genmsg, "Ștergere");
            }
            SetPerson();
            GetStoc();
            UpdateApp();
        }

        internal void GetStoc()
        {
            try
            {
                string[] bcData = {  };
                bcData = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/bc.dat");
                bc_nr.Text = bcData[0];
                bc_nrmax.Text = bcData[1];

                string[] tData = {  };
                tData = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/t.dat");
                t_nr.Text = tData[0];
                t_nrmax.Text = tData[1];

                string[] stData = {  };
                stData = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/st.dat");
                st_nr.Text = stData[0];
                st_nrmax.Text = stData[1];

                string[] fiData = {  };
                fiData = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/fi.dat");
                fi_nr.Text = fiData[0];
                fi_nrmax.Text = fiData[1];

                string[] adData = {  };
                adData = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/ad.dat");
                ad_nr.Text = adData[0];
                ad_nrmax.Text = adData[1];

                string[] xData = {  };
                xData = File.ReadAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/x.dat");
                x_nr.Text = xData[0];
                x_nrmax.Text = xData[1];


                bazine_nr.Text = Vars.stoc_baz;
                pal1_nr.Text = Vars.stoc_pal1;
                pal15_nr.Text = Vars.stoc_pal15;
                cutii_nrstoc.Text = Vars.stoc_cutii;
                note_stoc.Text = Vars.stoc_note;
            }
            catch
            {

            }
        }
        internal void SetPerson()
        {
            string name = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/person.json";
            var root = new RootObj();
            root = JsonConvert.DeserializeObject<RootObj>(File.ReadAllText(name));
            for (int i = 0; i < root.people.Count; i++)
            {
                var obj = Content.FindByName<Entry>("pers" + (i + 1).ToString() + "_text");
                if (obj != null)
                {
                    obj.Text = root.people[i].Nume;
                }
                var obi = Content.FindByName<Entry>("pers" + (i + 1).ToString() + "_nr");
                if (obi != null)
                {
                    obi.Text = root.people[i].Ore;
                }
            }
        }

        public int GetWeekNumber()
        {
            CultureInfo ciCurr = CultureInfo.CurrentCulture;
            int weekNum = ciCurr.Calendar.GetWeekOfYear(DateTime.Now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNum;
        }

        internal async void UpdateApp()
        {
            if (Vars.GotVersion != 0)
            {
                bool a;
                try
                {
                    
                        
                        if (Convert.ToDouble(Vars.GotVersion) > Vars.Version)
                        {
                        a = await DisplayAlert("Actualizare", "O nouă versiune este disponibilă. Doriți să o instalați acum?" /*+ "\n" + Vars.Version + "\n" + Vars.GotVersion*/, "Da", "Nu");
                        if (a)
                            {
                                Browser.OpenAsync(Vars.updateLink, BrowserLaunchMode.SystemPreferred);
                            }
                        }
                    
                }
                catch
                {

                }

            }
        }

        #region -FIRST PAGE-

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

        private void minus_pers2_Pressed(object sender, EventArgs e)
        {
            pers2_nr.Text = (Convert.ToDouble(pers2_nr.Text) - 0.5).ToString();
        }

        private void plus_pers2_Pressed(object sender, EventArgs e)
        {
            pers2_nr.Text = (Convert.ToDouble(pers2_nr.Text) + 0.5).ToString();
        }

        //entry no.3

        private void minus_pers3_Pressed(object sender, EventArgs e)
        {
            pers3_nr.Text = (Convert.ToDouble(pers3_nr.Text) - 0.5).ToString();
        }

        private void plus_pers3_Pressed(object sender, EventArgs e)
        {
            pers3_nr.Text = (Convert.ToDouble(pers3_nr.Text) + 0.5).ToString();
        }

        //entry no.4
        private void minus_pers4_Pressed(object sender, EventArgs e)
        {
            pers4_nr.Text = (Convert.ToDouble(pers4_nr.Text) - 0.5).ToString();
        }

        private void plus_pers4_Pressed(object sender, EventArgs e)
        {
            pers4_nr.Text = (Convert.ToDouble(pers4_nr.Text) + 0.5).ToString();
        }

        //entry no.5

        private void minus_pers5_Pressed(object sender, EventArgs e)
        {
            pers5_nr.Text = (Convert.ToDouble(pers5_nr.Text) - 0.5).ToString();
        }

        private void plus_pers5_Pressed(object sender, EventArgs e)
        {
            pers5_nr.Text = (Convert.ToDouble(pers5_nr.Text) + 0.5).ToString();
        }

        //entry no.6

        private void minus_pers6_Pressed(object sender, EventArgs e)
        {
            pers6_nr.Text = (Convert.ToDouble(pers6_nr.Text) - 0.5).ToString();
        }

        private void plus_pers6_Pressed(object sender, EventArgs e)
        {
            pers6_nr.Text = (Convert.ToDouble(pers6_nr.Text) + 0.5).ToString();
        }

        //entry no.7

        private void minus_pers7_Pressed(object sender, EventArgs e)
        {
            pers7_nr.Text = (Convert.ToDouble(pers7_nr.Text) - 0.5).ToString();
        }

        private void plus_pers7_Pressed(object sender, EventArgs e)
        {
            pers7_nr.Text = (Convert.ToDouble(pers7_nr.Text) + 0.5).ToString();
        }

        //entry no.8

        private void minus_pers8_Pressed(object sender, EventArgs e)
        {
            pers8_nr.Text = (Convert.ToDouble(pers8_nr.Text) - 0.5).ToString();
        }

        private void plus_pers8_Pressed(object sender, EventArgs e)
        {
            pers8_nr.Text = (Convert.ToDouble(pers8_nr.Text) + 0.5).ToString();
        }

        //entry no.9

        private void minus_pers9_Pressed(object sender, EventArgs e)
        {
            pers9_nr.Text = (Convert.ToDouble(pers9_nr.Text) - 0.5).ToString();
        }

        private void plus_pers9_Pressed(object sender, EventArgs e)
        {
            pers9_nr.Text = (Convert.ToDouble(pers9_nr.Text) + 0.5).ToString();
        }

        //entry no.10

        private void minus_pers10_Pressed(object sender, EventArgs e)
        {
            pers10_nr.Text = (Convert.ToDouble(pers10_nr.Text) - 0.5).ToString();
        }

        private void plus_pers10_Pressed(object sender, EventArgs e)
        {
            pers10_nr.Text = (Convert.ToDouble(pers10_nr.Text) + 0.5).ToString();
        }

        //entry all

        private void minus_perstotal_Pressed(object sender, EventArgs e)
        {
            //perstotal_nr.Text = (Convert.ToDouble(perstotal_nr.Text) - 0.5).ToString();
            minus_pers1_Pressed(this, null); minus_pers2_Pressed(this, null); minus_pers3_Pressed(this, null); minus_pers4_Pressed(this, null); minus_pers5_Pressed(this, null);
            minus_pers6_Pressed(this, null); minus_pers7_Pressed(this, null); minus_pers8_Pressed(this, null); minus_pers9_Pressed(this, null); minus_pers10_Pressed(this, null);
        }

        private void plus_perstotal_Pressed(object sender, EventArgs e)
        {
            //perstotal_nr.Text = (Convert.ToDouble(perstotal_nr.Text) + 0.5).ToString();
            plus_pers1_Pressed(this, null); plus_pers2_Pressed(this, null); plus_pers3_Pressed(this, null); plus_pers4_Pressed(this, null); plus_pers5_Pressed(this, null); 
            plus_pers6_Pressed(this, null); plus_pers7_Pressed(this, null); plus_pers8_Pressed(this, null); plus_pers9_Pressed(this, null); plus_pers10_Pressed(this, null);
        }

        private void reset_perstotal_Pressed(object sender, EventArgs e)
        {
            pers1_nr.Text =  pers2_nr.Text =  pers3_nr.Text =  pers4_nr.Text =  pers5_nr.Text =  pers6_nr.Text =  pers7_nr.Text = pers8_nr.Text = pers9_nr.Text =  pers10_nr.Text = "0";
        }



        #endregion

        #region -SECOND PAGE-
        private void save_comenzitemp_Pressed(object sender, EventArgs e)
        {
            string[] bcData = {bc_nr.Text, bc_nrmax.Text };
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/bc.dat", bcData);

            string[] tData = { t_nr.Text, t_nrmax.Text };
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/t.dat", tData);

            string[] stData = { st_nr.Text, st_nrmax.Text };
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/st.dat", stData);

            string[] fiData = { fi_nr.Text, fi_nrmax.Text };
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/fi.dat", fiData);

            string[] adData = { ad_nr.Text, ad_nrmax.Text };
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/ad.dat", adData);

            string[] xData = { x_nr.Text, x_nrmax.Text };
            File.WriteAllLines(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/stoc/x.dat", xData);
        }

        private void bazine_nr_TextChanged(object sender, TextChangedEventArgs e)
        {
            
        }

        private void pal1_nr_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
            if(pal1_nr.Text != null)
                pal1_res.Text = "(" + (Convert.ToInt32(pal1_nr.Text) *68).ToString() + " baxuri)";
            }
            catch

            {

            }
        }

        private void pal15_nr_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            { 
            if (pal15_nr.Text != null)
                pal15_res.Text = "(" + (Convert.ToInt32(pal15_nr.Text) * 84).ToString() + " baxuri)";
            }
            catch

            {

            }
        }

        private void cutii_nrstoc_TextChanged(object sender, TextChangedEventArgs e)
        {
            try
            {
                if (cutii_nrstoc.Text != null)
                    cutii_res.Text = "(" + (Convert.ToInt32(cutii_nrstoc.Text) * 60).ToString() + " baxuri)";
            }
            catch

            {

            }
        }

        private void send_stocambalat_Pressed(object sender, EventArgs e)
        {
            string ex = Dep.UploadStoc(bazine_nr.Text, pal1_nr.Text, pal15_nr.Text, cutii_nrstoc.Text, note_stoc.Text);
            if (ex == "")
                DisplayAlert("Succes!", "Trimis către server!", "OK");
            else
                DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
        }


        #endregion


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
            //string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "2f";
            //if (!File.Exists(file))
            //{
            //    File.WriteAllText(file, "1");
            //}
            //else
            //{
            //    string nrch = File.ReadAllText(file);
            //    File.WriteAllText(file, (Convert.ToInt32(nrch)+1).ToString() );
            //}
            Dep.SchimbaCutii("2");
        }

        private void schimbacutie3f_Pressed(object sender, EventArgs e)
        {
            //string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "3f";
            //if (!File.Exists(file))
            //{
            //    File.WriteAllText(file, "1");
            //}
            //else
            //{
            //    string nrch = File.ReadAllText(file);
            //    File.WriteAllText(file, (Convert.ToInt32(nrch) + 1).ToString());
            //}
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
                int a, b, c;
                a = Convert.ToInt32(ppet.Text) / 100;
                b = Convert.ToInt32(ppet.Text) / 10 % 10;
                c = Convert.ToInt32(ppet.Text) % 10;
                string strimg;
                strimg = a.ToString() + b.ToString() + "." + c.ToString();
                ppet.Text = a.ToString() + b.ToString() + "." + c.ToString();
                double asd;
                Double.TryParse(strimg, out asd);
                asd = Math.Round(asd * 200 / 41.3 * 5, 2);
                result_ppetnr.Text = asd.ToString();
                if(asd >= 1000)
                {
                    result_ppetnr.TextColor = Color.Green;

                }
                else
                    result_ppetnr.TextColor = Color.Red;

            }
        }

        private void ppet_Focused(object sender, FocusEventArgs e)
        {
            ppet.Text = "";
        }

        #endregion


        #region -FOURTH TAB-
        private void SetariTab_TabTapped(object sender, Xamarin.CommunityToolkit.UI.Views.TabTappedEventArgs e)
        {
            current_week.Text = "Săptămâna curentă:" + GetWeekNumber().ToString();
            week_to_generate.Text = GetWeekNumber().ToString();
        }

        private void generate_report20_Pressed(object sender, EventArgs e)
        {
            string rap;
            //string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "2f";
            //if (File.Exists(file))
            //{
            //    rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "2", File.ReadAllText(file));
            //}
            //else
            //{

            //}
            rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "2", "0");
            Share.RequestAsync(new ShareTextRequest
            {
                Text = rap,
                Title = "Raport 20.5"
            });

        }

        private void generate_report30_Pressed(object sender, EventArgs e)
        {
            string rap;
            //string file = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/changed" + GetWeekNumber().ToString() + "3f";
            //if (File.Exists(file))
            //{
            //    rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "3", File.ReadAllText(file));
            //}
            //else
            //{

            //}
            rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "3", "0");
            Share.RequestAsync(new ShareTextRequest
            {
                Text = rap,
                Title = "Raport 30.5"
            });
        }

        private void generate_report_Pressed(object sender, EventArgs e)
        {
            string rap;
            rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "1", "0");
            Share.RequestAsync(new ShareTextRequest
            {
                Text = rap,
                Title = "Raport"
            });
        }

        private void save_pers_Pressed(object sender, EventArgs e)
        {
            var img = (ImageButton)sender;
            string name = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/person.json";
            var root = JsonConvert.DeserializeObject<RootObj>(File.ReadAllText(name));
            root.people[Convert.ToInt32(img.ClassId) - 1].Ore = Content.FindByName<Entry>("pers" + img.ClassId + "_nr").Text;
            root.people[Convert.ToInt32(img.ClassId) - 1].Nume = Content.FindByName<Entry>("pers" + img.ClassId + "_text").Text;
            File.WriteAllText(name, JsonConvert.SerializeObject(root, Formatting.Indented));
        }

        private void save_names_Pressed(object sender, EventArgs e)
        {
            string name = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/person.json";
            var root = JsonConvert.DeserializeObject<RootObj>(File.ReadAllText(name));
            for (int i = 0; i < 10; i++)
            {
                root.people[i].Nume = Content.FindByName<Entry>("pers" + (i + 1).ToString() + "_text").Text;
            }
            File.WriteAllText(name, JsonConvert.SerializeObject(root, Formatting.Indented));
        }

        private void save_numbers_Pressed(object sender, EventArgs e)
        {
            string name = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/person.json";
            var root = JsonConvert.DeserializeObject<RootObj>(File.ReadAllText(name));
            for (int i = 0; i < 10; i++)
            {
                root.people[i].Ore = Content.FindByName<Entry>("pers" + (i + 1).ToString() + "_nr").Text;
            }
            File.WriteAllText(name, JsonConvert.SerializeObject(root, Formatting.Indented));
        }

        private void save_all_Pressed(object sender, EventArgs e)
        {
            string name = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/person.json";
            var root = JsonConvert.DeserializeObject<RootObj>(File.ReadAllText(name));
            for (int i = 0; i < 10; i++)
            {
                root.people[i].Ore = Content.FindByName<Entry>("pers" + (i + 1).ToString() + "_nr").Text;
                root.people[i].Nume = Content.FindByName<Entry>("pers" + (i + 1).ToString() + "_text").Text;
            }
            File.WriteAllText(name, JsonConvert.SerializeObject(root, Formatting.Indented));
        }

        private void upload_json_Pressed(object sender, EventArgs e)
        {
            save_all_Pressed(this, null);
            string name = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/person.json";
            string ex = Dep.IncarcarePersoane(File.ReadAllText(name));
            if (ex == "")
                DisplayAlert("Succes!", "Trimis către server!", "OK");
            else
                DisplayAlert("Eroare!", "Nu s-au putut trimite datele!", "OK");
        }

        private void generate_reportConta_Pressed(object sender, EventArgs e)
        {
            string name = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + "/person.json";
            var root = JsonConvert.DeserializeObject<RootObj>(File.ReadAllText(name));
            string shareable = "";
            for (int i = 0; i < 10; i++)
            {
                if (root.people[i].Nume != "")
                {
                    shareable += root.people[i].Id + ". ";
                    shareable += root.people[i].Nume + " -- ";
                    shareable += root.people[i].Ore + " ore suplimentare\n";
                }
            }
            if(shareable != "")
            {
                Share.RequestAsync(new ShareTextRequest
                {
                    Text = shareable,
                    Title = "Raport Conta"
                });
            }
            else
            {
                DisplayAlert("Eroare", "Nu există niciun nume de trimis.", "OK");
            }
            

        }

        private void generate_reportStoc_Pressed(object sender, EventArgs e)
        {
            string rap;
            rap = Dep.GenerareRaport(week_to_generate.Text.ToString(), "4", "0");
            Share.RequestAsync(new ShareTextRequest
            {
                Text = rap,
                Title = "Raport Stoc"
            });
        }

        private void raport_pontaj_Pressed(object sender, EventArgs e)
        {
            Browser.OpenAsync(Vars.getpontaj, BrowserLaunchMode.SystemPreferred);

        }

        private void raport_pontaj_wk_Pressed(object sender, EventArgs e)
        {
            string tmppj = Dep.DownloadData(Vars.pontajrap);
            Share.RequestAsync(new ShareTextRequest
            {
                Text = tmppj,
                Title = "Raport Pontaj săptămâna " + GetWeekNumber().ToString()
            });
        }

        #endregion


    }
}