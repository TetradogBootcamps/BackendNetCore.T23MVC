
namespace NetCoreBootcampT23MVC_EX1
{
    partial class Form1
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
            NetCoreBootcampT23MVC_EX1.Cliente cliente1 = new NetCoreBootcampT23MVC_EX1.Cliente();
            this.lstClientes = new System.Windows.Forms.ListBox();
            this.btnAddCliente = new System.Windows.Forms.Button();
            this.visorEditorCreadorCliente = new NetCoreBootcampT23MVC_EX1.VisorEditorCreadorCliente();
            this.SuspendLayout();
            // 
            // lstClientes
            // 
            this.lstClientes.FormattingEnabled = true;
            this.lstClientes.ItemHeight = 15;
            this.lstClientes.Location = new System.Drawing.Point(2, 3);
            this.lstClientes.Name = "lstClientes";
            this.lstClientes.Size = new System.Drawing.Size(205, 229);
            this.lstClientes.TabIndex = 0;
            this.lstClientes.SelectedIndexChanged += new System.EventHandler(this.lstClientes_SelectedIndexChanged);
            // 
            // btnAddCliente
            // 
            this.btnAddCliente.Location = new System.Drawing.Point(2, 260);
            this.btnAddCliente.Name = "btnAddCliente";
            this.btnAddCliente.Size = new System.Drawing.Size(205, 23);
            this.btnAddCliente.TabIndex = 1;
            this.btnAddCliente.Text = "Añadir Cliente";
            this.btnAddCliente.UseVisualStyleBackColor = true;
            this.btnAddCliente.Click += new System.EventHandler(this.btnAddCliente_Click);
            // 
            // visorEditorCreadorCliente
            // 
            cliente1.Apellidos = null;
            cliente1.Direccion = null;
            cliente1.DNI = null;
            cliente1.Fecha = null;
            cliente1.Id = null;
            cliente1.Nombre = null;
            this.visorEditorCreadorCliente.Cliente = cliente1;
            this.visorEditorCreadorCliente.Location = new System.Drawing.Point(213, 3);
            this.visorEditorCreadorCliente.Name = "visorEditorCreadorCliente";
            this.visorEditorCreadorCliente.Size = new System.Drawing.Size(332, 294);
            this.visorEditorCreadorCliente.TabIndex = 2;
            this.visorEditorCreadorCliente.Deleted += new System.EventHandler(this.visorEditorCreadorCliente_Deleted);
            this.visorEditorCreadorCliente.Added += new System.EventHandler(this.visorEditorCreadorCliente_Added);
            this.visorEditorCreadorCliente.Updated += new System.EventHandler(this.visorEditorCreadorCliente_Updated);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(557, 300);
            this.Controls.Add(this.visorEditorCreadorCliente);
            this.Controls.Add(this.btnAddCliente);
            this.Controls.Add(this.lstClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Exercici 1 T23 MVC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstClientes;
        private System.Windows.Forms.Button btnAddCliente;
        private NetCoreBootcampT23MVC_EX1.VisorEditorCreadorCliente visorEditorCreadorCliente;
    }
}

