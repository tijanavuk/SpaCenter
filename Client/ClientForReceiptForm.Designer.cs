namespace Client
{
    partial class ClientForReceiptForm
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
            this.buttonAddClient = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResetLoyalty = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxLoyalties = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonAddClient
            // 
            this.buttonAddClient.Location = new System.Drawing.Point(496, 316);
            this.buttonAddClient.Name = "buttonAddClient";
            this.buttonAddClient.Size = new System.Drawing.Size(138, 23);
            this.buttonAddClient.TabIndex = 14;
            this.buttonAddClient.Text = "Add client";
            this.buttonAddClient.UseVisualStyleBackColor = true;
            this.buttonAddClient.Click += new System.EventHandler(this.buttonAddClient_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(8, 133);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(626, 165);
            this.dataGridViewClient.TabIndex = 13;
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(497, 104);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(137, 23);
            this.buttonSearchClient.TabIndex = 12;
            this.buttonSearchClient.Text = "Find clients";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Location = new System.Drawing.Point(217, 21);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(416, 20);
            this.textBoxSearchClient.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter part of first name, last name or email:";
            // 
            // buttonResetLoyalty
            // 
            this.buttonResetLoyalty.Location = new System.Drawing.Point(497, 60);
            this.buttonResetLoyalty.Name = "buttonResetLoyalty";
            this.buttonResetLoyalty.Size = new System.Drawing.Size(139, 23);
            this.buttonResetLoyalty.TabIndex = 18;
            this.buttonResetLoyalty.Text = "Reset selected loyalty";
            this.buttonResetLoyalty.UseVisualStyleBackColor = true;
            this.buttonResetLoyalty.Click += new System.EventHandler(this.buttonResetLoyalty_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Select loyalty:";
            // 
            // comboBoxLoyalties
            // 
            this.comboBoxLoyalties.FormattingEnabled = true;
            this.comboBoxLoyalties.Location = new System.Drawing.Point(217, 60);
            this.comboBoxLoyalties.Name = "comboBoxLoyalties";
            this.comboBoxLoyalties.Size = new System.Drawing.Size(242, 21);
            this.comboBoxLoyalties.TabIndex = 16;
            // 
            // ClientForReceiptForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(645, 346);
            this.Controls.Add(this.buttonResetLoyalty);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxLoyalties);
            this.Controls.Add(this.buttonAddClient);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.buttonSearchClient);
            this.Controls.Add(this.textBoxSearchClient);
            this.Controls.Add(this.label1);
            this.Name = "ClientForReceiptForm";
            this.Text = "Client for receipt";
            this.Load += new System.EventHandler(this.ClientForReceiptForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonAddClient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.TextBox textBoxSearchClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResetLoyalty;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBoxLoyalties;
    }
}