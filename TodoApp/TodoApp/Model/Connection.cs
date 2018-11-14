using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp.Model
{
    class Connection
    {
        public SqlConnection conectOpen()
        {
            string _connectionString = @"Data Source=DESKTOP-NVFPDDO;Initial Catalog=DBTaller;Integrated Security=False;User=admin;Password=123456;Connect Timeout=0";
            SqlConnection conexion = new SqlConnection(_connectionString);
            conexion.Open();
            return conexion;
        } 
    }
}
