using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_10.Segundo_examen
{
    public class Actividad
    {
        public string Descripcion { get; set; }
        public string Responsable { get; set; }
        public DateTime Fecha { get; set; }

        public Actividad()
        {
            Fecha = DateTime.Now;
        }

        public string Informacion => $"{Descripcion} - {Responsable} - {Fecha:dd/MM/yyyy}";
    }
}
