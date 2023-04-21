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
    public partial class ShowRolesForm : Form
    {
        ControllerUI ui;
        public ShowRolesForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void ShowRolesForm_Load(object sender, EventArgs e)
        {
            ui.ShowEmployeeRolesData(ui.showEmployee, dataGridViewEmployeeRoles, this);
            textBoxEmployee.Text = ui.showEmployee.firstName + " " + ui.showEmployee.lastName;
        }
    }
}
