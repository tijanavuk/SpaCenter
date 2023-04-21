namespace Client
{
    partial class ShowEmployee
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
            this.buttonShowRoles = new System.Windows.Forms.Button();
            this.buttonAddRole = new System.Windows.Forms.Button();
            this.buttonDeactive = new System.Windows.Forms.Button();
            this.dateTimeTermination = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimeOfEmployment = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.buttonEditService = new System.Windows.Forms.Button();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.CategoryLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.checkBoxTerminationDate = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.checkBoxTerminationDate);
            this.groupBox1.Controls.Add(this.buttonShowRoles);
            this.groupBox1.Controls.Add(this.buttonAddRole);
            this.groupBox1.Controls.Add(this.buttonDeactive);
            this.groupBox1.Controls.Add(this.dateTimeTermination);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.dateTimeOfEmployment);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textBoxLastName);
            this.groupBox1.Controls.Add(this.buttonEditService);
            this.groupBox1.Controls.Add(this.textBoxFirstName);
            this.groupBox1.Controls.Add(this.textBoxPassword);
            this.groupBox1.Controls.Add(this.textBoxUsername);
            this.groupBox1.Controls.Add(this.CategoryLabel);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(393, 326);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employee data";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // buttonShowRoles
            // 
            this.buttonShowRoles.Location = new System.Drawing.Point(26, 294);
            this.buttonShowRoles.Name = "buttonShowRoles";
            this.buttonShowRoles.Size = new System.Drawing.Size(75, 23);
            this.buttonShowRoles.TabIndex = 17;
            this.buttonShowRoles.Text = "Show roles";
            this.buttonShowRoles.UseVisualStyleBackColor = true;
            this.buttonShowRoles.Click += new System.EventHandler(this.buttonShowRoles_Click);
            // 
            // buttonAddRole
            // 
            this.buttonAddRole.Location = new System.Drawing.Point(121, 294);
            this.buttonAddRole.Name = "buttonAddRole";
            this.buttonAddRole.Size = new System.Drawing.Size(75, 23);
            this.buttonAddRole.TabIndex = 16;
            this.buttonAddRole.Text = "Add role";
            this.buttonAddRole.UseVisualStyleBackColor = true;
            this.buttonAddRole.Click += new System.EventHandler(this.buttonAddRole_Click);
            // 
            // buttonDeactive
            // 
            this.buttonDeactive.Location = new System.Drawing.Point(213, 294);
            this.buttonDeactive.Name = "buttonDeactive";
            this.buttonDeactive.Size = new System.Drawing.Size(70, 23);
            this.buttonDeactive.TabIndex = 15;
            this.buttonDeactive.Text = "Delete";
            this.buttonDeactive.UseVisualStyleBackColor = true;
            this.buttonDeactive.Click += new System.EventHandler(this.buttonDeactive_Click);
            // 
            // dateTimeTermination
            // 
            this.dateTimeTermination.Location = new System.Drawing.Point(138, 245);
            this.dateTimeTermination.Name = "dateTimeTermination";
            this.dateTimeTermination.Size = new System.Drawing.Size(237, 20);
            this.dateTimeTermination.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(23, 251);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Termination date:";
            // 
            // dateTimeOfEmployment
            // 
            this.dateTimeOfEmployment.Location = new System.Drawing.Point(138, 189);
            this.dateTimeOfEmployment.Name = "dateTimeOfEmployment";
            this.dateTimeOfEmployment.Size = new System.Drawing.Size(237, 20);
            this.dateTimeOfEmployment.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(104, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Date of employment:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(23, 201);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 10;
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(138, 154);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(237, 20);
            this.textBoxLastName.TabIndex = 9;
            // 
            // buttonEditService
            // 
            this.buttonEditService.Location = new System.Drawing.Point(299, 294);
            this.buttonEditService.Name = "buttonEditService";
            this.buttonEditService.Size = new System.Drawing.Size(76, 23);
            this.buttonEditService.TabIndex = 8;
            this.buttonEditService.Text = "Edit";
            this.buttonEditService.UseVisualStyleBackColor = true;
            this.buttonEditService.Click += new System.EventHandler(this.buttonEditService_Click);
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(138, 117);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(237, 20);
            this.textBoxFirstName.TabIndex = 7;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(138, 78);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(237, 20);
            this.textBoxPassword.TabIndex = 6;
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(138, 40);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(237, 20);
            this.textBoxUsername.TabIndex = 5;
            // 
            // CategoryLabel
            // 
            this.CategoryLabel.AutoSize = true;
            this.CategoryLabel.Location = new System.Drawing.Point(23, 157);
            this.CategoryLabel.Name = "CategoryLabel";
            this.CategoryLabel.Size = new System.Drawing.Size(59, 13);
            this.CategoryLabel.TabIndex = 4;
            this.CategoryLabel.Text = "Last name:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(23, 120);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "First name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // checkBoxTerminationDate
            // 
            this.checkBoxTerminationDate.AutoSize = true;
            this.checkBoxTerminationDate.Location = new System.Drawing.Point(26, 222);
            this.checkBoxTerminationDate.Name = "checkBoxTerminationDate";
            this.checkBoxTerminationDate.Size = new System.Drawing.Size(199, 17);
            this.checkBoxTerminationDate.TabIndex = 18;
            this.checkBoxTerminationDate.Text = "Do you want to set termination date?";
            this.checkBoxTerminationDate.UseVisualStyleBackColor = true;
            this.checkBoxTerminationDate.Visible = false;
            this.checkBoxTerminationDate.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ShowEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(405, 335);
            this.Controls.Add(this.groupBox1);
            this.Name = "ShowEmployee";
            this.Text = "ShowEmployee";
            this.Load += new System.EventHandler(this.ShowEmployee_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dateTimeTermination;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimeOfEmployment;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxLastName;
        private System.Windows.Forms.Button buttonEditService;
        private System.Windows.Forms.TextBox textBoxFirstName;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label CategoryLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonDeactive;
        private System.Windows.Forms.Button buttonShowRoles;
        private System.Windows.Forms.Button buttonAddRole;
        private System.Windows.Forms.CheckBox checkBoxTerminationDate;
    }
}