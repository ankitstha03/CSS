using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Ticket
    {
        private int Id { get; set; }
        private User Currentusr { get; set; }
        public string Title { get; set; }
        public string Status { get; set; }
        public List<Message> Msg { get; set; }
        private Employee Emp { get; set; }

        public Ticket() { }
        public Ticket(User usr, string title, string status, List<Message> msg)
        {
            this.Currentusr = usr;
            this.Title = title;
            this.Status = status;
            this.Msg = msg;
        }

        public Ticket Addmessage(Ticket ticket, Message msg)
        {
            ticket.Msg.Add(msg);
            return ticket;
        }

    }
}
