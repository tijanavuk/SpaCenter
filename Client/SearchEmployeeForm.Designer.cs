namespace Client
{
    partial class SearchEmployeeForm
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
            this.textBoxSearchEmployee = new System.Windows.Forms.TextBox();
            this.buttonSearchEmployees = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.buttonShowEmployee = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(223, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter part of first name, last name or username:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // textBoxSearchEmployee
            // 
            this.textBoxSearchEmployee.Location = new System.Drawing.Point(164, 62);
            this.textBoxSearchEmployee.Name = "textBoxSearchEmployee";
            this.textBoxSearchEmployee.Size = new System.Drawing.Size(331, 20);
            this.textBoxSearchEmployee.TabIndex = 1;
            this.textBoxSearchEmployee.TextChanged += new System.EventHandler(this.textBoxSearchEmployee_TextChanged);
            // 
            // buttonSearchEmployees
            // 
            this.buttonSearchEmployees.Location = new System.Drawing.Point(274, 99);
            this.buttonSearchEmployees.Name = "buttonSearchEmployees";
            this.buttonSearchEmployees.Size = new System.Drawing.Size(115, 23);
            this.buttonSearchEmployees.TabIndex = 2;
            this.buttonSearchEmployees.Text = "Find employees";
            this.buttonSearchEmployees.UseVisualStyleBackColor = true;
            this.buttonSearchEmployees.Click += new System.EventHandler(this.buttonSearchEmployees_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AllowUserToDeleteRows = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(12, 145);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.ReadOnly = true;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(626, 165);
            this.dataGridViewEmployee.TabIndex = 3;
            this.dataGridViewEmployee.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewEmployee_CellContentClick);
            // 
            // buttonShowEmployee
            // 
            this.buttonShowEmployee.Location = new System.Drawing.Point(500, 328);
            this.buttonShowEmployee.Name = "buttonShowEmployee";
            this.buttonShowEmployee.Size = new System.Drawing.Size(138, 23);
            this.buttonShowEmployee.TabIndex = 4;
            this.buttonShowEmployee.Text = "Show employee";
            this.buttonShowEmployee.UseVisualStyleBackColor = true;
            this.buttonShowEmployee.Click += new System.EventHandler(this.buttonShowEmployee_Click);
            // 
            // SearchEmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(650, 463);
            this.Controls.Add(this.buttonShowEmployee);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.buttonSearchEmployees);
            this.Controls.Add(this.textBoxSearchEmployee);
            this.Controls.Add(this.label1);
            this.Name = "SearchEmployeeForm";
            this.Text = "Search employees";
            this.Load += new System.EventHandler(this.SearchEmployeeForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBoxSearchEmployee;
        private System.Windows.Forms.Button buttonSearchEmployees;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        private System.Windows.Forms.Button buttonShowEmployee;
    }
}