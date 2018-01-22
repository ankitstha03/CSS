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
        App app = Application.Current as App;

        public Profile ()
		{
			InitializeComponent ();
            Title = Constants.user.Username;
            imagp.Source = Constants.user.ProfileImage;
            usern.Text = Constants.user.Username;
            lbluser.Text = Constants.user.Username;
            lblname.Text = Constants.user.Username;
            lbladdress.Text = Constants.user.Username;
            lblphn.Text = Constants.user.Username;

        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);

        }

        private void Onactivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage(), true);
        }

        private void Onlogout(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());

        }
    }
}