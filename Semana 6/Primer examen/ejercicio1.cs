using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_6
{
    public partial class ejercicio1 : Form
    {
        public ejercicio1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtHoras.Text) || string.IsNullOrWhiteSpace(txtPagoHora.Text))
            {
                MessageBox.Show("Debe completar todos los campos.");
            }
            else
            {
                double horas;
                double pagoHora;

                if (!double.TryParse(txtHoras.Text, out horas) || !double.TryParse(txtPagoHora.Text, out pagoHora))
                {
                    MessageBox.Show("Debe ingresar valores numéricos.");
                }
                else
                {
                    double salario;
                    if (horas <= 0 || pagoHora <= 0)
                    {
                        MessageBox.Show("Las horas y el pago por hora deben ser mayores que cero.");
                    }
                    else
                    {
                        if (horas <= 40)
                        {
                            salario = horas * pagoHora;
                        }
                        else
                        {
                            salario = (40 * pagoHora) + ((horas - 40) * pagoHora * 1.5);
                        }

                        lblResultado.Text = "Nombre: " + txtNombre.Text + "\nSalario total: ₡" + salario.ToString("N2");
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtHoras.Clear();
            txtPagoHora.Clear();
            lblResultado.Text = "";
        }
    }
}
