using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    public class User
    {
        private int Id { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }

        public User() { }
        public User(string Username, string Password)
        {
            this.Username = Username;
            this.Password = Password;
        }


        public bool CheckInformation(List<User> Userlist)
        {
            if (Userlist.Count!=0)
            {
                if (!this.Username.Equals("") && !this.Password.Equals(""))
                {


                    foreach (User item in Userlist)
                    {
                        if (this.Username.Equals(item.Username) && this.Password.Equals(item.Password))
                            return true;
                    }
                }
                else
                    return false;
            }

            return false;

        }
    }
}
