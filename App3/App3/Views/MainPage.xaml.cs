using System;
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
        private const string Url = "http://support.prixa.net/api-auth/login/";
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
            if(enUser.Text!=null && enPass.Text != null && enUser.Text != "" && enPass.Text != "")
            {
                Constants.user = new User(enUser.Text,"", new Passwo(enPass.Text));
                var newuser=JsonConvert.SerializeObject(Constants.user);
                HttpResponseMessage response = await _client.PostAsync(Url, new StringContent(newuser, Encoding.UTF32, "application/json"));
                    await DisplayAlert("Login Failed", response.StatusCode.ToString(), "Ok");

            }
            else
                await DisplayAlert("Login Failed", "The Username Or Password is Empty", "Ok");


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
