
namespace NetCoreBootcampT23MVC_EX3.Controls
{
    partial class EditorCientificos
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
            NetCoreBootcampT23MVC_EX3.Models.Cientifico cientifico2 = new NetCoreBootcampT23MVC_EX3.Models.Cientifico();
            this.lstCientificos = new System.Windows.Forms.ListBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.creadorEditorCientifico = new NetCoreBootcampT23MVC_EX3.Controls.CreadorEditorCientifico();
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
            this.lstCientificos.SelectedIndexChanged += new System.EventHandler(this.lstCientificos_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(155, 229);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(232, 30);
            this.btnNew.TabIndex = 1;
            this.btnNew.Text = "Nuevo";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // creadorEditorCientifico
            // 
            cientifico2.DNI = null;
            cientifico2.NombreCompleto = null;
            this.creadorEditorCientifico.Cientifico = cientifico2;
            this.creadorEditorCientifico.IsOnBD = false;
            this.creadorEditorCientifico.Location = new System.Drawing.Point(155, 43);
            this.creadorEditorCientifico.Name = "creadorEditorCientifico";
            this.creadorEditorCientifico.Size = new System.Drawing.Size(229, 161);
            this.creadorEditorCientifico.TabIndex = 2;
            this.creadorEditorCientifico.Deleted += new System.EventHandler(this.creadorEditorCientifico_Deleted);
            this.creadorEditorCientifico.Updated += new System.EventHandler(this.creadorEditorCientifico_Updated);
            this.creadorEditorCientifico.Added += new System.EventHandler(this.creadorEditorCientifico_Added);
            // 
            // EditorCientificos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.creadorEditorCientifico);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.lstCientificos);
            this.Name = "EditorCientificos";
            this.Size = new System.Drawing.Size(392, 263);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstCientificos;
        private System.Windows.Forms.Button btnNew;
        private CreadorEditorCientifico creadorEditorCientifico;
    }
}
