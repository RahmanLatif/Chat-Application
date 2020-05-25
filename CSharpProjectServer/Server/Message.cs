using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Message
    {
        public Client Sender;
        public DateTime Time;
        public string message;
        public Message(Client Sender,string message)
        {
            this.Sender = Sender;
            Time = DateTime.Now;
            this.message = message;
        }
    }
}
