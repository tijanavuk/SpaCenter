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
    public partial class AddRoleForm : Form
    {
        ControllerUI ui;
        public AddRoleForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void AddRoleForm_Load(object sender, EventArgs e)
        {
            textBoxEmployee.Text = ui.showEmployee.firstName + " " + ui.showEmployee.lastName;
            ui.ReturnRoles(comboBoxRoles);
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            ui.SaveEmployeeRole(comboBoxRoles, dateTimePickerFrom, dateTimePickerTo, checkBoxDateTo, this);
        }

        private void checkBoxDateTo_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxDateTo.Checked)
            {
                label4.Visible = true;
                dateTimePickerTo.Visible = true;
            }
            else {
                label4.Visible = false;
                dateTimePickerTo.Visible = false;
            }
        }
    }
}
