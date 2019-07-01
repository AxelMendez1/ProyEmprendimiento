using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MiLibreria;

namespace Proyectoemprendimiento
{
    public partial class ventanauser : Form
    {
        public ventanauser()
        {
            InitializeComponent();
        }

        private void Ventanauser_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void Ventanauser_Load(object sender, EventArgs e)
        {
            String cmd = "Select * FROM usuarios WHERE id_usuario=" + ventanalogin.codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);
            lblnomus.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblus.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblcodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);

        }
    }
}
