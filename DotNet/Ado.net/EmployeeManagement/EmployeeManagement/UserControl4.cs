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
    public partial class UserControl4 : UserControl
    {
        public UserControl4()
        {
            InitializeComponent();
        }

        private void btn3back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnexit2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btnsub2_Click(object sender, EventArgs e)
        {
            int count = 0;
            try
            {
                SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=EmployeeManagement;Integrated Security=True;MultipleActiveResultSets=true");
                con.Open();
                string id = textBox1.Text;
                using (SqlCommand check = new SqlCommand("SELECT EmployeeID FROM Employee WHERE EmployeeID='" + id + "'", con))
                {
                    try
                    {
                        count = Convert.ToInt32(check.ExecuteScalar());
                    }
                    catch (NullReferenceException ex)
                    {
                        count = 0;
                        MessageBox.Show("Connection to Server Error/User ID does not exists");
                        Console.WriteLine(ex);
                        MessageBox.Show(ex.ToString());

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection to Server Error/User ID does not exists");
                        Console.WriteLine(ex);
                        MessageBox.Show(ex.ToString());
                    }


                }
                if (count > 0)
                {
                }

                else
                {
                    MessageBox.Show("User ID does not exists");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to Server Error/User ID exists");
                Console.WriteLine(ex);
                MessageBox.Show(ex.ToString());
            }
        }
    }
}

