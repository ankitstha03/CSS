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

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        App app = Application.Current as App;
        CardDataViewModel abc = new CardDataViewModel();


        public Page1()
        {
            InitializeComponent();

        }

        async private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var dataCard = e.SelectedItem as Models.Ticket;
            
            await Navigation.PushAsync(new TicketPage(dataCard.Id),true);
            listView.SelectedItem = null;
        }

        private void Onactivated(object sender, EventArgs e)
        {
            Navigation.PushAsync(new SettingPage(),true);
        }

        private void Onlogout(object sender, EventArgs e)
        {
            Application.Current.MainPage = new NavigationPage(new MainPage());

        }

        private void Onchange(object sender, TextChangedEventArgs e)
        {
            listView.ItemsSource = abc.GetCard(e.NewTextValue).Reverse<Ticket>();
        }

        private void Onrefresh(object sender, EventArgs e)
        {
            Navigation.InsertPageBefore(new Page1(), this);
            listView.EndRefresh();
            Navigation.RemovePage(this);
            
        }

        private void Ticket_Add(object sender, EventArgs e)
        {
            Navigation.PushAsync(new TicketFormPage(),true);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);
            newticket.BackgroundColor = Color.FromHex(app.DefColor);
            abc = new CardDataViewModel();
            listView.ItemsSource = abc.GetCard().Reverse<Ticket>();

        }
    }

}
