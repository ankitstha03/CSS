using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Feed
    {
        public int Id { get; set; }
        public User Currentusr { get; set; }
        public string Title { get; set; }
        public List<Comment> Comments { get; set; }


        public Feed() { }
        public Feed(int id, User usr, string title, List<Comment> comment)
        {
            this.Id = id;
            this.Currentusr = usr;
            this.Title = title;
            this.Comments = comment;
        }

        public Feed AddComment(Feed feed, Comment comment)
        {
            feed.Comments.Add(comment);
            return feed;
        }

    }
}
