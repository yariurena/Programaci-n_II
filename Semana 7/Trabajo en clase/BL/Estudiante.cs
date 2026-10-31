using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_7.Trabajo_en_clase.BL
{
    public class Estudiante : Persona
    {
        public int EdadCalculada => DateTime.Now.Year - AñoNacimiento;
    }
}
