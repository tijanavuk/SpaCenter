namespace Client
{
    partial class SearchServiceForm
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
            this.buttonShowService = new System.Windows.Forms.Button();
            this.dataGridViewService = new System.Windows.Forms.DataGridView();
            this.buttonSearchService = new System.Windows.Forms.Button();
            this.textBoxSearchService = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonResetCategory = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxCategory = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowService
            // 
            this.buttonShowService.Location = new System.Drawing.Point(498, 320);
            this.buttonShowService.Name = "buttonShowService";
            this.buttonShowService.Size = new System.Drawing.Size(138, 23);
            this.buttonShowService.TabIndex = 14;
            this.buttonShowService.Text = "Show service";
            this.buttonShowService.UseVisualStyleBackColor = true;
            this.buttonShowService.Click += new System.EventHandler(this.buttonShowService_Click);
            // 
            // dataGridViewService
            // 
            this.dataGridViewService.AllowUserToAddRows = false;
            this.dataGridViewService.AllowUserToDeleteRows = false;
            this.dataGridViewService.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewService.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewService.Location = new System.Drawing.Point(10, 137);
            this.dataGridViewService.Name = "dataGridViewService";
            this.dataGridViewService.ReadOnly = true;
            this.dataGridViewService.Size = new System.Drawing.Size(626, 165);
            this.dataGridViewService.TabIndex = 13;
            // 
            // buttonSearchService
            // 
            this.buttonSearchService.Location = new System.Drawing.Point(488, 99);
            this.buttonSearchService.Name = "buttonSearchService";
            this.buttonSearchService.Size = new System.Drawing.Size(148, 23);
            this.buttonSearchService.TabIndex = 12;
            this.buttonSearchService.Text = "Find services";
            this.buttonSearchService.UseVisualStyleBackColor = true;
            this.buttonSearchService.Click += new System.EventHandler(this.buttonSearchService_Click);
            // 
            // textBoxSearchService
            // 
            this.textBoxSearchService.Location = new System.Drawing.Point(183, 25);
            this.textBoxSearchService.Name = "textBoxSearchService";
            this.textBoxSearchService.Size = new System.Drawing.Size(453, 20);
            this.textBoxSearchService.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Enter part of name or desription:";
            // 
            // buttonResetCategory
            // 
            this.buttonResetCategory.Location = new System.Drawing.Point(487, 60);
            this.buttonResetCategory.Name = "buttonResetCategory";
            this.buttonResetCategory.Size = new System.Drawing.Size(149, 23);
            this.buttonResetCategory.TabIndex = 17;
            this.buttonResetCategory.Text = "Reset selected category";
            this.buttonResetCategory.UseVisualStyleBackColor = true;
            this.buttonResetCategory.Click += new System.EventHandler(this.buttonResetCategory_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 68);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Select category:";
            // 
            // comboBoxCategory
            // 
            this.comboBoxCategory.FormattingEnabled = true;
            this.comboBoxCategory.Location = new System.Drawing.Point(183, 60);
            this.comboBoxCategory.Name = "comboBoxCategory";
            this.comboBoxCategory.Size = new System.Drawing.Size(252, 21);
            this.comboBoxCategory.TabIndex = 15;
            // 
            // SearchServiceForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(649, 355);
            this.Controls.Add(this.buttonResetCategory);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxCategory);
            this.Controls.Add(this.buttonShowService);
            this.Controls.Add(this.dataGridViewService);
            this.Controls.Add(this.buttonSearchService);
            this.Controls.Add(this.textBoxSearchService);
            this.Controls.Add(this.label1);
            this.Name = "SearchServiceForm";
            this.Text = "Search services";
            this.Load += new System.EventHandler(this.SearchServiceForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewService)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowService;
        private System.Windows.Forms.DataGridView dataGridViewService;
        private System.Windows.Forms.Button buttonSearchService;
        private System.Windows.Forms.TextBox textBoxSearchService;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonResetCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxCategory;
    }
}