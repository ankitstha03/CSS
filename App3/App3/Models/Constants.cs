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
        public static User user;
        public static List<Message> _msg = new List<Message>()
           {
               new Message ("User1 is asdasd asd and asd and asd asswd as addasndiad asda dadkasd asdiasd asdmiasdnasd asdasjdas das dasdasd", true),
               new Message ("asdasdasda User1 is asdasd asd", false),
               new Message ("ujyhygrfdcgh User1 is asdasd asd", true),
               new Message (",kmjnhgbhjmhbg User1 is asdasd asd", true),
               new Message ("jyhy ujhyg User1 is asdasd asd", false),
               new Message ("nbgtv User1 is asdasd asd", true),
               new Message ("nhbgvf User1 is asdasd asd", false),
               new Message ("User1 is asdasd asd", false),
               new Message ("nbgfv User1 is asdasd asd", true),
               new Message ("mjnbgvnnhbgvf jyhgtnhytgrf yhtgrfhtg User1 is asdasd asd", true),
               new Message (" hbgfvd User1 is asdasd asd", true),
               new Message ("yhtgrfed User1 is asdasd asd", true),
               new Message ("asdasdasda User1 is asdasd asd", false),
               new Message ("ujyhygrfdcgh User1 is asdasd asd", true),
               new Message (",kmjnhgbhjmhbg User1 is asdasd asd", true),
               new Message ("jyhy ujhyg User1 is asdasd asd", false),
               new Message ("nbgtv User1 is asdasd asd", true),
               new Message ("nhbgvf User1 is asdasd asd", false),
               new Message ("User1 is asdasd asd", false),
               new Message ("nbgfv User1 is asdasd asd", true),
               new Message ("mjnbgvnnhbgvf jyhgtnhytgrf yhtgrfhtg User1 is asdasd asd", true),
               new Message (" hbgfvd User1 is asdasd asd", true),
               new Message ("yhtgrfed User1 is asdasd asd", true),
               new Message ("asdasdasda User1 is asdasd asd", false),
               new Message ("ujyhygrfdcgh User1 is asdasd asd", true),
               new Message (",kmjnhgbhjmhbg User1 is asdasd asd", true),
               new Message ("jyhy ujhyg User1 is asdasd asd", false),
               new Message ("nbgtv User1 is asdasd asd", true),
               new Message ("nhbgvf User1 is asdasd asd", false),
               new Message ("User1 is asdasd asd", false),
               new Message ("nbgfv User1 is asdasd asd", true),
               new Message ("mjnbgvnnhbgvf jyhgtnhytgrf yhtgrfhtg User1 is asdasd asd", true),
               new Message (" hbgfvd User1 is asdasd asd", true),
               new Message ("yhtgrfed User1 is asdasd asd", true),

           };

        public static Ticket ticketer = new Ticket(new User("User1", "pass1"), "asdasd", "Pending", _msg);

        public static int LoginIconHeight = 120;

        public static List<User> _users = new List<User>()
           {
               new User ("User1", "pass1"),
               new User ("User2", "pass2")

           };
    }
}
