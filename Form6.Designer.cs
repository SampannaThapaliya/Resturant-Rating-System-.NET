namespace WindowsFormsApp6
{
    partial class Form6
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
            this.lblScore = new System.Windows.Forms.Label();
            this.cmbScore = new System.Windows.Forms.ComboBox();
            this.btnDisplay = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(24, 39);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(35, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score";
            // 
            // cmbScore
            // 
            this.cmbScore.FormattingEnabled = true;
            this.cmbScore.Items.AddRange(new object[] {
            "Excellent",
            "Good",
            "Average",
            "Dissatisfied"});
            this.cmbScore.Location = new System.Drawing.Point(82, 36);
            this.cmbScore.Name = "cmbScore";
            this.cmbScore.Size = new System.Drawing.Size(145, 21);
            this.cmbScore.TabIndex = 1;
            this.cmbScore.SelectedIndexChanged += new System.EventHandler(this.cmbScore_SelectedIndexChanged);
            // 
            // btnDisplay
            // 
            this.btnDisplay.Location = new System.Drawing.Point(27, 88);
            this.btnDisplay.Name = "btnDisplay";
            this.btnDisplay.Size = new System.Drawing.Size(107, 23);
            this.btnDisplay.TabIndex = 2;
            this.btnDisplay.Text = "Display chart";
            this.btnDisplay.UseVisualStyleBackColor = true;
            this.btnDisplay.Click += new System.EventHandler(this.btnDisplay_Click);
            // 
            // Form7
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 433);
            this.Controls.Add(this.btnDisplay);
            this.Controls.Add(this.cmbScore);
            this.Controls.Add(this.lblScore);
            this.Name = "Form7";
            this.Text = "Dashboard - [Generate chart]";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.ComboBox cmbScore;
        private System.Windows.Forms.Button btnDisplay;
    }
}