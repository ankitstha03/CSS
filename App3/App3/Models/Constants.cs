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

        public static List<Comment> _comments = new List<Comment>()
        {
               new Comment (new User("User2", "pass2"),"Green?"),
               new Comment (new User("User1", "pass1"),"Yellow."),

           };

        public static Feed feed1 = new Feed(1, new User("User1", "pass1"), "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Etiam id erat nunc. Vestibulum feugiat lacus nec libero dignissim convallis. Donec nisl eros, faucibus ac sapien at, tristique consectetur lectus. Quisque porta consequat condimentum. Fusce scelerisque, velit nec dictum faucibus, erat enim fringilla augue, id condimentum massa magna eu nibh. Suspendisse malesuada sapien ac molestie imperdiet. Fusce scelerisque, arcu et commodo luctus, risus massa vehicula est, a elementum ante sapien et purus. Aenean enim odio, lacinia at eros sit amet, aliquet luctus eros. Proin vitae lacus sit amet lacus porttitor venenatis. Nunc at diam bibendum, dictum urna molestie, aliquam mauris. Vestibulum dignissim malesuada lorem eget fringilla. Donec blandit nisl non orci malesuada scelerisque. Ut enim turpis, mattis eu auctor a, venenatis eu enim.  ", _comments);
        public static Feed feed2 = new Feed(2, new User("User1", "pass1"), "does it?", _comments);

        public static List<Ticket> _ticket = new List<Ticket>()
        {
           ticketer1,
            ticketer2,
            ticketer3,
            ticketer4,
            ticketer5,
            ticketer6,
            ticketer7,


        };

        public static List<Feed> _feed = new List<Feed>()
        {
            feed1,
            feed2,
        };


        public static int LoginIconHeight = 120;

        public static List<User> _users = new List<User>()
           {
               new User ("User1", "pass1"),
               new User ("User2", "pass2")

           };
    }
}
