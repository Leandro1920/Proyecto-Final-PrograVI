using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;

namespace PrograVI_Final_Project
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void BtnSave_Clicked(object sender, EventArgs e)
        {
            Preferences.Set("username", EntUserName.Text);
        }

        private void BtnRetrieve_Clicked(object sender, EventArgs e)
        {
          var response =  Preferences.Get("username", String.Empty);
            LblUserName.Text = response;
        }
    }
}
