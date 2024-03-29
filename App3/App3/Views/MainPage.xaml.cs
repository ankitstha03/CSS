﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using App3.Models;
using App3.ViewModel;
using Newtonsoft.Json;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {

        private const string Url = "http://support.prixa.net/api-auth/customers/";
        private HttpClient _client = new HttpClient();
        private bool _canClose = true;

        App app = Application.Current as App;

        public MainPage()
        {
            InitializeComponent();
            Init();
        }

        private void Init()
        {
            BackgroundColor = Constants.BackgroundColor;
           
            btnLogin.TextColor = Constants.BackgroundColor;
            
            
            enUser.Completed += (s, e) => enPass.Focus();
            enPass.Completed += (s, e) => Button_Clicked(s, e);
        }



        List<User> GetUsers()
        {
            
            return Constants._users;

        }

      
        private void TapGestureRecognizer_Clicked(object sender, EventArgs e)
        {
            DisplayAlert("Title", "Confirm Submission", "OK", "CANCEL");
        }

        private void Tap1GestureRecognizer_Tapped(object sender, EventArgs e)
        {
            DisplayAlert("Help SignIn", "Confirm Submission", "OK", "CANCEL");
        }
        private void Tap2GestureRecognizer_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new Page2(),true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);
            enUser.PlaceholderColor = Color.FromHex(app.DefColor);
            enPass.TextColor = Color.FromHex(app.DefColor);
            btnLogin.BackgroundColor = Color.FromHex(app.DefColor);
            enUser.Margin=new Thickness(-200, 0, 200, 0);
            enPass.Margin = new Thickness(200, 0, -200, 0);
            grd1.Opacity = 0;
            btnLogin.Opacity = 0;
            enUser.TranslateTo(200, 0, 1000, Easing.SpringIn);
            enPass.TranslateTo(-200, 0, 1000, Easing.SpringIn);
            btnLogin.FadeTo(1, 2000, Easing.SpringIn);
            grd1.FadeTo(1, 300, Easing.SpringIn);


        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
             using (var cl = new HttpClient())
            {
                var formcontent = new FormUrlEncodedContent(new[]
                {
                        new KeyValuePair<string,string>("username",enUser.Text),
                        new KeyValuePair<string, string>("password",enPass.Text)
                    });


                var request = await cl.PostAsync("http://support.prixa.net/api-auth/login/", formcontent);

                if ((int)request.StatusCode == 200)
                {
                    var content = await _client.GetStringAsync(Url);
                    Constants.currentcustomer = JsonConvert.DeserializeObject<List<Customer>>(content).SingleOrDefault(x => x.username == enUser.Text); ;
                    Application.Current.MainPage = new NavigationPage(new Page1());
                }
                else
                {
                    await DisplayAlert("Error", "Your password or username is incorrect", "OK");
                }


                

            }


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


        private void Onactivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage(),true);


        }
    }


}
