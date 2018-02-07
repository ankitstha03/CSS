using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3.Models;
using System.Net.Http;
using Newtonsoft.Json;

namespace App3.ViewModel
{
    class CardDataViewModel
    {
        private const string Url = "http://support.prixa.net/api-auth/tickets/?format=json";
        private HttpClient _client = new HttpClient();
        List<Ticket> tickets;

        public ObservableCollection<Ticket>  CardDataCollection = new ObservableCollection<Ticket>
                {
                 };
    public object SelectedItem { get; set; }

        public CardDataViewModel()
        {

            GenerateCardModel();
        }

        private async void GenerateCardModel()
        {
            // for (var i = 0; i < 10; i++)
            {
                var content = await _client.GetStringAsync(Url);
                tickets = JsonConvert.DeserializeObject<List<Ticket>>(content);
                CardDataCollection = new ObservableCollection<Ticket>(tickets);




            //foreach (Ticket ticket in Constants._ticket)
            //{
            //        if (ticket.Currentusr.Username == Constants.user.Username)
            //        {
            //            CardDataCollection.Add(ticket);
            //        }
            //}


            }
        }

        //public IEnumerable<Ticket> GetCard(string sear=null)
        //{
        //    if(String.IsNullOrWhiteSpace(sear))
        //        return CardDataCollection;

        //    return CardDataCollection.Where(c => c.subject.StartsWith(sear));
        //}
    }
}