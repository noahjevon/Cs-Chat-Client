using System.ComponentModel;

namespace CsChat
{
    partial class ChatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

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
            this.lbl_chat_usernames = new System.Windows.Forms.Label();
            this.txt_chat_input = new System.Windows.Forms.TextBox();
            this.btn_chat_send = new System.Windows.Forms.Button();
            this.lbl_chat_users = new System.Windows.Forms.Label();
            this.pnl_chat_usernames = new System.Windows.Forms.Panel();
            this.pnl_chat_panel = new System.Windows.Forms.Panel();
            this.lbl_chat_panel = new System.Windows.Forms.Label();
            this.btn_chat_disconnect = new System.Windows.Forms.Button();
            this.pnl_chat_usernames.SuspendLayout();
            this.pnl_chat_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_chat_usernames
            // 
            this.lbl_chat_usernames.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.lbl_chat_usernames.AutoSize = true;
            this.lbl_chat_usernames.BackColor = System.Drawing.SystemColors.ControlLight;
            this.lbl_chat_usernames.Location = new System.Drawing.Point(-1, 0);
            this.lbl_chat_usernames.Name = "lbl_chat_usernames";
            this.lbl_chat_usernames.Size = new System.Drawing.Size(0, 13);
            this.lbl_chat_usernames.TabIndex = 0;
            this.lbl_chat_usernames.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // txt_chat_input
            // 
            this.txt_chat_input.Anchor = ((System.Windows.Forms.AnchorStyles) ((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txt_chat_input.Location = new System.Drawing.Point(151, 416);
            this.txt_chat_input.Name = "txt_chat_input";
            this.txt_chat_input.Size = new System.Drawing.Size(557, 20);
            this.txt_chat_input.TabIndex = 1;
            // 
            // btn_chat_send
            // 
            this.btn_chat_send.Location = new System.Drawing.Point(714, 416);
            this.btn_chat_send.Name = "btn_chat_send";
            this.btn_chat_send.Size = new System.Drawing.Size(76, 20);
            this.btn_chat_send.TabIndex = 2;
            this.btn_chat_send.Text = "Send";
            this.btn_chat_send.UseVisualStyleBackColor = true;
            this.btn_chat_send.Click += new System.EventHandler(this.btn_chat_send_Click);
            // 
            // lbl_chat_users
            // 
            this.lbl_chat_users.Location = new System.Drawing.Point(12, 9);
            this.lbl_chat_users.Name = "lbl_chat_users";
            this.lbl_chat_users.Size = new System.Drawing.Size(133, 15);
            this.lbl_chat_users.TabIndex = 3;
            this.lbl_chat_users.Text = "Users";
            this.lbl_chat_users.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnl_chat_usernames
            // 
            this.pnl_chat_usernames.AutoScroll = true;
            this.pnl_chat_usernames.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnl_chat_usernames.Controls.Add(this.lbl_chat_usernames);
            this.pnl_chat_usernames.Location = new System.Drawing.Point(12, 27);
            this.pnl_chat_usernames.Name = "pnl_chat_usernames";
            this.pnl_chat_usernames.Size = new System.Drawing.Size(132, 409);
            this.pnl_chat_usernames.TabIndex = 5;
            // 
            // pnl_chat_panel
            // 
            this.pnl_chat_panel.AutoScroll = true;
            this.pnl_chat_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnl_chat_panel.Controls.Add(this.lbl_chat_panel);
            this.pnl_chat_panel.Location = new System.Drawing.Point(151, 27);
            this.pnl_chat_panel.Name = "pnl_chat_panel";
            this.pnl_chat_panel.Size = new System.Drawing.Size(558, 383);
            this.pnl_chat_panel.TabIndex = 6;
            // 
            // lbl_chat_panel
            // 
            this.lbl_chat_panel.AutoSize = true;
            this.lbl_chat_panel.Location = new System.Drawing.Point(3, 0);
            this.lbl_chat_panel.Name = "lbl_chat_panel";
            this.lbl_chat_panel.Size = new System.Drawing.Size(0, 13);
            this.lbl_chat_panel.TabIndex = 0;
            // 
            // btn_chat_disconnect
            // 
            this.btn_chat_disconnect.Location = new System.Drawing.Point(715, 27);
            this.btn_chat_disconnect.Name = "btn_chat_disconnect";
            this.btn_chat_disconnect.Size = new System.Drawing.Size(76, 20);
            this.btn_chat_disconnect.TabIndex = 7;
            this.btn_chat_disconnect.Text = "Disconnect";
            this.btn_chat_disconnect.UseVisualStyleBackColor = true;
            this.btn_chat_disconnect.Click += new System.EventHandler(this.btn_chat_disconnect_Click);
            // 
            // ChatForm
            // 
            this.AcceptButton = this.btn_chat_send;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_chat_disconnect);
            this.Controls.Add(this.pnl_chat_panel);
            this.Controls.Add(this.pnl_chat_usernames);
            this.Controls.Add(this.lbl_chat_users);
            this.Controls.Add(this.btn_chat_send);
            this.Controls.Add(this.txt_chat_input);
            this.Name = "ChatForm";
            this.Text = "ChatForm";
            this.pnl_chat_usernames.ResumeLayout(false);
            this.pnl_chat_usernames.PerformLayout();
            this.pnl_chat_panel.ResumeLayout(false);
            this.pnl_chat_panel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Button btn_chat_disconnect;

        private System.Windows.Forms.Label lbl_chat_panel;

        private System.Windows.Forms.Panel pnl_chat_usernames;

        private System.Windows.Forms.Panel pnl_chat_panel;
        private System.Windows.Forms.Label lbl_chat_users;

        private System.Windows.Forms.Panel panel1;

        private System.Windows.Forms.TextBox txt_chat_input;
        private System.Windows.Forms.Button btn_chat_send;

        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label lbl_chat_usernames;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}