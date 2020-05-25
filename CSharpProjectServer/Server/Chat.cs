using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Chat
    {
        public int Id;
        public List<Client> Clients;
        public DateTime dateStart;
        public DateTime dateLastMessage;
        public string Name;
        public bool Type;
        public List<Message> Messages;
        public Chat(List<Client> Clients, string Name, int Id, bool Type)
        {
            this.Id = Id;
            this.Clients = Clients;
            dateStart = DateTime.Now;
            this.Name = Name;
            this.Type = Type;
            Messages = new List<Message>();
        }
        public void SendMessage(Client cl, string message)
        {
            foreach (Client client in Clients)
            {
                client.AddMessage(Id, cl, message);
            }
        }
        public void AddMessage(Client client, string message)
        {

            Message message1 = new Message(client, message);
            this.Messages.Add(message1);
            this.dateLastMessage = DateTime.Now;
        }
        public string GetChat()
        {
            string Q = "GetChat&" + Id.ToString() + "&" + Name + "&" + Type.ToString();
            foreach (Message message in Messages)
            {
                Q += "&" + message.Sender.Username;
                Q += "&" + message.message;
                Q += "&" + message.Time;
            }
            return Q;
        }
    }
}
