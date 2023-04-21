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
    public partial class Form1 : Form
    {
        private ControllerUI ui;
        public Form1(ControllerUI ui)
        {
            InitializeComponent();
            this.ui = ui;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ui.CheckRoles(employeeToolStripMenuItem, newLoyaltyToolStripMenuItem);
            ui.SetDateForNewReceipt(textBoxReceiptNumber, textBoxReceiptDate, comboBoxPaymentMethods, dataGridViewReceiptLines);

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void newClientToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewClientForm(ui).ShowDialog();
        }

        private void newServiceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new NewServiceForm(ui).ShowDialog();
        }

        private void newLoyaltyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewLoyaltyForm(ui).ShowDialog();
        }

        private void newEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewEmployeeForm(ui).ShowDialog();
        }

        private void searchToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new SearchEmployeeForm(ui).ShowDialog();
        }

        private void searchToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            new SearchLoyalty(ui).ShowDialog();
        }

        private void newServiceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchServiceForm(ui).ShowDialog();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchClientForm(ui).ShowDialog();
        }

        private void addRoleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new SearchEmployeeForm(ui).ShowDialog();
        }

        private void newReceiptToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new NewReceiptForm(ui).ShowDialog();
        }

        private void newReceiptToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new CancelReceiptForm(ui).ShowDialog();
        }

        private void buttonFindClient_Click(object sender, EventArgs e)
        {
            new ClientForReceiptForm(ui).ShowDialog();
            ui.CheckIfClientExist(textBoxClient, labelClient, buttonFindClient, textBoxAmount, textBoxDiscountAmount);
            dataGridViewReceiptLines.Refresh();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new NewReceiptLineForm(ui).ShowDialog();
            textBoxAmount.Text = ui.receiptHeader.Amount.ToString();
            textBoxDiscountAmount.Text = ui.receiptHeader.discount.ToString();
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
    }
}
