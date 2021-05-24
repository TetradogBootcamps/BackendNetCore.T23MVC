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
        static int IdGen = 0;
        public Form1()
        {
            InitializeComponent();
            Videos = new List<Video>();

        }
        List<Cliente> Clientes => visorEditorCreadorVideo.Clientes;
        List<Video> Videos { get; set; }

        private void btnAddClientes_Click(object sender, EventArgs e)
        {

            FrmClientes frmClientes = new FrmClientes();
            frmClientes.Clientes = Clientes;
            frmClientes.UpdateList();
            frmClientes.ShowDialog();
            //actualizo los CMB de clientes
            visorEditorCreadorVideo.RefreshCmb();

        }

        private void visorEditorCreadorVideo1_Added(object sender, EventArgs e)
        {
            Video video = visorEditorCreadorVideo.Video;
            video.Id = IdGen++;
            Videos.Add(video);
            UpdateList();
        }

        private void UpdateList()
        {
            Video videoAux = lstVideos.SelectedItem as Video;
            lstVideos.SelectedIndexChanged -= lstVideos_SelectedIndexChanged;

            lstVideos.Items.Clear();
            for (int i = 0; i < Videos.Count; i++)
                lstVideos.Items.Add(Videos[i]);

            if (!Equals(videoAux, default))
            {
                lstVideos.SelectedIndex = Videos.IndexOf(videoAux);
            }

            lstVideos.SelectedIndexChanged += lstVideos_SelectedIndexChanged;
        }

        private void visorEditorCreadorVideo1_Updated(object sender, EventArgs e)
        {
            UpdateList();
        }

        private void visorEditorCreadorVideo1_Deleted(object sender, EventArgs e)
        {
            if (visorEditorCreadorVideo.Video.Id.HasValue)
            {
                Videos.Remove(visorEditorCreadorVideo.Video);
                UpdateList();
            }
        }

        private void lstVideos_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstVideos.SelectedIndex >= 0 && !ReferenceEquals(Videos[lstVideos.SelectedIndex], visorEditorCreadorVideo.Video))
            {
                if (!visorEditorCreadorVideo.HasDataToUpdate() || DeseaPerderInformacion())
                {
                    visorEditorCreadorVideo.Video = Videos[lstVideos.SelectedIndex];
                    visorEditorCreadorVideo.Refresh();
                }
                else
                {
                    lstVideos.SelectedIndex = Videos.IndexOf(visorEditorCreadorVideo.Video);
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
