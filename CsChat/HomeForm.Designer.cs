using System.ComponentModel;

namespace CsChat
{
    partial class HomeForm
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
            this.lbl_home_welcome = new System.Windows.Forms.Label();
            this.lbl_home_username = new System.Windows.Forms.Label();
            this.txt_home_username = new System.Windows.Forms.TextBox();
            this.btn_home_chat = new System.Windows.Forms.Button();
            this.lbl_home_warning = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_home_welcome
            // 
            this.lbl_home_welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_home_welcome.Location = new System.Drawing.Point(0, 0);
            this.lbl_home_welcome.Name = "lbl_home_welcome";
            this.lbl_home_welcome.Size = new System.Drawing.Size(800, 127);
            this.lbl_home_welcome.TabIndex = 0;
            this.lbl_home_welcome.Text = "Welcome!";
            this.lbl_home_welcome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_home_username
            // 
            this.lbl_home_username.Dock = System.Windows.Forms.DockStyle.Top;
            this.lbl_home_username.Location = new System.Drawing.Point(0, 127);
            this.lbl_home_username.Name = "lbl_home_username";
            this.lbl_home_username.Size = new System.Drawing.Size(800, 69);
            this.lbl_home_username.TabIndex = 1;
            this.lbl_home_username.Text = "Enter a username to continue";
            this.lbl_home_username.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // txt_home_username
            // 
            this.txt_home_username.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_home_username.Location = new System.Drawing.Point(331, 199);
            this.txt_home_username.Name = "txt_home_username";
            this.txt_home_username.Size = new System.Drawing.Size(138, 20);
            this.txt_home_username.TabIndex = 2;
            // 
            // btn_home_chat
            // 
            this.btn_home_chat.Anchor = ((System.Windows.Forms.AnchorStyles) ((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_home_chat.Location = new System.Drawing.Point(350, 225);
            this.btn_home_chat.Name = "btn_home_chat";
            this.btn_home_chat.Size = new System.Drawing.Size(101, 24);
            this.btn_home_chat.TabIndex = 3;
            this.btn_home_chat.Text = "Start chat";
            this.btn_home_chat.UseVisualStyleBackColor = true;
            this.btn_home_chat.Click += new System.EventHandler(this.btn_home_chat_Click);
            // 
            // lbl_home_warning
            // 
            this.lbl_home_warning.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lbl_home_warning.Location = new System.Drawing.Point(0, 374);
            this.lbl_home_warning.Name = "lbl_home_warning";
            this.lbl_home_warning.Size = new System.Drawing.Size(800, 73);
            this.lbl_home_warning.TabIndex = 4;
            this.lbl_home_warning.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // HomeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 447);
            this.Controls.Add(this.lbl_home_warning);
            this.Controls.Add(this.btn_home_chat);
            this.Controls.Add(this.txt_home_username);
            this.Controls.Add(this.lbl_home_username);
            this.Controls.Add(this.lbl_home_welcome);
            this.Name = "HomeForm";
            this.Text = "HomeForm";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.Label lbl_home_warning;

        private System.Windows.Forms.Button btn_home_chat;

        private System.Windows.Forms.TextBox txt_home_username;
        private System.Windows.Forms.Button button1;

        private System.Windows.Forms.Label lbl_home_username;
        private System.Windows.Forms.TextBox textBox1;

        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Label lbl_home_welcome;

        #endregion
    }
}