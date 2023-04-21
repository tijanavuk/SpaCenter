using Domain;
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
    public partial class ShowEmployee : Form
    {
        ControllerUI ui;
        public ShowEmployee(ControllerUI ui, Employee e)
        {
            InitializeComponent();
            this.ui = ui;
            ui.showEmployee = e;
        }

        private void ShowEmployee_Load(object sender, EventArgs e)
        {
            ui.ShowEmployeeData(textBoxUsername, textBoxPassword, textBoxFirstName, textBoxLastName, dateTimeOfEmployment, dateTimeTermination, checkBoxTerminationDate, label6, this);
        }

        private void buttonEditService_Click(object sender, EventArgs e)
        {
            ui.EditEmployee(textBoxUsername, textBoxPassword, textBoxFirstName, textBoxLastName, dateTimeOfEmployment, dateTimeTermination, checkBoxTerminationDate, this);
        }

        private void buttonDeactive_Click(object sender, EventArgs e)
        {
            ui.DeactiveEmployee(this);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void buttonShowRoles_Click(object sender, EventArgs e)
        {
            ShowRolesForm er = new ShowRolesForm(ui);
            er.ShowDialog();
        }

        private void buttonAddRole_Click(object sender, EventArgs e)
        {
            AddRoleForm ar = new AddRoleForm(ui);
            ar.ShowDialog();
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
    }
}
