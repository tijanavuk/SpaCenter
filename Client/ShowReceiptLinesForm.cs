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
    public partial class ShowReceiptLinesForm : Form
    {
        ControllerUI ui;
        public ShowReceiptLinesForm(ControllerUI ui, ReceiptHeader receiptHeader)
        {
            InitializeComponent();
            this.ui = ui;
            ui.showReceiptHeader = receiptHeader;
        }

        private void ShowReceiptLinesForm_Load(object sender, EventArgs e)
        {
            ui.ShowReceiptLines(dataGridViewReceiptLines, textBoxReceiptNumber);
        }
    }
}
