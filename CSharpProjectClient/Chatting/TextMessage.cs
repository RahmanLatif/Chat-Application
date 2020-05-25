using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chatting
{
    public partial class TextMessage : UserControl
    {
        public TextMessage(string Username, string Message, string Date)
        {
            InitializeComponent();
            lblUsername.Text = Username;
            lblMessage.Text = Message;
            lblDate.Text = Date;
        }
        public string Username
        {
            get { return lblUsername.Text; }
            set { lblUsername.Text = value; }
        }
        public string Message
        {
            get { return lblMessage.Text; }
            set { lblMessage.Text = value; }
        }
        public string Date
        {
            get { return lblDate.Text; }
            set { lblDate.Text = value; }
        }

        private void TextMessage_Load(object sender, EventArgs e)
        {
            int cnt = 0;
            string[] lines = Message.Split(new string[] { Environment.NewLine }, StringSplitOptions.None);
            foreach(string str in lines)
            {
                cnt += str.Length;
                cnt += 18;
            }
            cnt -= 18;
            int x = cnt / 30;
            if (cnt % 30 != 0)
            {
                x++;
            }
            lblMessage.Height = x * 18;
            this.Height = lblMessage.Height + 30;
        }
    }
}
