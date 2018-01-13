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
    public class CardDataViewModel
    {
        public IList<CardDataModel> CardDataCollection { get; set; }

        public object SelectedItem { get; set; }

        public CardDataViewModel()
        {
            CardDataCollection = new List<CardDataModel>();
            GenerateCardModel();
        }

        private void GenerateCardModel()
        {
            // for (var i = 0; i < 10; i++)
            {
                CardDataCollection = new ObservableCollection<CardDataModel>
                {
                    new CardDataModel
                    {
                     HeadTitle = " 1 day ago   - FaceBook ",

                     HeadLines="Samsung SM-T385S with Android 7.0 gets Wifi certified - GSM Arena News " ,
                     ProfileImage = "profile.png",
                     HeadLinesDesc = "Facebook is a social networking service launched on February 4........small sample based on your scenario. Please review my project and let us know  ",

                    },



                     new CardDataModel
                    {
                     HeadTitle = " 9 hrs ago   - The Indipendendent",
                     HeadLines="Game of THrones season 7 : Fans think Catelyn's Stark's Ghost was" ,
                     HeadLinesDesc = "The Independent is a British online newspaper.[2]............small sample based on your scenario. Please review my project and let us know",

                     ProfileImage = "profile.png"
                     },



                      new CardDataModel
                    {
                    HeadTitle       = " 10 hrs ago  - Power BI Microsoft",
                    HeadLines         ="Announcing the Power BI Solution Tempelate for Azure Activity Log" ,
                     HeadLinesDesc     = "Microsoft Corporation (/ˈmaɪkrəˌsɒft/,[2][3] abbreviated.............small sample based on your scenario. Please review my project and let us know",

                      ProfileImage     = "profile.png"
                      },


                       new CardDataModel
                    {
                    HeadTitle = " 13 hrs ago  - MacRumors ",
                      HeadLines    = "MacRumors.com is a website that aggregates Mac and Apple",
                     HeadLinesDesc="Google Rolls Out Anti-Polishing Feature to Gmail on Ios",
                     ProfileImage = "profile.png"

                       },


                        new CardDataModel
                    {
                    HeadTitle= " 15 hrs ago - Android Authority",
                   HeadLinesDesc  = "If you have read Jules Verne’s Around the World...........small sample based on your scenario. Please review my project and let us know" ,
                     HeadLines="Set it and forget it : 5 Things you should always automate on your phone" ,
                     ProfileImage = "profile.png"
                        },


                         new CardDataModel
                    {
                      HeadTitle = " 16 hrs ago - MacRumors",
                      HeadLinesDesc = "MacRumors.com is a website that aggregates Mac and Apple related news................small sample based on your scenario. Please review my project and let us know,",
                      HeadLines="Set it and forget it : 5 Things you should always automate on your phone" ,
                      ProfileImage = "profile.png"
                         },


                          new CardDataModel
                    {
                     HeadTitle = " 19 hrs ago  - Android Authority",
                      HeadLinesDesc = "MacRumors.com is a website that aggregates Mac and Apple.........small sample based on your scenario. Please review my project and let us know",
                      HeadLines="Set it and forget it : 5 Things you should always automate on your phone" ,
                      ProfileImage = "profile.png"
                          },
                   
                 //   AlertColor =  Color.Green : Color.Blue,    This can be added to set alert dialog inside card data model
                };



            }
        }
    }
}