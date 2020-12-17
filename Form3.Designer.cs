namespace WindowsFormsApp6
{
    partial class Form3
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
            this.lblCriteria = new System.Windows.Forms.Label();
            this.lblEnterCriteria = new System.Windows.Forms.Label();
            this.txtEnterCriteria = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblExistingCriteria = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lblCriteria
            // 
            this.lblCriteria.AutoSize = true;
            this.lblCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriteria.Location = new System.Drawing.Point(35, 9);
            this.lblCriteria.Name = "lblCriteria";
            this.lblCriteria.Size = new System.Drawing.Size(76, 24);
            this.lblCriteria.TabIndex = 0;
            this.lblCriteria.Text = "Criteria";
            // 
            // lblEnterCriteria
            // 
            this.lblEnterCriteria.AutoSize = true;
            this.lblEnterCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEnterCriteria.Location = new System.Drawing.Point(36, 74);
            this.lblEnterCriteria.Name = "lblEnterCriteria";
            this.lblEnterCriteria.Size = new System.Drawing.Size(112, 16);
            this.lblEnterCriteria.TabIndex = 1;
            this.lblEnterCriteria.Text = "Enter new criteria:";
            // 
            // txtEnterCriteria
            // 
            this.txtEnterCriteria.Location = new System.Drawing.Point(154, 74);
            this.txtEnterCriteria.Name = "txtEnterCriteria";
            this.txtEnterCriteria.Size = new System.Drawing.Size(188, 20);
            this.txtEnterCriteria.TabIndex = 2;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(359, 74);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(59, 20);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblExistingCriteria
            // 
            this.lblExistingCriteria.AutoSize = true;
            this.lblExistingCriteria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExistingCriteria.Location = new System.Drawing.Point(495, 78);
            this.lblExistingCriteria.Name = "lblExistingCriteria";
            this.lblExistingCriteria.Size = new System.Drawing.Size(97, 16);
            this.lblExistingCriteria.TabIndex = 4;
            this.lblExistingCriteria.Text = "Existing criteria";
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(498, 97);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(206, 264);
            this.listBox1.TabIndex = 5;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.lblExistingCriteria);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txtEnterCriteria);
            this.Controls.Add(this.lblEnterCriteria);
            this.Controls.Add(this.lblCriteria);
            this.Name = "Form3";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Dashboard - [Add criteria]";
            this.Load += new System.EventHandler(this.Form3_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCriteria;
        private System.Windows.Forms.Label lblEnterCriteria;
        private System.Windows.Forms.TextBox txtEnterCriteria;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblExistingCriteria;
        private System.Windows.Forms.ListBox listBox1;
    }
}