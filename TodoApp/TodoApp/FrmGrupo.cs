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
    public partial class FrmGrupo : Form
    {
        public FrmGrupo()
        {
            InitializeComponent();
        }

        public Grupo GetGrupo()
        {
            return new Grupo() { Nombre = this.textBox1.Text};
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
