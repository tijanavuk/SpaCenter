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
    public partial class ShowService : Form
    {
        ControllerUI ui;
        public ShowService(ControllerUI ui, Service s)
        {
            InitializeComponent();
            this.ui = ui;
            ui.showService = s;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShowService_Load(object sender, EventArgs e)
        {
            ui.ShowServiceData(textBoxName, textBoxDescription, textBoxPrice, comboBoxCategory, this);
        }

        private void buttonEditService_Click(object sender, EventArgs e)
        {
            ui.EditService(textBoxName, textBoxDescription, textBoxPrice, comboBoxCategory, this);
        }

        private void buttonDeactiveService_Click(object sender, EventArgs e)
        {
            ui.DeactiveService(this);
        }
    }
}
