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
    public partial class NewReceiptForm : Form
    {
        ControllerUI ui;
        public NewReceiptForm(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewReceiptLineForm(ui).ShowDialog();
            textBoxAmount.Text = ui.receiptHeader.Amount.ToString();
            textBoxDiscountAmount.Text = ui.receiptHeader.discount.ToString();
        }

        private void buttonEditRL_Click(object sender, EventArgs e)
        {
        }

        private void buttonFindClient_Click(object sender, EventArgs e)
        {
            new ClientForReceiptForm(ui).ShowDialog();
            ui.CheckIfClientExist(textBoxClient, labelClient, buttonFindClient, textBoxAmount, textBoxDiscountAmount);
            dataGridViewReceiptLines.Refresh();

        }

        private void NewReceiptForm_Load(object sender, EventArgs e)
        {
            ui.SetDateForNewReceipt(textBoxReceiptNumber, textBoxReceiptDate, comboBoxPaymentMethods, dataGridViewReceiptLines);
        }

        private void buttonRemoveRL_Click(object sender, EventArgs e)
        {
            ui.RemoveReceiptLine(dataGridViewReceiptLines);
            textBoxAmount.Text = ui.receiptHeader.Amount.ToString();
            textBoxDiscountAmount.Text = ui.receiptHeader.discount.ToString();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            ui.SaveReceipt(textBoxReceiptNumber, textBoxReceiptDate, comboBoxPaymentMethods, textBoxClient, textBoxNote, textBoxAmount, dataGridViewReceiptLines, textBoxDiscountAmount, labelClient, buttonFindClient, this);
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

    }
}
