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
    public partial class CancelReceiptForm : Form
    {
        ControllerUI ui;
        public CancelReceiptForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void buttonSearchReceipt_Click(object sender, EventArgs e)
        {
            ui.SearchReceipt(textBoxSearchReceipt, dataGridViewReceipt, comboBoxStatuses);
        }

        private void buttonShowReceiptLines_Click(object sender, EventArgs e)
        {
  
            ui.OpenReceiptLinesForm(dataGridViewReceipt);
        }

        private void buttonCancelReceipt_Click(object sender, EventArgs e)
        {
            ui.CancelReceiptHeader(this, dataGridViewReceipt);
        }

        private void CancelReceiptForm_Load(object sender, EventArgs e)
        {
            ui.ReturnStatuses(comboBoxStatuses);
            ui.ReturnAllReceipt(dataGridViewReceipt);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            comboBoxStatuses.SelectedItem = Status.None;
        }
    }
}
