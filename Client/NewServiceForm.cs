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
    public partial class NewServiceForm : Form
    {
        ControllerUI ui;
        public NewServiceForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void NewServiceForm_Load(object sender, EventArgs e)
        {
            ui.ReturnCategories(comboBoxCategory);
        }

        private void buttonSaveService_Click(object sender, EventArgs e)
        {
            ui.SaveNewService(textBoxName, textBoxDesc, textBoxPrice, comboBoxCategory, this);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxName.BackColor = Color.White;
        }

        private void textBoxDesc_TextChanged(object sender, EventArgs e)
        {
            textBoxDesc.BackColor = Color.White;
        }

        private void textBoxPrice_TextChanged(object sender, EventArgs e)
        {
            textBoxPrice.BackColor = Color.White;
        }

        private void comboBoxCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
    }
}
