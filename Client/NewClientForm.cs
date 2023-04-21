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
    public partial class NewClientForm : Form
    {
        private ControllerUI ui;
        public NewClientForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            ui.ReturnLoyalties(comboBoxLoyalty);
        }

        private void buttonSaveClient_Click(object sender, EventArgs e)
        {
            ui.SaveNewClient(textBoxFirstName, textBoxLastName, textBoxEmail, comboBoxLoyalty, this);
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            textBoxFirstName.BackColor = Color.White;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            textBoxLastName.BackColor = Color.White;
        }

        private void textBoxEmail_TextChanged(object sender, EventArgs e)
        {
            textBoxEmail.BackColor = Color.White;
        }

        private void comboBoxLoyalty_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
