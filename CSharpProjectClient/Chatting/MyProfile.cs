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
    public partial class MyProfile : UserControl
    {
        public delegate void OnClose(object sender, EventArgs e);
        private OnClose getClosed;
        public delegate void OnSave(object sender, EventArgs e);
        private OnSave getSaved;
        public MyProfile()
        {
            InitializeComponent();
        }
        public event OnClose GetClosed
        {
            add { getClosed += value; }
            remove { getClosed -= value; }
        }
        public event OnSave GetSaved
        {
            add { getSaved += value; }
            remove { getSaved -= value; }
        }
        public string Username
        {
            get { return txtUsername.Text; }
            set { txtUsername.Text = value; }
        }
        public string Password
        {
            get { return txtPassword.Text; }
            set { txtPassword.Text = value; }
        }
        public string ConfirmPassword
        {
            get { return txtConfirmPassword.Text; }
            set { txtConfirmPassword.Text = value; }
        }
        public string Gender
        {
            get { return comGender.Text; }
            set
            {
                if (value == "Male")
                {
                    comGender.SelectedIndex = 0;
                }
                else
                {
                    comGender.SelectedIndex = 1;
                }
            }
        }
        public DateTime Birthdate
        {
            get { return dateTimePicker1.Value; }
            set
            {
                dateTimePicker1.Value = value;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (getSaved != null)
            {
                getSaved.Invoke(this, e);
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
