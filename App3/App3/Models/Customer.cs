using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Customer
    {
        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public string email { get; set; }
        public string company_name { get; set; }
        public string phone_number { get; set; }
        public string address { get; set; }
        public List<Project> projects { get; set; }
        public bool status { get; set; }
        public string profile_picture { get; set; }

        public Customer() { }


        //public bool CheckInformation(List<User> Userlist)
        //{
        //    if (Userlist.Count != 0)
        //    {

        //        foreach (User item in Userlist)
        //        {
        //            if (this.Username.Equals(item.Username) && this.Password.Equals(item.Password))
        //                return true;
        //        }

        //    }

        //    return false;

        //}

        //public bool CheckUsername(List<User> Userlist)
        //{
        //    if (Userlist.Count != 0)
        //    {

        //        foreach (User item in Userlist)
        //        {
        //            if (this.Username.Equals(item.Username))
        //                return true;
        //        }

        //    }

        //    return false;

        //}
    }
}
