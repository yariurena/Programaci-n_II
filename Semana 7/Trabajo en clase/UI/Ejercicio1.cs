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

namespace Semana_7
{
    public partial class Ejercicio1 : Form
    {
        public Ejercicio1()
        {
            InitializeComponent();

            ServicioProducto servicioProducto = new ServicioProducto();
            List<Producto> productos = servicioProducto.ObtenerProductos();
            dgvProductos.DataSource = productos;
        }
    }
}
