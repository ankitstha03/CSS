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
        public IList<Ticket> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }

        public CardDataViewModel()
        {
            CardDataCollection = new List<Ticket>();
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




            //   AlertColor =  Color.Green : Color.Blue,    This can be added to set alert dialog inside card data model



            }
        }
    }
}