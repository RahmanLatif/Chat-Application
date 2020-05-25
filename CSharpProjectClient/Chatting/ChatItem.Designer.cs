namespace Chatting
{
    partial class ChatItem
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
            this.lblChatName = new System.Windows.Forms.Label();
            this.lblDateLastMessage = new System.Windows.Forms.Label();
            this.lblLastMessage = new System.Windows.Forms.Label();
            this.lblUnread = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblChatName
            // 
            this.lblChatName.AutoEllipsis = true;
            this.lblChatName.AutoSize = true;
            this.lblChatName.BackColor = System.Drawing.Color.Transparent;
            this.lblChatName.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChatName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblChatName.Location = new System.Drawing.Point(3, 4);
            this.lblChatName.Name = "lblChatName";
            this.lblChatName.Size = new System.Drawing.Size(72, 26);
            this.lblChatName.TabIndex = 1;
            this.lblChatName.Text = "lblChatName";
            this.lblChatName.Click += new System.EventHandler(this.ChatItem_Click);
            // 
            // lblDateLastMessage
            // 
            this.lblDateLastMessage.AutoEllipsis = true;
            this.lblDateLastMessage.AutoSize = true;
            this.lblDateLastMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblDateLastMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateLastMessage.Location = new System.Drawing.Point(142, 6);
            this.lblDateLastMessage.Name = "lblDateLastMessage";
            this.lblDateLastMessage.Size = new System.Drawing.Size(60, 16);
            this.lblDateLastMessage.TabIndex = 2;
            this.lblDateLastMessage.Text = "03/10/20";
            this.lblDateLastMessage.Click += new System.EventHandler(this.ChatItem_Click);
            // 
            // lblLastMessage
            // 
            this.lblLastMessage.AutoEllipsis = true;
            this.lblLastMessage.AutoSize = true;
            this.lblLastMessage.BackColor = System.Drawing.Color.Transparent;
            this.lblLastMessage.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLastMessage.Location = new System.Drawing.Point(5, 34);
            this.lblLastMessage.Name = "lblLastMessage";
            this.lblLastMessage.Size = new System.Drawing.Size(94, 16);
            this.lblLastMessage.TabIndex = 4;
            this.lblLastMessage.Text = "lblLastMessage";
            this.lblLastMessage.Click += new System.EventHandler(this.ChatItem_Click);
            // 
            // lblUnread
            // 
            this.lblUnread.BackColor = System.Drawing.Color.Black;
            this.lblUnread.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnread.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblUnread.Location = new System.Drawing.Point(125, 8);
            this.lblUnread.Name = "lblUnread";
            this.lblUnread.Size = new System.Drawing.Size(11, 10);
            this.lblUnread.TabIndex = 5;
            this.lblUnread.Click += new System.EventHandler(this.ChatItem_Click);
            // 
            // ChatItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.lblUnread);
            this.Controls.Add(this.lblLastMessage);
            this.Controls.Add(this.lblDateLastMessage);
            this.Controls.Add(this.lblChatName);
            this.Name = "ChatItem";
            this.Size = new System.Drawing.Size(213, 56);
            this.Click += new System.EventHandler(this.ChatItem_Click);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblChatName;
        private System.Windows.Forms.Label lblDateLastMessage;
        private System.Windows.Forms.Label lblLastMessage;
        private System.Windows.Forms.Label lblUnread;
    }
}
