using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App3.Models;
using App3.Views;

using Xamarin.Forms;

namespace App3
{

	public partial class App : Application
	{
        private const string color = "Colorer";
        private const string session = "Session";


        public App ()
		{
			InitializeComponent();
            if (Nsession == "0")
                MainPage = new MainCarouselPage();
            else
                MainPage = new NavigationPage(new MainPage());
        }

        protected override void OnStart()
        {
            // Handle when your app starts
        }

        protected override void OnSleep()
        {
            // Handle when your app sleeps
        }


		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public string DefColor
        {
            get
            {
                if (Properties.ContainsKey(color))
                    return Properties[color].ToString();

                else
                    return "#6677dd";
            }

            set
            {
                Properties[color] = value;
            }

        }

        public string Nsession
        {
            get
            {
                if (Properties.ContainsKey(session))
                    return Properties[session].ToString();

                else
                    return "0";
            }

            set
            {
                Properties[session] = value;
            }

        }
    }
}
