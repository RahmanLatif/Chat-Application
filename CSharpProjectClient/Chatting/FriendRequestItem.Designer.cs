namespace Chatting
{
    partial class FriendRequestItem
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
            this.lblClientName = new System.Windows.Forms.Label();
            this.btnReject = new System.Windows.Forms.Button();
            this.btnAccept = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoEllipsis = true;
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClientName.Location = new System.Drawing.Point(5, 12);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(104, 34);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "lblFriendName";
            // 
            // btnReject
            // 
            this.btnReject.BackColor = System.Drawing.Color.Transparent;
            this.btnReject.BackgroundImage = global::Chatting.Properties.Resources.Reject;
            this.btnReject.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReject.FlatAppearance.BorderSize = 0;
            this.btnReject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReject.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReject.Location = new System.Drawing.Point(157, 29);
            this.btnReject.Name = "btnReject";
            this.btnReject.Size = new System.Drawing.Size(27, 24);
            this.btnReject.TabIndex = 12;
            this.btnReject.UseVisualStyleBackColor = false;
            this.btnReject.Click += new System.EventHandler(this.btnReject_Click);
            // 
            // btnAccept
            // 
            this.btnAccept.BackColor = System.Drawing.Color.Transparent;
            this.btnAccept.BackgroundImage = global::Chatting.Properties.Resources.Accept;
            this.btnAccept.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnAccept.FlatAppearance.BorderSize = 0;
            this.btnAccept.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccept.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccept.Location = new System.Drawing.Point(157, 3);
            this.btnAccept.Name = "btnAccept";
            this.btnAccept.Size = new System.Drawing.Size(27, 24);
            this.btnAccept.TabIndex = 11;
            this.btnAccept.UseVisualStyleBackColor = false;
            this.btnAccept.Click += new System.EventHandler(this.btnAccept_Click);
            // 
            // FriendRequestItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.btnReject);
            this.Controls.Add(this.btnAccept);
            this.Controls.Add(this.lblClientName);
            this.Name = "FriendRequestItem";
            this.Size = new System.Drawing.Size(192, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Button btnAccept;
        private System.Windows.Forms.Button btnReject;
    }
}
