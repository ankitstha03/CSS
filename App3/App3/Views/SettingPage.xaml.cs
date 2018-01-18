using App3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace App3.Views
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class SettingPage : ContentPage
	{
        TapGestureRecognizer tapGestureRecognizer = new TapGestureRecognizer();

        public SettingPage ()
		{
            int count = 0;
            int counth = 0;

            InitializeComponent();
            var grd = new Grid
            {
                RowSpacing = 10,
                ColumnSpacing=10

            };

            var layout = new StackLayout
            {
                Padding = new Thickness(20, 20, 20, 20),
                Spacing = 20,
                Orientation = StackOrientation.Vertical

            };
            foreach (String clr in Constants._colors)
            {

                BoxView temp = new BoxView
                {
                    Color = Color.FromHex(clr)
                };

                var tapGestureRecognizer = new TapGestureRecognizer();
                tapGestureRecognizer.Tapped += (s, e) => {
                    var a = s as BoxView;
                    var app = Application.Current as App;
                    int red = (int)(a.Color.R * 255);
                    int green = (int)(a.Color.G * 255);
                    int blue = (int)(a.Color.B * 255);
                    string hex = String.Format("#{0:X2}{1:X2}{2:X2}", red, green, blue);
                    app.DefColor = hex;
                   ((NavigationPage)Application.Current.MainPage).BarBackgroundColor = Color.FromHex(app.DefColor);
                    Application.Current.SavePropertiesAsync();
                    Navigation.PopAsync();

                };

                temp.GestureRecognizers.Add(tapGestureRecognizer);
                grd.Children.Add(temp,count,counth);
                if (count < 2)
                    count++;
                else
                {
                    count = 0;
                    counth++;
                }
            }
            grd.RowDefinitions.Add(new RowDefinition
            {
                Height =new GridLength(100, GridUnitType.Absolute)
            });
            grd.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            }); grd.RowDefinitions.Add(new RowDefinition
            {
                Height = new GridLength(100, GridUnitType.Absolute)
            });
            layout.Children.Add(new Label { Text = "Select your Theme", FontSize=20 });
            layout.Children.Add(grd);
            Content = layout;
        }


    }
}