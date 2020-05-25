namespace Chatting
{
    partial class AddChatMember
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
            this.lblFriendName = new System.Windows.Forms.Label();
            this.chkChosen = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // lblFriendName
            // 
            this.lblFriendName.AutoEllipsis = true;
            this.lblFriendName.AutoSize = true;
            this.lblFriendName.BackColor = System.Drawing.Color.Transparent;
            this.lblFriendName.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFriendName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblFriendName.Location = new System.Drawing.Point(5, 11);
            this.lblFriendName.Name = "lblFriendName";
            this.lblFriendName.Size = new System.Drawing.Size(104, 34);
            this.lblFriendName.TabIndex = 1;
            this.lblFriendName.Text = "lblFriendName";
            // 
            // chkChosen
            // 
            this.chkChosen.AutoSize = true;
            this.chkChosen.Location = new System.Drawing.Point(176, 22);
            this.chkChosen.Name = "chkChosen";
            this.chkChosen.Size = new System.Drawing.Size(15, 14);
            this.chkChosen.TabIndex = 2;
            this.chkChosen.UseVisualStyleBackColor = true;
            // 
            // AddChatMember
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.chkChosen);
            this.Controls.Add(this.lblFriendName);
            this.Name = "AddChatMember";
            this.Size = new System.Drawing.Size(194, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblFriendName;
        private System.Windows.Forms.CheckBox chkChosen;
    }
}
