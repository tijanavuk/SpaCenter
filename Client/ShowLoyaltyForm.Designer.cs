namespace Client
{
    partial class ShowLoyaltyForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.textBoxDiscount = new System.Windows.Forms.TextBox();
            this.buttonEditLoyalty = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonDeactiveLoyalty = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Discount(%):";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(138, 40);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(225, 20);
            this.textBoxName.TabIndex = 5;
            // 
            // textBoxDiscount
            // 
            this.textBoxDiscount.Location = new System.Drawing.Point(138, 78);
            this.textBoxDiscount.Name = "textBoxDiscount";
            this.textBoxDiscount.Size = new System.Drawing.Size(225, 20);
            this.textBoxDiscount.TabIndex = 6;
            // 
            // buttonEditLoyalty
            // 
            this.buttonEditLoyalty.Location = new System.Drawing.Point(256, 122);
            this.buttonEditLoyalty.Name = "buttonEditLoyalty";
            this.buttonEditLoyalty.Size = new System.Drawing.Size(107, 23);
            this.buttonEditLoyalty.TabIndex = 8;
            this.buttonEditLoyalty.Text = "Edit";
            this.buttonEditLoyalty.UseVisualStyleBackColor = true;
            this.buttonEditLoyalty.Click += new System.EventHandler(this.buttonEditLoyalty_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // buttonDeactiveLoyalty
            // 
            this.buttonDeactiveLoyalty.Location = new System.Drawing.Point(138, 122);
            this.buttonDeactiveLoyalty.Name = "buttonDeactiveLoyalty";
            this.buttonDeactiveLoyalty.Size = new System.Drawing.Size(107, 23);
            this.buttonDeactiveLoyalty.TabIndex = 15;
            this.buttonDeactiveLoyalty.Text = "Delete";
            this.buttonDeactiveLoyalty.UseVisualStyleBackColor = true;
            this.buttonDeactiveLoyalty.Click += new System.EventHandler(this.buttonDeactiveLoyalty_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonDeactiveLoyalty);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.buttonEditLoyalty);
            this.groupBox1.Controls.Add(this.textBoxDiscount);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(371, 166);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Loyalty data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // ShowLoyaltyForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 179);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowLoyaltyForm";
            this.Text = "Show loyalty";
            this.Load += new System.EventHandler(this.ShowLoyaltyForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.TextBox textBoxDiscount;
        private System.Windows.Forms.Button buttonEditLoyalty;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonDeactiveLoyalty;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}