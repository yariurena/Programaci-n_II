using Semana_7.Trabajo_en_clase.BL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_7.Trabajo_en_clase.UI
{
    public partial class Ejercicio3 : Form
    {
        List<Producto> listaProductos;
        public Ejercicio3()
        {
            InitializeComponent();

            ServicioProducto servicioProducto = new ServicioProducto();
            listaProductos = servicioProducto.ObtenerProductos();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Desea guardar los cambios?", "Confirmar", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                foreach (var p in listaProductos)
                {
                    MessageBox.Show("Producto: " + p.Nombre + " - Precio: " + p.Precio);
                }
            }
            else
            {
                MessageBox.Show("Proceso cancelado.");
            }
        }
    }
}
