using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Message
    {
        private int Id { get; set; }
        public string Textmess { get; set; }
        public bool Sender { get; set; }

        public Message() { }
        public Message(string textmess, bool sender)
        {
            this.Textmess = textmess;
            this.Sender = sender;
        }
    }
}
