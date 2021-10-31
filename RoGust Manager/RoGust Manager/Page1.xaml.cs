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
    }
}