namespace Client
{
    partial class SearchLoyalty
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
            this.buttonShowLoyalty = new System.Windows.Forms.Button();
            this.dataGridViewLoyalty = new System.Windows.Forms.DataGridView();
            this.buttonSearchLoyalty = new System.Windows.Forms.Button();
            this.textBoxSearchLoyalty = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoyalty)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonShowLoyalty
            // 
            this.buttonShowLoyalty.Location = new System.Drawing.Point(494, 311);
            this.buttonShowLoyalty.Name = "buttonShowLoyalty";
            this.buttonShowLoyalty.Size = new System.Drawing.Size(138, 23);
            this.buttonShowLoyalty.TabIndex = 19;
            this.buttonShowLoyalty.Text = "Show loyalty";
            this.buttonShowLoyalty.UseVisualStyleBackColor = true;
            this.buttonShowLoyalty.Click += new System.EventHandler(this.buttonShowLoyalty_Click);
            // 
            // dataGridViewLoyalty
            // 
            this.dataGridViewLoyalty.AllowUserToAddRows = false;
            this.dataGridViewLoyalty.AllowUserToDeleteRows = false;
            this.dataGridViewLoyalty.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewLoyalty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLoyalty.Location = new System.Drawing.Point(6, 128);
            this.dataGridViewLoyalty.Name = "dataGridViewLoyalty";
            this.dataGridViewLoyalty.ReadOnly = true;
            this.dataGridViewLoyalty.Size = new System.Drawing.Size(626, 165);
            this.dataGridViewLoyalty.TabIndex = 18;
            // 
            // buttonSearchLoyalty
            // 
            this.buttonSearchLoyalty.Location = new System.Drawing.Point(233, 77);
            this.buttonSearchLoyalty.Name = "buttonSearchLoyalty";
            this.buttonSearchLoyalty.Size = new System.Drawing.Size(115, 23);
            this.buttonSearchLoyalty.TabIndex = 17;
            this.buttonSearchLoyalty.Text = "Find loyalties";
            this.buttonSearchLoyalty.UseVisualStyleBackColor = true;
            this.buttonSearchLoyalty.Click += new System.EventHandler(this.buttonSearchLoyalty_Click);
            // 
            // textBoxSearchLoyalty
            // 
            this.textBoxSearchLoyalty.Location = new System.Drawing.Point(143, 35);
            this.textBoxSearchLoyalty.Name = "textBoxSearchLoyalty";
            this.textBoxSearchLoyalty.Size = new System.Drawing.Size(331, 20);
            this.textBoxSearchLoyalty.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(251, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Enter part of name:";
            // 
            // SearchLoyalty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(641, 341);
            this.Controls.Add(this.buttonShowLoyalty);
            this.Controls.Add(this.dataGridViewLoyalty);
            this.Controls.Add(this.buttonSearchLoyalty);
            this.Controls.Add(this.textBoxSearchLoyalty);
            this.Controls.Add(this.label1);
            this.Name = "SearchLoyalty";
            this.Text = "SearchLoyalty";
            this.Load += new System.EventHandler(this.SearchLoyalty_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLoyalty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonShowLoyalty;
        private System.Windows.Forms.DataGridView dataGridViewLoyalty;
        private System.Windows.Forms.Button buttonSearchLoyalty;
        private System.Windows.Forms.TextBox textBoxSearchLoyalty;
        private System.Windows.Forms.Label label1;
    }
}