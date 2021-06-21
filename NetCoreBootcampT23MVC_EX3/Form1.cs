using NetCoreBootcampT23MVC_EX3.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NetCoreBootcampT23MVC_EX3
{
    public partial class FrmMain : Form
    {

        public FrmMain()
        {
            InitializeComponent();

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (editorCientificos.HasDataToUpdate() || editorProyectos.HasDataToUpdate()) && !MessageWhantToLoseData();
        }
        public static bool MessageWhantToLoseData()
        {
            return MessageBox.Show("Hay información por actualizar,¿ está seguro que quiere perderla?","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes;
        }

        private void tbMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            const int INDEXASIGNADOA = 2;

            if (tbMain.SelectedIndex==INDEXASIGNADOA)
            {
                asignarProyectos1.Refresh();
            }
        }
    }
}
