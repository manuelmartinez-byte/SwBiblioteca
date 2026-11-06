using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using SwBiblioteca.Datos;

namespace SwBiblioteca
{
    public partial class FrmUsuarios : Form
    {
        public FrmUsuarios()
        {
            InitializeComponent();
            CargarUsuarios();
        }

        private void lblcorreo_usuarios_Click(object sender, EventArgs e)
        {

        }

        private void CargarUsuarios()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Usuarios";

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvUsuarios.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtnombre_usuarios.Text) ||
       string.IsNullOrWhiteSpace(txtapellido_usuarios.Text) ||
       string.IsNullOrWhiteSpace(txtdocumentos_usuarios.Text) ||
       string.IsNullOrWhiteSpace(txttelefono_usuarios.Text) ||
       string.IsNullOrWhiteSpace(txtcorreoe_usuarios.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de guardar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "INSERT INTO Usuarios " +
                    "(Nombre, Apellido, Documento, Telefono, Correo) " +
                    "VALUES " +
                    "(@Nombre, @Apellido, @Documento, @Telefono, @Correo)";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@Nombre", txtnombre_usuarios.Text.Trim());
                    comando.Parameters.AddWithValue("@Apellido", txtapellido_usuarios.Text.Trim());
                    comando.Parameters.AddWithValue("@Documento", txtdocumentos_usuarios.Text.Trim());
                    comando.Parameters.AddWithValue("@Telefono", txttelefono_usuarios.Text.Trim());
                    comando.Parameters.AddWithValue("@Correo", txtcorreoe_usuarios.Text.Trim());

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario guardado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevo_usuarios_Click(null, null);




        }

        private void btnNuevo_usuarios_Click(object sender, EventArgs e)
        {
            txtnombre_usuarios.Clear();
            txtapellido_usuarios.Clear();
            txtdocumentos_usuarios.Clear();
            txttelefono_usuarios.Clear();
            txtcorreoe_usuarios.Clear();

            txtnombre_usuarios.Focus();
        }

        // *** Metodo Función CellDoubleClick - dgvUsuarios ****

        private void dgvUsuarios_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            txtnombre_usuarios.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Nombre"].Value.ToString();

            txtapellido_usuarios.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Apellido"].Value.ToString();

            txtdocumentos_usuarios.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Documento"].Value.ToString();

            txttelefono_usuarios.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Telefono"].Value.ToString();

            txtcorreoe_usuarios.Text = dgvUsuarios.Rows[e.RowIndex].Cells["Correo"].Value.ToString();
        }

        // *** Código btnEditar_Click ***

        private void btnEditar_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            if (string.IsNullOrWhiteSpace(txtnombre_usuarios.Text) ||
                string.IsNullOrWhiteSpace(txtapellido_usuarios.Text) ||
                string.IsNullOrWhiteSpace(txtdocumentos_usuarios.Text) ||
                string.IsNullOrWhiteSpace(txttelefono_usuarios.Text) ||
                string.IsNullOrWhiteSpace(txtcorreoe_usuarios.Text))
            {
                MessageBox.Show(
                    "Complete todos los campos antes de editar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "UPDATE Usuarios SET " +
                    "Nombre = @Nombre, " +
                    "Apellido = @Apellido, " +
                    "Documento = @Documento, " +
                    "Telefono = @Telefono, " +
                    "Correo = @Correo " +
                    "WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue(
                        "@Nombre",
                        txtnombre_usuarios.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Apellido",
                        txtapellido_usuarios.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Documento",
                        txtdocumentos_usuarios.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Telefono",
                        txttelefono_usuarios.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@Correo",
                        txtcorreoe_usuarios.Text.Trim());

                    comando.Parameters.AddWithValue(
                        "@IdUsuario",
                        idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario actualizado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevo_usuarios_Click(null, null);
        }

        private void btnEliminar_usuarios_Click(object sender, EventArgs e)
        {
            if (dgvUsuarios.CurrentRow == null)
            {
                MessageBox.Show(
                    "Seleccione un usuario para eliminar.",
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            int idUsuario = Convert.ToInt32(
                dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            DialogResult respuesta = MessageBox.Show(
                "¿Está seguro de eliminar este usuario?",
                "Biblioteca",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (respuesta == DialogResult.No)
            {
                return;
            }

            Conexion conexion = new Conexion();

            using (SqlConnection cn = conexion.ObtenerConexion())
            {
                cn.Open();

                string consulta =
                    "DELETE FROM Usuarios WHERE IdUsuario = @IdUsuario";

                using (SqlCommand comando = new SqlCommand(consulta, cn))
                {
                    comando.Parameters.AddWithValue("@IdUsuario", idUsuario);

                    comando.ExecuteNonQuery();
                }
            }

            MessageBox.Show(
                "Usuario eliminado correctamente.",
                "Biblioteca",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            CargarUsuarios();

            btnNuevo_usuarios_Click(null, null);
        }

        // *** Código btnCancelar_Click ***

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtnombre_usuarios.Clear();
            txtapellido_usuarios.Clear();
            txtdocumentos_usuarios.Clear();
            txttelefono_usuarios.Clear();
            txtcorreo_usuarios.Clear();

            dgvUsuarios.ClearSelection();

            txtnombre_usuarios.Focus();

        }
    }
}
