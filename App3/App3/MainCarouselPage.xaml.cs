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

        public MainCarouselPage()
        {
            InitializeComponent();
            WebView _animatedLogoView = new WebView
            {
                Source = "http://xamarin.com"
            };
            first.Children.Add(_animatedLogoView);
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);
            
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            app.Nsession = "1";
            Application.Current.MainPage = new NavigationPage(new MainPage());
        }

        private void Browser_Navigated(object sender, WebNavigatedEventArgs e)
        {
            LoadingLabel.IsVisible = false;
        }

        private void Browser_Navigating(object sender, WebNavigatingEventArgs e)
        {
            LoadingLabel.IsVisible = true;
        }
    }
}
