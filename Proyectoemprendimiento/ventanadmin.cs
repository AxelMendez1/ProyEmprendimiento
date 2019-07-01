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
    public partial class ventanadmin : Form
    {
        public ventanadmin()
        {
            InitializeComponent();
        }

        private void Label6_Click(object sender, EventArgs e)
        {

        }

        private void Ventanadmin_Load(object sender, EventArgs e)
        {
            String cmd = "Select * FROM usuarios WHERE id_usuario=" + ventanalogin.codigo;

            DataSet DS = Utilidades.Ejecutar(cmd);
            lblnomadmin.Text = DS.Tables[0].Rows[0]["Nom_usu"].ToString();
            lblusadmin.Text = DS.Tables[0].Rows[0]["account"].ToString();
            lblcodigo.Text = DS.Tables[0].Rows[0]["id_usuario"].ToString();

            string url = DS.Tables[0].Rows[0]["Foto"].ToString();

            pictureBox1.Image = Image.FromFile(url);

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Ventanadmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
