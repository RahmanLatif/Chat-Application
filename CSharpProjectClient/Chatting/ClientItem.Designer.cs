namespace Chatting
{
    partial class ClientItem
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
            this.btnSendRequest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblClientName
            // 
            this.lblClientName.AutoEllipsis = true;
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Gill Sans MT Ext Condensed Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblClientName.Location = new System.Drawing.Point(6, 11);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(101, 34);
            this.lblClientName.TabIndex = 1;
            this.lblClientName.Text = "lblClientName";
            // 
            // btnSendRequest
            // 
            this.btnSendRequest.BackColor = System.Drawing.Color.Transparent;
            this.btnSendRequest.BackgroundImage = global::Chatting.Properties.Resources.SendRequest;
            this.btnSendRequest.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSendRequest.FlatAppearance.BorderSize = 0;
            this.btnSendRequest.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSendRequest.Font = new System.Drawing.Font("Comic Sans MS", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendRequest.Location = new System.Drawing.Point(157, 6);
            this.btnSendRequest.Name = "btnSendRequest";
            this.btnSendRequest.Size = new System.Drawing.Size(36, 43);
            this.btnSendRequest.TabIndex = 12;
            this.btnSendRequest.UseVisualStyleBackColor = false;
            this.btnSendRequest.Click += new System.EventHandler(this.btnSendRequest_Click);
            // 
            // ClientItem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.Controls.Add(this.btnSendRequest);
            this.Controls.Add(this.lblClientName);
            this.Name = "ClientItem";
            this.Size = new System.Drawing.Size(196, 56);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Button btnSendRequest;
    }
}
