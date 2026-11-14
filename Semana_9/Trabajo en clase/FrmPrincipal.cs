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

namespace Semana_9
{
    public partial class FrmPrincipal : Form
    {
        private readonly string conexion = "server=localhost;database=Tienda;uid=root;pwd=*A123456789*;";
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        //Ejercicio 1.
        private void btnProbarConexion_Click(object sender, EventArgs e)
        {
            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    MessageBox.Show("Conexión exitosa");
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

        //Ejercicio 2.
        private void btnInsertar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Debe completar el nombre y el correo.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = "INSERT INTO Clientes (Nombre, Correo) VALUES (@Nombre, @Correo)";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Cliente insertado correctamente.");
                    txtNombre.Clear();
                    txtCorreo.Clear();
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en MySQL: " + ex.Message);
            }
        }

        //Ejercicio 3.
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBuscar.Text))
            {
                MessageBox.Show("Escriba el nombre que desea buscar.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = "SELECT * FROM Clientes WHERE Nombre=@Nombre";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtBuscar.Text.Trim());

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            txtNombre.Text = reader["Nombre"].ToString();
                            txtCorreo.Text = reader["Correo"].ToString();
                        }
                        else
                        {
                            MessageBox.Show("No se encontró ningún cliente con ese nombre.");
                        }
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en MySQL: " + ex.Message);
            }
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text) || string.IsNullOrWhiteSpace(txtCorreo.Text))
            {
                MessageBox.Show("Primero busque un cliente y escriba el nuevo correo.");
                return;
            }

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = "UPDATE Clientes SET Correo=@Correo WHERE Nombre=@Nombre";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Correo", txtCorreo.Text.Trim());
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());

                    int filasAfectadas = cmd.ExecuteNonQuery();

                    if (filasAfectadas > 0)
                        MessageBox.Show("Correo actualizado correctamente.");
                    else
                        MessageBox.Show("No se modificó ningún registro.");
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en MySQL: " + ex.Message);
            }
        }

        //Ejercicio 4.
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Escriba el nombre del cliente a eliminar.");
                return;
            }

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de que desea eliminar a " + txtNombre.Text.Trim() + "?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta != DialogResult.Yes)
                return;

            try
            {
                using (MySqlConnection conn = new MySqlConnection(conexion))
                {
                    conn.Open();
                    string sql = "DELETE FROM Clientes WHERE Nombre=@Nombre";
                    MySqlCommand cmd = new MySqlCommand(sql, conn);
                    cmd.Parameters.AddWithValue("@Nombre", txtNombre.Text.Trim());

                    int filas = cmd.ExecuteNonQuery();

                    if (filas > 0)
                    {
                        MessageBox.Show("Cliente eliminado correctamente.");
                        txtNombre.Clear();
                        txtCorreo.Clear();
                    }
                    else
                    {
                        MessageBox.Show("No existe un cliente con ese nombre.");
                    }
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Error en MySQL: " + ex.Message);
            }
        }
    }
}
