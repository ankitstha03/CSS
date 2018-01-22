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


            layout.Children.Add(new Label { HeightRequest = 0, BackgroundColor = Color.Transparent, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });
            layout.Children.Add(new Label { Text = CurrentFeed.Title});
            foreach (Comment comment in CurrentFeed.Comments)
            {
                
                    Label username = new Label { Text = comment.Currentusr.Username, FontSize = 14 };
                    Label commenter = new Label { Text = comment.Text, FontSize = 12 };
                    StackLayout sl = new StackLayout();
                    sl.Orientation = StackOrientation.Horizontal;
                    sl.Children.Add(username);
                    sl.Children.Add(commenter);
                    layout.Children.Add(sl);
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
            var abc = new Label { HeightRequest = 0, BackgroundColor = Color.Transparent };
            layout.Children.Add(abc);
            view.ScrollToAsync(abc, ScrollToPosition.End, false);

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
                Label username = new Label { Text = Constants.user.Username, FontSize = 14 };
                Label commenter = new Label { Text = msgent.Text, FontSize = 12 };
                StackLayout sl = new StackLayout();
                sl.Orientation = StackOrientation.Horizontal;
                sl.Children.Add(username);
                sl.Children.Add(commenter);
                layout.Children.Add(sl);
                view.ScrollToAsync(sl, ScrollToPosition.End, true);
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