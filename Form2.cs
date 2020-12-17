using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void addCriteriaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\acer\Downloads\criteria.txt";
            List<string> lines = new List<string>();

            // Checking the existence of the specified file
            if (File.Exists(filePath))
            {
                Form3 frm = new Form3();
                frm.MdiParent = this;
                frm.Show();
                frm.Activate();
            }
            else
            {
                MessageBox.Show("The file criteria.txt does not exist");
            }
        }

        private void enterFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\acer\Downloads\criteria.txt";
            string feedbackFilePath = @"C:\Users\acer\Downloads\feedback.txt";

            if (File.Exists(filePath)) 
            {
                if (new FileInfo(filePath).Length == 0)
                {
                    MessageBox.Show("No criteria has been recorded yet");
                }
                else
                {
                    if (File.Exists(feedbackFilePath))
                    {
                        Form4 frm = new Form4();
                        frm.MdiParent = this;
                        frm.Show();
                        frm.Activate();
                    }
                    else
                    {
                        MessageBox.Show("The file feedback.txt does not exist");
                    }
                }
            }
            else
            {
                MessageBox.Show("The file criteria.txt does not exist"); 
            }
        }

        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\acer\Downloads\criteria.txt";
            string feedbackFilePath = @"C:\Users\acer\Downloads\feedback.txt";

            if (File.Exists(filePath))
            {
                if (new FileInfo(filePath).Length == 0)
                {
                    MessageBox.Show("No criteria has been recorded yet");
                }
                else
                {
                    if (File.Exists(feedbackFilePath))
                    {
                        if (new FileInfo(feedbackFilePath).Length == 0)
                        {
                            MessageBox.Show("No feedback has been recorded yet");
                        }
                        else 
                        {
                            Form5 frm = new Form5();
                            frm.MdiParent = this;
                            frm.Show();
                            frm.Activate();
                        }  
                    }
                    else
                    {
                        MessageBox.Show("The file feedback.txt does not exist");
                    }
                }
            }
            else
            {
                MessageBox.Show("The file criteria.txt does not exist");
            }
        }

        private void generateChartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filePath = @"E:\criteria.txt";
            string feedbackFilePath = @"C:\Users\acer\Downloads\feedback.txt";

            if (File.Exists(filePath))
            {
                if (new FileInfo(filePath).Length == 0)
                {
                    MessageBox.Show("No criteria has been recorded yet");
                }
                else
                {
                    if (File.Exists(feedbackFilePath))
                    {
                        if (new FileInfo(feedbackFilePath).Length == 0)
                        {
                            MessageBox.Show("No feedback has been recorded yet");
                        }
                        else
                        {
                            Form6 frm = new Form6();
                            frm.MdiParent = this;
                            frm.Show();
                            frm.Activate();
                        }
                    }
                    else
                    {
                        MessageBox.Show("The file feedback.txt does not exist");
                    }
                }
            }
            else
            {
                MessageBox.Show("The file criteria.txt does not exist");
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
