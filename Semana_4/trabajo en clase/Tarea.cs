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
    public partial class Tarea : Form
    {
        public Tarea()
        {
            InitializeComponent();
        }

        private void btnMostrarDia_Click(object sender, EventArgs e)
        {
            int dia;
            if (!int.TryParse(txtDia.Text, out dia))
            {
                MessageBox.Show("Error! Debe ingresar un número.");
                return;
            }

            switch (dia)
            {
                case 1:
                    MessageBox.Show("Lunes");
                    break;
                case 2:
                    MessageBox.Show("Martes");
                    break;
                case 3:
                    MessageBox.Show("Miércoles");
                    break;
                case 4:
                    MessageBox.Show("Jueves");
                    break;
                case 5:
                    MessageBox.Show("Viernes");
                    break;
                case 6:
                    MessageBox.Show("Sábado");
                    break;
                case 7:
                    MessageBox.Show("Domingo");
                    break;
                default:
                    MessageBox.Show("Error! ingrese un número del 1 al 7.");
                    break;
            }

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea salir del programa?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                this.Close();
            }
        }
    }
}