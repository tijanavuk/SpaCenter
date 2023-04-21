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
    public partial class NewReceiptLineForm : Form
    {
        ControllerUI ui;
        public NewReceiptLineForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void NewReceiptLineForm_Load(object sender, EventArgs e)
        {
            ui.ReturnServices(comboBoxService);
        }

        private void buttonAddReceiptLine_Click(object sender, EventArgs e)
        {
            ui.AddReceiptLine(comboBoxService, textBoxQuantity, this);
        }

        private void textBoxQuantity_TextChanged(object sender, EventArgs e)
        {
            textBoxQuantity.BackColor = Color.White;
        }
    }
}
