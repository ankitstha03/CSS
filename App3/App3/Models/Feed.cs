using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Feed
    {
        public string title { get; set; }
        public Ticket ticket { get; set; }
        public string created_by { get; set; }
        public string access { get; set; }
        public int id { get; set; }


        //public Feed() { }
        //public Feed(int id, User usr, string title, List<Comment> comment)
        //{
        //    this.Id = id;
        //    this.Currentusr = usr;
        //    this.Title = title;
        //    this.Comments = comment;
        //}

        //public Feed AddComment(Feed feed, Comment comment)
        //{
        //    feed.Comments.Add(comment);
        //    return feed;
        //}

    }
}
