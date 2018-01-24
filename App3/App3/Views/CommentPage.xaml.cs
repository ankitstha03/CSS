using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class CommentPage : ContentPage
	{
        Feed CurrentFeed = new Feed();
        int count = 0;
        Entry msgent = new Entry { Placeholder = "Comment", HeightRequest = 50, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 };
        StackLayout layout = new StackLayout
        {
            Spacing = 10,
            Padding = new Thickness(20, 20, 20, 20),
            Orientation = StackOrientation.Vertical

        };

        ScrollView view = new ScrollView
        {
            VerticalOptions = LayoutOptions.StartAndExpand

        };
        public CommentPage(int id)
        {
            InitializeComponent();
            GetFeed(id);
            //Title = CurrentFeed.Title;
            Button senbutton = new Button { Text = "Send", HeightRequest = 50, VerticalOptions = LayoutOptions.End };
            senbutton.Clicked += new EventHandler(Button_Clicked);
            Frame abc = new Frame
            {
                IsClippedToBounds = true,
                HasShadow = true,
                BackgroundColor = Color.White,
                OutlineColor = Color.Gray,
                Margin = new Thickness(7),
                Padding = new Thickness(5)
            };

            StackLayout layout3 = new StackLayout();
            layout3.Children.Add(new Label { HeightRequest = 0, BackgroundColor = Color.Transparent, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });
            layout3.Children.Add(new Label { Text = CurrentFeed.Title });



            Label commcount = new Label { Text = CurrentFeed.Comments.Count.ToString() + " comments" };
            StackLayout sl2 = new StackLayout
            {
                Orientation = StackOrientation.Horizontal
            };
            sl2.Children.Add(commcount);
            layout3.Children.Add(sl2);
            abc.Content = layout3;
            layout.Children.Add(new Label { HeightRequest = 0, BackgroundColor = Color.Transparent, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });
            layout.Children.Add(abc);
            foreach (Comment comment in CurrentFeed.Comments)
            {
                Frame abc2 = new Frame
                {
                    IsClippedToBounds = true,
                    HasShadow = true,
                    BackgroundColor = Color.White,
                    OutlineColor = Color.Gray,
                    Margin = new Thickness(7),
                    Padding = new Thickness(5)
                };
                Image imag = new Image { Source = comment.Currentusr.ProfileImage, WidthRequest=40,HeightRequest=40 };
                Label username = new Label { Text = comment.Currentusr.Username, HorizontalOptions=LayoutOptions.Center, FontSize = 10 };
                    Label commenter = new Label { Text = comment.Text, FontSize = 18, VerticalOptions=LayoutOptions.Center };
                    StackLayout sl = new StackLayout();
                    sl.Orientation = StackOrientation.Horizontal;

                StackLayout sl3 = new StackLayout();
                sl3.Orientation = StackOrientation.Vertical;
                sl3.WidthRequest = 50;
                sl3.Children.Add(imag);
                sl3.Children.Add(username);
                sl.Children.Add(sl3);
                sl.Children.Add(commenter);


                abc2.Content = sl;

                    layout.Children.Add(abc2);
            }



            view.Content = layout;

            var layout1 = new StackLayout
            {
                Spacing = 10,
                Orientation = StackOrientation.Horizontal,
                VerticalOptions = LayoutOptions.End
            };
            layout1.Children.Add(msgent);
            layout1.Children.Add(senbutton);


            var layout2 = new StackLayout
            {
                Spacing = 10,
                Padding = new Thickness(0, 0, 0, 0),
                Orientation = StackOrientation.Vertical
            };
            layout2.Children.Add(new Label { Text = CurrentFeed.Currentusr.Username, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center, HeightRequest = 40, BackgroundColor = Color.FromHex("#121212"), FontSize = 16, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });
            layout2.Children.Add(view);
            layout2.Children.Add(layout1);

            Content = layout2;
            var abc3 = new Label { HeightRequest = 0, BackgroundColor = Color.Transparent };
            layout.Children.Add(abc3);
            view.ScrollToAsync(abc3, ScrollToPosition.End, false);

        }

        private void GetFeed(int id)
        {
            foreach (Feed feed in Constants._feed)
            {
                if (feed.Id == id)
                    CurrentFeed= feed;
            }
        }
        private void Button_Clicked(object sender, EventArgs e)
        {
            if (msgent.Text != "" && msgent.Text != null)
            {
                CurrentFeed.AddComment(CurrentFeed, new Comment(Constants.user, msgent.Text));
                Frame abc2 = new Frame
                {
                    IsClippedToBounds = true,
                    HasShadow = true,
                    BackgroundColor = Color.White,
                    OutlineColor = Color.Gray,
                    Margin = new Thickness(7),
                    Padding = new Thickness(5)
                };
                Image imag = new Image { Source = Constants.user.ProfileImage, WidthRequest = 40, HeightRequest = 40 };
                Label username = new Label { Text = Constants.user.Username, HorizontalOptions = LayoutOptions.Center, FontSize = 10 };
                Label commenter = new Label { Text = msgent.Text, FontSize = 18, VerticalOptions = LayoutOptions.Center };
                StackLayout sl = new StackLayout();
                sl.Orientation = StackOrientation.Horizontal;

                StackLayout sl3 = new StackLayout();
                sl3.Orientation = StackOrientation.Vertical;
                sl3.WidthRequest = 50;
                sl3.Children.Add(imag);
                sl3.Children.Add(username);
                sl.Children.Add(sl3);
                sl.Children.Add(commenter);


                abc2.Content = sl;
                layout.Children.Add(abc2);
                view.ScrollToAsync(abc2, ScrollToPosition.End, true);
                msgent.Text = string.Empty;
            }


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