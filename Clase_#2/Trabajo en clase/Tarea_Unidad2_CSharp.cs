using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Clase__2.Trabajo_en_clase
{
    public partial class Tarea_Unidad2_CSharp : Form
    {
        public Tarea_Unidad2_CSharp()
        {
            InitializeComponent();
        }

        private void Tarea_Unidad2_CSharp_Load(object sender, EventArgs e)
        {
            listBoxColores.Items.Add("Rojo");
            listBoxColores.Items.Add("Azul");
            listBoxColores.Items.Add("Verde");
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            double numero1 = Convert.ToDouble(txtNumero1.Text);
            double numero2 = Convert.ToDouble(txtNumero2.Text);

            if (numero1 > numero2)
            {
                MessageBox.Show("El número mayor es: " + numero1);
            }
            else if (numero2 > numero1)
            {
                MessageBox.Show("El número mayor es: " + numero2);
            }
            else
            {
                MessageBox.Show("Los dos números son iguales.");
            }
        }

        private void listBoxColores_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBoxColores.SelectedItem != null)
            {
                string colorSeleccionado = listBoxColores.SelectedItem.ToString();

                if (colorSeleccionado == "Rojo")
                {
                    this.BackColor = Color.Red;
                }
                else if (colorSeleccionado == "Azul")
                {
                    this.BackColor = Color.Blue;
                }
                else if (colorSeleccionado == "Verde")
                {
                    this.BackColor = Color.Green;
                }
            }
        }

        private void cambiarFondoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (colorDialogFondo.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorDialogFondo.Color;
            }
        }
    }
}
