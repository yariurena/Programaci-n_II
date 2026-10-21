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
    public partial class ejercicio2 : Form
    {
        public ejercicio2()
        {
            InitializeComponent();
        }

        private string ClasificarNota(double nota)
        {
            if (nota >= 90)
            {
                return "Excelente";
            }
            else if (nota >= 80)
            {
                return "Muy bueno";
            }
            else if (nota >= 70)
            {
                return "Bueno";
            }
            else if (nota >= 60)
            {
                return "Regular";
            }
            else
            {
                return "Deficiente";
            }
        }

        private void ejercicio2_Load(object sender, EventArgs e)
        {
            lstCategorias.Items.Add("Excelente");
            lstCategorias.Items.Add("Muy bueno");
            lstCategorias.Items.Add("Bueno");
            lstCategorias.Items.Add("Regular");
            lstCategorias.Items.Add("Deficiente");
        }

        private void btnEvaluar_Click(object sender, EventArgs e)
        {
            if (txtNota.Text == "")
            {
                MessageBox.Show("Debe ingresar una nota.");
            }
            else
            {
                double nota = Convert.ToDouble(txtNota.Text);

                if (nota < 0 || nota > 100)
                {
                    MessageBox.Show("La nota debe estar entre 0 y 100.");
                }
                else
                {
                    string categoria = ClasificarNota(nota);
                    lblResultado.Text = "Resultado: " + categoria;
                    lstCategorias.SelectedItem = categoria;
                    if (nota >= 90)
                    {
                        lblResultado.BackColor = Color.LightGreen;
                    }
                    else if (nota < 60)
                    {
                        lblResultado.BackColor = Color.LightCoral;
                    }
                    else
                    {
                        lblResultado.BackColor = SystemColors.Control;
                    }
                }
            }
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNota.Clear();
            lblResultado.Text = "";
            lblResultado.BackColor = SystemColors.Control;
            lstCategorias.ClearSelected();
        }
    }
}
