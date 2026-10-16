using Semana_5.Trabajo_en_clase;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5
{
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void Ejercicio1_Load(object sender, EventArgs e)
        {
            Producto producto1 = new Producto();

            producto1.Nombre = "Computadora";
            producto1.Precio = 450000;

            producto1.MostrarInfo();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text.Trim();
            double precio;

            if (string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar el nombre del producto.");
                return;
            }

            if (!double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("El precio debe ser un número mayor que cero.");
                return;
            }

            Producto producto1 = new Producto();

            producto1.Nombre = nombre;
            producto1.Precio = precio;

            producto1.MostrarInfo();
        }
    }
}
