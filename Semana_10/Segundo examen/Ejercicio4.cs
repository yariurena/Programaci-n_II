using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace Semana_10.Segundo_examen
{
    public partial class Ejercicio4 : Form
    {
        string conexion = "server=localhost;database=Tienda;uid=root;pwd=*A123456789*;";

        public Ejercicio4()
        {
            InitializeComponent();
        }

        private void MostrarProductos()
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string sql = @"SELECT p.Codigo, p.Nombre, p.Precio, p.Cantidad, c.Nombre AS Categoria FROM Producto p INNER JOIN Categoria c ON p.CodigoCategoria = c.Codigo ORDER BY p.Codigo";

                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    MySqlDataAdapter da = new MySqlDataAdapter(cmd);
                    DataTable dt = new DataTable();

                    da.Fill(dt);
                    dgvProductos.DataSource = dt;
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }

        private void LimpiarCampos()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
            txtCodigo.Focus();
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            MostrarProductos();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtCodigo.Text) || string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtPrecio.Text) || string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Complete todos los campos.");
                return;
            }

            int codigo, cantidad;
            decimal precio;

            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("El código debe ser un número entero.");
                return;
            }
            if (!decimal.TryParse(txtPrecio.Text, out precio))
            {
                MessageBox.Show("El precio debe ser un número válido.");
                return;
            }
            if (!int.TryParse(txtCantidad.Text, out cantidad))
            {
                MessageBox.Show("La cantidad debe ser un número entero.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();

                    string sql = "INSERT INTO Producto (Codigo, Nombre, Precio, Cantidad, CodigoCategoria) " + "VALUES (@Codigo, @Nombre, @Precio, @Cantidad, @Categoria)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);

                    cmd.Parameters.AddWithValue("@Codigo", codigo);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Precio", precio);
                    cmd.Parameters.AddWithValue("@Cantidad", cantidad);
                    cmd.Parameters.AddWithValue("@Categoria", 1); 

                    cmd.ExecuteNonQuery();
                }

                MessageBox.Show("Producto agregado correctamente.");
                LimpiarCampos();
                MostrarProductos();
            }
            catch (MySqlException ex)
            {
                if (ex.Number == 1062)
                    MessageBox.Show("Ya existe un producto con ese código.");
                else if (ex.Number == 1452)
                    MessageBox.Show("La categoría asignada no existe.");
                else
                    MessageBox.Show("Error en MySQL: " + ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error general: " + ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            int codigo;
            if (!int.TryParse(txtCodigo.Text, out codigo))
            {
                MessageBox.Show("Escriba el código del producto a eliminar.");
                return;
            }

            DialogResult result = MessageBox.Show( "¿Desea eliminar el producto con código " + codigo + "?", "Confirmar", MessageBoxButtons.YesNo
            );

            if (result == DialogResult.Yes)
            {
                try
                {
                    using (MySqlConnection conn = new MySqlConnection(conexion))
                    {
                        conn.Open();

                        string sql = "DELETE FROM Producto WHERE Codigo=@Codigo";
                        MySqlCommand cmd = new MySqlCommand(sql, conn);
                        cmd.Parameters.AddWithValue("@Codigo", codigo);

                        int filas = cmd.ExecuteNonQuery();

                        if (filas > 0)
                        {
                            MessageBox.Show("Producto eliminado.");
                            LimpiarCampos();
                            MostrarProductos();
                        }
                        else
                        {
                            MessageBox.Show("No existe un producto con ese código.");
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Error en MySQL: " + ex.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error general: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Eliminación cancelada.");
            }
        }

        private void dgvProductos_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtCodigo.Text = dgvProductos.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
            }
        }
    }
}