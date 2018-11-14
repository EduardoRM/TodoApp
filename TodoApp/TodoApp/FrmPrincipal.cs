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
        List<Grupo> list;
        public Form1()
        {
            InitializeComponent();

            Grupo grupo = new Grupo();
            list = grupo.retrive();
            InitializeNodeInTreeView(list);
        }


        private Grupo lookUpNodesChild(Grupo i)
        {
            foreach(Grupo it in this.list)
            {
                if(i.IdGrupo == it.IdGrupo)
                {
                    return it;
                }
            }
            return null;
        }


        private void aggreateNodes(Grupo item, TreeNode parent)
        {

            if (item.Parent == -1)
            {
                TreeNode p = tvGrupos.Nodes.Add(item.Nombre);
                if(item.childs != null)
                {
                    foreach(Grupo i in item.childs)
                    {
                        Grupo e = lookUpNodesChild(i);
                        if (e != null)
                            aggreateNodes(e, p);
                    }
                    
                }
            }
            else
            {
                TreeNode pi = parent.Nodes.Add(item.Nombre);
                if (item.childs != null)
                {
                    foreach (Grupo i in item.childs)
                    {
                        Grupo j = lookUpNodesChild(i);
                        if (j != null)
                            aggreateNodes(j, pi);
                    }

                }
                // lookUpNodesChild();
            }
        }

        private void InitializeNodeInTreeView(List<Grupo> list)
        {
            foreach (Grupo item in list)
            {
                if (item.Parent == -1)
                {
                   aggreateNodes(item, null);
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
