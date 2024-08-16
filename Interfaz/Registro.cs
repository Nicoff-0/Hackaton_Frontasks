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
    public partial class Registro : Form
    {
        cConexion cn; //Variable cConexion
        SqlCommand cmd; //para traer los comandos del sql
        SqlDataAdapter da; //Se necesita para las consultas
        DataTable dt;
        public Registro()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void BtRegistrar_Click(object sender, EventArgs e)
        {
            if (TbName.Text == "" || TbLastName.Text == "" || TbMail.Text == "" || TbPassword.Text == "" || TbId.Text == "" )
            {
                MessageBox.Show("Informacion incompleta");
            }
            else
            {



                cn = new cConexion(); cmd = new SqlCommand("Select * from tblUsuarios where id_usuario= '" + TbId.Text + "' ", cn.AbrirConexion());
                da = new SqlDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);//llena dt con consulta cmd

                if (dt.Rows.Count > 0)
                {
                    MessageBox.Show("Usuario ya registrado, inicie sesion");
                    this.Hide();
                    LoginPane frmy = new LoginPane();
                    frmy.Show();
                }
                else
                {
                    cn = new cConexion();
                    cmd = new SqlCommand("insert into tblUsuarios values ( '" + TbId.Text + "', '" + TbName.Text + "', '" + TbLastName.Text + "', '" + TbMail.Text + "', '" + TbPassword.Text + "')", cn.AbrirConexion());

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Usuario creado");
                }
                LoginPane frm = new LoginPane();
                frm.Show();
                this.Hide();
            }
        }

        private void LinkIniciar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            LoginPane frm = new LoginPane();
            frm.Show();
        }
    }
}
