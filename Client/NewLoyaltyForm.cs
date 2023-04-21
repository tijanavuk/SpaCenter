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
    public partial class NewLoyaltyForm : Form
    {
        ControllerUI ui;
        public NewLoyaltyForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void buttonSaveLoyalty_Click(object sender, EventArgs e)
        {
            ui.SaveNewLoyalty(textBoxName, textBoxDiscount, this);
        }

        private void textBoxName_TextChanged(object sender, EventArgs e)
        {
            textBoxName.BackColor = Color.White;
        }

        private void textBoxDiscount_TextChanged(object sender, EventArgs e)
        {
            textBoxDiscount.BackColor = Color.White;
        }
    }
}
