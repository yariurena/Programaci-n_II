using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7.Trabajo_en_clase.BL__ejercicio_1_
{
    public class ServicioProducto
    {
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>();

            productos.Add(new Producto
            {
                Nombre = "Arroz",
                Precio = 1500
            });

            productos.Add(new Producto
            {
                Nombre = "Leche",
                Precio = 1200
            });

            productos.Add(new Producto
            {
                Nombre = "Pan",
                Precio = 900
            });
            return productos;
        }
    }
}
