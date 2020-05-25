namespace Chatting
{
    partial class Chat
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Chat));
            this.flbChat = new System.Windows.Forms.FlowLayoutPanel();
            this.textMessage = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblChatName = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flbChat
            // 
            this.flbChat.AutoScroll = true;
            this.flbChat.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flbChat.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.flbChat.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flbChat.Location = new System.Drawing.Point(6, 52);
            this.flbChat.Name = "flbChat";
            this.flbChat.Size = new System.Drawing.Size(437, 400);
            this.flbChat.TabIndex = 5;
            this.flbChat.WrapContents = false;
            // 
            // textMessage
            // 
            this.textMessage.Location = new System.Drawing.Point(85, 458);
            this.textMessage.Name = "textMessage";
            this.textMessage.Size = new System.Drawing.Size(358, 70);
            this.textMessage.TabIndex = 6;
            this.textMessage.Text = "";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.lblChatName);
            this.panel1.Location = new System.Drawing.Point(6, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(393, 40);
            this.panel1.TabIndex = 9;
            // 
            // lblChatName
            // 
            this.lblChatName.AutoSize = true;
            this.lblChatName.Font = new System.Drawing.Font("Wide Latin", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatName.Location = new System.Drawing.Point(5, 5);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(247, 26);
            this.lblChatName.TabIndex = 1;
            this.lblChatName.Text = "lblChatName";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Transparent;
            this.btnClose.BackgroundImage = global::Chatting.Properties.Resources.Close;
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(408, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(35, 41);
            this.btnClose.TabIndex = 8;
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSend
            // 
            this.btnSend.BackColor = System.Drawing.Color.Transparent;
            this.btnSend.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSend.BackgroundImage")));
            this.btnSend.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSend.FlatAppearance.BorderSize = 0;
            this.btnSend.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSend.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSend.Location = new System.Drawing.Point(9, 459);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(70, 69);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "Send";
            this.btnSend.UseVisualStyleBackColor = false;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // Chat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.flbChat);
            this.Controls.Add(this.textMessage);
            this.Controls.Add(this.btnSend);
            this.Name = "Chat";
            this.Size = new System.Drawing.Size(449, 537);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flbChat;
        private System.Windows.Forms.RichTextBox textMessage;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblChatName;
    }
}
