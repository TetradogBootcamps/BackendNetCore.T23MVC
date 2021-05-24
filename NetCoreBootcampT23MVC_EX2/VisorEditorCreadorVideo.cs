using NetCoreBootcampT23MVC_EX1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreBootcampT23MVC_EX2
{
    public partial class VisorEditorCreadorVideo : UserControl
    {
        static bool ControlEmpty { get; set; } = true;

        public event EventHandler Added;
        public event EventHandler Deleted;
        public event EventHandler Updated;
        public VisorEditorCreadorVideo()
        {
            InitializeComponent();
            Clientes = new List<Cliente>();
            Reset();
        }
        public Video Video { get; set; }
        public List<Cliente> Clientes { get; set; }

        public override void Refresh()
        {
            RefreshCmb();

            if (Video.Id.HasValue)
            {
                txtTitle.Text = Video.Title;
                txtDirector.Text = Video.Director;

                if (!Equals(Video.Cliente, default))
                     cmbClientes.SelectedIndex = Clientes.IndexOf(Video.Cliente);
                else cmbClientes.SelectedIndex = -1;
                SetButtonsVideoWithId();
            }
            else
            {
                txtTitle.Text =string.Empty;
                txtDirector.Text = string.Empty;
                cmbClientes.SelectedIndex = -1;
                btnAddOrUpdate.Text = "Añadir";
                btnClearOrDelete.Text = "Limpiar";
            }

            base.Refresh();
        }

        public void RefreshCmb()
        {
            cmbClientes.Items.Clear();
            cmbClientes.Items.AddRange(Clientes.ToArray());
        }

        private void SetButtonsVideoWithId()
        {
            btnAddOrUpdate.Text = "Actualizar";
            btnClearOrDelete.Text = "Eliminar";
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            const int TOTAL = 3;

            int totalEmpty = 0;
            bool error = false;
            if(string.IsNullOrEmpty(txtTitle.Text) || string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                Video.Title = default;
                totalEmpty++;
            }
            else if(txtTitle.Text.Length<=Video.MAXTITLE)
            {
                Video.Title = txtTitle.Text;
            }
            else
            {
                error = true;
                MessageBox.Show($"El titulo supera los {Video.MAXTITLE} carácteres!","Atención",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
            }
            if (!error)
            {

                if (string.IsNullOrEmpty(txtDirector.Text) || string.IsNullOrWhiteSpace(txtDirector.Text))
                {
                    Video.Director = default;
                    totalEmpty++;
                }
                else if (txtDirector.Text.Length <= Video.MAXTITLE)
                {
                    Video.Director = txtDirector.Text;
                }
                else
                {
                    error = true;
                    MessageBox.Show($"El director supera los {Video.MAXDIRECTOR} carácteres!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (cmbClientes.SelectedIndex < 0)
                {
                    Video.Cliente = default;
                    totalEmpty++;
                }
                else
                {
                    Video.Cliente = Clientes[cmbClientes.SelectedIndex];
                }
                if (!error)
                {
                    if (Video.Id.HasValue)
                    {
                        if (!ControlEmpty || totalEmpty < TOTAL)
                        {
                            if (Updated != null)
                                Updated(this, new EventArgs());
                        }
                        else
                        {
                            MessageBox.Show("No se puede actualizar a un videos sin contenido!!");
                        }
                    }
                    else
                    {
                        if(!ControlEmpty || totalEmpty < TOTAL)
                        {
                            if (Added != null)
                                Added(this, new EventArgs());
                            SetButtonsVideoWithId();
                        }
                        else
                        {
                            MessageBox.Show("No se puede añadir videos sin contenido!!");
                        }
                    }
                }
            }
        }

        private void btnClearOrDelete_Click(object sender, EventArgs e)
        {
            if (Deleted != null)
                Deleted(this, new EventArgs());
            Reset();
        }

        private void Reset()
        {
            Video = new Video();
            Refresh();
        }
        public bool HasDataToUpdate()
        {
            bool hasDataToUpdate = !Equals(txtTitle.Text, Equals(Video.Title, default) ? string.Empty : Video.Title);

            if (!hasDataToUpdate)
            {
                hasDataToUpdate = !Equals(txtDirector.Text, Equals(Video.Director, default) ? string.Empty : Video.Director);
                if (!hasDataToUpdate)
                {
                    hasDataToUpdate = !Equals(cmbClientes.SelectedIndex, Equals(Video.Cliente, default) ? -1: Clientes.IndexOf(Video.Cliente));
                 
                }
            }



            return hasDataToUpdate;
        }
    }
}
