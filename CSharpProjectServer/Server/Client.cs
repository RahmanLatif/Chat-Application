using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Server
{
    class Client
    {
        public TcpClient tcpClient;
        public List<Client> Friends;
        List<string> FriendRequestsSended;
        List<string> FriendRequestsRecieved;
        public List<Chat> Chats;
        public string Username;
        public string Password;
        public string BirthDate;
        public string Gender;
        public string IpAdrress;
        public string PortNumber;
        public int ChatsCounter;
        public string Status;
        CancellationTokenSource cancellationTokenSource;
        public Client(TcpClient tcpClient, string username, string password, string gender, string birthDate)
        {
            Chats = new List<Chat>();
            Username = username;
            Password = password;
            BirthDate = birthDate;
            Gender = gender;
            ChatsCounter = 0;
            Status = "Online";
            FriendRequestsRecieved = new List<string>();
            FriendRequestsSended = new List<string>();
            Friends = new List<Client>();
            IpAdrress = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Address.ToString();
            PortNumber = ((IPEndPoint)tcpClient.Client.RemoteEndPoint).Port.ToString();
            this.tcpClient = tcpClient;
            cancellationTokenSource = new CancellationTokenSource();
            ReadNotifications();
        }

        public void SendMsg(int chatID, string msg)
        {
            foreach (Chat chat in Chats)
            {
                if (chatID == chat.Id)
                {
                    chat.SendMessage(this, msg);
                }
            }
        }
        public void AddMessage(int chatID, Client client, string msg)
        {
            foreach (Chat chat in Chats)
            {
                if (chatID == chat.Id)
                {
                    string Q = "Message Recieved&" + chat.Name + "&" + client.Username + "&" + chatID.ToString() + "&" + msg + "&" + DateTime.Now.ToLocalTime() + "&" + chat.Type.ToString();
                    SendNotification(Q);
                    chat.AddMessage(client, msg);
                }
            }
        }
        public void UpdateChatNames(int chatID, string newChatName)
        {
            foreach (Chat chat in Chats)
            {
                if (chat.Id == chatID)
                {
                    chat.Name = newChatName;
                }
            }
        }
        public async void SendNotification(string Notification)
        {
            if (Status == "Online")
            {
                try
                {
                    NetworkStream networkStream = tcpClient.GetStream();
                    StreamWriter streamWriter = new StreamWriter(networkStream);
                    streamWriter.AutoFlush = true;
                    await streamWriter.WriteLineAsync(Notification);
                }
                catch(Exception ex)
                {
                    cancellationTokenSource.Cancel();
                }
            }
        }
        public void GoOnline(TcpClient tcpClient)
        {
            cancellationTokenSource.Cancel();
            this.tcpClient = tcpClient;
            Status = "Online";
            foreach (Client client in Friends)
            {
                client.SendNotification("Friend Login" + "&" + Username);
            }
            cancellationTokenSource.Dispose();
            cancellationTokenSource = new CancellationTokenSource();
            ReadNotifications();
        }
        public void GoOffline()
        {
            Status = "Offline";
            foreach (Client client in Friends)
            {
                client.SendNotification("Friend Logout" + "&" + Username);
            }
        }
        async Task<string> QueryAwaiting(CancellationToken cancellationToken)
        {
            cancellationToken.ThrowIfCancellationRequested();
            NetworkStream networkStream = tcpClient.GetStream();
            StreamReader streamReader = new StreamReader(networkStream);
            string query = await streamReader.ReadLineAsync();
            return query;
        }
        private async void ReadNotifications()
        {
            while (true)
            {
                try
                {
                    string query = await QueryAwaiting(cancellationTokenSource.Token);
                    string[] Queries = query.Split('&');
                    RespondToNotifications(Queries);
                }
                catch(Exception ex)
                {
                    cancellationTokenSource.Cancel();
                }
            }
        }
        private void RespondToNotifications(string[] Queries)
        {
            if (Queries[0] == "GetMyInformation")
            {
                string Q = "GetMyInformation&" + Username + "&" + Password + "&" + BirthDate + "&" + Gender;
                SendNotification(Q);
            }
            if (Queries[0] == "UpdateMyInformation")
            {
                string OldUsername = Username;
                bool used = false;
                foreach (Client client in Program.Clients)
                {
                    if (client.Username == Queries[1])
                    {
                        used = true;
                        break;
                    }
                }
                if (used)
                {
                    SendNotification("NotUpdated");
                }
                else
                {
                    Username = Queries[1];
                    Password = Queries[2];
                    BirthDate = Queries[3];
                    Gender = Queries[4];
                    foreach (Chat chat in Chats)
                    {
                        if (chat.Type)
                        {
                            foreach (Client client in chat.Clients)
                            {
                                if (client.Username != Username)
                                {
                                    client.UpdateChatNames(chat.Id, Username);
                                }
                            }
                        }
                    }
                    SendNotification("ClientUpdated&Me&" + OldUsername + "&" + Username);
                    foreach (Client client2 in Friends)
                    {
                        client2.SendNotification("ClientUpdated&Friend&" + OldUsername + "&" + Username + "&" + BirthDate + "&" + Gender);
                    }
                    foreach (Client client1 in Program.Clients)
                    {
                        if (!Friends.Contains(client1))
                        {
                            client1.SendNotification("ClientUpdated&Client&" + OldUsername + "&" + Username);
                        }
                    }
                }
            }
            if (Queries[0] == "SendMessage")
            {
                int chatID;
                bool ok = int.TryParse(Queries[1], out chatID);
                if (ok)
                {
                    string msg = Queries[2];
                    SendMsg(chatID, msg);
                }
                else
                {
                    bool exist = false;
                    foreach (Chat chat in Chats)
                    {
                        if (chat.Clients.Count == 2)
                        {
                            if (chat.Type && (chat.Clients[0].Username == Queries[1] || chat.Clients[1].Username == Queries[1]))
                            {
                                SendMsg(chat.Id, Queries[2]);
                                exist = true;
                                break;
                            }
                        }
                    }
                    if (!exist)
                    {
                        Client client = null;
                        foreach (Client client1 in Program.Clients)
                        {
                            if (client1.Username == Queries[1])
                            {
                                client = client1;
                            }
                        }
                        Chat chat = new Chat(new List<Client> { this, client }, Queries[1], Program.ChatsID, true);
                        Chat chat1 = new Chat(new List<Client> { this, client }, Username, Program.ChatsID, true);
                        Chats.Add(chat);
                        client.Chats.Add(chat1);
                        SendMsg(Program.ChatsID, Queries[2]);
                        Program.ChatsID++;
                    }
                }
            }
            if (Queries[0] == "GetChat")
            {
                int chatId = int.Parse(Queries[1]);
                foreach (Chat chat in Chats)
                {
                    if (chat.Id == chatId)
                    {
                        SendNotification(chat.GetChat());
                        break;
                    }
                }
            }
            if (Queries[0] == "NewChat")
            {
                string ChatName = Queries[1];
                List<Client> ChatMembers = new List<Client>();
                for (int i = 2; i < Queries.Length; i++)
                {
                    foreach (Client client in Friends)
                    {
                        if (client.Username == Queries[i])
                        {
                            ChatMembers.Add(client);
                        }
                    }
                }
                ChatMembers.Add(this);
                foreach (Client client1 in ChatMembers)
                {
                    Chat chat = new Chat(ChatMembers, ChatName, Program.ChatsID, false);
                    client1.Chats.Add(chat);
                }
                SendMsg(Program.ChatsID, Username + " has added you to this chat");
                Program.ChatsID++;
            }
            if (Queries[0] == "GetProfile")
            {
                string Q = "Get Profile&";
                Q += Username + "&";
                foreach (Chat chat in Chats)
                {
                    Q += chat.Id.ToString() + "&";
                    Q += chat.Name + "&";
                    Q += chat.Type.ToString() + "&";
                    Q += chat.Messages[chat.Messages.Count - 1].Sender.Username + "&";
                    Q += chat.Messages[chat.Messages.Count - 1].message + "&";
                    Q += chat.dateLastMessage.ToLocalTime() + "&";
                }
                Q += "-1&";
                foreach (Client client in Friends)
                {
                    Q += client.Username + "&";
                    Q += client.Status + "&";
                }
                Q += "-1&";
                foreach (Client client in Program.Clients)
                {
                    if (client.Username != Username)
                    {
                        Q += client.Username + "&";
                        if (FriendRequestsSended.Contains(client.Username))
                        {
                            Q += "True&";
                        }
                        else
                        {
                            Q += "False&";
                        }
                    }
                }
                Q += "-1&";
                foreach (string request in FriendRequestsRecieved)
                {
                    Q += request + "&";
                }
                Q += "-1&";
                SendNotification(Q);
            }
            if (Queries[0] == "GetFriendProfile")
            {
                string Q = "GetFriendProfile&";
                string userName = Queries[1];
                Q += userName + "&";
                foreach (Client client in Friends)
                {
                    if (client.Username == userName)
                    {
                        Q += client.BirthDate + "&";
                        Q += client.Gender;
                        break;
                    }
                }
                SendNotification(Q);
            }
            if (Queries[0] == "Request Accepted")
            {
                string Q = "Request Accepted&";
                string userName = Queries[1];
                FriendRequestsRecieved.Remove(userName);
                foreach (Client client in Program.Clients)
                {
                    if (client.Username == userName)
                    {
                        Friends.Add(client);
                        client.Friends.Add(this);
                        Q += Username;
                        client.FriendRequestsSended.Remove(Username);
                        client.SendNotification(Q);
                    }
                }
            }
            if (Queries[0] == "Request Rejected")
            {
                string Q = "Request Rejected&";
                string userName = Queries[1];
                FriendRequestsRecieved.Remove(userName);
                foreach (Client client in Program.Clients)
                {
                    if (client.Username == userName)
                    {
                        client.FriendRequestsSended.Remove(Username);
                        Q += Username;
                        client.SendNotification(Q);
                    }
                }
            }
            if (Queries[0] == "Send Request")
            {
                string Q = "Friend Request&";
                string userName = Queries[1];
                FriendRequestsSended.Add(userName);
                foreach (Client client in Program.Clients)
                {
                    if (client.Username == userName)
                    {
                        client.FriendRequestsRecieved.Add(Username);
                        Q += Username;
                        client.SendNotification(Q);
                    }
                }
            }
            if (Queries[0] == "Cancel Request")
            {
                string Q = "Cancel Request&";
                string userName = Queries[1];
                FriendRequestsSended.Remove(userName);
                foreach (Client client in Program.Clients)
                {
                    if (client.Username == userName)
                    {
                        client.FriendRequestsRecieved.Remove(Username);
                        Q += Username;
                        client.SendNotification(Q);
                    }
                }
            }
            if (Queries[0] == "Status")
            {
                string userName = Queries[1];
                foreach (Client client in Program.Clients)
                {
                    if (client.Username == userName)
                    {
                        SendNotification("Status&" + userName + "&" + client.Status);
                        break;
                    }
                }
            }
            if (Queries[0] == "Logout")
            {
                GoOffline();
            }
        }
    }
}
