using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana_10.Segundo_examen
{
    public class Empleado : Persona
    {
        public decimal Salario { get; set; }

        public decimal SalarioAnual => Salario * 12;
    }
}
