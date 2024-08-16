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
    public partial class Atrasadas : Form
    {

        bool sidebarExpand;
        cConexion cn; //Variable cConexion
        SqlCommand cmd; //para traer los comandos del sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        public Atrasadas()
        {
            InitializeComponent();
        }

        private void Atrasadas_Load(object sender, EventArgs e)
        {
            int n = 0;
            cn = new cConexion();
            SqlCommand cmd = new SqlCommand("select * from tblTareas where id_usuario = '" + IdUsusario.Text + "' and estado= '" + "Atrasado" + " '", cn.AbrirConexion());
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

                }
            }
        }
    }
}
