using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Employee
    {
        private int Id { get; set; }
        private string Username { get; set; }
       
        public Employee() { }
        public Employee(string Username)
        {
            this.Username = Username;
        }
    }
}
