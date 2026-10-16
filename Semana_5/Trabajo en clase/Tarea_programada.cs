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
    public partial class Tarea_programada : Form
    {
        public Tarea_programada()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                errorProvider1.SetError(txtNombre, "Debe ingresar el nombre del estudiante.");
            }
            else
            {
                errorProvider1.SetError(txtNombre, "");
            }

            if (string.IsNullOrWhiteSpace(txtCurso.Text))
            {
                errorProvider1.SetError(txtCurso, "Debe ingresar el nombre del curso.");
            }
            else
            {
                errorProvider1.SetError(txtCurso, "");
            }

            int edad;
            if (!int.TryParse(txtEdad.Text, out edad) || edad <= 0)
            {
                errorProvider1.SetError(txtEdad, "La edad debe ser un número mayor que cero.");
            }
            else
            {
                errorProvider1.SetError(txtEdad, "");
            }

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCurso.Text) || !int.TryParse(txtEdad.Text, out edad) || edad <= 0)
            {
                return;
            }

            Estudiante estudiante1 = new Estudiante();

            estudiante1.Nombre = txtNombre.Text.Trim();
            estudiante1.Edad = int.Parse(txtEdad.Text.Trim());
            estudiante1.Curso = txtCurso.Text.Trim();

            estudiante1.MostrarDatos();
        }
    }
}
