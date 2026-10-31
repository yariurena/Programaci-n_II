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
    public partial class Ejercicio2 : Form
    {
        public Ejercicio2()
        {
            InitializeComponent();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Estudiante estudiante = new Estudiante();
            estudiante.AñoNacimiento = 2000;

            MessageBox.Show("Año de nacimiento: " + estudiante.AñoNacimiento + "\nEdad calculada: " + estudiante.EdadCalculada);
        }
    }
}
