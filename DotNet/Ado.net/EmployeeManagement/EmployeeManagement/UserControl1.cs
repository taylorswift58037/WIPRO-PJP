using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EmployeeManagement
{
    public partial class UserControl1 : UserControl
    {
         SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true");
        public UserControl1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
       
        private void btnsub2_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true");
            string id = textBox1.Text;
            string name = textBox2.Text;
            string des = textBox3.Text;
            string qual = textBox4.Text;
            DateTime date = dateTimePicker1.Value;
            string queryinsert = "INSERT INTO Employee (EmployeeID,EmpName,Designation,Qualification,JoiningDate) " +
                    "Values('" + id + "', '" + name + "', '" + des + "', '" + qual + "', '" + date + "')";

            try
            {

                // SqlCommand check = new  SqlCommand("SELECT case when EmpName='Muhilan' then 1 else 0 end as ans FROM [EmployeeManagement].[dbo].[Employee]",con);
                con.Open();
                using (con)
                {
                    using (SqlCommand commandinsert = new SqlCommand(queryinsert, con))
                    {
                        commandinsert.ExecuteNonQuery();
                        MessageBox.Show("Successful", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Error/User ID exists");
                Console.WriteLine(ex);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();

            }
        }

        private void btn3back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnexit2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
    }
}
