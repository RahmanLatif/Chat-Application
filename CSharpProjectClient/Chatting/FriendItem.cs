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
    public partial class FriendItem : UserControl
    {
        private bool status;
        private string friendName;
        public delegate void OnFriendClick(object sender, EventArgs e);
        private OnFriendClick getClicked;
        public FriendItem(string FriendName, string Status)
        {
            InitializeComponent();
            this.FriendName = FriendName;
            if (Status == "Online")
            {
                this.Status = true;
            }
            else
            {
                this.Status = false;
            }
        }
        public event OnFriendClick GetClicked
        {
            add { getClicked += value; }
            remove { getClicked -= value; }
        }
        public string FriendName
        {
            get { return friendName; }
            set { friendName = value; lblFriendName.Text = value; }
        }
        public bool Status
        {
            get { return status; }
            set { status = value; lblStatus.BackColor = (value ? Color.Green : Color.Black); }
        }
        private void FriendItem_Click(object sender, EventArgs e)
        {
            if (getClicked != null)
            {
                getClicked.Invoke(this, e);
            }
        }
    }
}
