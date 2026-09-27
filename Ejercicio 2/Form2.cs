using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_2
{
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            try
            {
                double numero1 = double.Parse(txtNumero1.Text);
                double numero2 = double.Parse(txtNumero2.Text);

                double resultado = numero1 * numero2;

                lblResultado.Text = "Resultado: " + resultado;
            }
            catch
            {
                MessageBox.Show("Por favor, ingrese números válidos.");
            }
        }
    }
}
