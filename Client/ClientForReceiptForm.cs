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
    public partial class ClientForReceiptForm : Form
    {
        ControllerUI ui;
        public ClientForReceiptForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void buttonSearchClient_Click(object sender, EventArgs e)
        {
            ui.SearchClients(textBoxSearchClient, comboBoxLoyalties, dataGridViewClient);
        }

        private void buttonAddClient_Click(object sender, EventArgs e)
        {
            ui.SetClientToReceipt(dataGridViewClient.CurrentRow.DataBoundItem as Domain.Client, this);
        }

        private void ClientForReceiptForm_Load(object sender, EventArgs e)
        {
            ui.ReturnLoyalties(comboBoxLoyalties);
            ui.ReturnAllClient(dataGridViewClient);
        }

        private void buttonResetLoyalty_Click(object sender, EventArgs e)
        {
            comboBoxLoyalties.SelectedItem = null;
        }
    }
}
