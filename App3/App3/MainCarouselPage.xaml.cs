using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using App3.Views;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MainCarouselPage : CarouselPage
    {
        App app = Application.Current as App;
        private bool _canClose = true;

        public MainCarouselPage()
        {
            InitializeComponent();
 
        }

   

        private void Button_Clicked(object sender, EventArgs e)
        {
            app.Nsession = "1";
            Application.Current.MainPage = new NavigationPage(new MainPage());
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
                OnBackButtonPressed();
            }
        }

    }
}
