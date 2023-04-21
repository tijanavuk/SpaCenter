using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Client
{
    public partial class ShowClientForm : Form
    {
        ControllerUI ui;
        public ShowClientForm(ControllerUI ui, Domain.Client client)
        {
            InitializeComponent();
            this.ui = ui;
            ui.showClient = client;
        }

        private void ShowClientForm_Load(object sender, EventArgs e)
        {
            ui.ShowClientData(textBoxFirstName, textBoxLastName, textBoxEmail, comboBoxLoyalty, this);
        }

        private void buttonDeactiveClient_Click(object sender, EventArgs e)
        {
            ui.DeactiveClient(this);
        }

        private void buttonEditClient_Click(object sender, EventArgs e)
        {
            ui.EditClient(textBoxFirstName, textBoxLastName, textBoxEmail, comboBoxLoyalty, this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
