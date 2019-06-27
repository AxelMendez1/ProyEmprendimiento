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

        private void Button1_Click(object sender, EventArgs e)
        {
          try
            {
                string CMD = string.Format("Select * FROM Usuarios WHERE Account ='{0}' AND password = '{1}'", txtnomacc.Text.Trim(), txtpass.Text.Trim());

                DataSet DS = Utilidades.Ejecutar(CMD);

                string cuenta = DS.Tables[0].Rows[0]["Account"].ToString().Trim();
                string contra = DS.Tables[0].Rows[0]["Password"].ToString().Trim();

                if (cuenta == txtnomacc.Text.Trim() && contra == txtpass.Text.Trim())

                {
                    if (Convert.ToBoolean(DS.Tables[0].Rows[0]["Status admin"]) ==true)
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
                MessageBox.Show("Contraseña o usuario incorrecta");
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {

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
    }
}
