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
    public partial class EditorCientificos : UserControl
    {
        public EditorCientificos()
        {
            InitializeComponent();
            Context = new Context();
            UpdateList();
        }


        public Context Context { get; set; }

        private void UpdateList()
        {
            object selected = lstCientificos.SelectedItem;
            lstCientificos.SelectedIndexChanged -= lstCientificos_SelectedIndexChanged;

            lstCientificos.Items.Clear();

            foreach (var cientifico in Context.Cientificos)
                lstCientificos.Items.Add(cientifico);

            if (!Equals(selected, default) && lstCientificos.Items.IndexOf(selected) >= 0)
                lstCientificos.SelectedItem = selected;

            lstCientificos.SelectedIndexChanged += lstCientificos_SelectedIndexChanged;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            if (!HasDataToUpdate() || FrmMain.MessageWhantToLoseData())
            {

                creadorEditorCientifico.NuevoCientifico();
            }
        }

        private void creadorEditorCientifico_Deleted(object sender, EventArgs e)
        {
            Cientifico cientifico = creadorEditorCientifico.Cientifico;
            Context.Cientificos.Remove(cientifico);
            Context.SaveChanges();
            UpdateList();
        }

        private void creadorEditorCientifico_Updated(object sender, EventArgs e)
        {
            Context.SaveChanges();
            UpdateList();
        }

        private void creadorEditorCientifico_Added(object sender, EventArgs e)
        {
            Cientifico cientifico = creadorEditorCientifico.Cientifico;
            Context.Cientificos.Add(cientifico);
            Context.SaveChanges();
            UpdateList();
        }

        private void lstCientificos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!Equals(lstCientificos.SelectedItem, default) && !ReferenceEquals(lstCientificos.SelectedItem, creadorEditorCientifico.Cientifico) && (!HasDataToUpdate() || FrmMain.MessageWhantToLoseData()))
            {
                creadorEditorCientifico.Cientifico = lstCientificos.SelectedItem as Cientifico;
                creadorEditorCientifico.IsOnBD = true;
                creadorEditorCientifico.Refresh();
            }
        }
        public bool HasDataToUpdate() => creadorEditorCientifico.HasDataToUpdate();
    }
}
