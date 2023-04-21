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
    public partial class ShowLoyaltyForm : Form
    {
        ControllerUI ui;
        public ShowLoyaltyForm(ControllerUI ui, Loyalty loyalty)
        {
            InitializeComponent();
            this.ui = ui;
            ui.showLoyalty = loyalty;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void ShowLoyaltyForm_Load(object sender, EventArgs e)
        {
            ui.ShowLoyaltyData(textBoxName, textBoxDiscount, buttonDeactiveLoyalty, buttonEditLoyalty, this);
        }

        private void buttonDeactiveLoyalty_Click(object sender, EventArgs e)
        {
            ui.DeactiveLoyalty(this);
        }

        private void buttonEditLoyalty_Click(object sender, EventArgs e)
        {
            ui.EditLoyalty(textBoxName, textBoxDiscount, this);
        }
    }
}
