using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using MiLibreria;



namespace Proyectoemprendimiento
{
    public partial class ventanalogin : Form
    {
        public ventanalogin()
        {
            InitializeComponent();
        }
        public static string codigo= "";

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE account ='{0}' AND password ='{1}'", txtnomacc.Text.Trim(), txtpass.Text.Trim());

                DataSet ds = Utilidades.Ejecutar(CMD);

                string cuenta = ds.Tables[0].Rows[0]["account"].ToString().Trim();
                string contra = ds.Tables[0].Rows[0]["password"].ToString().Trim();

                codigo = ds.Tables[0].Rows[0]["id_usuario"].ToString().Trim();

                if (cuenta == txtnomacc.Text.Trim() && contra == txtpass.Text.Trim())
                {
                }
               
                {
                    if (Convert.ToBoolean(ds.Tables[0].Rows[0]["Status_admin"]) == true)
                    {
                        ventanadmin VenAd = new ventanadmin();
                        this.Hide();
                        VenAd.Show();
                    }
                    else
                    {
                        ventanauser VeNus = new ventanauser();
                        this.Hide();
                        VeNus.Show();
                    }
                }
                

            }
            catch
            {
                MessageBox.Show("Contraseña o usuario incorrecto");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Txtnomacc_TextChanged(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Ventanalogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Ventanalogin_Load(object sender, EventArgs e)
        {

        }
    }
}
