using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            othersLable.Visible = false;
            othersBox.Visible = false;
            othersBox.Multiline = true;
        }
        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Submit_Click(object sender, EventArgs e)
        {
            string str = " ";

            if (JP.Checked == true)
            { str = str + JP.Text;
            str += " "; 
            }

            if (PH.Checked == true)
            {
                str = str + PH.Text;
                str += " ";
            }

            if (THAI.Checked == true)
            {
                str = str + THAI.Text;
                str += " ";
            }

            if (INDO.Checked == true)
            {
                str = str + INDO.Text;
                str += " ";
            }

            if (others.Checked == true)
            {
                str = str + othersBox.Text;
                str += " ";
            }

            if (str != null)
            {
                MessageBox.Show("You Selected: \n " + str + "\nThank You!", "Survey", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void checkBox4INDO_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void othersBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged_1(object sender, EventArgs e)
        {
            if (others.Checked)
            {
                othersBox.Visible = true;
                othersLable.Visible = true;
            }
            else
            {
                othersBox.Visible = false;
                othersLable.Visible = false;
            }


        }
        private void othersLable_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
