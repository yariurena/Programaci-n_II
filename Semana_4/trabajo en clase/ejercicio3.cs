using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_4.trabajo_en_clase
{
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            int numero;
            if (!int.TryParse(txtNumero.Text, out numero))
            {
                MessageBox.Show("Debe ingresar un número.");
                return;
            }
            if (numero < 1)
            {
                MessageBox.Show("El número debe estar entre 1 y 4.");
                return;
            }
            if (numero > 4)
            {
                MessageBox.Show("El número debe estar entre 1 y 4.");
                return;
            }

            switch (numero)
            {
                case 1:
                    MessageBox.Show("Opción 1 seleccionada.");
                    break;
                case 2:
                    MessageBox.Show("Opción 2 seleccionada.");
                    break;
                case 3:
                    MessageBox.Show("Opción 3 seleccionada.");
                    break;
                case 4:
                    MessageBox.Show("Opción 4 seleccionada.");
                    break;
                default:
                    MessageBox.Show("Opción no válida.");
                    break;
            }
        }
    }
}
