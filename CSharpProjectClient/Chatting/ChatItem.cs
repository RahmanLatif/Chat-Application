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
    public partial class ChatItem : UserControl
    {
        private string chatName;
        private bool unread;
        private string dateLastMessage;
        private int chatID;
        private string lastMessage;
        private bool type;
        public delegate void OnClicked(object sender, EventArgs e);
        private OnClicked getClicked;
        public ChatItem(int ChatID, string ChatName, string LastMessage, string DateLastMessage, bool Unread,bool Type)
        {
            InitializeComponent();
            this.ChatName = ChatName;
            this.DateLastMessage = DateLastMessage;
            this.ChatID = ChatID;
            this.LastMessage = LastMessage;
            this.Unread = Unread;
            this.Type = Type;
        }
        public bool Type
        {
            get { return type; }
            set { type = value; }
        }
        public bool Unread
        {
            get { return unread; }
            set { unread = value; lblUnread.BackColor = (value ? Color.Red : Color.Transparent); }
        }
        public string ChatName
        {
            get { return chatName; }
            set { chatName = value; lblChatName.Text = value; }
        }
        public string LastMessage
        {
            get { return lastMessage; }
            set { lastMessage = value; lblLastMessage.Text = value; }
        }
        public string DateLastMessage
        {
            get { return dateLastMessage; }
            set { dateLastMessage = value; lblDateLastMessage.Text = value; }
        }
        public int ChatID
        {
            get { return chatID; }
            set { chatID = value; }
        }
        public event OnClicked GetClicked
        {
            add { getClicked += value; }
            remove { getClicked -= value; }
        }
        private void ChatItem_Click(object sender, EventArgs e)
        {
            if (getClicked != null)
            {
                getClicked.Invoke(this, e);
            }
        }
    }
}
