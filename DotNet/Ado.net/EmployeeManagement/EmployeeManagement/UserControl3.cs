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
    public partial class UserControl3 : UserControl
    {
        public UserControl3()
        {
            InitializeComponent();
        }

        private void btnexit2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn3back_Click(object sender, EventArgs e)
        {
            textBox10.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox1.Clear();
            this.Hide();
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
                        textBox2.Clear();
                        textBox3.Clear();
                        textBox4.Clear();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection to Server Error/User ID does not exists");
                        Console.WriteLine(ex);
                        MessageBox.Show(ex.ToString());
                        this.Hide();
                    }


                }
                if (count > 0)
                {
                    SqlCommand searchq = new SqlCommand("SELECT [EmpName],[Designation],[Qualification],[JoiningDate] FROM[EmployeeManagement].[dbo].[Employee] WHERE EmployeeID = '"+id+"'", con);
                    using(SqlDataReader reader=searchq.ExecuteReader())
                    {
                        while(reader.Read())
                        {
                            textBox2.Text=reader["EmpName"].ToString();
                            textBox3.Text = reader["Designation"].ToString();
                            textBox4.Text = reader["Qualification"].ToString();
                            textBox10.Text = reader["JoiningDate"].ToString();

                        }
                    }
                }
                else
                {
                    MessageBox.Show("User ID does not exists");
                    textBox2.Clear();
                    textBox3.Clear();
                    textBox4.Clear();
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
