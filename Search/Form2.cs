using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Search
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Connection String  
        string cs = "Data Source=.;Initial Catalog=Test;Integrated Security=true;";
        SqlConnection con;
        SqlDataAdapter adapt;
        DataTable dt;

        //form_Load Event  
        private void form_Load(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Test", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        //TextChanged Event  
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            con = new SqlConnection(cs);
            con.Open();
            adapt = new SqlDataAdapter("select * from Test where Day like '" + textBox1.Text + "%'", con);
            dt = new DataTable();
            adapt.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

    }
}