using NetCoreBootcampT23MVC_EX3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreBootcampT23MVC_EX3.Controls
{
    public partial class CreadorEditorCientifico : UserControl
    {
        public static bool ControlEmpty { get; set; } = true;

        public event EventHandler Deleted;
        public event EventHandler Updated;
        public event EventHandler Added;
        public CreadorEditorCientifico()
        {
            InitializeComponent();
            NuevoCientifico();
        }
        public Cientifico Cientifico { get; set; }
        public bool IsOnBD { get; set; }

        public override void Refresh()
        {
            base.Refresh();

            if (IsOnBD)
            {
                txtNombreCompleto.Text = Cientifico.NombreCompleto;
                txtDNI.Text = Cientifico.DNI;
                btnAddOrUpdate.Text = "Actualizar";
                btnClearOrDelete.Text = "Eliminar";
            }
        }

        public void NuevoCientifico()
        {
            Cientifico = new Cientifico();
            txtNombreCompleto.Text = string.Empty;
            txtDNI.Text = string.Empty;
            btnAddOrUpdate.Text = "Añadir";
            btnClearOrDelete.Text = "Limpiar";
            IsOnBD = false;
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            const int TOTALEMPTY =0;
            int totalEmpty = 0;
            bool hayError = false;
            if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrWhiteSpace(txtDNI.Text))
            {
                hayError = true;
                MessageBox.Show($"Es imprescindible poner un DNI", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            else if (txtDNI.Text.Length <= Cientifico.DNIMAXLENGHT)
            {
                Cientifico.DNI = txtDNI.Text;
            }
            else
            {
                hayError = true;
                MessageBox.Show($"La longitud del DNI ha superado los {Cientifico.DNIMAXLENGHT} carácteres", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!hayError)
            {
                if (string.IsNullOrEmpty(txtNombreCompleto.Text) || string.IsNullOrWhiteSpace(txtNombreCompleto.Text))
                {
                    totalEmpty++;
                  Cientifico.NombreCompleto = default;
                }
                else if (txtNombreCompleto.Text.Length <= Cientifico.NOMBRECOMPLETOMAXLENGHT)
                {
                    Cientifico.NombreCompleto = txtNombreCompleto.Text;
                }
                else
                {
                    hayError = true;
                    MessageBox.Show($"La longitud del nombre ha superado los {Cientifico.NOMBRECOMPLETOMAXLENGHT} carácteres", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (!hayError)
                {

                    if (IsOnBD)
                    {
                        if (!ControlEmpty || totalEmpty == TOTALEMPTY)
                        {
                            if (Updated != null)
                            {
                                Updated(this, new EventArgs());
                            }
                        }
                        else
                        {
                            MessageBox.Show("Se requieren campos con valores!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        if (!ControlEmpty || totalEmpty == TOTALEMPTY)
                        {
                            if (Added != null)
                            {
                                Added(this, new EventArgs());
                            }
                            IsOnBD = true;
                            Refresh();
                        }
                        else
                        {
                            MessageBox.Show("Se requieren campos con valores!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }

                }


            }

        }

        private void btnClearOrDelete_Click(object sender, EventArgs e)
        {
            if (IsOnBD)
            {
                if (Deleted != null)
                    Deleted(this, new EventArgs());
            }
            NuevoCientifico();
        }
        public bool HasDataToUpdate()
        {
            bool hasDataToUpdate = !Equals(txtDNI.Text, Equals(Cientifico.DNI, default) ? string.Empty : Cientifico.DNI);

            if (!hasDataToUpdate)
            {
                hasDataToUpdate = !Equals(txtNombreCompleto.Text, Equals(Cientifico.NombreCompleto, default) ? string.Empty : Cientifico.NombreCompleto);
    
            }



            return hasDataToUpdate;
        }
    }
}
