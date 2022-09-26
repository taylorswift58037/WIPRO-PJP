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

namespace Northwind
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=Northwind;Integrated Security=True");
            
            SqlCommand com = new SqlCommand("SELECT [FirstName] FROM [Northwind].[dbo].[Employees]", con);
            try
            {
                con.Open();
                using(SqlDataReader reader =com.ExecuteReader())
                {
                    while(reader.Read())
                    {
                        listBox1.Items.Add(reader["FirstName"].ToString());
                    }
                }

            }
            catch(Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }

        }
    }
}
