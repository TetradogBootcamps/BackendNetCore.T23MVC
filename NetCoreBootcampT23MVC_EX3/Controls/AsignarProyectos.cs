using NetCoreBootcampT23MVC_EX3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace NetCoreBootcampT23MVC_EX3.Controls
{
    public partial class AsignarProyectos : UserControl
    {
        public AsignarProyectos()
        {
            InitializeComponent();
            Context = new Context();
            Refresh();

        }
        public Context Context { get; set; }
        public override void Refresh()
        {
            base.Refresh();
            lstCientificos.Items.Clear();
            cmbProyectos.Items.Clear();
            foreach (Cientifico cientifico in Context.Cientificos)
                lstCientificos.Items.Add(cientifico);
            foreach (Proyecto proyecto in Context.Proyectos)
                cmbProyectos.Items.Add(proyecto);
            if (cmbProyectos.Items.Count > 0)
                cmbProyectos.SelectedIndex = 0;
        }
        private void cmbProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            Proyecto proyecto = cmbProyectos.SelectedItem as Proyecto;
            if (!Equals(proyecto, default(Proyecto)))
            {
                lstCientificosProyecto.Items.Clear();
                //añado los del proyecto
                foreach (AsignadoA asignadoA in Context.AsignacionesProyectos.ToList().Where(a => a.ProyectoId == proyecto.Id))
                    lstCientificosProyecto.Items.Add(asignadoA);
            }
        }

        private void lstCientificosProyecto_MouseClick(object sender, MouseEventArgs e)
        {
            AsignadoA asignadoA = lstCientificosProyecto.SelectedItem as AsignadoA;
            if (!Equals(asignadoA, default(AsignadoA)))
            {
                if (MessageBox.Show($"¿Desea quitar a {asignadoA.Cientifico} del proyecto {asignadoA.Proyecto}?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    Context.AsignacionesProyectos.Remove(asignadoA);
                    Context.SaveChanges();
                    lstCientificosProyecto.Items.Remove(asignadoA);
                }
            }
        }

        private void lstCientificos_MouseClick(object sender, MouseEventArgs e)
        {
            AsignadoA asignadoA = new AsignadoA() { Cientifico = lstCientificos.SelectedItem as Cientifico, Proyecto = cmbProyectos.SelectedItem as Proyecto };
            if (!Equals(asignadoA.Cientifico, default(Cientifico)) && !Equals(asignadoA.Proyecto, default(Proyecto)))
            {
                try
                {
                    Context.AsignacionesProyectos.Add(asignadoA);
                    lstCientificosProyecto.Items.Add(asignadoA);
                    Context.SaveChanges();
                }
                catch { }
                
            }
        }
    }
}
