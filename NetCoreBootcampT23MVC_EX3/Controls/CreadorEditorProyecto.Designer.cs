
namespace NetCoreBootcampT23MVC_EX3
{
    partial class CreadorEditorProyecto
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
            this.lblId = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblHoras = new System.Windows.Forms.Label();
            this.numHoras = new System.Windows.Forms.NumericUpDown();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtId = new System.Windows.Forms.TextBox();
            this.btnAddOrUpdate = new System.Windows.Forms.Button();
            this.btnClearOrDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).BeginInit();
            this.SuspendLayout();
            // 
            // lblId
            // 
            this.lblId.AutoSize = true;
            this.lblId.Location = new System.Drawing.Point(11, 17);
            this.lblId.Name = "lblId";
            this.lblId.Size = new System.Drawing.Size(20, 15);
            this.lblId.TabIndex = 0;
            this.lblId.Text = "Id:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(11, 51);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(54, 15);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre:";
            // 
            // lblHoras
            // 
            this.lblHoras.AutoSize = true;
            this.lblHoras.Location = new System.Drawing.Point(11, 85);
            this.lblHoras.Name = "lblHoras";
            this.lblHoras.Size = new System.Drawing.Size(41, 15);
            this.lblHoras.TabIndex = 2;
            this.lblHoras.Text = "Horas:";
            // 
            // numHoras
            // 
            this.numHoras.Location = new System.Drawing.Point(65, 83);
            this.numHoras.Name = "numHoras";
            this.numHoras.Size = new System.Drawing.Size(86, 23);
            this.numHoras.TabIndex = 3;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(65, 50);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(86, 23);
            this.txtNombre.TabIndex = 4;
            // 
            // txtId
            // 
            this.txtId.Location = new System.Drawing.Point(65, 15);
            this.txtId.Name = "txtId";
            this.txtId.Size = new System.Drawing.Size(86, 23);
            this.txtId.TabIndex = 5;
            // 
            // btnAddOrUpdate
            // 
            this.btnAddOrUpdate.Location = new System.Drawing.Point(7, 124);
            this.btnAddOrUpdate.Name = "btnAddOrUpdate";
            this.btnAddOrUpdate.Size = new System.Drawing.Size(64, 25);
            this.btnAddOrUpdate.TabIndex = 6;
            this.btnAddOrUpdate.Text = "Añadir";
            this.btnAddOrUpdate.UseVisualStyleBackColor = true;
            this.btnAddOrUpdate.Click += new System.EventHandler(this.btnAddOrUpdate_Click);
            // 
            // btnClearOrDelete
            // 
            this.btnClearOrDelete.Location = new System.Drawing.Point(89, 125);
            this.btnClearOrDelete.Name = "btnClearOrDelete";
            this.btnClearOrDelete.Size = new System.Drawing.Size(62, 24);
            this.btnClearOrDelete.TabIndex = 7;
            this.btnClearOrDelete.Text = "Clear";
            this.btnClearOrDelete.UseVisualStyleBackColor = true;
            this.btnClearOrDelete.Click += new System.EventHandler(this.btnClearOrDelete_Click);
            // 
            // CreadorEditorProyecto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnClearOrDelete);
            this.Controls.Add(this.btnAddOrUpdate);
            this.Controls.Add(this.txtId);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.numHoras);
            this.Controls.Add(this.lblHoras);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblId);
            this.Name = "CreadorEditorProyecto";
            this.Size = new System.Drawing.Size(163, 150);
            ((System.ComponentModel.ISupportInitialize)(this.numHoras)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblId;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblHoras;
        private System.Windows.Forms.NumericUpDown numHoras;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtId;
        private System.Windows.Forms.Button btnAddOrUpdate;
        private System.Windows.Forms.Button btnClearOrDelete;
    }
}
