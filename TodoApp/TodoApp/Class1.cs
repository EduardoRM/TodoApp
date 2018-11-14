using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoApp
{
    class Class1
    {
        public Boolean conexionDB()
        {
            SqlConnection conexion = new SqlConnection("server=DESKTOP-NVFPDDO ; database=DBTaller ; integrated security = true");
            conexion.Open();
            return true;
        }
    }
}
