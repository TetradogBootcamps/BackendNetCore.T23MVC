
namespace NetCoreBootcampT23MVC_EX2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            NetCoreBootcampT23MVC_EX2.Video video1 = new NetCoreBootcampT23MVC_EX2.Video();
            this.btnAddClientes = new System.Windows.Forms.Button();
            this.lstVideos = new System.Windows.Forms.ListBox();
            this.visorEditorCreadorVideo = new NetCoreBootcampT23MVC_EX2.VisorEditorCreadorVideo();
            this.btnAddNew = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAddClientes
            // 
            this.btnAddClientes.Location = new System.Drawing.Point(9, 186);
            this.btnAddClientes.Name = "btnAddClientes";
            this.btnAddClientes.Size = new System.Drawing.Size(360, 32);
            this.btnAddClientes.TabIndex = 7;
            this.btnAddClientes.Text = "Añadir Clientes";
            this.btnAddClientes.UseVisualStyleBackColor = true;
            this.btnAddClientes.Click += new System.EventHandler(this.btnAddClientes_Click);
            // 
            // lstVideos
            // 
            this.lstVideos.FormattingEnabled = true;
            this.lstVideos.ItemHeight = 15;
            this.lstVideos.Location = new System.Drawing.Point(9, 1);
            this.lstVideos.Name = "lstVideos";
            this.lstVideos.Size = new System.Drawing.Size(134, 139);
            this.lstVideos.TabIndex = 8;
            this.lstVideos.SelectedIndexChanged += new System.EventHandler(this.lstVideos_SelectedIndexChanged);
            // 
            // visorEditorCreadorVideo
            // 
            this.visorEditorCreadorVideo.Location = new System.Drawing.Point(149, 1);
            this.visorEditorCreadorVideo.Name = "visorEditorCreadorVideo";
            this.visorEditorCreadorVideo.Size = new System.Drawing.Size(230, 180);
            this.visorEditorCreadorVideo.TabIndex = 3;
            video1.Cliente = null;
            video1.Director = null;
            video1.Id = null;
            video1.Title = null;
            this.visorEditorCreadorVideo.Video = video1;
            this.visorEditorCreadorVideo.Added += new System.EventHandler(this.visorEditorCreadorVideo1_Added);
            this.visorEditorCreadorVideo.Deleted += new System.EventHandler(this.visorEditorCreadorVideo1_Deleted);
            this.visorEditorCreadorVideo.Updated += new System.EventHandler(this.visorEditorCreadorVideo1_Updated);
            // 
            // btnAddNew
            // 
            this.btnAddNew.Location = new System.Drawing.Point(11, 146);
            this.btnAddNew.Name = "btnAddNew";
            this.btnAddNew.Size = new System.Drawing.Size(131, 25);
            this.btnAddNew.TabIndex = 6;
            this.btnAddNew.Text = "Nuevo";
            this.btnAddNew.UseVisualStyleBackColor = true;
            this.btnAddNew.Click += new System.EventHandler(this.btnAddNew_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 227);
            this.Controls.Add(this.btnAddNew);
            this.Controls.Add(this.visorEditorCreadorVideo);
            this.Controls.Add(this.lstVideos);
            this.Controls.Add(this.btnAddClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Exercici 2 T23 MVC";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnAddClientes;
        private System.Windows.Forms.ListBox lstVideos;
        private VisorEditorCreadorVideo visorEditorCreadorVideo;
        private System.Windows.Forms.Button btnAddNew;
    }
}

