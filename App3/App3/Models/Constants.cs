using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;
using App3.ViewModel;

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

        public static Ticket ticketer1 = new Ticket(1, new User("User1", "pass1"), "asdasd", "Pending", _msg );
        public static Ticket ticketer2 = new Ticket(2, new User("User1", "pass1"), "asdasd", "Pending", _msg);
        public static Ticket ticketer3 = new Ticket(3, new User("User1", "pass1"), "asdasd", "Pending", _msg);
        public static Ticket ticketer4 = new Ticket(4, new User("User2", "pass2"), "asdasd", "Pending", _msg);
        public static Ticket ticketer5 = new Ticket(5, new User("User1", "pass1"), "asdasd", "Pending", _msg);
        public static Ticket ticketer6 = new Ticket(6, new User("User1", "pass1"), "asdasd", "Pending", _msg);
        public static Ticket ticketer7 = new Ticket(7, new User("User2", "pass2"), "asdasd", "Pending", _msg);


        public static List<Ticket> _ticket = new List<Ticket>()
        {
            ticketer1,
            ticketer2,
            ticketer3,
            ticketer4,
            ticketer5,
            ticketer6,
            ticketer7
        };

        public static List<String> _colors = new List<String>()
        {
            "#f44336",
            "#e91e63",
            "#9c27b0",
            "#2196f3",
            "#009688",
            "#4caf50",
            "#f57f17",
            "#f57c00",
            "#757575",

        };

        public static Page CurrentPage;

        public static int LoginIconHeight = 120;

        public static List<User> _users = new List<User>()
           {
               new User ("User1", "pass1"),
               new User ("User2", "pass2")

           };

       
    }
}
