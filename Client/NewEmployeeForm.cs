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
    public partial class NewEmployeeForm : Form
    {
        ControllerUI ui;
        public NewEmployeeForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void buttonSaveService_Click(object sender, EventArgs e)
        {
            ui.SaveNewEmployee(textBoxUsername, textBoxPassword, textBoxFirstName, textBoxLastName, dateTimeOfEmployment, dateTimeTermination, checkBoxTerminationDate, this);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxTerminationDate.Checked)
            {
                label6.Visible = true;
                dateTimeTermination.Visible = true;
            }
            else {
                label6.Visible = false;
                dateTimeTermination.Visible = false;
            }

        }

        private void textBoxUsername_TextChanged(object sender, EventArgs e)
        {
            textBoxUsername.BackColor = Color.White;
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {
            textBoxPassword.BackColor = Color.White;
        }

        private void textBoxFirstName_TextChanged(object sender, EventArgs e)
        {
            textBoxFirstName.BackColor = Color.White;
        }

        private void textBoxLastName_TextChanged(object sender, EventArgs e)
        {
            textBoxLastName.BackColor = Color.White;
        }
    }
}
