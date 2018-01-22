using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App3.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class TicketFormPage : ContentPage
	{
        App app = Application.Current as App;

        public TicketFormPage ()
		{
			InitializeComponent ();
            
		}

        private void Onlogout(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);
            entmsg.PlaceholderColor = Color.FromHex(app.DefColor);
            entsub.PlaceholderColor = Color.FromHex(app.DefColor);
            btntick.BackgroundColor = Color.FromHex(app.DefColor);
            Icon.Icon = Constants.user.ProfileImage;
            categ.Margin = new Thickness(-200, 0, 200, 0);
            entsub.Margin = new Thickness(200, 0, -200, 0);
            entmsg.Margin = new Thickness(-200, 0, 200, 0);
            btntick.Opacity = 0;
            categ.TranslateTo(200, 0, 1000, Easing.SpringIn);
            entsub.TranslateTo(-200, 0, 1000, Easing.SpringIn);
            entmsg.TranslateTo(200, 0, 1000, Easing.SpringIn);
            btntick.FadeTo(1, 2000, Easing.SpringIn);

        }

        private void Onactivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage(),true);
        }

        private void Icon_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Profile());


        }

        private void Onfeed(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new FeedPage());
        }

        private void Ontickets(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page1());

        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (entsub.Text != "" && entmsg.Text != "" && categ.SelectedIndex != -1 && entsub.Text != null && entmsg.Text != null)
            {
                Constants._ticket.Add(new Ticket(Constants.count++, Constants.user, entsub.Text, categ.Items[categ.SelectedIndex], new List<Message> { new Message(entmsg.Text, true) }));
                Navigation.PopAsync(true);
            }
            else
                DisplayAlert("Empty fields", "Please fill all the fields of the form", "Ok");
        }
    }
}