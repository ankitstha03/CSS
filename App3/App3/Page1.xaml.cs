using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using App3.Views;
using App3.ViewModel;
using Xamarin.Forms.Xaml;
using App3.Models;
using System.Net.Http;
using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        ObservableCollection<Ticket> CardDataCollection;
        private const string Url = "http://support.prixa.net/api-auth/tickets/?format=json";
        private HttpClient _client = new HttpClient();
        List<Ticket> tickets;
        private bool _canClose = true;

        App app = Application.Current as App;


        public Page1()
        {
            InitializeComponent();


        }

        private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var dataCard = e.SelectedItem as Models.Ticket;
            
            //await Navigation.PushAsync(new TicketPage(dataCard.Id),true);
            listView.SelectedItem = null;
        }

        private void Onactivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage(),true);
        }

        private void Icon_Clicked(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new Profile());


        }
        private void Onlogout(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());

        }

        private void Onchange(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(e.NewTextValue))
            {
                var temp = CardDataCollection.Where(c => c.subject.StartsWith(e.NewTextValue));
                CardDataCollection = new ObservableCollection<Ticket>(temp);
                listView.ItemsSource = CardDataCollection.Reverse<Ticket>();
            }
            else
            {
                CardDataCollection = new ObservableCollection<Ticket>(tickets);
                listView.ItemsSource = CardDataCollection.Reverse<Ticket>();
            }

        }

        private void Onrefresh(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new Page1(), this);
            listView.EndRefresh();
            Navigation.RemovePage(this);
            
        }

        //private void Onfeed(object sender, EventArgs e)
        //{
        //    Application.Current.MainPage = new NavigationPage(new feedPage2());
        //}

        //private void Ontickets(object sender, EventArgs e)
        //{
        //    Application.Current.MainPage = new NavigationPage(new Page1());

        //}


        //private void Ticket_Add(object sender, EventArgs e)
        //{
        //    Navigation.PushAsync(new TicketFormPage(),true);
        //}

        protected override async void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);
            //newticket.BackgroundColor = Color.FromHex(app.DefColor);
            var content = await _client.GetStringAsync(Url);
            var temp= JsonConvert.DeserializeObject<List<Ticket>>(content).Where(c => c.customer.username.Equals(Constants.currentcustomer.username));
            tickets = temp.ToList();
            CardDataCollection = new ObservableCollection<Ticket>(tickets);
            listView.ItemsSource = CardDataCollection.Reverse<Ticket>();
            Icon.Icon = Constants.currentcustomer.profile_picture;
            view.Margin = new Thickness(-200,0,200,0);
            view.TranslateTo(200, 0, 1000, Easing.SpringIn);
            //newticket.Opacity = 0;
            //newticket.FadeTo(1, 1000,Easing.SpringIn);
            listView.Opacity = 0;
            listView.FadeTo(1, 1000, Easing.SpringIn);
        }

        protected override bool OnBackButtonPressed()
        {
            if (_canClose)
            {
                ShowExitDialog();
            }
            return _canClose;
        }

        private async void ShowExitDialog()
        {
            var answer = await DisplayAlert("Exit", "Do you wan't to exit the App?", "Yes", "No");
            if (answer)
            {
                _canClose = false;
                this.OnBackButtonPressed();

            }
        }
    }

}
