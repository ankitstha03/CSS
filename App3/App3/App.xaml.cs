﻿using System;
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

        public App ()
		{
			InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}

        public Color DefColor
        {
            get
            {
                if (Properties.ContainsKey(color))
                    return (Color)Properties[color];


                return Color.FromHex("#6677dd");
            }

            set
            {
                Properties[color] = value;
            }
        }
    }
}
