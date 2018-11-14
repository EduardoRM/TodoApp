namespace TodoApp
{
    partial class main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.treeViewGroup = new System.Windows.Forms.TreeView();
            this.add = new System.Windows.Forms.Button();
            this.del = new System.Windows.Forms.Button();
            this.textGroup = new System.Windows.Forms.TextBox();
            this.lblgroup = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblgroup);
            this.panel1.Controls.Add(this.textGroup);
            this.panel1.Controls.Add(this.del);
            this.panel1.Controls.Add(this.add);
            this.panel1.Controls.Add(this.treeViewGroup);
            this.panel1.Location = new System.Drawing.Point(5, 6);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(772, 432);
            this.panel1.TabIndex = 0;
            // 
            // treeViewGroup
            // 
            this.treeViewGroup.Location = new System.Drawing.Point(7, 99);
            this.treeViewGroup.Name = "treeViewGroup";
            this.treeViewGroup.Size = new System.Drawing.Size(216, 330);
            this.treeViewGroup.TabIndex = 0;
            this.treeViewGroup.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // add
            // 
            this.add.Image = global::TodoApp.Properties.Resources.if_plus_1646001;
            this.add.Location = new System.Drawing.Point(49, 42);
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(77, 33);
            this.add.TabIndex = 1;
            this.add.UseVisualStyleBackColor = true;
            this.add.Click += new System.EventHandler(this.add_Click);
            // 
            // del
            // 
            this.del.Location = new System.Drawing.Point(145, 42);
            this.del.Name = "del";
            this.del.Size = new System.Drawing.Size(78, 33);
            this.del.TabIndex = 2;
            this.del.UseVisualStyleBackColor = true;
            // 
            // textGroup
            // 
            this.textGroup.Location = new System.Drawing.Point(49, 16);
            this.textGroup.Name = "textGroup";
            this.textGroup.Size = new System.Drawing.Size(174, 20);
            this.textGroup.TabIndex = 3;
            // 
            // lblgroup
            // 
            this.lblgroup.AutoSize = true;
            this.lblgroup.Location = new System.Drawing.Point(7, 19);
            this.lblgroup.Name = "lblgroup";
            this.lblgroup.Size = new System.Drawing.Size(36, 13);
            this.lblgroup.TabIndex = 4;
            this.lblgroup.Text = "Group";
            // 
            // main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Name = "main";
            this.Text = "main";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TreeView treeViewGroup;
        private System.Windows.Forms.Button del;
        private System.Windows.Forms.Button add;
        private System.Windows.Forms.Label lblgroup;
        private System.Windows.Forms.TextBox textGroup;
    }
}