using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class User
    {
        public string username { get; set; }
        public string email { get; set; }
        private string password { get; set; }

        public User() { }

        public User(string username, string email, string password)
        {
            this.email = email;
            this.username = username;
            this.password = password;
        }


        //public bool CheckInformation(List<User> Userlist)
        //{
        //    if (Userlist.Count!=0)
        //    {
                
        //            foreach (User item in Userlist)
        //            {
        //                if (this.Username.Equals(item.Username) && this.Password.Equals(item.Password))
        //                    return true;
        //            }
             
        //    }

        //    return false;

        //}

        public bool CheckUsername(List<User> Userlist)
        {
            if (Userlist.Count != 0)
            {

                foreach (User item in Userlist)
                {
                    if (this.username.Equals(item.username))
                        return true;
                }

            }

            return false;

        }

     
    }
}
