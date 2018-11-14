using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String sql = "SP_FindUser";
            string _connectionString = @"Data Source=DESKTOP-NVFPDDO;Initial Catalog=DBTaller;Integrated Security=False;User=admin;Password=123456;Connect Timeout=0";
            SqlConnection conexion = new SqlConnection(_connectionString);
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conexion);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("@Username", SqlDbType.Text).Value=textBox2.Text;
            dataAdapter.SelectCommand.Parameters.Add("@Password", SqlDbType.Text).Value=textBox1.Text;

            dataAdapter.Fill(dt);
            if(dt.Rows.Count > 0)
            {
                
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }

            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Password p = new Password();
            p.Show();
        }
    }
}
