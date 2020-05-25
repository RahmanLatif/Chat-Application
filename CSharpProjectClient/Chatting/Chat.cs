using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Sockets;

namespace Chatting
{
    public partial class Chat : UserControl
    {
        private int chatID;
        private string chatName;
        private bool type;
        public delegate void OnClose(object sender, EventArgs e);
        private OnClose getClosed;
        public delegate void OnSending(object sender, EventArgs e);
        private OnSending getSended;
        public Chat(int ChatID, string ChatName, bool Type)
        {
            InitializeComponent();
            this.ChatID = ChatID;
            this.ChatName = ChatName;
            this.Type = Type;
        }
        public bool Type
        {
            get { return type; }
            set { type = value; }
        }
        public event OnClose GetClosed
        {
            add { getClosed += value; }
            remove { getClosed -= value; }
        }
        public event OnSending GetSended
        {
            add { getSended += value; }
            remove { getSended -= value; }
        }
        public int ChatID
        {
            get { return chatID; }
            set { chatID = value; }
        }
        public string ChatName
        {
            get { return chatName; }
            set { chatName = value; lblChatName.Text = value; }
        }
        public string Message
        {
            get 
            {
                string q = "";
                foreach(string str in textMessage.Lines)
                {
                    q += str + Environment.NewLine;
                }
                return q;
            }
        }
        private void btnSend_Click(object sender, EventArgs e)
        {
            if (Message.Length > 0)
            {
                if (getSended != null)
                {
                    getSended.Invoke(this, e);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if (getClosed != null)
            {
                getClosed.Invoke(this, e);
            }
        }
    }
}
