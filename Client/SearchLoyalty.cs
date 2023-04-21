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
    public partial class SearchLoyalty : Form
    {
        ControllerUI ui;
        public SearchLoyalty(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void buttonSearchLoyalty_Click(object sender, EventArgs e)
        {
            ui.SearchLoyalties(textBoxSearchLoyalty, dataGridViewLoyalty);
        }

        private void buttonShowLoyalty_Click(object sender, EventArgs e)
        {
            ui.ReturnSelectedLoyalty(dataGridViewLoyalty);
        }

        private void SearchLoyalty_Load(object sender, EventArgs e)
        {
            ui.ReturnAllLoyalties(dataGridViewLoyalty);
        }
    }
}
