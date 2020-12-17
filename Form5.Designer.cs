namespace WindowsFormsApp6
{
    partial class Form5
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
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.criteriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.excellentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.goodDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.averageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dissatisfiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.class2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblParticipant = new System.Windows.Forms.Label();
            this.txtCount = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView2
            // 
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.criteriaDataGridViewTextBoxColumn,
            this.excellentDataGridViewTextBoxColumn,
            this.goodDataGridViewTextBoxColumn,
            this.averageDataGridViewTextBoxColumn,
            this.dissatisfiedDataGridViewTextBoxColumn});
            this.dataGridView2.DataSource = this.class2BindingSource;
            this.dataGridView2.Location = new System.Drawing.Point(-2, -1);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(541, 150);
            this.dataGridView2.TabIndex = 0;
            // 
            // criteriaDataGridViewTextBoxColumn
            // 
            this.criteriaDataGridViewTextBoxColumn.DataPropertyName = "Criteria";
            this.criteriaDataGridViewTextBoxColumn.HeaderText = "Criteria";
            this.criteriaDataGridViewTextBoxColumn.Name = "criteriaDataGridViewTextBoxColumn";
            // 
            // excellentDataGridViewTextBoxColumn
            // 
            this.excellentDataGridViewTextBoxColumn.DataPropertyName = "Excellent";
            this.excellentDataGridViewTextBoxColumn.HeaderText = "Excellent";
            this.excellentDataGridViewTextBoxColumn.Name = "excellentDataGridViewTextBoxColumn";
            // 
            // goodDataGridViewTextBoxColumn
            // 
            this.goodDataGridViewTextBoxColumn.DataPropertyName = "Good";
            this.goodDataGridViewTextBoxColumn.HeaderText = "Good";
            this.goodDataGridViewTextBoxColumn.Name = "goodDataGridViewTextBoxColumn";
            // 
            // averageDataGridViewTextBoxColumn
            // 
            this.averageDataGridViewTextBoxColumn.DataPropertyName = "Average";
            this.averageDataGridViewTextBoxColumn.HeaderText = "Average";
            this.averageDataGridViewTextBoxColumn.Name = "averageDataGridViewTextBoxColumn";
            // 
            // dissatisfiedDataGridViewTextBoxColumn
            // 
            this.dissatisfiedDataGridViewTextBoxColumn.DataPropertyName = "Dissatisfied";
            this.dissatisfiedDataGridViewTextBoxColumn.HeaderText = "Dissatisfied";
            this.dissatisfiedDataGridViewTextBoxColumn.Name = "dissatisfiedDataGridViewTextBoxColumn";
            // 
            // class2BindingSource
            // 
            this.class2BindingSource.DataSource = typeof(WindowsFormsApp6.Class2);
            // 
            // lblParticipant
            // 
            this.lblParticipant.AutoSize = true;
            this.lblParticipant.Location = new System.Drawing.Point(13, 174);
            this.lblParticipant.Name = "lblParticipant";
            this.lblParticipant.Size = new System.Drawing.Size(136, 13);
            this.lblParticipant.TabIndex = 1;
            this.lblParticipant.Text = "Total number of participant:";
            // 
            // txtCount
            // 
            this.txtCount.Location = new System.Drawing.Point(155, 171);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(54, 20);
            this.txtCount.TabIndex = 2;
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.lblParticipant);
            this.Controls.Add(this.dataGridView2);
            this.Name = "Form5";
            this.Text = "Dashboard - [Generate report]";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.class2BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn criteriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn excellentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn goodDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn averageDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dissatisfiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource class2BindingSource;
        private System.Windows.Forms.Label lblParticipant;
        private System.Windows.Forms.TextBox txtCount;
    }
}