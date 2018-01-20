using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class User
    {
        private int Id { get; set; }
        public string Username { get; set; }
        private string Password { get; set; }
        public string ProfileImage { get; set; }

        public User() { }
        public User(string Username, string Password, string imag = "profile.png")
        {
            this.Username = Username;
            this.Password = Password;
            this.ProfileImage = imag;
        }


        public bool CheckInformation(List<User> Userlist)
        {
            if (Userlist.Count!=0)
            {
                
                    foreach (User item in Userlist)
                    {
                        if (this.Username.Equals(item.Username) && this.Password.Equals(item.Password))
                            return true;
                    }
             
            }

            return false;

        }

        public bool CheckUsername(List<User> Userlist)
        {
            if (Userlist.Count != 0)
            {

                foreach (User item in Userlist)
                {
                    if (this.Username.Equals(item.Username))
                        return true;
                }

            }

            return false;

        }

     
    }
}
