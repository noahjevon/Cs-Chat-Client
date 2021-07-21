using System;
using System.Windows.Forms;

namespace CsChat
{
    public partial class HomeForm : Form
    {
        private ChatForm _chat;
        public HomeForm()
        {
            InitializeComponent();
        }

        public string Username => txt_home_username.Text;

        private void btn_home_chat_Click(object sender, EventArgs e)
        {
            // Get username from text box
            var username = txt_home_username.Text;
            
            // Check if username field is populated
            if (username == "")
            {
                lbl_home_warning.ForeColor = System.Drawing.Color.Red;
                lbl_home_warning.Text = "You must enter a username to continue!";
            }
            else
            {
                // Load ChatForm
                _chat ??= new ChatForm(this.txt_home_username.Text);
            
                _chat.Show(this);
                Hide();
            }
        }
    }
}