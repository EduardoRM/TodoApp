using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TodoApp.Model;

namespace TodoApp
{
    public partial class main : Form
    {
        List<Grupo> list;
        public main()
        {
            InitializeComponent();
            Grupo grupo = new Grupo();
            list = grupo.retrive();
            InitializeNodeInTreeView(list);
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }



        private Grupo lookUpNodesChild(Grupo i)
        {
            foreach (Grupo it in this.list)
            {
                if (i.IdGrupo == it.IdGrupo)
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
                TreeNode p = treeViewGroup.Nodes.Add(item.Nombre);
                if (item.childs != null)
                {
                    foreach (Grupo i in item.childs)
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

        private void add_Click(object sender, EventArgs e)
        {
            //treeViewGroup

            TreeNode nodoSeleccionado = this.treeViewGroup.SelectedNode;
            TreeNode nodo = new TreeNode();
            nodo.Text = this.textGroup.Text;
               
            if (nodoSeleccionado != null)
            {
                nodoSeleccionado.Nodes.Add(nodo);
            }
            else
            {
                //Raiz
                this.treeViewGroup.Nodes.Add(nodo);
            }
        }
    }
}
