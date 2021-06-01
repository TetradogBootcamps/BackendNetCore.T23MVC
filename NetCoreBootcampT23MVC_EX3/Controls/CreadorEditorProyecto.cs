using NetCoreBootcampT23MVC_EX3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreBootcampT23MVC_EX3
{
    public partial class CreadorEditorProyecto : UserControl
    {
        public static bool ControlEmpty { get; set; }


        public event EventHandler Updated;
        public event EventHandler Added;
        public event EventHandler Deleted;
        public CreadorEditorProyecto()
        {
            InitializeComponent();

        }
        public Proyecto Proyecto { get; set; }
        public bool IsOnBD { get; set; }

        public override void Refresh()
        {
            if (Equals(Proyecto, default))
                Proyecto = new Proyecto();

            txtId.Text = Proyecto.Id;
            txtNombre.Text = Proyecto.Nombre;
            numHoras.Value = Proyecto.Horas;
            if (IsOnBD)
            {
                btnAddOrUpdate.Text = "Actualizar";
                btnClearOrDelete.Text = "Eliminar";
            }
            else
            {
                btnAddOrUpdate.Text = "Añadir";
                btnClearOrDelete.Text = "Limpiar";
            }

            base.Refresh();
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            const int TOTAL = 3;
            int totalEmpty = 0;
            bool hayError = false;
            if (string.IsNullOrEmpty(txtId.Text) || string.IsNullOrWhiteSpace(txtId.Text))
            {
                totalEmpty++;
                Proyecto.Id = default;
            }
            else if (txtId.Text.Length <= Proyecto.MAXIDLENGTH)
            {
                Proyecto.Id = txtId.Text;
            }
            else
            {
                hayError = true;
                MessageBox.Show($"La longitud del Id ha superado los {Proyecto.MAXIDLENGTH} carácteres", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            if (!hayError)
            {
                if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
                {
                    totalEmpty++;
                    Proyecto.Nombre = default;
                }
                else if (txtNombre.Text.Length <= Proyecto.MAXNOMBRELENGTH)
                {
                    Proyecto.Nombre = txtNombre.Text;
                }
                else
                {
                    hayError = true;
                    MessageBox.Show($"La longitud del Id ha superado los {Proyecto.MAXNOMBRELENGTH} carácteres", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                if (!hayError)
                {
                    if (numHoras.Value <= 0)
                    {
                        Proyecto.Horas = 0;
                    }
                    else
                    {
                        Proyecto.Horas = (int)numHoras.Value;
                    }

                    if (IsOnBD)
                    {
                        if (!ControlEmpty || totalEmpty == TOTAL)
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
                        if (!ControlEmpty || totalEmpty == TOTAL)
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
                {
                    Deleted(this, new EventArgs());
                }
                IsOnBD = false;
            }

            Proyecto = new Proyecto();
            Refresh();

        }
        public bool HasDataToUpdate()
        {
            bool hasDataToUpdate = !Equals(txtId.Text, Equals(Proyecto.Id, default) ? string.Empty : Proyecto.Id);

            if (!hasDataToUpdate)
            {
                hasDataToUpdate = !Equals(txtNombre.Text, Equals(Proyecto.Nombre, default) ? string.Empty : Proyecto.Nombre);
                if (!hasDataToUpdate)
                {
                    hasDataToUpdate = !Equals((int)numHoras.Value, Proyecto.Horas);

                }
            }



            return hasDataToUpdate;
        }

    }
}
