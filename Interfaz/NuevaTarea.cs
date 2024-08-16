using Hackaton_Frontasks.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Hackaton_Frontasks.Interfaz
{
    public partial class NuevaTarea : Form
    {

        cConexion cn; //Variable cConexion
        SqlCommand cmd; //para traer los comandos del sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        public NuevaTarea()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtAceptar_Click(object sender, EventArgs e)
        {

            DateTime now = DateTime.Now;
            

            cn = new cConexion();
            cmd = new SqlCommand("insert into tblTareas values ( '" + TbTitulo.Text + "', '" + TbTitulo.Text + "', '" + TbDescripcion.Text + "', '" + CbEstado.Text + "', '" + DtpFechaFin.Value + "', '" + CbPrioridad.Text + "', '" + now + "', '"  + txtId.Text + "')", cn.AbrirConexion());

            cmd.ExecuteNonQuery();

            MessageBox.Show("Vehiculo inscrito");


        }

        private void NuevaTarea_Load(object sender, EventArgs e)
        {

        }
    }
}
