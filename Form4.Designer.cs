namespace WindowsFormsApp6
{
    partial class Form4
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
            this.components = new System.ComponentModel.Container();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.criteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excellentDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.goodDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.averageDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dissatisfiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.class1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.criteriaDataGridViewTextBoxColumn,
            this.excellentDataGridViewCheckBoxColumn,
            this.goodDataGridViewCheckBoxColumn,
            this.averageDataGridViewCheckBoxColumn,
            this.dissatisfiedDataGridViewCheckBoxColumn});
            this.dataGridView1.DataSource = this.class1BindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(-1, -3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(542, 239);
            this.dataGridView1.TabIndex = 0;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 256);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 1;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // criteriaDataGridViewTextBoxColumn
            // 
            this.criteriaDataGridViewTextBoxColumn.DataPropertyName = "Criteria";
            this.criteriaDataGridViewTextBoxColumn.HeaderText = "Criteria";
            this.criteriaDataGridViewTextBoxColumn.Name = "criteriaDataGridViewTextBoxColumn";
            // 
            // excellentDataGridViewCheckBoxColumn
            // 
            this.excellentDataGridViewCheckBoxColumn.DataPropertyName = "Excellent";
            this.excellentDataGridViewCheckBoxColumn.HeaderText = "Excellent";
            this.excellentDataGridViewCheckBoxColumn.Name = "excellentDataGridViewCheckBoxColumn";
            // 
            // goodDataGridViewCheckBoxColumn
            // 
            this.goodDataGridViewCheckBoxColumn.DataPropertyName = "Good";
            this.goodDataGridViewCheckBoxColumn.HeaderText = "Good";
            this.goodDataGridViewCheckBoxColumn.Name = "goodDataGridViewCheckBoxColumn";
            // 
            // averageDataGridViewCheckBoxColumn
            // 
            this.averageDataGridViewCheckBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewCheckBoxColumn.HeaderText = "Average";
            this.averageDataGridViewCheckBoxColumn.Name = "averageDataGridViewCheckBoxColumn";
            // 
            // dissatisfiedDataGridViewCheckBoxColumn
            // 
            this.dissatisfiedDataGridViewCheckBoxColumn.DataPropertyName = "Dissatisfied";
            this.dissatisfiedDataGridViewCheckBoxColumn.HeaderText = "Dissatisfied";
            this.dissatisfiedDataGridViewCheckBoxColumn.Name = "dissatisfiedDataGridViewCheckBoxColumn";
            // 
            // class1BindingSource
            // 
            this.class1BindingSource.DataSource = typeof(WindowsFormsApp6.Class1);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form4";
            this.Text = "Dashboard - [Enter feedback]";
            this.Load += new System.EventHandler(this.Form4_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class1BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn criteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn excellentDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn goodDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn averageDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dissatisfiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.BindingSource class1BindingSource;
        private System.Windows.Forms.Button btnSubmit;
    }
}