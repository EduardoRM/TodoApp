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
using TodoApp.Model;

namespace TodoApp
{
    public partial class CreateUser : Form
    {
        public CreateUser()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CreateUser_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataTable dt = new DataTable();
            String sql = "SP_CreateUser";
            Conexion c = new Conexion();
            SqlCommand command = new SqlCommand(sql, c.conectOpen());
            command.CommandType = CommandType.StoredProcedure;
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.Add("@Username", SqlDbType.Text).Value = textBox1.Text;
            command.Parameters.Add("@Password", SqlDbType.Text).Value = textBox2.Text;
            command.Parameters.Add("@Email", SqlDbType.Text).Value = textBox3.Text;
            command.Parameters.Add("@PrimerNombre", SqlDbType.Text).Value = textBox4.Text;
            command.Parameters.Add("@SegundoNombre", SqlDbType.Text).Value = textBox5.Text;
            command.Parameters.Add("@PrimerApellido", SqlDbType.Text).Value = textBox6.Text;
            command.Parameters.Add("@SegundoApellido", SqlDbType.Text).Value = textBox7.Text;
            // dataAdapter.SelectCommand.Parameters.Add("@Password", SqlDbType.Text).Value = textBox1.Text;

            command.ExecuteNonQuery();


        }
    }
}
