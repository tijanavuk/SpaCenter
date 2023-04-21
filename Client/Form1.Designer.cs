namespace Client
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.clientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newClientToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.serviceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newServiceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newServiceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.perToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReceiptToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newReceiptToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.loyaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.newLoyaltyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newEmployeeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxDiscountAmount = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonRemoveRL = new System.Windows.Forms.Button();
            this.buttonFindClient = new System.Windows.Forms.Button();
            this.labelClient = new System.Windows.Forms.Label();
            this.textBoxClient = new System.Windows.Forms.TextBox();
            this.comboBoxPaymentMethods = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxAmount = new System.Windows.Forms.TextBox();
            this.buttonSave = new System.Windows.Forms.Button();
            this.dataGridViewReceiptLines = new System.Windows.Forms.DataGridView();
            this.textBoxReceiptDate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxNote = new System.Windows.Forms.TextBox();
            this.textBoxReceiptNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptLines)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientToolStripMenuItem,
            this.serviceToolStripMenuItem,
            this.perToolStripMenuItem,
            this.loyaltyToolStripMenuItem,
            this.employeeToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(736, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // clientToolStripMenuItem
            // 
            this.clientToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.newClientToolStripMenuItem});
            this.clientToolStripMenuItem.Name = "clientToolStripMenuItem";
            this.clientToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.clientToolStripMenuItem.Text = "Client";
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.searchToolStripMenuItem.Text = "Search/Edit/Delete client";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // newClientToolStripMenuItem
            // 
            this.newClientToolStripMenuItem.Name = "newClientToolStripMenuItem";
            this.newClientToolStripMenuItem.Size = new System.Drawing.Size(204, 22);
            this.newClientToolStripMenuItem.Text = "New client";
            this.newClientToolStripMenuItem.Click += new System.EventHandler(this.newClientToolStripMenuItem_Click);
            // 
            // serviceToolStripMenuItem
            // 
            this.serviceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newServiceToolStripMenuItem,
            this.newServiceToolStripMenuItem1});
            this.serviceToolStripMenuItem.Name = "serviceToolStripMenuItem";
            this.serviceToolStripMenuItem.Size = new System.Drawing.Size(56, 20);
            this.serviceToolStripMenuItem.Text = "Service";
            // 
            // newServiceToolStripMenuItem
            // 
            this.newServiceToolStripMenuItem.Name = "newServiceToolStripMenuItem";
            this.newServiceToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            this.newServiceToolStripMenuItem.Text = "Search/Edit/Delete service";
            this.newServiceToolStripMenuItem.Click += new System.EventHandler(this.newServiceToolStripMenuItem_Click);
            // 
            // newServiceToolStripMenuItem1
            // 
            this.newServiceToolStripMenuItem1.Name = "newServiceToolStripMenuItem1";
            this.newServiceToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            this.newServiceToolStripMenuItem1.Text = "New service";
            this.newServiceToolStripMenuItem1.Click += new System.EventHandler(this.newServiceToolStripMenuItem1_Click);
            // 
            // perToolStripMenuItem
            // 
            this.perToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newReceiptToolStripMenuItem,
            this.newReceiptToolStripMenuItem1});
            this.perToolStripMenuItem.Name = "perToolStripMenuItem";
            this.perToolStripMenuItem.Size = new System.Drawing.Size(58, 20);
            this.perToolStripMenuItem.Text = "Receipt";
            // 
            // newReceiptToolStripMenuItem
            // 
            this.newReceiptToolStripMenuItem.Name = "newReceiptToolStripMenuItem";
            this.newReceiptToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.newReceiptToolStripMenuItem.Text = "New receipt";
            this.newReceiptToolStripMenuItem.Click += new System.EventHandler(this.newReceiptToolStripMenuItem_Click);
            // 
            // newReceiptToolStripMenuItem1
            // 
            this.newReceiptToolStripMenuItem1.Name = "newReceiptToolStripMenuItem1";
            this.newReceiptToolStripMenuItem1.Size = new System.Drawing.Size(189, 22);
            this.newReceiptToolStripMenuItem1.Text = "Search/Cancel receipt";
            this.newReceiptToolStripMenuItem1.Click += new System.EventHandler(this.newReceiptToolStripMenuItem1_Click);
            // 
            // loyaltyToolStripMenuItem
            // 
            this.loyaltyToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem2,
            this.newLoyaltyToolStripMenuItem});
            this.loyaltyToolStripMenuItem.Name = "loyaltyToolStripMenuItem";
            this.loyaltyToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.loyaltyToolStripMenuItem.Text = "Loyalty";
            // 
            // searchToolStripMenuItem2
            // 
            this.searchToolStripMenuItem2.Name = "searchToolStripMenuItem2";
            this.searchToolStripMenuItem2.Size = new System.Drawing.Size(210, 22);
            this.searchToolStripMenuItem2.Text = "Search/Edit/Delete loyalty";
            this.searchToolStripMenuItem2.Click += new System.EventHandler(this.searchToolStripMenuItem2_Click);
            // 
            // newLoyaltyToolStripMenuItem
            // 
            this.newLoyaltyToolStripMenuItem.Name = "newLoyaltyToolStripMenuItem";
            this.newLoyaltyToolStripMenuItem.Size = new System.Drawing.Size(210, 22);
            this.newLoyaltyToolStripMenuItem.Text = "New loyalty";
            this.newLoyaltyToolStripMenuItem.Visible = false;
            this.newLoyaltyToolStripMenuItem.Click += new System.EventHandler(this.newLoyaltyToolStripMenuItem_Click);
            // 
            // employeeToolStripMenuItem
            // 
            this.employeeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem1,
            this.newEmployeeToolStripMenuItem});
            this.employeeToolStripMenuItem.Name = "employeeToolStripMenuItem";
            this.employeeToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.employeeToolStripMenuItem.Text = "Employee";
            this.employeeToolStripMenuItem.Visible = false;
            // 
            // searchToolStripMenuItem1
            // 
            this.searchToolStripMenuItem1.Name = "searchToolStripMenuItem1";
            this.searchToolStripMenuItem1.Size = new System.Drawing.Size(222, 22);
            this.searchToolStripMenuItem1.Text = "Search/Edit/Delete/Add role";
            this.searchToolStripMenuItem1.Click += new System.EventHandler(this.searchToolStripMenuItem1_Click);
            // 
            // newEmployeeToolStripMenuItem
            // 
            this.newEmployeeToolStripMenuItem.Name = "newEmployeeToolStripMenuItem";
            this.newEmployeeToolStripMenuItem.Size = new System.Drawing.Size(222, 22);
            this.newEmployeeToolStripMenuItem.Text = "New employee";
            this.newEmployeeToolStripMenuItem.Click += new System.EventHandler(this.newEmployeeToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBoxDiscountAmount);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.buttonRemoveRL);
            this.groupBox1.Controls.Add(this.buttonFindClient);
            this.groupBox1.Controls.Add(this.labelClient);
            this.groupBox1.Controls.Add(this.textBoxClient);
            this.groupBox1.Controls.Add(this.comboBoxPaymentMethods);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxAmount);
            this.groupBox1.Controls.Add(this.buttonSave);
            this.groupBox1.Controls.Add(this.dataGridViewReceiptLines);
            this.groupBox1.Controls.Add(this.textBoxReceiptDate);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBoxNote);
            this.groupBox1.Controls.Add(this.textBoxReceiptNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(11, 27);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(713, 514);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Fill receipt data";
            // 
            // textBoxDiscountAmount
            // 
            this.textBoxDiscountAmount.BackColor = System.Drawing.SystemColors.Window;
            this.textBoxDiscountAmount.ForeColor = System.Drawing.Color.Red;
            this.textBoxDiscountAmount.Location = new System.Drawing.Point(576, 205);
            this.textBoxDiscountAmount.Name = "textBoxDiscountAmount";
            this.textBoxDiscountAmount.ReadOnly = true;
            this.textBoxDiscountAmount.Size = new System.Drawing.Size(121, 20);
            this.textBoxDiscountAmount.TabIndex = 20;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(619, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Discount:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 263);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add receipt line";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRemoveRL
            // 
            this.buttonRemoveRL.Location = new System.Drawing.Point(131, 263);
            this.buttonRemoveRL.Name = "buttonRemoveRL";
            this.buttonRemoveRL.Size = new System.Drawing.Size(112, 23);
            this.buttonRemoveRL.TabIndex = 18;
            this.buttonRemoveRL.Text = "Delete receipt line";
            this.buttonRemoveRL.UseVisualStyleBackColor = true;
            this.buttonRemoveRL.Click += new System.EventHandler(this.buttonRemoveRL_Click);
            // 
            // buttonFindClient
            // 
            this.buttonFindClient.Location = new System.Drawing.Point(13, 144);
            this.buttonFindClient.Name = "buttonFindClient";
            this.buttonFindClient.Size = new System.Drawing.Size(342, 23);
            this.buttonFindClient.TabIndex = 16;
            this.buttonFindClient.Text = "Add client";
            this.buttonFindClient.UseVisualStyleBackColor = true;
            this.buttonFindClient.Click += new System.EventHandler(this.buttonFindClient_Click);
            // 
            // labelClient
            // 
            this.labelClient.AutoSize = true;
            this.labelClient.Location = new System.Drawing.Point(10, 185);
            this.labelClient.Name = "labelClient";
            this.labelClient.Size = new System.Drawing.Size(36, 13);
            this.labelClient.TabIndex = 15;
            this.labelClient.Text = "Client:";
            this.labelClient.Visible = false;
            // 
            // textBoxClient
            // 
            this.textBoxClient.Enabled = false;
            this.textBoxClient.Location = new System.Drawing.Point(131, 182);
            this.textBoxClient.Name = "textBoxClient";
            this.textBoxClient.Size = new System.Drawing.Size(224, 20);
            this.textBoxClient.TabIndex = 14;
            this.textBoxClient.Visible = false;
            // 
            // comboBoxPaymentMethods
            // 
            this.comboBoxPaymentMethods.FormattingEnabled = true;
            this.comboBoxPaymentMethods.Location = new System.Drawing.Point(131, 106);
            this.comboBoxPaymentMethods.Name = "comboBoxPaymentMethods";
            this.comboBoxPaymentMethods.Size = new System.Drawing.Size(224, 21);
            this.comboBoxPaymentMethods.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(10, 109);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Payment method:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(619, 242);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Amount:";
            // 
            // textBoxAmount
            // 
            this.textBoxAmount.Enabled = false;
            this.textBoxAmount.Location = new System.Drawing.Point(576, 265);
            this.textBoxAmount.Name = "textBoxAmount";
            this.textBoxAmount.Size = new System.Drawing.Size(121, 20);
            this.textBoxAmount.TabIndex = 9;
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(622, 479);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(75, 23);
            this.buttonSave.TabIndex = 7;
            this.buttonSave.Text = "Save";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // dataGridViewReceiptLines
            // 
            this.dataGridViewReceiptLines.AllowUserToAddRows = false;
            this.dataGridViewReceiptLines.AllowUserToDeleteRows = false;
            this.dataGridViewReceiptLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceiptLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceiptLines.Location = new System.Drawing.Point(6, 298);
            this.dataGridViewReceiptLines.Name = "dataGridViewReceiptLines";
            this.dataGridViewReceiptLines.ReadOnly = true;
            this.dataGridViewReceiptLines.Size = new System.Drawing.Size(691, 175);
            this.dataGridViewReceiptLines.TabIndex = 6;
            // 
            // textBoxReceiptDate
            // 
            this.textBoxReceiptDate.Enabled = false;
            this.textBoxReceiptDate.Location = new System.Drawing.Point(131, 65);
            this.textBoxReceiptDate.Name = "textBoxReceiptDate";
            this.textBoxReceiptDate.Size = new System.Drawing.Size(224, 20);
            this.textBoxReceiptDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Receipt date:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(403, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Note:";
            // 
            // textBoxNote
            // 
            this.textBoxNote.Location = new System.Drawing.Point(473, 85);
            this.textBoxNote.Multiline = true;
            this.textBoxNote.Name = "textBoxNote";
            this.textBoxNote.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxNote.Size = new System.Drawing.Size(224, 67);
            this.textBoxNote.TabIndex = 2;
            // 
            // textBoxReceiptNumber
            // 
            this.textBoxReceiptNumber.Enabled = false;
            this.textBoxReceiptNumber.Location = new System.Drawing.Point(131, 26);
            this.textBoxReceiptNumber.Name = "textBoxReceiptNumber";
            this.textBoxReceiptNumber.Size = new System.Drawing.Size(224, 20);
            this.textBoxReceiptNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt number:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(736, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Main form";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptLines)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem clientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newClientToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem serviceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newServiceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newServiceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem perToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newReceiptToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newReceiptToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loyaltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem newLoyaltyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem employeeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem newEmployeeToolStripMenuItem;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxDiscountAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRemoveRL;
        private System.Windows.Forms.Button buttonFindClient;
        private System.Windows.Forms.Label labelClient;
        private System.Windows.Forms.TextBox textBoxClient;
        private System.Windows.Forms.ComboBox comboBoxPaymentMethods;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxAmount;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.DataGridView dataGridViewReceiptLines;
        private System.Windows.Forms.TextBox textBoxReceiptDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxNote;
        private System.Windows.Forms.TextBox textBoxReceiptNumber;
        private System.Windows.Forms.Label label1;
    }
}

