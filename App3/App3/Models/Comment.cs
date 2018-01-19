using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Comment
    {
        public int Id { get; set; }
        public User Currentusr { get; set; }
        public string Text { get; set; }
        public Feed Parent { get; set; }

        public Comment() { }
        public Comment( User user,string text)
        {
            this.Text = text;
            this.Currentusr = user;
        }
    }
}
