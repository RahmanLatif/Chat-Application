namespace Chatting
{
    partial class MainPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.Chatss = new System.Windows.Forms.TabPage();
            this.txtSearchChat = new System.Windows.Forms.TextBox();
            this.flpChats = new System.Windows.Forms.FlowLayoutPanel();
            this.NewChats = new System.Windows.Forms.TabPage();
            this.btnCreateChat = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.flbAddChatMembers = new System.Windows.Forms.FlowLayoutPanel();
            this.txtChatName = new System.Windows.Forms.TextBox();
            this.btnMyProfile = new System.Windows.Forms.Button();
            this.lblProfileName = new System.Windows.Forms.Label();
            this.btnLogout = new System.Windows.Forms.Button();
            this.tabFriends = new System.Windows.Forms.TabControl();
            this.Friends = new System.Windows.Forms.TabPage();
            this.flbFriends = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchFriends = new System.Windows.Forms.TextBox();
            this.Others = new System.Windows.Forms.TabPage();
            this.flbClients = new System.Windows.Forms.FlowLayoutPanel();
            this.txtSearchClients = new System.Windows.Forms.TextBox();
            this.FriendRequest = new System.Windows.Forms.TabPage();
            this.flbRequests = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.Chatss.SuspendLayout();
            this.NewChats.SuspendLayout();
            this.tabFriends.SuspendLayout();
            this.Friends.SuspendLayout();
            this.Others.SuspendLayout();
            this.FriendRequest.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Controls.Add(this.tabControl1);
            this.panel1.Controls.Add(this.btnMyProfile);
            this.panel1.Controls.Add(this.lblProfileName);
            this.panel1.Controls.Add(this.btnLogout);
            this.panel1.Location = new System.Drawing.Point(5, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(250, 537);
            this.panel1.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.Chatss);
            this.tabControl1.Controls.Add(this.NewChats);
            this.tabControl1.Location = new System.Drawing.Point(5, 60);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(240, 470);
            this.tabControl1.TabIndex = 8;
            // 
            // Chatss
            // 
            this.Chatss.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Chatss.Controls.Add(this.txtSearchChat);
            this.Chatss.Controls.Add(this.flpChats);
            this.Chatss.Location = new System.Drawing.Point(4, 22);
            this.Chatss.Name = "Chatss";
            this.Chatss.Padding = new System.Windows.Forms.Padding(3);
            this.Chatss.Size = new System.Drawing.Size(232, 444);
            this.Chatss.TabIndex = 2;
            this.Chatss.Text = "Chats";
            // 
            // txtSearchChat
            // 
            this.txtSearchChat.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchChat.Location = new System.Drawing.Point(6, 4);
            this.txtSearchChat.Name = "txtSearchChat";
            this.txtSearchChat.Size = new System.Drawing.Size(222, 30);
            this.txtSearchChat.TabIndex = 4;
            this.txtSearchChat.TextChanged += new System.EventHandler(this.txtSearchChat_TextChanged);
            // 
            // flpChats
            // 
            this.flpChats.AutoScroll = true;
            this.flpChats.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flpChats.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpChats.Location = new System.Drawing.Point(5, 39);
            this.flpChats.Name = "flpChats";
            this.flpChats.Size = new System.Drawing.Size(223, 400);
            this.flpChats.TabIndex = 0;
            this.flpChats.WrapContents = false;
            // 
            // NewChats
            // 
            this.NewChats.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.NewChats.Controls.Add(this.btnCreateChat);
            this.NewChats.Controls.Add(this.label6);
            this.NewChats.Controls.Add(this.flbAddChatMembers);
            this.NewChats.Controls.Add(this.txtChatName);
            this.NewChats.Location = new System.Drawing.Point(4, 22);
            this.NewChats.Name = "NewChats";
            this.NewChats.Padding = new System.Windows.Forms.Padding(3);
            this.NewChats.Size = new System.Drawing.Size(232, 444);
            this.NewChats.TabIndex = 1;
            this.NewChats.Text = "New Chat";
            // 
            // btnCreateChat
            // 
            this.btnCreateChat.BackColor = System.Drawing.Color.Transparent;
            this.btnCreateChat.BackgroundImage = global::Chatting.Properties.Resources.btnBackground;
            this.btnCreateChat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCreateChat.FlatAppearance.BorderSize = 0;
            this.btnCreateChat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateChat.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateChat.Location = new System.Drawing.Point(52, 403);
            this.btnCreateChat.Name = "btnCreateChat";
            this.btnCreateChat.Size = new System.Drawing.Size(130, 35);
            this.btnCreateChat.TabIndex = 7;
            this.btnCreateChat.Text = "Create Chat";
            this.btnCreateChat.UseVisualStyleBackColor = false;
            this.btnCreateChat.Click += new System.EventHandler(this.btnCreateChat_Click);
            // 
            // label6
            // 
            this.label6.AutoEllipsis = true;
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Playbill", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(6, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(72, 24);
            this.label6.TabIndex = 6;
            this.label6.Text = "Chat Name";
            // 
            // flbAddChatMembers
            // 
            this.flbAddChatMembers.AutoScroll = true;
            this.flbAddChatMembers.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flbAddChatMembers.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flbAddChatMembers.Location = new System.Drawing.Point(5, 40);
            this.flbAddChatMembers.Name = "flbAddChatMembers";
            this.flbAddChatMembers.Size = new System.Drawing.Size(221, 357);
            this.flbAddChatMembers.TabIndex = 4;
            this.flbAddChatMembers.WrapContents = false;
            // 
            // txtChatName
            // 
            this.txtChatName.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChatName.Location = new System.Drawing.Point(83, 4);
            this.txtChatName.Name = "txtChatName";
            this.txtChatName.Size = new System.Drawing.Size(143, 30);
            this.txtChatName.TabIndex = 3;
            // 
            // btnMyProfile
            // 
            this.btnMyProfile.BackColor = System.Drawing.Color.Transparent;
            this.btnMyProfile.BackgroundImage = global::Chatting.Properties.Resources.Profile;
            this.btnMyProfile.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMyProfile.FlatAppearance.BorderSize = 0;
            this.btnMyProfile.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyProfile.Location = new System.Drawing.Point(186, 22);
            this.btnMyProfile.Name = "btnMyProfile";
            this.btnMyProfile.Size = new System.Drawing.Size(26, 27);
            this.btnMyProfile.TabIndex = 6;
            this.btnMyProfile.Text = " ";
            this.btnMyProfile.UseVisualStyleBackColor = false;
            this.btnMyProfile.Click += new System.EventHandler(this.btnMyProfile_Click);
            // 
            // lblProfileName
            // 
            this.lblProfileName.AutoEllipsis = true;
            this.lblProfileName.AutoSize = true;
            this.lblProfileName.BackColor = System.Drawing.Color.Transparent;
            this.lblProfileName.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfileName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblProfileName.Location = new System.Drawing.Point(7, 12);
            this.lblProfileName.Name = "lblProfileName";
            this.lblProfileName.Size = new System.Drawing.Size(137, 44);
            this.lblProfileName.TabIndex = 5;
            this.lblProfileName.Text = "lblProfileName";
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.Transparent;
            this.btnLogout.BackgroundImage = global::Chatting.Properties.Resources.logout;
            this.btnLogout.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Location = new System.Drawing.Point(219, 22);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(26, 26);
            this.btnLogout.TabIndex = 4;
            this.btnLogout.Text = " ";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // tabFriends
            // 
            this.tabFriends.Controls.Add(this.Friends);
            this.tabFriends.Controls.Add(this.Others);
            this.tabFriends.Controls.Add(this.FriendRequest);
            this.tabFriends.Location = new System.Drawing.Point(718, 12);
            this.tabFriends.Name = "tabFriends";
            this.tabFriends.SelectedIndex = 0;
            this.tabFriends.Size = new System.Drawing.Size(228, 534);
            this.tabFriends.TabIndex = 5;
            // 
            // Friends
            // 
            this.Friends.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Friends.Controls.Add(this.flbFriends);
            this.Friends.Controls.Add(this.txtSearchFriends);
            this.Friends.Location = new System.Drawing.Point(4, 22);
            this.Friends.Name = "Friends";
            this.Friends.Padding = new System.Windows.Forms.Padding(3);
            this.Friends.Size = new System.Drawing.Size(220, 508);
            this.Friends.TabIndex = 0;
            this.Friends.Text = "Friends";
            // 
            // flbFriends
            // 
            this.flbFriends.AutoScroll = true;
            this.flbFriends.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flbFriends.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flbFriends.Location = new System.Drawing.Point(6, 46);
            this.flbFriends.Name = "flbFriends";
            this.flbFriends.Size = new System.Drawing.Size(209, 456);
            this.flbFriends.TabIndex = 3;
            this.flbFriends.WrapContents = false;
            // 
            // txtSearchFriends
            // 
            this.txtSearchFriends.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFriends.Location = new System.Drawing.Point(5, 10);
            this.txtSearchFriends.Name = "txtSearchFriends";
            this.txtSearchFriends.Size = new System.Drawing.Size(211, 30);
            this.txtSearchFriends.TabIndex = 2;
            this.txtSearchFriends.TextChanged += new System.EventHandler(this.txtSearchFriends_TextChanged);
            // 
            // Others
            // 
            this.Others.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Others.Controls.Add(this.flbClients);
            this.Others.Controls.Add(this.txtSearchClients);
            this.Others.Location = new System.Drawing.Point(4, 22);
            this.Others.Name = "Others";
            this.Others.Padding = new System.Windows.Forms.Padding(3);
            this.Others.Size = new System.Drawing.Size(220, 508);
            this.Others.TabIndex = 1;
            this.Others.Text = "Others";
            // 
            // flbClients
            // 
            this.flbClients.AutoScroll = true;
            this.flbClients.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flbClients.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flbClients.Location = new System.Drawing.Point(5, 47);
            this.flbClients.Name = "flbClients";
            this.flbClients.Size = new System.Drawing.Size(209, 456);
            this.flbClients.TabIndex = 4;
            this.flbClients.WrapContents = false;
            // 
            // txtSearchClients
            // 
            this.txtSearchClients.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchClients.Location = new System.Drawing.Point(3, 10);
            this.txtSearchClients.Name = "txtSearchClients";
            this.txtSearchClients.Size = new System.Drawing.Size(214, 30);
            this.txtSearchClients.TabIndex = 3;
            this.txtSearchClients.TextChanged += new System.EventHandler(this.txtSearchClients_TextChanged);
            // 
            // FriendRequest
            // 
            this.FriendRequest.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.FriendRequest.Controls.Add(this.flbRequests);
            this.FriendRequest.Location = new System.Drawing.Point(4, 22);
            this.FriendRequest.Name = "FriendRequest";
            this.FriendRequest.Padding = new System.Windows.Forms.Padding(3);
            this.FriendRequest.Size = new System.Drawing.Size(220, 508);
            this.FriendRequest.TabIndex = 2;
            this.FriendRequest.Text = "Friend Request";
            // 
            // flbRequests
            // 
            this.flbRequests.AutoScroll = true;
            this.flbRequests.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flbRequests.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flbRequests.Location = new System.Drawing.Point(6, 6);
            this.flbRequests.Name = "flbRequests";
            this.flbRequests.Size = new System.Drawing.Size(209, 496);
            this.flbRequests.TabIndex = 5;
            this.flbRequests.WrapContents = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(261, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(449, 537);
            this.panel2.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Bauhaus 93", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.SaddleBrown;
            this.label5.Location = new System.Drawing.Point(34, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(391, 54);
            this.label5.TabIndex = 4;
            this.label5.Text = "Chat Application";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.label4.Font = new System.Drawing.Font("Magneto", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Orchid;
            this.label4.Location = new System.Drawing.Point(334, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(107, 97);
            this.label4.TabIndex = 3;
            this.label4.Text = "K";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Thistle;
            this.label3.Font = new System.Drawing.Font("Magneto", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Yellow;
            this.label3.Location = new System.Drawing.Point(230, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(92, 97);
            this.label3.TabIndex = 2;
            this.label3.Text = "a";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.MediumAquamarine;
            this.label2.Font = new System.Drawing.Font("Magneto", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.RoyalBlue;
            this.label2.Location = new System.Drawing.Point(127, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 97);
            this.label2.TabIndex = 1;
            this.label2.Text = "a";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.NavajoWhite;
            this.label1.Font = new System.Drawing.Font("Magneto", 60F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Crimson;
            this.label1.Location = new System.Drawing.Point(11, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 97);
            this.label1.TabIndex = 0;
            this.label1.Text = "B";
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(954, 561);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.tabFriends);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainPage_FormClosing);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.Chatss.ResumeLayout(false);
            this.Chatss.PerformLayout();
            this.NewChats.ResumeLayout(false);
            this.NewChats.PerformLayout();
            this.tabFriends.ResumeLayout(false);
            this.Friends.ResumeLayout(false);
            this.Friends.PerformLayout();
            this.Others.ResumeLayout(false);
            this.Others.PerformLayout();
            this.FriendRequest.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.FlowLayoutPanel flpChats;
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.Label lblProfileName;
        private System.Windows.Forms.TabControl tabFriends;
        private System.Windows.Forms.TabPage Friends;
        private System.Windows.Forms.FlowLayoutPanel flbFriends;
        private System.Windows.Forms.TextBox txtSearchFriends;
        private System.Windows.Forms.TabPage Others;
        private System.Windows.Forms.TextBox txtSearchClients;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flbClients;
        private System.Windows.Forms.TabPage FriendRequest;
        private System.Windows.Forms.FlowLayoutPanel flbRequests;
        private System.Windows.Forms.Button btnMyProfile;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage Chatss;
        private System.Windows.Forms.TextBox txtSearchChat;
        private System.Windows.Forms.TabPage NewChats;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.FlowLayoutPanel flbAddChatMembers;
        private System.Windows.Forms.TextBox txtChatName;
        private System.Windows.Forms.Button btnCreateChat;
    }
}