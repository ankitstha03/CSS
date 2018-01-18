using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Plugin.Media;
using Plugin.Media.Abstractions;
using Xamarin.Forms.Xaml;
using App3.Models;
using App3.Views;


namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page2 : ContentPage
	{
        private MediaFile _mediaFile;

		public Page2 ()
		{
			InitializeComponent ();
		}

        void AddUsers(User newuse)
        {

            Constants._users.Add(newuse);

        }

        private async void Tap3GestureRecognizer_Tapped(object sender, EventArgs e)
        {
            await CrossMedia.Current.Initialize();
            if (!CrossMedia.Current.IsPickPhotoSupported)
            {

               await DisplayAlert("No Photo Picked", ":( No Photo Available", "OK");
                return;

            }
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            if (userent.Text != null && passent.Text != null && userent.Text != "" && passent.Text != "")
            {
                if (passent.Text == passent2.Text)
                {
                    User user = new User(userent.Text, passent.Text);

                    if (!user.CheckUsername(Constants._users))
                    {
                        AddUsers(user);

                        if (user.CheckInformation(Constants._users))
                        {
                            Application.Current.MainPage = new NavigationPage(new Page1());
                        }
                        else
                            DisplayAlert("Register Failed", "The Username Or Password is Incorrect", "Ok");
                    }
                    else
                        DisplayAlert("Register Failed", "The Username already exists", "Ok");

                }
                else
                    DisplayAlert("Register Failed", "The Password and Confirm Password do not match", "Ok");

            }
            else
                DisplayAlert("Register Failed", "The Username Or Password is Empty", "Ok");
        }
    }
}