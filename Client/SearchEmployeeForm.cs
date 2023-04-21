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
    public partial class SearchEmployeeForm : Form
    {
        ControllerUI ui;
        public SearchEmployeeForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void buttonSearchEmployees_Click(object sender, EventArgs e)
        {
            ui.SearchEmployees(textBoxSearchEmployee, dataGridViewEmployee);
        }

        private void dataGridViewEmployee_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void buttonShowEmployee_Click(object sender, EventArgs e)
        {
            ui.ReturnSelectedEmployee(dataGridViewEmployee);
        }

        private void textBoxSearchEmployee_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SearchEmployeeForm_Load(object sender, EventArgs e)
        {
            ui.ReturnAllEmployees(dataGridViewEmployee);
        }
    }
}
