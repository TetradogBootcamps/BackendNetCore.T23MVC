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
    public partial class EditorProyectos : UserControl
    {
        public EditorProyectos()
        {
            InitializeComponent();
            Proyectos = new List<Proyecto>();
        }
        public List<Proyecto> Proyectos { get; set; }

        private void creadorEditorProyecto_Added(object sender, EventArgs e)
        {

        }

        private void creadorEditorProyecto_Updated(object sender, EventArgs e)
        {

        }

        private void creadorEditorProyecto_Deleted(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {

        }

        private void lstProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
