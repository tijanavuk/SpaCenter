namespace Client
{
    partial class CancelReceiptForm
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
            this.buttonShowReceiptLines = new System.Windows.Forms.Button();
            this.dataGridViewReceipt = new System.Windows.Forms.DataGridView();
            this.buttonSearchReceipt = new System.Windows.Forms.Button();
            this.textBoxSearchReceipt = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonCancelReceipt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStatuses = new System.Windows.Forms.ComboBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowReceiptLines
            // 
            this.buttonShowReceiptLines.Location = new System.Drawing.Point(12, 315);
            this.buttonShowReceiptLines.Name = "buttonShowReceiptLines";
            this.buttonShowReceiptLines.Size = new System.Drawing.Size(138, 23);
            this.buttonShowReceiptLines.TabIndex = 9;
            this.buttonShowReceiptLines.Text = "Show receipt lines";
            this.buttonShowReceiptLines.UseVisualStyleBackColor = true;
            this.buttonShowReceiptLines.Click += new System.EventHandler(this.buttonShowReceiptLines_Click);
            // 
            // dataGridViewReceipt
            // 
            this.dataGridViewReceipt.AllowUserToAddRows = false;
            this.dataGridViewReceipt.AllowUserToDeleteRows = false;
            this.dataGridViewReceipt.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceipt.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceipt.Location = new System.Drawing.Point(10, 133);
            this.dataGridViewReceipt.Name = "dataGridViewReceipt";
            this.dataGridViewReceipt.ReadOnly = true;
            this.dataGridViewReceipt.Size = new System.Drawing.Size(769, 164);
            this.dataGridViewReceipt.TabIndex = 8;
            // 
            // buttonSearchReceipt
            // 
            this.buttonSearchReceipt.Location = new System.Drawing.Point(302, 104);
            this.buttonSearchReceipt.Name = "buttonSearchReceipt";
            this.buttonSearchReceipt.Size = new System.Drawing.Size(206, 23);
            this.buttonSearchReceipt.TabIndex = 7;
            this.buttonSearchReceipt.Text = "Find receipt";
            this.buttonSearchReceipt.UseVisualStyleBackColor = true;
            this.buttonSearchReceipt.Click += new System.EventHandler(this.buttonSearchReceipt_Click);
            // 
            // textBoxSearchReceipt
            // 
            this.textBoxSearchReceipt.Location = new System.Drawing.Point(302, 22);
            this.textBoxSearchReceipt.Name = "textBoxSearchReceipt";
            this.textBoxSearchReceipt.Size = new System.Drawing.Size(206, 20);
            this.textBoxSearchReceipt.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter receipt number:";
            // 
            // buttonCancelReceipt
            // 
            this.buttonCancelReceipt.Location = new System.Drawing.Point(641, 315);
            this.buttonCancelReceipt.Name = "buttonCancelReceipt";
            this.buttonCancelReceipt.Size = new System.Drawing.Size(138, 23);
            this.buttonCancelReceipt.TabIndex = 10;
            this.buttonCancelReceipt.Text = "Cancel receipt";
            this.buttonCancelReceipt.UseVisualStyleBackColor = true;
            this.buttonCancelReceipt.Click += new System.EventHandler(this.buttonCancelReceipt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(175, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select status:";
            // 
            // comboBoxStatuses
            // 
            this.comboBoxStatuses.FormattingEnabled = true;
            this.comboBoxStatuses.Location = new System.Drawing.Point(302, 63);
            this.comboBoxStatuses.Name = "comboBoxStatuses";
            this.comboBoxStatuses.Size = new System.Drawing.Size(206, 21);
            this.comboBoxStatuses.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(541, 60);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(137, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "Reset selected status";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // CancelReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 350);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.comboBoxStatuses);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonCancelReceipt);
            this.Controls.Add(this.buttonShowReceiptLines);
            this.Controls.Add(this.dataGridViewReceipt);
            this.Controls.Add(this.buttonSearchReceipt);
            this.Controls.Add(this.textBoxSearchReceipt);
            this.Controls.Add(this.label1);
            this.Name = "CancelReceiptForm";
            this.Text = "Cancel receipt ";
            this.Load += new System.EventHandler(this.CancelReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceipt)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowReceiptLines;
        private System.Windows.Forms.DataGridView dataGridViewReceipt;
        private System.Windows.Forms.Button buttonSearchReceipt;
        private System.Windows.Forms.TextBox textBoxSearchReceipt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonCancelReceipt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxStatuses;
        private System.Windows.Forms.Button button1;
    }
}