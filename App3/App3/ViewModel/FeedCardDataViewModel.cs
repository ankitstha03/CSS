using App3.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace App3.ViewModel
{
    class FeedCardDataViewModel
    {
        public IList<Feed> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }

        public FeedCardDataViewModel()
        {
            CardDataCollection = new List<Feed>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            // for (var i = 0; i < 10; i++)
            {
                CardDataCollection = new ObservableCollection<Feed>
                {
                };

                foreach (Feed feed in Constants._feed)
                {
                    if (feed.Currentusr.Username == Constants.user.Username)
                    {
                        CardDataCollection.Add(feed);
                    }
                }




                //   AlertColor =  Color.Green : Color.Blue,    This can be added to set alert dialog inside card data model



            }
        }
    }
}