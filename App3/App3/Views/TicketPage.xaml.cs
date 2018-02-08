//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//using Xamarin.Forms;
//using App3.Models;
//using Xamarin.Forms.Xaml;

//namespace App3.Views
//{
//	[XamlCompilation(XamlCompilationOptions.Compile)]
//	public partial class TicketPage : ContentPage
//	{
//        Ticket ticketer=new Ticket();
//        int count=0;


//        App app = Application.Current as App;


//        Entry msgent = new Entry { Placeholder = "Write a message", Margin=new Thickness(20,0,20,0),  HeightRequest = 50, HorizontalOptions = LayoutOptions.FillAndExpand, FontSize = 16 };
//        StackLayout layout = new StackLayout
//        {
//            Spacing = 10,
//            Padding = new Thickness(20, 20, 20, 20),
//            Orientation = StackOrientation.Vertical

//        };

//        ScrollView view = new ScrollView
//        {
//            VerticalOptions = LayoutOptions.StartAndExpand

//        };
//        public TicketPage (int id)
//		{
//			InitializeComponent ();
//            Getticket(id);
//            Title = ticketer.Title;

            


//        }

      

//        private void Getticket(int id)
//        {
//            foreach(Ticket ticket in Constants._ticket)
//            {
//                if (ticket.Id == id)
//                    ticketer = ticket;
//            }
//        }
//        private void Button_Clicked(object sender, EventArgs e)
//        {
//            if(msgent.Text!="" && msgent.Text != null)
//            {
//                ticketer.Addmessage(ticketer, new Message(msgent.Text, true));
//                Frame temp = new Frame
//                {
//                    CornerRadius = 12,
//                    OutlineColor = Color.Transparent,
//                    Padding = new Thickness(15, 5, 15, 5),
//                    Margin = new Thickness(0, 0, 50, 0),
//                    HorizontalOptions = LayoutOptions.Start,
//                    VerticalOptions = LayoutOptions.Fill,
//                    BackgroundColor = Color.FromHex(app.DefColor)

//                };
//                temp.Content = new Label { Text = msgent.Text, FontSize = 16, TextColor = Color.White, HorizontalOptions = LayoutOptions.StartAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
//                layout.Children.Add(temp);
//                view.ScrollToAsync(temp, ScrollToPosition.End, true);
//                msgent.Text = string.Empty;
//            }
            

//        }


//        protected override void OnAppearing()
//        {
//            base.OnAppearing();
//            Icon.Icon = Constants.user.ProfileImage;
//            layout.Children.Clear();
//            msgent.PlaceholderColor = Color.FromHex(app.DefColor);
//            Button senbutton = new Button { Text = "Send", HeightRequest = 50, BackgroundColor = Color.FromHex(app.DefColor), Margin = new Thickness(20, 0, 20, 0), VerticalOptions = LayoutOptions.End };
//            senbutton.Clicked += new EventHandler(Button_Clicked);


//            layout.Children.Add(new Label { HeightRequest = 0, BackgroundColor = Color.Transparent, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });




//            foreach (Message msg in ticketer.Msg)
//            {
//                count += 1;
//                if (msg.Sender)
//                {
//                    Frame temp = new Frame
//                    {
//                        CornerRadius = 12,
//                        OutlineColor = Color.Transparent,


//                        Padding = new Thickness(15, 5, 15, 5),
//                        Margin = new Thickness(-200, 0, 250, 0),
//                        HorizontalOptions = LayoutOptions.Start,
//                        VerticalOptions = LayoutOptions.Fill,
//                        BackgroundColor = Color.FromHex(app.DefColor)


//                    };
//                    temp.Content = new Label { Text = msg.Textmess, FontSize = 16, TextColor = Color.White, HorizontalOptions = LayoutOptions.StartAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
//                    layout.Children.Add(temp);
//                    temp.Opacity = 0;
//                    temp.FadeTo(1, 1000);
//                    temp.TranslateTo(200, 0, 1000, Easing.SpringIn);

//                }

//                else
//                {
//                    Frame temp = new Frame
//                    {
//                        CornerRadius = 12,
//                        OutlineColor = Color.Transparent,
//                        Padding = new Thickness(15, 5, 15, 5),
//                        Margin = new Thickness(250, 0, -200, 0),
//                        HorizontalOptions = LayoutOptions.End,
//                        VerticalOptions = LayoutOptions.Fill,
//                        BackgroundColor = Color.FromHex("#eeeeee")
//                    };
//                    temp.Content = new Label { Text = msg.Textmess, FontSize = 16, TextColor = Color.Black, HorizontalOptions = LayoutOptions.EndAndExpand, VerticalOptions = LayoutOptions.FillAndExpand };
//                    layout.Children.Add(temp);
//                    temp.Opacity = 0;
//                    temp.FadeTo(1, 1000);
//                    temp.TranslateTo(-200, 0, 1000, Easing.SpringIn);


//                }
//            }



//            view.Content = layout;

//            var layout1 = new StackLayout
//            {
//                Spacing = 10,
//                Orientation = StackOrientation.Horizontal,
//                VerticalOptions = LayoutOptions.End
//            };
//            layout1.Children.Add(msgent);
//            layout1.Children.Add(senbutton);
//            msgent.Opacity = 0;
//            senbutton.Opacity = 0;
//            msgent.FadeTo(1, 2000, Easing.SpringIn);
//            senbutton.FadeTo(1, 2000, Easing.SpringIn);

//            var layout2 = new StackLayout
//            {
//                Spacing = 10,
//                Padding = new Thickness(0, 0, 0, 0),
//                Orientation = StackOrientation.Vertical
//            };


//            layout2.Children.Add(new Label { Text = ticketer.Status, HorizontalTextAlignment = TextAlignment.Center, VerticalTextAlignment = TextAlignment.Center, HeightRequest = 40, BackgroundColor = Color.FromHex("#121212"), FontSize = 16, TextColor = Color.White, HorizontalOptions = LayoutOptions.FillAndExpand });
//            layout2.Children.Add(view);
//            layout2.Children.Add(layout1);



//            Content = layout2;
//            var abc = new Label { HeightRequest = 0, BackgroundColor = Color.Transparent };
//            layout.Children.Add(abc);
//            view.ScrollToAsync(abc, ScrollToPosition.End, false);

//        }

//        private void Icon_Clicked(object sender, EventArgs e)
//        {
//            Application.Current.MainPage = new NavigationPage(new Profile());


//        }

//        private void Onfeed(object sender, EventArgs e)
//        {
//            Application.Current.MainPage = new NavigationPage(new feedPage2());
//        }

//        private void Ontickets(object sender, EventArgs e)
//        {
//            Application.Current.MainPage = new NavigationPage(new Page1());

//        }

//        private void Onactivated(object sender, EventArgs e)
//        {
//             Navigation.PushAsync(new SettingPage(), true);
//        }

//        private void Onlogout(object sender, EventArgs e)
//        {
//            Application.Current.MainPage = new NavigationPage(new MainPage());


//        }
//    }
//}