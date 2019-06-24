using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplicacionPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {
            txtID.Focus();
        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label3_Click(object sender, EventArgs e)
        {

        }

        private void Btniniciar_Click(object sender, EventArgs e)
        {
            if (txtID.Text == "TWL" && txtcontraseña.Text == "123")
            {
                // MessageBox.Show("Se ha iniciado sesion");
                this.Hide();

                ventana2 NuevaVentana = new ventana2();

                NuevaVentana.Show();
            }
            else
            {
                MessageBox.Show("Su usuario o contraseña son incorrectos");

                

                txtID.Text = "";
                txtcontraseña.Text = "";

                txtID.Focus();


            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
