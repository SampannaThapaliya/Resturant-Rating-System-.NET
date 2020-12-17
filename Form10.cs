using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp6
{
    public partial class Form10 : Form
    {
        public Form10()
        {
            InitializeComponent();
        }

        private void Form10_Load(object sender, EventArgs e)
        {
            string filePath = @"C:\Users\acer\Downloads\criteria.txt";
            List<string> lines = new List<string>();
            lines = File.ReadAllLines(filePath).ToList();

            int[,] mat = new int[lines.Count, 4];
            string feedbackFilePath =@"C:\Users\acer\Downloads\feedback.txt";
            List<string> l = new List<string>();
            l = File.ReadAllLines(feedbackFilePath).ToList();

            foreach (string v in l)
            {
                string[] dat = v.Split(' ');

                for (int j = 0; j < dat.Length - 3; j++)
                {
                    int i = j;
                    if (dat[j] == "Excellent")
                    {
                        mat[i, 0] = mat[i, 0] + 1;
                    }
                    else if (dat[j] == "Good")
                    {
                        mat[i, 1] = mat[i, 1] + 1;

                    }
                    else if (dat[j] == "Average")
                    {
                        mat[i, 2] = mat[i, 2] + 1;
                    }
                    else if (dat[j] == "Dissatisfied")
                    {
                        mat[i, 3] = mat[i, 3] + 1;
                    }
                }
            }

            for (int i = 0; i < lines.Count; i++)
            {
                this.chart4.Series["Rating Count"].Points.AddXY(lines[i], mat[i, 3]);
            }
        }
    }
}
