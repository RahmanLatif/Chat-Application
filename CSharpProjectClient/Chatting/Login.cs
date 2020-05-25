using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatting
{
    public partial class Login : Form
    {
        TcpClient tcpClient;
        StreamWriter streamWriter;
        public Login()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            StartPage startPage = new StartPage();
            startPage.Show();
            this.Hide();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            tcpClient = new TcpClient();
            tcpClient.Connect("192.168.1.11", 5000);
            NetworkStream networkStream = tcpClient.GetStream();
            streamWriter = new StreamWriter(networkStream);
            StreamReader streamReader = new StreamReader(networkStream);
            streamWriter.AutoFlush = true;
            await streamWriter.WriteLineAsync("Login&" + txtUsername.Text + "&" + txtPassword.Text);
            string confirm = await streamReader.ReadLineAsync();
            if (confirm == "True")
            {
                MainPage mainPage = new MainPage(tcpClient);
                mainPage.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show(confirm);
            }
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
