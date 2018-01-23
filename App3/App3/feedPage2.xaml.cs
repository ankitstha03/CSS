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
	public partial class feedPage2 : ContentPage
	{
        StackLayout layout_main = new StackLayout
        {
            Spacing = 10,
            Padding = new Thickness(20, 20, 20, 20),
            Orientation = StackOrientation.Vertical

        };

        ScrollView view = new ScrollView
        {
            VerticalOptions = LayoutOptions.StartAndExpand

        };
        public feedPage2 ()
		{
			InitializeComponent ();
            foreach(Feed feed in Constants._feed) {
                StackLayout layout = new StackLayout();
                layout.Children.Add(new Label { HeightRequest = 0, BackgroundColor = Color.Transparent, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });
                layout.Children.Add(new Label { Text = feed.Title });
                foreach (Comment comment in feed.Comments)
                {

                    Label username = new Label { Text = comment.Currentusr.Username, FontSize = 14 };
                    Label commenter = new Label { Text = comment.Text, FontSize = 12 };
                    StackLayout sl = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal
                    };
                    sl.Children.Add(username);
                    sl.Children.Add(commenter);
                    layout.Children.Add(sl);
                }
                Button commentButton = new Button { Text = "Comment", HeightRequest = 50, VerticalOptions = LayoutOptions.End };
                commentButton.Clicked += async (sender, e) =>
                {
                    await Navigation.PushModalAsync(new CommentPage(feed.Id));
                };
                layout.Children.Add(commentButton);
                layout_main.Children.Add(layout);
                view.Content = layout_main;
            }
            Content = layout_main;
		}
    }
}