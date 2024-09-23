using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace timesTable
// created by Mupira Nigel 10/03/2024 0154hrs
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            // setting form initial position to the very center of the screen
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // accepting user input for timetable number
            int num = Convert.ToInt32(textBox1.Text);

            // error handling for negative timetable number
            if (num <= 0)
            {
                MessageBox.Show("The times table number must be positive.");
                return;
            }

            // determining starting and end point of timetable from input
            int start_num = Convert.ToInt32(textBox2.Text);
            int end_num = Convert.ToInt32(textBox3.Text);

            // ensuring that starting point is lower than the end point
            if (start_num >= end_num)
            {
                MessageBox.Show("Please enter a valid range for the starting and ending number.");
                return;
            }

            // clearing list box before displaying timetable
            listBox1.Items.Clear();
            // opening statement
            listBox1.Items.Add("Timetable for " + num + " from " + start_num + " to " + end_num + " :");
            // empty line between opening statement and timetable
            listBox1.Items.Add(" ");

            // the loop that calculates and displays our timetable
            for (int i = start_num; i <= end_num; i++)
            {
                listBox1.Items.Add(i + " X " + num + " = " + i * num);
            }

            // empty line between timetable and closing statement
            listBox1.Items.Add(" ");
            // closing statement
            listBox1.Items.Add("====== End of timetable ======");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //adding a button to close the form window
            this.Close();
        }
    }
}
