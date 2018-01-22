using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using App3.Models;

namespace App3.ViewModel
{
    class CardDataViewModel
    {

        public ObservableCollection<Ticket>  CardDataCollection = new ObservableCollection<Ticket>
                {
                 };
    public object SelectedItem { get; set; }

        public CardDataViewModel()
        {

            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            // for (var i = 0; i < 10; i++)
            {
                CardDataCollection = new ObservableCollection<Ticket>
                {
                 };

            foreach (Ticket ticket in Constants._ticket)
            {
                    if (ticket.Currentusr.Username == Constants.user.Username)
                    {
                        CardDataCollection.Add(ticket);
                    }
            }


            }
        }

        public IEnumerable<Ticket> GetCard(string sear=null)
        {
            if(String.IsNullOrWhiteSpace(sear))
                return CardDataCollection;

            return CardDataCollection.Where(c => c.Title.StartsWith(sear));
        }
    }
}