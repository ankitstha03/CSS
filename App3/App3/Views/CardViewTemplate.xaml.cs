﻿using App3.Models;
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
	public partial class CardViewTemplate : ContentView
	{
		public CardViewTemplate ()
		{
			InitializeComponent ();

            imags.SetBinding(Image.SourceProperty, "customer.profile_picture");
            assigned.SetBinding(Label.TextProperty, "escalate_to.username");
		}

        }

}