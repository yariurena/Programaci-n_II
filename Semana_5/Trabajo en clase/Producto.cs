using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_5.Trabajo_en_clase
{
    public class Producto
    {
        //Primer ejercicio
        //public string Nombre;
        //public double Precio;
        
        //public void MostrarInfo()
            //{
            //MessageBox.Show("Nombre: " + Nombre + "\nPrecio: " + Precio);
            //}

        private string nombre;
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private double precio;
        public double Precio
        {
            get { return precio; }
            set { precio = value; }
        }

        public void MostrarInfo()
        {
            MessageBox.Show("Nombre: " + Nombre + "\nPrecio: " + Precio);
        }
    }
}
