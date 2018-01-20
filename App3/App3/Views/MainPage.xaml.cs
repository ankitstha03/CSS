using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using App3.Models;
using App3.ViewModel;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainPage : ContentPage
    {
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

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if(enUser.Text!=null && enPass.Text != null && enUser.Text != "" && enPass.Text != "")
            {

                Constants.user = new User(enUser.Text, enPass.Text);

                if (Constants.user.CheckInformation(GetUsers()))
                {
                    Application.Current.MainPage = new NavigationPage(new Page1());
                }
                else
                    DisplayAlert("Login Failed", "The Username Or Password is Incorrect", "Ok");

            }
            else
                DisplayAlert("Login Failed", "The Username Or Password is Empty", "Ok");

        }


        private async void Icon_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new TicketPage(1),true);

        }

        private void Onactivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage(),true);

        }
    }


}
