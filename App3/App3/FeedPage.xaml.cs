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
	public partial class FeedPage : ContentPage
	{
		public FeedPage ()
		{
			InitializeComponent ();
		}


        async private void CommentHandler(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var dataCard = e.SelectedItem as Models.Feed;

            await Navigation.PushAsync(new CommentPage(dataCard.Id));
            listView.SelectedItem = null;
        }


        private void Onactivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage(), true);
        }

        private void Icon_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Profile());


        }
        private void Onlogout(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());

        }

        private void Ontickets(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Page1());

        }

    }
}