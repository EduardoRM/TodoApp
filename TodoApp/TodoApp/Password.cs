using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TodoApp
{
    public partial class Password : Form
    {
        public Password()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            String sql = "SP_FindPassword";
            string _connectionString = @"Data Source=DESKTOP-NVFPDDO;Initial Catalog=DBTaller;Integrated Security=False;User=admin;Password=123456;Connect Timeout=0";
            SqlConnection conexion = new SqlConnection(_connectionString);
            conexion.Open();
            SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, conexion);
            dataAdapter.SelectCommand.CommandType = CommandType.StoredProcedure;
            dataAdapter.SelectCommand.Parameters.Add("@Username", SqlDbType.Text).Value = textBox1.Text;
           // dataAdapter.SelectCommand.Parameters.Add("@Password", SqlDbType.Text).Value = textBox1.Text;

            dataAdapter.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                String emailUser = dt.Rows[0]["Email"].ToString();
                String password = dt.Rows[0]["Password"].ToString();

                MailMessage email = new MailMessage();
                email.To.Add(new MailAddress(emailUser));
                email.From = new MailAddress("romeromarquez12@gmail.com");
                email.Subject = "Password";
                email.Body = "Su password es "+password;
                email.IsBodyHtml = true;
                email.Priority = MailPriority.Normal;

                SmtpClient smtp = new SmtpClient();
                smtp.Host = "smtp.gmail.com";
                smtp.Port = 587;
                smtp.UseDefaultCredentials = false;
                smtp.EnableSsl = true;
                smtp.Credentials = new NetworkCredential("romeromarquez12@gmail.com", "adentroC13");
                
                string output = null;

                try
                {
                    smtp.Send(email);
                    email.Dispose();
                    MessageBox.Show("Corre electrónico fue enviado satisfactoriamente.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                } 

                Console.WriteLine(output); 
            }
            else
            {
                MessageBox.Show("Usuario incorrecto");
            }
        }
    }
}
