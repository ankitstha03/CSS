using App3.Models;
using App3.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Profile : ContentPage
    {
        private bool _canClose = true;

        App app = Application.Current as App;

        public Profile()
        {
            InitializeComponent();
            Title = Constants.currentcustomer.username;
            imagp.Source = Constants.currentcustomer.profile_picture;
            usern.Text = Constants.currentcustomer.username;
            lblname.Text = Constants.currentcustomer.first_name+" "+Constants.currentcustomer.last_name;
            lblcom.Text = Constants.currentcustomer.company_name;
            lbladdress.Text = Constants.currentcustomer.address;
            lblphn.Text = Constants.currentcustomer.phone_number;
            lblemail.Text = Constants.currentcustomer.email;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);
            view.Opacity = 0;
            view.FadeTo(1, 1000, Easing.SpringIn);
        }

        private void Onactivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage(), true);
        }

        private void Onfeed(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new feedPage2());
        }

        private void Ontickets(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page1());

        }

        private void Userdata1(object sender, TextChangedEventArgs e)
        {
            Constants.currentcustomer.first_name = e.NewTextValue;

        }

        private void Userdata2(object sender, TextChangedEventArgs e)
        {
            Constants.currentcustomer.email = e.NewTextValue;


        }

        private void Userdata3(object sender, TextChangedEventArgs e)
        {
            Constants.currentcustomer.address = e.NewTextValue;


        }

        private void Userdata4(object sender, TextChangedEventArgs e)
        {
            Constants.currentcustomer.phone_number = e.NewTextValue;


        }

        private void Userdata5(object sender, TextChangedEventArgs e)
        {
            Constants.currentcustomer.company_name = e.NewTextValue;


        }

        private void Onlogout(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());

        }

        protected override bool OnBackButtonPressed()
        {
            if (_canClose)
            {
                ShowExitDialog();
            }
            return _canClose;
        }

        private async void ShowExitDialog()
        {
            var answer = await DisplayAlert("Exit", "Do you wan't to exit the App?", "Yes", "No");
            if (answer)
            {
                _canClose = false;
                this.OnBackButtonPressed();

            }
        }
    }
}