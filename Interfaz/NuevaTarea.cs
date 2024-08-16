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
            DateTime fin = DtpFechaFin.Value;

            cn = new cConexion();
            cmd = new SqlCommand("INSERT INTO tblTareas (titulo, descripcion, estado, fecha_fin, prioridad, ultima_modificacion, id_usuario) " +
                                 "VALUES (@Titulo, @Descripcion, @Estado, @FechaFin, @Prioridad, @UltimaModificacion, @IdUsuario)", cn.AbrirConexion());

            // Definir los parámetros y asignar valores
            cmd.Parameters.AddWithValue("@Titulo", TbTitulo.Text);
            cmd.Parameters.AddWithValue("@Descripcion", TbDescripcion.Text);
            cmd.Parameters.AddWithValue("@Estado", CbEstado.Text);
            cmd.Parameters.AddWithValue("@FechaFin", fin); // Tipo DateTime
            cmd.Parameters.AddWithValue("@Prioridad", CbPrioridad.Text);
            cmd.Parameters.AddWithValue("@UltimaModificacion", now); // Tipo DateTime
            cmd.Parameters.AddWithValue("@IdUsuario", IdUsuario.Text);

            MessageBox.Show("Tarea Creada");

            int filasAfectadas = cmd.ExecuteNonQuery();

        }

        private void NuevaTarea_Load(object sender, EventArgs e)
        {

        }
    }
}
