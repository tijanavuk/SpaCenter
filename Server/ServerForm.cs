using Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Server
{
    public partial class ServerForm : Form
    {
        private Server s;
        public ServerForm()
        {
            InitializeComponent();
            s = new Server();
        }

        private void buttonStartServer_Click(object sender, EventArgs e)
        {
            
            if (s.StartServer())
            {
                this.Text = "The server is running!";
                buttonStartServer.Enabled = false;
                buttonStopServer.Enabled = true;
            }
        }

        private void buttonStopServer_Click(object sender, EventArgs e)
        {
            if (Server.clients.Count > 0)
            {
                MessageBox.Show("There are more logged users!");
                return;
            }
            if (s.StopServer())
            {
                this.Text = "The server is not running!";
                buttonStartServer.Enabled = true;
                buttonStopServer.Enabled = false;
            }
            else {
                MessageBox.Show("You cannot stop the server because it is not even started!");
            }
        }

        private void ServerForm_Load(object sender, EventArgs e)
        {

        }
    }
}
