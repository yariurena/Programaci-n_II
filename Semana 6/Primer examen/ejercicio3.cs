using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Semana_6.Primer_examen
{
    public partial class ejercicio3 : Form
    {
        public ejercicio3()
        {
            InitializeComponent();
        }

        private void ejercicio3_Load(object sender, EventArgs e)
        {
            lstServicios.Items.Add("Instalación de software");
            lstServicios.Items.Add("Mantenimiento");
            lstServicios.Items.Add("Soporte técnico");
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            if (lstServicios.SelectedIndex == -1)
            {
                MessageBox.Show("Debe seleccionar un servicio.");
            }
            else
            {
                decimal precio = 0;
                switch (lstServicios.SelectedIndex)
                {
                    case 0:
                        precio = 15000;
                        break;

                    case 1:
                        precio = 20000;
                        break;

                    case 2:
                        precio = 10000;
                        break;
                }
                MessageBox.Show("Servicio: " + lstServicios.SelectedItem + "\nPrecio: ₡" + precio);
            }
        }

        private void limpiarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            lstServicios.ClearSelected();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
