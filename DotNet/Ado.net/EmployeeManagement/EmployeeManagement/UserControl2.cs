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
    public partial class UserControl2 : UserControl
    {
        public UserControl2()
        {
            InitializeComponent();
        }

        private void btnexit2_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void btn3back_Click(object sender, EventArgs e)
        {
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
                    string name = textBox2.Text;
                    string des = textBox3.Text;
                    string qual = textBox4.Text;
                    DateTime date = dateTimePicker1.Value;

                    string updateq = "UPDATE [EmployeeManagement].[dbo].[Employee] SET EmpName='" + name + "',Designation='" + des + "',Qualification='" + qual + "',JoiningDate='" + date + "' WHERE EmployeeID='" + id + "'";
                    try
                    {
                        using (con)
                        {
                            using (SqlCommand commandupdate = new SqlCommand(updateq, con))
                            {
                                commandupdate.ExecuteNonQuery();
                                MessageBox.Show("Successful", "Updated", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Connection to Server Error/User ID exists");
                        Console.WriteLine(ex);
                        MessageBox.Show(ex.ToString());
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show("Connection to Server Error");
                        Console.WriteLine(ex);
                        MessageBox.Show(ex.ToString());
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
            catch(Exception ex)
            {
                MessageBox.Show("Connection to Server Error/User ID exists");
                Console.WriteLine(ex);
                MessageBox.Show(ex.ToString());
            }
            finally
            {
                textBox2.Clear();
                textBox3.Clear();
                textBox4.Clear();
            }

        }
            
    }
    
}
