using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true");
        public Form1()
        {
            InitializeComponent();

            try
            {
                con.Open();
                MessageBox.Show("Connected","" ,MessageBoxButtons.OK,MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Error");
            }
            finally
            {
                con.Close(); 
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl11.Show();
            userControl11.BringToFront();
        }

        private void btn3back_Click(object sender, EventArgs e)
        {

        }

        private void btnsub2_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Hide();
        }

        private void userControl41_Load(object sender, EventArgs e)
        {

        }

        private void btn2update_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl31.Hide();
            userControl41.Hide();
            userControl21.Show();
            userControl21.BringToFront();
        }

        private void btn3delete_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl31.Hide();
            userControl41.Show();
            userControl41.BringToFront();
        }

        private void btn4search_Click(object sender, EventArgs e)
        {
            userControl11.Hide();
            userControl21.Hide();
            userControl41.Hide();
            userControl31.Show();
            userControl31.BringToFront();
        }

        private void userControl11_Load(object sender, EventArgs e)
        {

        }

        private void exit1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
