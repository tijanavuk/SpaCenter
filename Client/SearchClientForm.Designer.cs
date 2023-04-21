namespace Client
{
    partial class SearchClientForm
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
            this.buttonShowClient = new System.Windows.Forms.Button();
            this.dataGridViewClient = new System.Windows.Forms.DataGridView();
            this.buttonSearchClient = new System.Windows.Forms.Button();
            this.textBoxSearchClient = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxLoyalties = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonResetLoyalty = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowClient
            // 
            this.buttonShowClient.Location = new System.Drawing.Point(498, 326);
            this.buttonShowClient.Name = "buttonShowClient";
            this.buttonShowClient.Size = new System.Drawing.Size(138, 23);
            this.buttonShowClient.TabIndex = 9;
            this.buttonShowClient.Text = "Show client";
            this.buttonShowClient.UseVisualStyleBackColor = true;
            this.buttonShowClient.Click += new System.EventHandler(this.buttonShowClient_Click);
            // 
            // dataGridViewClient
            // 
            this.dataGridViewClient.AllowUserToAddRows = false;
            this.dataGridViewClient.AllowUserToDeleteRows = false;
            this.dataGridViewClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClient.Location = new System.Drawing.Point(10, 143);
            this.dataGridViewClient.Name = "dataGridViewClient";
            this.dataGridViewClient.ReadOnly = true;
            this.dataGridViewClient.Size = new System.Drawing.Size(626, 165);
            this.dataGridViewClient.TabIndex = 8;
            // 
            // buttonSearchClient
            // 
            this.buttonSearchClient.Location = new System.Drawing.Point(497, 105);
            this.buttonSearchClient.Name = "buttonSearchClient";
            this.buttonSearchClient.Size = new System.Drawing.Size(139, 23);
            this.buttonSearchClient.TabIndex = 7;
            this.buttonSearchClient.Text = "Find clients";
            this.buttonSearchClient.UseVisualStyleBackColor = true;
            this.buttonSearchClient.Click += new System.EventHandler(this.buttonSearchClient_Click);
            // 
            // textBoxSearchClient
            // 
            this.textBoxSearchClient.Location = new System.Drawing.Point(219, 30);
            this.textBoxSearchClient.Name = "textBoxSearchClient";
            this.textBoxSearchClient.Size = new System.Drawing.Size(417, 20);
            this.textBoxSearchClient.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(206, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Enter part of first name, last name or email:";
            // 
            // comboBoxLoyalties
            // 
            this.comboBoxLoyalties.FormattingEnabled = true;
            this.comboBoxLoyalties.Location = new System.Drawing.Point(219, 72);
            this.comboBoxLoyalties.Name = "comboBoxLoyalties";
            this.comboBoxLoyalties.Size = new System.Drawing.Size(242, 21);
            this.comboBoxLoyalties.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Select loyalty:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // buttonResetLoyalty
            // 
            this.buttonResetLoyalty.Location = new System.Drawing.Point(499, 70);
            this.buttonResetLoyalty.Name = "buttonResetLoyalty";
            this.buttonResetLoyalty.Size = new System.Drawing.Size(139, 23);
            this.buttonResetLoyalty.TabIndex = 12;
            this.buttonResetLoyalty.Text = "Reset selected loyalty";
            this.buttonResetLoyalty.UseVisualStyleBackColor = true;
            this.buttonResetLoyalty.Click += new System.EventHandler(this.buttonResetLoyalty_Click);
            // 
            // SearchClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 365);
            this.Controls.Add(this.buttonResetLoyalty);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxLoyalties);
            this.Controls.Add(this.buttonShowClient);
            this.Controls.Add(this.dataGridViewClient);
            this.Controls.Add(this.buttonSearchClient);
            this.Controls.Add(this.textBoxSearchClient);
            this.Controls.Add(this.label1);
            this.Name = "SearchClientForm";
            this.Text = "Search clients";
            this.Load += new System.EventHandler(this.SearchClientForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowClient;
        private System.Windows.Forms.DataGridView dataGridViewClient;
        private System.Windows.Forms.Button buttonSearchClient;
        private System.Windows.Forms.TextBox textBoxSearchClient;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBoxLoyalties;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button buttonResetLoyalty;
    }
}