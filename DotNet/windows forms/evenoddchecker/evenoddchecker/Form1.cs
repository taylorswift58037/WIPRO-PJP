using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace evenoddchecker
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void CLICK_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            if (n % 2 == 0)
            {
                label2.Text = "This number is even";
            }
            else
            {
                label2.Text = "This number is odd";
            }
        }
    }
}
