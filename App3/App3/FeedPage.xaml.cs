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
    }
}