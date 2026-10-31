using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7.Trabajo_en_clase.BL
{
    public class ServicioProducto
    {
        public List<Producto> ObtenerProductos()
        {
            List<Producto> productos = new List<Producto>
        {
            new Producto { Nombre = "Laptop", Precio = 1200 },
            new Producto { Nombre = "Mouse", Precio = 25 },
            new Producto { Nombre = "Teclado", Precio = 50 }
        };
            return productos;
        }
    }
}
