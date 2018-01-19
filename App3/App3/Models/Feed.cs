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
        public string ProfileImage { get; set; }


        public Feed() { }
        public Feed(int id, User usr, string title, List<Comment> comments, string imag = "profile.png")
        {
            this.Id = id;
            this.Currentusr = usr;
            this.Title = title;
            this.Comments = comments;
            this.ProfileImage = imag;
        }

        public Feed AddComment(Feed feed, Comment comment)
        {
            feed.Comments.Add(comment);
            return feed;
        }

    }
}
