namespace Client
{
    partial class ShowReceiptLinesForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewReceiptLines = new System.Windows.Forms.DataGridView();
            this.textBoxReceiptNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptLines)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewReceiptLines);
            this.groupBox1.Controls.Add(this.textBoxReceiptNumber);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 277);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Receipt lines data";
            // 
            // dataGridViewReceiptLines
            // 
            this.dataGridViewReceiptLines.AllowUserToAddRows = false;
            this.dataGridViewReceiptLines.AllowUserToDeleteRows = false;
            this.dataGridViewReceiptLines.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewReceiptLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewReceiptLines.Location = new System.Drawing.Point(10, 79);
            this.dataGridViewReceiptLines.Name = "dataGridViewReceiptLines";
            this.dataGridViewReceiptLines.Size = new System.Drawing.Size(760, 192);
            this.dataGridViewReceiptLines.TabIndex = 2;
            // 
            // textBoxReceiptNumber
            // 
            this.textBoxReceiptNumber.Location = new System.Drawing.Point(98, 28);
            this.textBoxReceiptNumber.Name = "textBoxReceiptNumber";
            this.textBoxReceiptNumber.Size = new System.Drawing.Size(232, 20);
            this.textBoxReceiptNumber.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Receipt number:";
            // 
            // ShowReceiptLinesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(794, 297);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowReceiptLinesForm";
            this.Text = "Show receipt lines";
            this.Load += new System.EventHandler(this.ShowReceiptLinesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewReceiptLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewReceiptLines;
        private System.Windows.Forms.TextBox textBoxReceiptNumber;
        private System.Windows.Forms.Label label1;
    }
}