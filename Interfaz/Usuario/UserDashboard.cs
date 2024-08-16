using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hackaton_Frontasks.Interfaz.Usuario
{
    public partial class UserDashboard : Form
    {
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void BtListTareas_Click(object sender, EventArgs e)
        {

        }

        private void BtNuevaTarea_Click(object sender, EventArgs e)
        {
            NuevaTarea frm = new NuevaTarea();
            frm.IdUsuario.Text = idUsuario.Text;

            frm.Show();
            this.Hide();
        }
    }
}
