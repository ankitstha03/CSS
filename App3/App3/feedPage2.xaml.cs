//using App3.Models;
//using App3.Views;
//using Newtonsoft.Json;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Net.Http;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using Xamarin.Forms.Xaml;

//namespace App3
//{
//	[XamlCompilation(XamlCompilationOptions.Compile)]
//	public partial class feedPage2 : ContentPage
//	{
//        private bool _canClose = true;
//        private const string Url= "http://support.prixa.net/api-auth/feeds/?format=json";
//        private HttpClient _client = new HttpClient();
//        List<Feed> feeds;
//        App app = Application.Current as App;

//        StackLayout layout_main = new StackLayout
//        {
//            Spacing = 5,
//            Padding = new Thickness(0, 0, 0, 0),
//            Orientation = StackOrientation.Vertical

//        };

//        StackLayout layout_main2 = new StackLayout
//        {
//            Spacing = 10,
//            Padding = new Thickness(20, 20, 20, 20),
//            Orientation = StackOrientation.Vertical

//        };

//        ScrollView view = new ScrollView
//        {
//            VerticalOptions = LayoutOptions.StartAndExpand

//        };

//        Entry entfeed = new Entry { Placeholder = "Write a Post", HorizontalOptions = LayoutOptions.FillAndExpand };
//        public feedPage2 ()
//		{
//			InitializeComponent ();
//            Icon.Icon = Constants.user.ProfileImage;
           
            
//		}

//        protected override async void OnAppearing()
//        {
//            base.OnAppearing();
//            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);
//            entfeed.PlaceholderColor = Color.FromHex(app.DefColor);
//            layout_main.Children.Clear();
//            layout_main2.Children.Clear();

//            var content = await _client.GetStringAsync(Url);
//            feeds = JsonConvert.DeserializeObject<List<Feed>>(content);


//            Button btnpost = new Button { Text = "Post", BackgroundColor=Color.FromHex(app.DefColor), TextColor = Color.White, HeightRequest = 50, HorizontalOptions = LayoutOptions.End };
//            btnpost.Clicked += new EventHandler(Button_Clicked);

//            Frame abcs = new Frame
//            {
//                IsClippedToBounds = true,
//                HasShadow = true,
//                BackgroundColor = Color.White,
//                OutlineColor = Color.Gray,
//                Margin = new Thickness(7),
//                Padding = new Thickness(5)
//            };
//            StackLayout sls2 = new StackLayout();
//            sls2.Orientation = StackOrientation.Vertical;
//            sls2.Children.Add(entfeed);
//            sls2.Children.Add(btnpost);
//            abcs.Content = sls2;
//            layout_main2.Children.Add(abcs);

//            foreach (Feed feed in Constants._feed.Reverse<Feed>())
//            {

//                Frame abc = new Frame
//                {
//                    IsClippedToBounds = true,
//                    HasShadow = true,
//                    BackgroundColor = Color.White,
//                    OutlineColor = Color.Gray,
//                    Margin = new Thickness(7),
//                    Padding = new Thickness(5)
//                };
//                var tapGestureRecognizer = new TapGestureRecognizer();
//                tapGestureRecognizer.Tapped += async (s, e) => {
//                    await Navigation.PushAsync(new CommentPage(feed.Id));

//                };

//                abc.GestureRecognizers.Add(tapGestureRecognizer);
//                Image imag0 = new Image { Source = feed.Currentusr.ProfileImage, WidthRequest = 40, HeightRequest = 40 };
//                Label username0 = new Label { Text = feed.Currentusr.Username, VerticalOptions = LayoutOptions.Center, FontSize = 18 };

//                StackLayout sls = new StackLayout();
//                sls.Orientation = StackOrientation.Horizontal;
//                sls.Children.Add(imag0);
//                sls.Children.Add(username0);

//                StackLayout layout = new StackLayout();

//                layout.Children.Add(new Label { HeightRequest = 0, BackgroundColor = Color.Transparent, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });
//                layout.Children.Add(sls);
//                layout.Children.Add(new Label { Text = feed.Title });


//                var asd = feed.Comments.Count();

//                Label commcount = new Label { Text = asd + " comments" };
//                layout.Children.Add(commcount);

//                Button commentButton = new Button { Text = "Comment", HeightRequest = 50, TextColor=Color.White, BackgroundColor=Color.FromHex(app.DefColor), VerticalOptions = LayoutOptions.End };
//                commentButton.Clicked += async (sender, e) =>
//                {
//                    await Navigation.PushAsync(new CommentPage(feed.Id));
//                };
//                layout.Children.Add(commentButton);
//                abc.Content = layout;
//                layout_main.Children.Add(abc);
//            }
//            view.Content = layout_main;
//            layout_main2.Children.Add(view);
//            Content = layout_main2;

//            view.Margin = new Thickness(-200, 0, 200, 0);
//            view.TranslateTo(200, 0, 1000, Easing.SpringIn);
//            abcs.Opacity = 0;
//            abcs.FadeTo(1, 1000, Easing.SpringIn);
//            view.Opacity = 0;
//            view.FadeTo(1, 1000, Easing.SpringIn);
//        }

//        private void Icon_Clicked(object sender, EventArgs e)
//        {
//            Application.Current.MainPage = new NavigationPage(new Profile());


//        }

      

//        private void Ontickets(object sender, EventArgs e)
//        {
//            Application.Current.MainPage = new NavigationPage(new Page1());

//        }

//        private void Onactivated(object sender, EventArgs e)
//        {
//            Navigation.PushAsync(new SettingPage(), true);
//        }

//        private void Onlogout(object sender, EventArgs e)
//        {
//            Application.Current.MainPage = new NavigationPage(new MainPage());


//        }

//        private void Button_Clicked(object sender, EventArgs e)
//        {
//            Constants._feed.Add(new Feed(Constants.count2++, Constants.user, entfeed.Text, new List<Comment>()));
//            Application.Current.MainPage = new NavigationPage(new feedPage2());


//        }

//        private async void GetFeeds()
//        {
//            var content = await _client.GetStringAsync(Url);
//            feeds = JsonConvert.DeserializeObject<List<Feed>>(content);
//        }

//        protected override bool OnBackButtonPressed()
//        {
//            if (_canClose)
//            {
//                ShowExitDialog();
//            }
//            return _canClose;
//        }

//        private async void ShowExitDialog()
//        {
//            var answer = await DisplayAlert("Exit", "Do you wan't to exit the App?", "Yes", "No");
//            if (answer)
//            {
//                _canClose = false;
//                this.OnBackButtonPressed();

//            }
//        }
//    }
//}