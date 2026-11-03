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
    public partial class FrmLibros : Form
    {
        public FrmLibros()
        {
            InitializeComponent();
            CargarLibros();
            CargarAutores();
            CargarEditoriales();
        }
        private void CargarLibros()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvLibros.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los libros:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarAutores()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdAutor, Nombre, Apellido FROM Autores ORDER BY Nombre, Apellido";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        tabla.Columns.Add("NombreCompleto", typeof(string));

                        foreach (DataRow fila in tabla.Rows)
                        {
                            fila["NombreCompleto"] =
                                fila["Nombre"].ToString() + " " +
                                fila["Apellido"].ToString();
                        }

                        cmbAutor.DataSource = tabla;
                        cmbAutor.DisplayMember = "NombreCompleto";
                        cmbAutor.ValueMember = "IdAutor";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los autores:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void CargarEditoriales()
        {
            try
            {
                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT IdEditorial, Nombre FROM Editoriales ORDER BY Nombre";

                    using (SqlDataAdapter adaptador = new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        cmbEditorial.DataSource = tabla;
                        cmbEditorial.DisplayMember = "Nombre";
                        cmbEditorial.ValueMember = "IdEditorial";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las editoriales:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txtbusquedaISBN.Text))
                {
                    MessageBox.Show(
                        "Ingrese un ISBN para realizar la búsqueda.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";

                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", txtbusquedaISBN.Text.Trim());

                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtISBN.Text = lector["ISBN"].ToString();
                                txttitulo.Text = lector["Titulo"].ToString();
                                txtcategoria.Text = lector["Categoria"].ToString();
                                txtano.Text = lector["Anio"].ToString();
                                txtexistencias.Text = lector["Existencias"].ToString();

                                MessageBox.Show(
                                    "Libro encontrado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un libro con ese ISBN.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtbusqueda_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            try
            {
                if(string.IsNullOrWhiteSpace(txtbusquedaISBN.Text))
                {
                    MessageBox.Show(
                        "Ingrese un ISBN para realizar la búsqueda.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "SELECT * FROM Libros WHERE ISBN = @ISBN";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", txtbusquedaISBN.Text.Trim());
                        using (SqlDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                txtISBN.Text = lector["ISBN"].ToString();
                                txttitulo.Text = lector["Titulo"].ToString();
                                cmbAutor.SelectedValue = Convert.ToInt32(lector["IdAutor"]);
                                cmbEditorial.SelectedValue = Convert.ToInt32(lector["IdEditorial"]);
                                txtcategoria.Text = lector["Categoria"].ToString();
                                txtano.Text = lector["Anio"].ToString();
                                txtexistencias.Text = lector["Existencias"].ToString();
                                
                                MessageBox.Show(
                                    "Libro encontrado.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                            else
                            {
                                MessageBox.Show(
                                    "No se encontró un libro con ese ISBN.",
                                    "Biblioteca",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al buscar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }

        }

        private void lblTitulo_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void lblCategoria_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtISBN.Clear();
            txttitulo.Clear();
            txtcategoria.Clear();
            txtano.Clear();
            txtexistencias.Clear();
            cmbEditorial.SelectedIndex = -1;
            cmbAutor.SelectedIndex = -1;
            txtbusquedaISBN.Clear();
            txtbusquedaISBN.Focus();



        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            { 

                if (string.IsNullOrWhiteSpace(txtISBN.Text) ||
                    string.IsNullOrWhiteSpace(txttitulo.Text) ||
                    string.IsNullOrWhiteSpace(txtcategoria.Text) ||
                    string.IsNullOrWhiteSpace(txtano.Text) ||
                    string.IsNullOrWhiteSpace(txtexistencias.Text) ||
                    cmbAutor.SelectedIndex == -1 ||
                    cmbEditorial.SelectedIndex == -1)
            {
                
            }
                int ano, existencias;
                if (!int.TryParse(txtano.Text, out ano) || !int.TryParse(txtexistencias.Text, out existencias))
                {
                    MessageBox.Show(
                        "Año y Existencias deben ser números enteros.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (ano < 0 || existencias < 0)
                {
                    MessageBox.Show(
                        "Año y Existencias no pueden ser negativos.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }
                if (txtISBN.Text.Length != 13)
                {
                    MessageBox.Show(
                        "El ISBN debe tener exactamente 13 caracteres.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();
                    string consulta = "INSERT INTO Libros (ISBN, Titulo, IdAutor, IdEditorial, Categoria, Anio, Existencias) " +
                                      "VALUES (@ISBN, @Titulo, @IdAutor, @IdEditorial, @Categoria, @Anio, @Existencias)";
                    using (SqlCommand comando = new SqlCommand(consulta, cn))
                    {
                        comando.Parameters.AddWithValue("@ISBN", txtISBN.Text.Trim());
                        comando.Parameters.AddWithValue("@Titulo", txttitulo.Text.Trim());
                        comando.Parameters.AddWithValue("@IdAutor", cmbAutor.SelectedValue);
                        comando.Parameters.AddWithValue("@IdEditorial", cmbEditorial.SelectedValue);
                        comando.Parameters.AddWithValue("@Categoria", txtcategoria.Text.Trim());
                        comando.Parameters.AddWithValue("@Anio", ano);
                        comando.Parameters.AddWithValue("@Existencias", existencias);
                        comando.ExecuteNonQuery();
                       
                           
                            
                        
                       
                    }

                    MessageBox.Show(
                               "Libro guardado correctamente.",
                               "Biblioteca",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Information);
                    CargarLibros();
                    btnNuevo_Click(null, null);


                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al guardar el libro:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }




        private void btnCancelar_Click(object sender, EventArgs e)
        {

        }
    }
}
