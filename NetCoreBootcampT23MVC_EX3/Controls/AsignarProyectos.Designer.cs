
namespace NetCoreBootcampT23MVC_EX3.Controls
{
    partial class AsignarProyectos
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
            this.lstCientificos = new System.Windows.Forms.ListBox();
            this.lblNotas = new System.Windows.Forms.Label();
            this.cmbProyectos = new System.Windows.Forms.ComboBox();
            this.lstCientificosProyecto = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // lstCientificos
            // 
            this.lstCientificos.FormattingEnabled = true;
            this.lstCientificos.ItemHeight = 15;
            this.lstCientificos.Location = new System.Drawing.Point(0, 0);
            this.lstCientificos.Name = "lstCientificos";
            this.lstCientificos.Size = new System.Drawing.Size(149, 259);
            this.lstCientificos.TabIndex = 0;
            this.lstCientificos.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstCientificos_MouseClick);
            // 
            // lblNotas
            // 
            this.lblNotas.AutoSize = true;
            this.lblNotas.Location = new System.Drawing.Point(155, 29);
            this.lblNotas.Name = "lblNotas";
            this.lblNotas.Size = new System.Drawing.Size(132, 15);
            this.lblNotas.TabIndex = 1;
            this.lblNotas.Text = "Cientificos del Proyecto";
            // 
            // cmbProyectos
            // 
            this.cmbProyectos.FormattingEnabled = true;
            this.cmbProyectos.Location = new System.Drawing.Point(155, 3);
            this.cmbProyectos.Name = "cmbProyectos";
            this.cmbProyectos.Size = new System.Drawing.Size(234, 23);
            this.cmbProyectos.TabIndex = 2;
            this.cmbProyectos.SelectedIndexChanged += new System.EventHandler(this.cmbProyectos_SelectedIndexChanged);
            // 
            // lstCientificosProyecto
            // 
            this.lstCientificosProyecto.FormattingEnabled = true;
            this.lstCientificosProyecto.ItemHeight = 15;
            this.lstCientificosProyecto.Location = new System.Drawing.Point(155, 59);
            this.lstCientificosProyecto.Name = "lstCientificosProyecto";
            this.lstCientificosProyecto.Size = new System.Drawing.Size(234, 199);
            this.lstCientificosProyecto.TabIndex = 3;
            this.lstCientificosProyecto.MouseClick += new System.Windows.Forms.MouseEventHandler(this.lstCientificosProyecto_MouseClick);
            // 
            // AsignarProyectos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lstCientificosProyecto);
            this.Controls.Add(this.cmbProyectos);
            this.Controls.Add(this.lblNotas);
            this.Controls.Add(this.lstCientificos);
            this.Name = "AsignarProyectos";
            this.Size = new System.Drawing.Size(392, 263);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lstCientificos;
        private System.Windows.Forms.Label lblNotas;
        private System.Windows.Forms.ComboBox cmbProyectos;
        private System.Windows.Forms.ListBox lstCientificosProyecto;
    }
}
