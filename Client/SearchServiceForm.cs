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
    public partial class SearchServiceForm : Form
    {
        ControllerUI ui;
        public SearchServiceForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void buttonSearchService_Click(object sender, EventArgs e)
        {
            ui.SearchServices(textBoxSearchService, comboBoxCategory, dataGridViewService);
        }

        private void buttonShowService_Click(object sender, EventArgs e)
        {
            ui.ReturnSelectedService(dataGridViewService);
        }

        private void SearchServiceForm_Load(object sender, EventArgs e)
        {
            ui.ReturnCategories(comboBoxCategory);
            ui.ReturnAllServices(dataGridViewService);
        }

        private void buttonResetCategory_Click(object sender, EventArgs e)
        {
            comboBoxCategory.SelectedItem = null;
        }
    }
}
