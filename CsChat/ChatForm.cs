using System;
using System.Diagnostics;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using WebSocketSharp;

namespace CsChat
{
    public partial class ChatForm : Form
    {
        
        // Store username (Name) variable
        public class ClientName 
        {
            public static string Name = ""; 
        }

        // Initiate socket allowing connection
        public class Connect
        {
            public static readonly WebSocket Socket = new WebSocket("ws://127.0.0.1:80/Connect");
        }
        
        // Initiate socket allowing messages to be received
        public class Message 
        {
            public static readonly WebSocket Socket = new WebSocket("ws://127.0.0.1:80/Message");
        }

        // Initiate socket allowing usernames to be received
        public class Usernames 
        {
            public static readonly WebSocket Socket = new WebSocket("ws://127.0.0.1:80/Usernames");
        }

        // Initiate socket allowing disconnection
        public class Disconnect
        {
            public static readonly WebSocket Socket = new WebSocket("ws://127.0.0.1:80/Disconnect");
        }

        public ChatForm(string username)
        {
            InitializeComponent();
            
            ClientName.Name = username; // Set name variable

            // Connect to Connect SocketBehaviour
            Connect.Socket.Connect();
            Connect.Socket.Send(username);
            Connect.Socket.OnMessage += (sender, e) =>
                lbl_chat_panel.Text += e.Data + "\n";

            // Connect to Usernames SocketBehaviour
            Usernames.Socket.Connect();
            Usernames.Socket.Send(username);
            Usernames.Socket.OnMessage += (sender, e) =>
                lbl_chat_usernames.Text = e.Data;

                // Connect to Message SocketBehaviour
            Message.Socket.Connect();
            Message.Socket.OnMessage += (sender, e) =>
                lbl_chat_panel.Text += e.Data + "\n"; // Retrieve input from all clients
        }

        private void btn_chat_send_Click(object sender, EventArgs e)
        {
            // Send message via /Message on button click
            Message.Socket.Send(ClientName.Name + "  ->  " + txt_chat_input.Text);
            txt_chat_input.Text = string.Empty; // Clear input
        }

        private void btn_chat_disconnect_Click(object sender, EventArgs e)
        {
            // Connect to Disconnect SocketBehaviour
            Disconnect.Socket.Connect();
            
            // Send username of client disconnecting
            Disconnect.Socket.Send(ClientName.Name);

            // Close all sockets and exit application
            Connect.Socket.Close();
            Message.Socket.Close();
            Usernames.Socket.Close();
            Disconnect.Socket.Close();
            Application.Exit();
        }
    }
}