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

namespace Hackaton_Frontasks.Interfaz.Usuario
{
    public partial class UserDashboard : Form
    {

        bool sidebarExpand;
        cConexion cn; //Variable cConexion
        SqlCommand cmd; //para traer los comandos del sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        public UserDashboard()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Completado frm = new Completado();
            frm.idUsuario.Text = idUsuario.Text;

            frm.Show();
            this.Hide();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void UserDashboard_Load(object sender, EventArgs e)
        {
            updatedgv();
        }

        private void BtListPendientes_Click(object sender, EventArgs e)
        {
            Pendientes frm = new Pendientes();
            frm.IdUsuario.Text = idUsuario.Text;

            frm.Show();
            this.Hide();
        }

        private void BtTareasAtrasadas_Click(object sender, EventArgs e)
        {
            Atrasadas frm = new Atrasadas();
            frm.IdUsusario.Text = idUsuario.Text;

            frm.Show();
            this.Hide();
        }

        private void dgvTareas_SelectionChanged(object sender, EventArgs e)
        {
            


            if (dgvTareas.SelectedRows.Count > 0)
            {
                IdTarea.Text = dgvTareas.CurrentRow.Cells[5].Value.ToString();

            }

        }

        private void updatedgv()
        {
            int n = 0;
            cn = new cConexion();
            SqlCommand cmd = new SqlCommand("select * from tblTareas where id_usuario = '" + idUsuario.Text + "' ", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count != 0)
            {

                n = dt.Rows.Count;
                dgvTareas.Rows.Add(n);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dgvTareas.Rows[i].Cells[0].Value = dt.Rows[i][1].ToString();
                    dgvTareas.Rows[i].Cells[1].Value = dt.Rows[i][3].ToString();
                    dgvTareas.Rows[i].Cells[2].Value = dt.Rows[i][4].ToString();
                    dgvTareas.Rows[i].Cells[3].Value = dt.Rows[i][5].ToString();
                    dgvTareas.Rows[i].Cells[4].Value = dt.Rows[i][6].ToString();
                    dgvTareas.Rows[i].Cells[5].Value = dt.Rows[i][0].ToString();

                }
            }

        }

        private void BtCompletar_Click(object sender, EventArgs e)
        {
            cn = new cConexion();
            SqlCommand cmd = new SqlCommand("update tblTareas set estado  = '" + "Completado" + "' where id_tarea= '" + IdTarea.Text + "' ", cn.AbrirConexion());
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            cmd.ExecuteNonQuery();

            updatedgv();
        }
    }
}
