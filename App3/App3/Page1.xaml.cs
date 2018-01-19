using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using App3.Views;
using Xamarin.Forms.Xaml;
using App3.Models;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Page1 : ContentPage
    {
        public Page1()
        {
            InitializeComponent();
            
            
        }

        async private void listView_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            if (e.SelectedItem == null)
                return;

            var dataCard = e.SelectedItem as Models.Ticket;
            
            await Navigation.PushAsync(new TicketPage(dataCard.Id));
            listView.SelectedItem = null;
        }
    }
}
