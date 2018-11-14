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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            InitializeNodeInTreeView();
        }

        public void aggreateNodes(Grupo item)
        {

            if (item.Parent == -1)
            {
                tvGrupos.Nodes.Add("Parent");
            }
            else
            {
               // lookUpNodesChild();
            }
        }

        private void InitializeNodeInTreeView()
        {
            Grupo grupo = new Grupo();
            List<Grupo> list = grupo.retrive();

            foreach (Grupo item in list)
            {
                if (item.Parent == -1)
                {
                   aggreateNodes(item);
                }
            }
        }

        private void btnAgregarNodo_Click(object sender, EventArgs e)
        {
            Class1 conec = new Class1();
            

            FrmGrupo frm = new FrmGrupo();

           

            DialogResult resultado = frm.ShowDialog();
            TreeNode nodoSeleccionado = this.tvGrupos.SelectedNode;

            if (resultado == DialogResult.Yes)
            {
                Grupo grupo = frm.GetGrupo();
                TreeNode nodo = new TreeNode();
                nodo.Text = grupo.Nombre;
                nodo.Tag = grupo;

                if (nodoSeleccionado != null)
                {
                    nodoSeleccionado.Nodes.Add(nodo);
                }
                else
                {
                    //Raiz
                    this.tvGrupos.Nodes.Add(nodo);
                }
            }

            
        }

        

        private void btnAgregarFila_Click(object sender, EventArgs e)
        {
            this.gvTareas.Rows.Add("1", "Realizar marco teorico");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ddlPorcentaje.SelectedIndex = 0;
        }
    }
}
