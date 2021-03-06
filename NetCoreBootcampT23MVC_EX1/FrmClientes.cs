
using System;

using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreBootcampT23MVC_EX1
{
    public partial class FrmClientes : Form
    {
        static int IdGen = 0;
        public FrmClientes()
        {
            InitializeComponent();
            Context = new Context();
            UpdateList();

        }
        public Context Context { get; set; }

        private void visorEditorCreadorCliente_Updated(object sender, EventArgs e)
        {
            try
            {
                Context.SaveChanges();
            }
            catch { /*no actualizan nada y da error*/}
            UpdateList();
            //actualizo el cliente a la BD
        }

        private void visorEditorCreadorCliente_Added(object sender, EventArgs e)
        {
            Cliente cliente = visorEditorCreadorCliente.Cliente;
            //añado el cliente a la BD
            //de momento pongo el Id desde la app
            //cliente.Id = IdGen++;

            Context.Clientes.Add(cliente);
            Context.SaveChanges();
            UpdateList();



        }

        public void UpdateList()
        {
            Cliente client;
            lstClientes.SelectedIndexChanged -= lstClientes_SelectedIndexChanged;

            lstClientes.DataSource = default;
            lstClientes.Items.Clear();

            lstClientes.DataSource = Context.Clientes.ToList();
            client = Context.Clientes.Find(visorEditorCreadorCliente.Cliente.Id);
            if (!Equals(client,default(Cliente)))
                lstClientes.SelectedItem = visorEditorCreadorCliente.Cliente;

            lstClientes.SelectedIndexChanged += lstClientes_SelectedIndexChanged;
        }

        private void visorEditorCreadorCliente_Deleted(object sender, EventArgs e)
        {
            Context.Clientes.Remove(visorEditorCreadorCliente.Cliente);
            Context.SaveChanges();
            UpdateList();
            //elimino el cliente de la BD
        }

        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            //miro si el visor tiene datos pendientes de actualizarse
            if (!visorEditorCreadorCliente.HasDataToUpdate() || DeseaPerderInformacion())
            {
                visorEditorCreadorCliente.Cliente = new Cliente();
                visorEditorCreadorCliente.Refresh();
            }
           
        }

        private bool DeseaPerderInformacion()
        {
            return  MessageBox.Show("Tiene información que podria perder, seguro que desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
        }
        protected override void OnClosing(CancelEventArgs e)
        {
            e.Cancel =visorEditorCreadorCliente.HasDataToUpdate() && !DeseaPerderInformacion();
        }

        private void lstClientes_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Equals(lstClientes.SelectedItem, default) && !ReferenceEquals(lstClientes.SelectedItem,visorEditorCreadorCliente.Cliente))
            {
                if (!visorEditorCreadorCliente.HasDataToUpdate() || DeseaPerderInformacion())
                {
                    visorEditorCreadorCliente.Cliente = lstClientes.SelectedItem as Cliente;
                    visorEditorCreadorCliente.Refresh();
                }
                else
                {
                    lstClientes.SelectedItem = visorEditorCreadorCliente.Cliente;
                }
            }
        }

    }
}
