using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Semana_10.Segundo_examen
{
    public partial class Ejercicio2 : Form
    {
        List<Actividad> listaActividades = new List<Actividad>();

        public Ejercicio2()
        {
            InitializeComponent();
            dgvActividades.Anchor = AnchorStyles.Top | AnchorStyles.Bottom |  AnchorStyles.Left | AnchorStyles.Right; dgvActividades.Columns.Add("colInformacion", "Información");
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtResponsable.Text))
            {
                MessageBox.Show("Complete la descripción y el responsable.");
                return;
            }

            Actividad act = new Actividad
            {
                Descripcion = txtDescripcion.Text.Trim(),
                Responsable = txtResponsable.Text.Trim()
            };

            listaActividades.Add(act);

            txtDescripcion.Clear();
            txtResponsable.Clear();
            txtDescripcion.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            dgvActividades.Rows.Clear();

            foreach (var act in listaActividades)
            {
                dgvActividades.Rows.Add(act.Informacion);
            }
        }
    }
}