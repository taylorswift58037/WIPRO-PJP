using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exersice_7
{
    public partial class Form1 : Form
    {
        ArrayList a = new ArrayList();
        ArrayList b1 = new ArrayList();
        
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            b1.Add("Finance");
            b1.Add("Production");
            b1.Add("HR");
            b1.Add("IT");
            b1.Add("Transport");
            int t = int.Parse(textBox2.Text);
            if (a.Contains(t))
            {
                MessageBox.Show("Enter a unique id", "Warning", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else {
                a.Add(t);
                MessageBox.Show("Number is added","NumberAdded",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
            if (textBox1.Text == "") {
                MessageBox.Show("Name Should not be empty","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            int Currentyear = 2020;
            int enteredyear = int.Parse(textBox3.Text);
            if (enteredyear > Currentyear)
            {
                MessageBox.Show("Joining year cannot be greater than current year","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            string dep = textBox4.Text;
            if (b1.Contains(dep))
            {
            }
            else {
                MessageBox.Show("The department is not in the list", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            long salary = long.Parse(textBox5.Text);
            if (salary < 50000000 && salary > 100000)
            {

            }
            else {
                MessageBox.Show("Salary Should be between 100000 and 50000000", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
