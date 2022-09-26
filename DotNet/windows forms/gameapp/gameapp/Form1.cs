using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gameapp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAnswer_Click(object sender, EventArgs e)
        {
            int f1;
            int f2;
            int number3;
            int answer;
            

            f1 = int.Parse(tbFirstNumber.Text);
            f2 = int.Parse(tbSecondNumber.Text);
            number3 = int.Parse(tbThirdNumber.Text);
            answer = f1 + f2 + number3;
            if (answer>21)
            {
                MessageBox.Show("YOU HAVE WON THE GAME");
            }
            else
            {
                MessageBox.Show("OOPS! BETTER LUCK NEXT TIME");
            }
            


        }
    }
}
