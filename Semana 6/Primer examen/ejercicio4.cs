using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_6.Primer_examen
{
    public partial class ejercicio4 : Form
    {
        public ejercicio4()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            errorProvider1.Clear();

            bool valido = true;
            decimal precio = 0;

            if (string.IsNullOrWhiteSpace(txtCodigo.Text))
            {
                errorProvider1.SetError(txtCodigo, "Ingrese el código.");
                valido = false;
            }
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Ingrese el nombre.");
                valido = false;
            }
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(txtPrecio, "El precio debe ser mayor que cero.");
                valido = false;
            }
            if (valido == false)
            {
                MessageBox.Show("Debe corregir los datos.");
            }
            else
            {
                Producto producto = new Producto();

                producto.Codigo = txtCodigo.Text;
                producto.Nombre = txtNombre.Text;
                producto.Precio = precio;

                decimal precioConIVA = producto.ObtenerPrecioConIVA();

                MessageBox.Show(
                    "Código: " + producto.Codigo +
                    "\nNombre: " + producto.Nombre +
                    "\nPrecio: ₡" + producto.Precio +
                    "\nPrecio con IVA: ₡" + precioConIVA,
                    "Información del producto");
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            errorProvider1.Clear();
        }
    }
}
