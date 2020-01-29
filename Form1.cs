using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics; // for showing my URL GITHUB PROFILE

namespace EQUAD
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Make my application exit when I click at button1
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // The maths working in these lines
            double a = Convert.ToDouble(textBox1.Text);
            double b = Convert.ToDouble(textBox2.Text);
            double c = Convert.ToDouble(textBox3.Text);

            if (a != 0)
            {
                double delta = (Math.Pow(b, 2) - (4 * a * c));
                if (delta == 0)
                {
                    double x = -b / (2 * a);
                    MessageBox.Show("There's one solution for you x = " + x);
                }
                else if (delta > 0)
                {
                    double x1 = (-b + Math.Sqrt(delta)) / (2 * a);
                    double x2 = (-b - Math.Sqrt(delta)) / (2 * a);
                    MessageBox.Show("I got two solution are " + x1 + " and " + x2);
                }
                else
                {
                    MessageBox.Show("I didn't found any solution for you :/ ");
                }
            }
            else
            {
                MessageBox.Show("There's an error maybe A VALUE equal zero","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                MessageBox.Show("Please change it value ","Info",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://github.com/farhatizakaria");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormHelp fh = new FormHelp(); // Create a new object from FormHelp()
            fh.Show(); // showing the FormHelp
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DarkButton.Enabled = false; // The user can't enables dark mode cause the dark mode is already enables
            DayButton.Enabled = true; // The user have the ability to use the Day Mode
        }

        private void DayButton_CheckedChanged(object sender, EventArgs e)
        {
            // When the user click at the DayButton
            DarkButton.Enabled = true;
            BackColor = Color.White;
            ForeColor = Color.White;
            DayButton.Enabled = false;

            //Form1 fr1 = new Form1();
            //fr1.BackColor = Color.White;
            //fr1.ForeColor = Color.White;
            //fr1.BackColorChanged == Color.White;
        }

        private void DarkButton_CheckedChanged(object sender, EventArgs e)
        {
            DayButton.Enabled = true;
            BackColor = Color.Black;
            ForeColor = Color.Black;
            DarkButton.Enabled = false;
        }
    }
}
