using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    class Program
    {
        public static List<Client> Clients;
        public static int ChatsID;
        static async void Start()
        {
            IPAddress iP = IPAddress.Parse("192.168.1.5");
            TcpListener tcpListener = new TcpListener(iP, 5000);
            tcpListener.Start();

            while (true)
            {
                TcpClient tcpClient = await tcpListener.AcceptTcpClientAsync();
                NetworkStream networkStream = tcpClient.GetStream();
                StreamReader streamReader = new StreamReader(networkStream);
                StreamWriter streamWriter = new StreamWriter(networkStream);
                streamWriter.AutoFlush = true;
                string query = await streamReader.ReadLineAsync();
                string[] Queries = query.Split('&');
                if (Queries[0] == "Login")
                {
                    string username = Queries[1];
                    string password = Queries[2];
                    Client logged = null;
                    foreach (Client client in Clients)
                    {
                        if (client.Username == username && client.Password == password)
                        {
                            logged = client;
                            break;
                        }
                    }
                    if (logged == null)
                    {
                        await streamWriter.WriteLineAsync("Wrong Username or Password !!");
                    }
                    else
                    {
                        logged.GoOnline(tcpClient);
                        await streamWriter.WriteLineAsync("True");
                    }
                }
                else if (Queries[0] == "Register")
                {
                    string username = Queries[1];
                    string password = Queries[2];
                    string birthdate = Queries[3];
                    string gender = Queries[4];
                    bool ok = true;
                    foreach (Client client in Clients)
                    {
                        if (client.Username == username)
                        {
                            ok = false;
                            break;
                        }
                    }
                    if (ok)
                    {
                        foreach (Client client1 in Clients)
                        {
                            client1.SendNotification("Client Registered" + "&" + username);
                        }
                        await streamWriter.WriteLineAsync("True");
                        Console.WriteLine(username + " " + birthdate + " " + gender);
                        Client client = new Client(tcpClient, username, password, gender, birthdate);
                        Clients.Add(client);
                    }
                    else
                    {
                        await streamWriter.WriteLineAsync("Username is used !!");
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            ChatsID = 1;
            Clients = new List<Client>();
            Start();
            Console.Read();
        }
    }
}
