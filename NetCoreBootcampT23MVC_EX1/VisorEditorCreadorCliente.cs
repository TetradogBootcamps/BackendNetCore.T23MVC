using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace NetCoreBootcampT23MVC_EX1
{
    public partial class VisorEditorCreadorCliente : UserControl
    {
        static  DateTime Default { get; set; } = DateTime.Now;

        //en la BD se puede añadir clientes vacios pero no creo que sea bueno

        /// <summary>
        /// Si es false se pueden añadir/actualizar clientes sin información
        /// </summary>
        static bool ControlEmpty { get; set; } = true;


        public event EventHandler Deleted;
        public event EventHandler Added;
        public event EventHandler Updated;
        public VisorEditorCreadorCliente()
        {
            InitializeComponent();
            Reset();
        }

        public Cliente Cliente { get; set; }

        public override void Refresh()
        {
            if (Cliente.Id.HasValue)
            {
                txtNombre.Text = Cliente.Nombre;
                txtApellidos.Text = Cliente.Apellidos;
                txtDireccion.Text = Cliente.Direccion;

                if (Cliente.DNI.HasValue)
                    txtDNI.Text = Cliente.DNI.Value.ToString().PadLeft(Cliente.TOTALDNI, '0');
                else txtDNI.Text = string.Empty;

                if (Cliente.Fecha.HasValue)
                    dtpkFecha.Value = Cliente.Fecha.Value;
                else
                    dtpkFecha.Value = Default;
                SetTextoBotonesHayCliente();
            }
            else
            {
                txtNombre.Text = string.Empty;
                txtApellidos.Text = string.Empty;
                txtDireccion.Text = string.Empty;
                txtDNI.Text = string.Empty;
                dtpkFecha.Value = Default;
                btnAddOrUpdate.Text = "Añadir";
                btnEliminar.Text = "Limpiar";
            }
            base.Refresh();
        }

        private void btnAddOrUpdate_Click(object sender, EventArgs e)
        {
            const int TOTAL = 5;

            bool error = false;
            int totalEmpty = 0;

            if (string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                Cliente.Nombre = default;
                totalEmpty++;
            }
            else if (txtNombre.Text.Length <= Cliente.MAXNOMBRE)
            {
                Cliente.Nombre = txtNombre.Text;
            }
            else
            {
                error = true;
                MessageBox.Show($"El nombre es muy largo, no puede superar los {Cliente.MAXNOMBRE} carácteres!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (!error)
            {
                if (string.IsNullOrEmpty(txtApellidos.Text) || string.IsNullOrWhiteSpace(txtApellidos.Text))
                {
                    Cliente.Apellidos = default;
                    totalEmpty++;
                }
                else if (txtApellidos.Text.Length <= Cliente.MAXAPELLIDOS)
                {
                    Cliente.Apellidos = txtApellidos.Text;
                }
                else
                {
                    error = true;
                    MessageBox.Show($"Los apellidos son muy largos, no puede superar los {Cliente.MAXAPELLIDOS} carácteres!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (!error)
                {
                    if (string.IsNullOrEmpty(txtDireccion.Text) || string.IsNullOrWhiteSpace(txtDireccion.Text))
                    {
                        Cliente.Direccion = default;
                        totalEmpty++;
                    }
                    else if (txtDireccion.Text.Length <= Cliente.MAXDIRECCION)
                    {
                        Cliente.Direccion = txtDireccion.Text;
                    }
                    else
                    {
                        error = true;
                        MessageBox.Show($"La dirección es muy larga, no puede superar los {Cliente.MAXDIRECCION} carácteres!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    if (!error)
                    {
                        if (string.IsNullOrEmpty(txtDNI.Text) || string.IsNullOrWhiteSpace(txtDNI.Text))
                        {
                            Cliente.DNI = default;
                            totalEmpty++;
                        }
                        else if (txtDNI.Text.Length <= Cliente.TOTALDNI)
                        {
                            Cliente.DNI = int.Parse(txtDNI.Text);
                        }
                        else
                        {
                            error = true;
                            MessageBox.Show($"El DNI debe de tener {Cliente.TOTALDNI} carácteres!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        if (!error)
                        {
                            if (!Equals(Default, dtpkFecha.Value))
                            {
                                Cliente.Fecha = dtpkFecha.Value.Date;
                            }
                            else
                            {
                                Cliente.Fecha = DateTime.UtcNow.Date;
                                totalEmpty++;
                            }
                        }
                    }
                }
            }

            if (!error)
            {

                if (Cliente.Id.HasValue)
                {
                    if (!ControlEmpty|| totalEmpty < TOTAL)
                    {
                        if (Updated != null)
                         Updated(this, new EventArgs());
                    }
                    else
                    {
                        MessageBox.Show("No es un cliente valido!");
                    }
                }
                else
                {
                    if (!ControlEmpty || totalEmpty < TOTAL)
                    {
                        if (Added != null)
                        {
                            Added(this, new EventArgs());
                        }
                        SetTextoBotonesHayCliente();
                    }
                    else
                    {
                        MessageBox.Show("No hay nada que añadir!");
                    }
                }

            }
        }

        private void SetTextoBotonesHayCliente()
        {
            btnAddOrUpdate.Text = "Actualizar";
            btnEliminar.Text = "Eliminar";
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string texto = Cliente.Id.HasValue ? "eliminar el cliente actual" : "limpiar los datos";
            if (MessageBox.Show($"Desea {texto}?\nEsta operación no tiene marcha atrás!", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Cliente.Id.HasValue && Deleted != null)
                    Deleted(this, new EventArgs());

                Reset();
            }
        }

        private void Reset()
        {
            Cliente = new Cliente();
            Refresh();
        }
        public bool HasDataToUpdate()
        {
            bool hasDataToUpdate = !Equals(txtNombre.Text, Equals(Cliente.Nombre, default) ? string.Empty : Cliente.Nombre);

            if (!hasDataToUpdate)
            {
                hasDataToUpdate = !Equals(txtApellidos.Text, Equals(Cliente.Apellidos, default) ? string.Empty : Cliente.Apellidos);
                if (!hasDataToUpdate)
                {
                    hasDataToUpdate = !Equals(txtDireccion.Text, Equals(Cliente.Direccion, default) ? string.Empty : Cliente.Direccion);
                    if (!hasDataToUpdate)
                    {
                        hasDataToUpdate = !Equals(txtDNI.Text.PadLeft(Cliente.TOTALDNI, '0'), (Cliente.DNI.HasValue ? Cliente.DNI.Value.ToString() : string.Empty).PadLeft(Cliente.TOTALDNI, '0'));
                        if (!hasDataToUpdate)
                        {
                            hasDataToUpdate = !Equals(dtpkFecha.Value, Default) && !Equals(dtpkFecha.Value, Cliente.Fecha.Value);
                        }
                    }
                }
            }



            return hasDataToUpdate;
        }



        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar);
        }
    }
}
