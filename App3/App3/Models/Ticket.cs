using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Ticket
    {
        public int Id { get; set; }
        public User Currentusr { get; set; }
        public string Title { get; set; }
        public string Category { get; set; }
        public string Status { get; set; }
        public List<Message> Msg { get; set; }
        public Employee Emp { get; set; }


        public Ticket() { }
        public Ticket(int id,User usr, string title,string category, List<Message> msg, string status = "Unassigned")

        {
            this.Id = id;
            this.Currentusr = usr;
            this.Title = title;

            this.Category = category;
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
