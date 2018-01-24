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
            foreach(Feed feed in Constants._feed.Reverse<Feed>()) {

                Frame abc = new Frame
                {
                    IsClippedToBounds = true,
                    HasShadow = true,
                    BackgroundColor = Color.White,
                    OutlineColor = Color.Gray,
                    Margin = new Thickness(7),
                    Padding = new Thickness(5)
                };
                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += async (s, e) => {
                    await Navigation.PushAsync(new CommentPage(feed.Id));

                };

                abc.GestureRecognizers.Add(tapGestureRecognizer);

                StackLayout layout = new StackLayout();
                layout.Children.Add(new Label { HeightRequest = 0, BackgroundColor = Color.Transparent, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });
                layout.Children.Add(new Label { Text = feed.Title });
                
                

                    Label commcount = new Label { Text = feed.Comments.Count.ToString()+" comments" };
                    StackLayout sl = new StackLayout
                    {
                        Orientation = StackOrientation.Horizontal
                    };
                    sl.Children.Add(commcount);
                    layout.Children.Add(sl);
                
                Button commentButton = new Button { Text = "Comment", HeightRequest = 50, VerticalOptions = LayoutOptions.End };
                commentButton.Clicked += async (sender, e) =>
                {
                    await Navigation.PushAsync(new CommentPage(feed.Id));
                };
                layout.Children.Add(commentButton);
                abc.Content = layout;
                layout_main.Children.Add(abc);
            }
            view.Content = layout_main;

            Content = view;
		}
    }
}