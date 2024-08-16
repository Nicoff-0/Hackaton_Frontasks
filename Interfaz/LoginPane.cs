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

namespace Hackaton_Frontasks.Interfaz
{
    public partial class LoginPane : Form
    {

        cConexion cn; //Variable cConexion
        SqlCommand cmd; //para traer los comandos del sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        public LoginPane()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            cn = new cConexion();

            cmd = new SqlCommand("select * from tblUsuario where id_usuario= '" + TbUser.Text + "' and contrseña= '" + TbPassword.Text + "'", cn.AbrirConexion());
            da = new SqlDataAdapter(cmd);
            dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count == 0)
            {
                if (TbUser.Text == "" || TbPassword.Text == "")
                {
                    MessageBox.Show("Ingrese sus datos");
                }
                else
                {

                    
                    TbUser.Focus();
                    MessageBox.Show("usuario o contraseña incorrecta, intentalo de nuevo");

                    
                }
            }
            else
            {
                if (TbUser.Text == "1")
                {
                    AdminDashboard frm3 = new AdminDashboard();
                    frm3.Show();
                    this.Hide();
                }
                else
                {


                    UserDashboard frm = new UserDashboard();
                    




                   

                    frm.Show();

                    this.Hide();
                }
            }
            //txtUser.Clear();
            TbUser.Clear();


        }
    }
}
