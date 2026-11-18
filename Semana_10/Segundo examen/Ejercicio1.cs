using Semana_10.Segundo_examen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_10
{
    public partial class Ejercicio1 : Form
    {
        private List<Empleado> listaEmpleados = new List<Empleado>();
        public Ejercicio1()
        {
            InitializeComponent();

            dgvEmpleados.Columns.Add("colIdentificacion", "Identificación");
            dgvEmpleados.Columns.Add("colNombre", "Nombre");
            dgvEmpleados.Columns.Add("colSalario", "Salario");
            dgvEmpleados.Columns.Add("colSalarioAnual", "Salario anual");

            dgvEmpleados.Columns["colSalario"].DefaultCellStyle.Format = "N2";
            dgvEmpleados.Columns["colSalarioAnual"].DefaultCellStyle.Format = "N2";
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtIdentificacion.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtSalario.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            decimal salario;
            if (!decimal.TryParse(txtSalario.Text, out salario))
            {
                MessageBox.Show("El salario debe ser un número válido.");
                return;
            }

            Empleado emp = new Empleado
            {
                Identificacion = txtIdentificacion.Text.Trim(),
                Nombre = txtNombre.Text.Trim(),
                Salario = salario
            };

            listaEmpleados.Add(emp);

            txtIdentificacion.Clear();
            txtNombre.Clear();
            txtSalario.Clear();
            txtIdentificacion.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvEmpleados.Rows.Clear();

            foreach (var emp in listaEmpleados)
            {
                dgvEmpleados.Rows.Add(emp.Identificacion, emp.Nombre, emp.Salario, emp.SalarioAnual);
            }
        }
    }
}
