using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase_1
{
    public partial class hola : Form
    {
        public hola()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            
        }

        private void txt2_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl4_Click(object sender, EventArgs e)
        {

        }

        private void btnSumar_Click(object sender, EventArgs e)
        {
            int numero1 = int.Parse(txtNumero1.Text);
            int numero2 = int.Parse(txtNumero2.Text);

            int resultado = numero1 + numero2;
            lblResultado.Text = "Resultado: " + resultado;

        }
    }
}