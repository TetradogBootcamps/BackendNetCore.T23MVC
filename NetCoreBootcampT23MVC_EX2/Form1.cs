using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NetCoreBootcampT23MVC_EX1;

namespace NetCoreBootcampT23MVC_EX2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            UpdateList();
        }
        Context Context => visorEditorCreadorVideo.Context;

        private void btnAddClientes_Click(object sender, EventArgs e)
        {

            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Context = Context;
            frmClientes.UpdateList();
            frmClientes.ShowDialog();
            //actualizo los CMB de clientes
            visorEditorCreadorVideo.RefreshCmb();

        }

        private void visorEditorCreadorVideo1_Added(object sender, EventArgs e)
        {
            Video video = visorEditorCreadorVideo.Video;
            Context.Videos.Add(video);
            Context.SaveChanges();
            UpdateList();
        }

        private void UpdateList()
        {
            Video videoAux = lstVideos.SelectedItem as Video;
            lstVideos.SelectedIndexChanged -= lstVideos_SelectedIndexChanged;

            lstVideos.Items.Clear();
            foreach(Video video in Context.Videos)
                lstVideos.Items.Add(video);


            lstVideos.SelectedIndexChanged += lstVideos_SelectedIndexChanged;
        }

        private void visorEditorCreadorVideo1_Updated(object sender, EventArgs e)
        {
            try
            {

                Context.SaveChanges();
            }
            catch { }
            UpdateList();
        }

        private void visorEditorCreadorVideo1_Deleted(object sender, EventArgs e)
        {
            if (visorEditorCreadorVideo.Video.Id.HasValue)
            {
                Context.Videos.Remove(visorEditorCreadorVideo.Video);
                Context.SaveChanges();
                UpdateList();
            }
        }

        private void lstVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            IList<Video> videos = Context.Videos.ToList();

            if (lstVideos.SelectedIndex >= 0 && !ReferenceEquals(videos[lstVideos.SelectedIndex], visorEditorCreadorVideo.Video))
            {
                if (!visorEditorCreadorVideo.HasDataToUpdate() || DeseaPerderInformacion())
                {
                    visorEditorCreadorVideo.Video = videos[lstVideos.SelectedIndex];
                    visorEditorCreadorVideo.Refresh();
                }
                else
                {
                    lstVideos.SelectedIndex = videos.IndexOf(visorEditorCreadorVideo.Video);
                }
            }
        }
        private bool DeseaPerderInformacion()
        {
            return MessageBox.Show("Tiene información que podria perder, seguro que desea continuar?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = visorEditorCreadorVideo.HasDataToUpdate() && !DeseaPerderInformacion();
        }

        private void btnAddNew_Click(object sender, EventArgs e)
        {
            if (!visorEditorCreadorVideo.HasDataToUpdate() || DeseaPerderInformacion())
            {
                visorEditorCreadorVideo.Video = new Video();
                visorEditorCreadorVideo.Refresh();
            }
        }
    }
}
