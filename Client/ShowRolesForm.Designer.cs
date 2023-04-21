namespace Client
{
    partial class ShowRolesForm
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
            this.dataGridViewEmployeeRoles = new System.Windows.Forms.DataGridView();
            this.textBoxEmployee = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeRoles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dataGridViewEmployeeRoles);
            this.groupBox1.Controls.Add(this.textBoxEmployee);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(419, 277);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee roles data";
            // 
            // dataGridViewEmployeeRoles
            // 
            this.dataGridViewEmployeeRoles.AllowUserToAddRows = false;
            this.dataGridViewEmployeeRoles.AllowUserToDeleteRows = false;
            this.dataGridViewEmployeeRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewEmployeeRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewEmployeeRoles.Location = new System.Drawing.Point(10, 79);
            this.dataGridViewEmployeeRoles.Name = "dataGridViewEmployeeRoles";
            this.dataGridViewEmployeeRoles.ReadOnly = true;
            this.dataGridViewEmployeeRoles.Size = new System.Drawing.Size(403, 192);
            this.dataGridViewEmployeeRoles.TabIndex = 2;
            // 
            // textBoxEmployee
            // 
            this.textBoxEmployee.Enabled = false;
            this.textBoxEmployee.Location = new System.Drawing.Point(81, 28);
            this.textBoxEmployee.Name = "textBoxEmployee";
            this.textBoxEmployee.Size = new System.Drawing.Size(232, 20);
            this.textBoxEmployee.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Employee:";
            // 
            // ShowRolesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(446, 300);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowRolesForm";
            this.Text = "Employee roles";
            this.Load += new System.EventHandler(this.ShowRolesForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployeeRoles)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridViewEmployeeRoles;
        private System.Windows.Forms.TextBox textBoxEmployee;
        private System.Windows.Forms.Label label1;
    }
}