using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace App3.Models
{
    class Constants
    {
        public static bool IsDev = true;

        public static Color BackgroundColor = Color.White;
        public static Color PlaceholderColor = Color.FromHex("#bababa");
        public static Color ButtonColor = Color.FromHex("#3897F0");


        public static int LoginIconHeight = 120;

        public static List<User> _users = new List<User>()
           {
               new User ("User1", "pass1"),
               new User ("User2", "pass2")

           };
    }
}
