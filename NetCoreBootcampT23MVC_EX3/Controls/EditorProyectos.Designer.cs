
namespace NetCoreBootcampT23MVC_EX3.Controls
{
    partial class EditorProyectos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.creadorEditorProyecto = new NetCoreBootcampT23MVC_EX3.CreadorEditorProyecto();
            this.lstProyectos = new System.Windows.Forms.ListBox();
            this.btnNuevo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // creadorEditorProyecto
            // 
            this.creadorEditorProyecto.IsOnBD = false;
            this.creadorEditorProyecto.Location = new System.Drawing.Point(191, 49);
            this.creadorEditorProyecto.Name = "creadorEditorProyecto";
            this.creadorEditorProyecto.Proyecto = null;
            this.creadorEditorProyecto.Size = new System.Drawing.Size(163, 150);
            this.creadorEditorProyecto.TabIndex = 0;
            this.creadorEditorProyecto.Updated += new System.EventHandler(this.creadorEditorProyecto_Updated);
            this.creadorEditorProyecto.Added += new System.EventHandler(this.creadorEditorProyecto_Added);
            this.creadorEditorProyecto.Deleted += new System.EventHandler(this.creadorEditorProyecto_Deleted);
            // 
            // lstProyectos
            // 
            this.lstProyectos.FormattingEnabled = true;
            this.lstProyectos.ItemHeight = 15;
            this.lstProyectos.Location = new System.Drawing.Point(2, 1);
            this.lstProyectos.Name = "lstProyectos";
            this.lstProyectos.Size = new System.Drawing.Size(149, 259);
            this.lstProyectos.TabIndex = 1;
            this.lstProyectos.SelectedIndexChanged += new System.EventHandler(this.lstProyectos_SelectedIndexChanged);
            // 
            // btnNuevo
            // 
            this.btnNuevo.Location = new System.Drawing.Point(158, 230);
            this.btnNuevo.Name = "btnNuevo";
            this.btnNuevo.Size = new System.Drawing.Size(232, 30);
            this.btnNuevo.TabIndex = 2;
            this.btnNuevo.Text = "Nuevo";
            this.btnNuevo.UseVisualStyleBackColor = true;
            this.btnNuevo.Click += new System.EventHandler(this.btnNuevo_Click);
            // 
            // EditorProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNuevo);
            this.Controls.Add(this.lstProyectos);
            this.Controls.Add(this.creadorEditorProyecto);
            this.Name = "EditorProyectos";
            this.Size = new System.Drawing.Size(392, 263);
            this.ResumeLayout(false);

        }

        #endregion

        private CreadorEditorProyecto creadorEditorProyecto;
        private System.Windows.Forms.ListBox lstProyectos;
        private System.Windows.Forms.Button btnNuevo;
    }
}
