using System;
using System.Collections.Generic;
using System.Text;

namespace App3.Models
{
    class Chat
    {
        public Feed feed { get; set; }
        public string message { get; set; }
        public string sender { get; set; }
        public string chat_type { get; set; }
    }
}
