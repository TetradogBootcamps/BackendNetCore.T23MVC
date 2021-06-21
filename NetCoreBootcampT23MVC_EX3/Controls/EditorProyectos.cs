using Microsoft.EntityFrameworkCore;
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
    public partial class EditorProyectos : UserControl
    {
        public EditorProyectos()
        {
            InitializeComponent();
            Context = new Context();
            creadorEditorProyecto.Refresh();
            UpdateList();
        }
       
        public Context Context { get; set; }


        private void creadorEditorProyecto_Added(object sender, EventArgs e)
        {
            Proyecto proyecto = creadorEditorProyecto.Proyecto;
            Context.Proyectos.Add(proyecto);
            Context.SaveChanges();
            UpdateList();
        }

        private void creadorEditorProyecto_Updated(object sender, EventArgs e)
        {
            Context.SaveChanges();
            UpdateList();
        }

        private void creadorEditorProyecto_Deleted(object sender, EventArgs e)
        {
            Proyecto proyecto = creadorEditorProyecto.Proyecto;
            Context.Proyectos.Remove(proyecto);
            Context.SaveChanges();
            UpdateList();
        }
        void UpdateList()
        {
            object selected = lstProyectos.SelectedItem;
            lstProyectos.SelectedIndexChanged -= lstProyectos_SelectedIndexChanged;

            lstProyectos.Items.Clear();

            foreach(var proyecto in Context.Proyectos)
                lstProyectos.Items.Add(proyecto);

            if (!Equals(selected,default) && lstProyectos.Items.IndexOf(selected) >= 0)
                lstProyectos.SelectedItem = selected;

            lstProyectos.SelectedIndexChanged += lstProyectos_SelectedIndexChanged;
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            if (!HasDataToUpdate() || FrmMain.MessageWhantToLoseData())
            {
                creadorEditorProyecto.Proyecto = new Proyecto();
                creadorEditorProyecto.IsOnBD = false;
                creadorEditorProyecto.Refresh();
            }

        }

        private void lstProyectos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(!Equals(lstProyectos.SelectedItem,default)&&!ReferenceEquals(lstProyectos.SelectedItem,creadorEditorProyecto.Proyecto) && (!HasDataToUpdate() || FrmMain.MessageWhantToLoseData()))
            {
                creadorEditorProyecto.Proyecto = lstProyectos.SelectedItem as Proyecto;
                creadorEditorProyecto.IsOnBD = true;
                creadorEditorProyecto.Refresh();
            }
        }
        public bool HasDataToUpdate() => creadorEditorProyecto.HasDataToUpdate();

    }
}
