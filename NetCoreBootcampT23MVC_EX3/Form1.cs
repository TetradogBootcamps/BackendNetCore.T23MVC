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
            e.Cancel = editorProyectos.HasDataToUpdate() && !MessageWhantToLoseData();
        }
        public static bool MessageWhantToLoseData()
        {
            return MessageBox.Show("Hay información por actualizar,¿ está seguro que quiere perderla?","Atención",MessageBoxButtons.YesNo,MessageBoxIcon.Exclamation) == DialogResult.Yes;
        }
    }
}
