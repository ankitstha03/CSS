using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Ticket
    {
        public Customer customer { get; set; }
        public string subject { get; set; }
        public Project project { get; set; }
        public string attachment { get; set; }
        public string message { get; set; }
        public string status { get; set; }
        public string estimated_time { get; set; }
        public string resolved_on { get; set; }
        public Staff escalate_to { get; set; }
        public Staff escalate_by { get; set; }


        //public Ticket() { }
        //public Ticket(int id,User usr, string title,string category, List<Message> msg, string status = "Unassigned")

        //{
        //    this.Id = id;
        //    this.Currentusr = usr;
        //    this.Title = title;

        //    this.Category = category;
        //    this.Status = status;
        //    this.Msg = msg;
            

        //}

        //public Ticket Addmessage(Ticket ticket, Message msg)
        //{
        //    ticket.Msg.Add(msg);
        //    return ticket;
        //}

    }
}
