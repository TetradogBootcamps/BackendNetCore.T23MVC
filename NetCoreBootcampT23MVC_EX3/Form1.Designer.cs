
namespace NetCoreBootcampT23MVC_EX3
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            NetCoreBootcampT23MVC_EX3.Context context1 = new NetCoreBootcampT23MVC_EX3.Context();
            NetCoreBootcampT23MVC_EX3.Context context2 = new NetCoreBootcampT23MVC_EX3.Context();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tbCientificos = new System.Windows.Forms.TabPage();
            this.editorCientificos = new NetCoreBootcampT23MVC_EX3.Controls.EditorCientificos();
            this.tbProyectos = new System.Windows.Forms.TabPage();
            this.editorProyectos = new NetCoreBootcampT23MVC_EX3.Controls.EditorProyectos();
            this.tbAsignadoAs = new System.Windows.Forms.TabPage();
            this.tabControl1.SuspendLayout();
            this.tbCientificos.SuspendLayout();
            this.tbProyectos.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tbCientificos);
            this.tabControl1.Controls.Add(this.tbProyectos);
            this.tabControl1.Controls.Add(this.tbAsignadoAs);
            this.tabControl1.Location = new System.Drawing.Point(5, 4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(393, 286);
            this.tabControl1.TabIndex = 0;
            // 
            // tbCientificos
            // 
            this.tbCientificos.Controls.Add(this.editorCientificos);
            this.tbCientificos.Location = new System.Drawing.Point(4, 24);
            this.tbCientificos.Name = "tbCientificos";
            this.tbCientificos.Padding = new System.Windows.Forms.Padding(3);
            this.tbCientificos.Size = new System.Drawing.Size(385, 258);
            this.tbCientificos.TabIndex = 0;
            this.tbCientificos.Text = "Cientificos";
            this.tbCientificos.UseVisualStyleBackColor = true;
            // 
            // editorCientificos1
            // 
            this.editorCientificos.Context = context1;
            this.editorCientificos.Location = new System.Drawing.Point(-4, -1);
            this.editorCientificos.Name = "editorCientificos1";
            this.editorCientificos.Size = new System.Drawing.Size(397, 263);
            this.editorCientificos.TabIndex = 0;
            // 
            // tbProyectos
            // 
            this.tbProyectos.Controls.Add(this.editorProyectos);
            this.tbProyectos.Location = new System.Drawing.Point(4, 24);
            this.tbProyectos.Name = "tbProyectos";
            this.tbProyectos.Padding = new System.Windows.Forms.Padding(3);
            this.tbProyectos.Size = new System.Drawing.Size(385, 258);
            this.tbProyectos.TabIndex = 1;
            this.tbProyectos.Text = "Proyectos";
            this.tbProyectos.UseVisualStyleBackColor = true;
            // 
            // editorProyectos
            // 
            this.editorProyectos.BackColor = System.Drawing.Color.Transparent;
            this.editorProyectos.Context = context2;
            this.editorProyectos.Location = new System.Drawing.Point(0, 0);
            this.editorProyectos.Name = "editorProyectos";
            this.editorProyectos.Size = new System.Drawing.Size(523, 349);
            this.editorProyectos.TabIndex = 0;
            // 
            // tbAsignadoAs
            // 
            this.tbAsignadoAs.Location = new System.Drawing.Point(4, 24);
            this.tbAsignadoAs.Name = "tbAsignadoAs";
            this.tbAsignadoAs.Size = new System.Drawing.Size(363, 258);
            this.tbAsignadoAs.TabIndex = 2;
            this.tbAsignadoAs.Text = "Asignar A";
            this.tbAsignadoAs.UseVisualStyleBackColor = true;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 290);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.RightToLeftLayout = true;
            this.Text = "Exercici 3 T23 MVC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.tabControl1.ResumeLayout(false);
            this.tbCientificos.ResumeLayout(false);
            this.tbProyectos.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tbCientificos;
        private System.Windows.Forms.TabPage tbProyectos;
        private Controls.EditorProyectos editorProyectos;
        private System.Windows.Forms.TabPage tbAsignadoAs;
        private Controls.EditorCientificos editorCientificos;
    }
}

