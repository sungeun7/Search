using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;

namespace DataGridView_CS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = this.PopulateDataGridView();
        }

        private void txtName_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridView1.DataSource = this.PopulateDataGridView();
        }

        private DataTable PopulateDataGridView()
        {
            string query = "SELECT CustomerID, ContactName, Country FROM Customers";
            query += " WHERE ContactName LIKE '%' + @ContactName + '%'";
            query += " OR @ContactName = ''";
            string constr = @"Data Source=.\SQL2005;Initial Catalog=Northwind;User ID=sa;Password=pass@123";
            using (SqlConnection con = new SqlConnection(constr))
            {
                using (SqlCommand cmd = new SqlCommand(query, con))
                {
                    cmd.Parameters.AddWithValue("@ContactName", txtName.Text.Trim());
                    using (SqlDataAdapter sda = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sda.Fill(dt);
                        return dt;
                    }
                }
            }
        }
    }
}
