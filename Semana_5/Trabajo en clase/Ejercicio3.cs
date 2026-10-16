using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5.Trabajo_en_clase
{
    public partial class Ejercicio3 : Form
    {
        public Ejercicio3()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar el nombre del producto.");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            double precio;
            if (!double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                errorProvider1.SetError(txtPrecio, "El precio debe ser un número mayor que cero.");
            }
            else
            {
                errorProvider1.SetError(txtPrecio, "");
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || !double.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                return;
            }

            Producto producto1 = new Producto();

            producto1.Nombre = txtNombre.Text.Trim();
            producto1.Precio = precio;

            producto1.MostrarInfo();
        }
    }
}
