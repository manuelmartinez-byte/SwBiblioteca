using Microsoft.Data.SqlClient;
using SwBiblioteca.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;



namespace SwBiblioteca
{
    public partial class FrmReportes : Form
    {
        public FrmReportes()
        {
            InitializeComponent();
            CargarTiposReporte();
        }

       
        

        private void CargarTiposReporte()
        {
            cmbtiporeporte.Items.Clear();

            cmbtiporeporte.Items.Add("Préstamos activos");
            cmbtiporeporte.Items.Add("Préstamos devueltos");
            cmbtiporeporte.Items.Add("Inventario de libros");

            cmbtiporeporte.SelectedIndex = -1;
        }


        private void btnGenerarReporte_click(object sender, EventArgs e)
        {
            try
            {
                if (cmbtiporeporte.SelectedIndex == -1)
                {
                    MessageBox.Show(
                        "Seleccione un tipo de reporte.",
                        "Biblioteca",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);

                    return;
                }

                Conexion conexion = new Conexion();

                using (SqlConnection cn = conexion.ObtenerConexion())
                {
                    cn.Open();

                    string consulta = "";

                    if (cmbtiporeporte.Text == "Préstamos activos")
                    {
                        consulta = @"SELECT
                                p.IdPrestamo,
                                u.Nombre + ' ' + u.Apellido AS Usuario,
                                l.ISBN,
                                l.Titulo,
                                p.FechaPrestamo,
                                p.Estado
                             FROM Prestamos p
                             INNER JOIN Usuarios u
                                ON p.IdUsuario = u.IdUsuario
                             INNER JOIN Libros l
                                ON p.ISBN = l.ISBN
                             WHERE p.Estado = 'Prestado'
                             ORDER BY p.FechaPrestamo DESC";
                    }
                    else if (cmbtiporeporte.Text == "Préstamos devueltos")
                    {
                        consulta = @"SELECT
                                p.IdPrestamo,
                                u.Nombre + ' ' + u.Apellido AS Usuario,
                                l.ISBN,
                                l.Titulo,
                                p.FechaPrestamo,
                                p.FechaDevolucion,
                                p.Estado
                             FROM Prestamos p
                             INNER JOIN Usuarios u
                                ON p.IdUsuario = u.IdUsuario
                             INNER JOIN Libros l
                                ON p.ISBN = l.ISBN
                             WHERE p.Estado = 'Devuelto'
                             ORDER BY p.FechaDevolucion DESC";
                    }
                    else if (cmbtiporeporte.Text == "Inventario de libros")
                    {
                        consulta = @"SELECT
                                l.ISBN,
                                l.Titulo,
                                a.Nombre + ' ' + a.Apellido AS Autor,
                                e.Nombre AS Editorial,
                                l.Categoria,
                                l.Anio,
                                l.Existencias
                             FROM Libros l
                             INNER JOIN Autores a
                                ON l.IdAutor = a.IdAutor
                             INNER JOIN Editoriales e
                                ON l.IdEditorial = e.IdEditorial
                             ORDER BY l.Titulo";
                    }

                    using (SqlDataAdapter adaptador =
                           new SqlDataAdapter(consulta, cn))
                    {
                        DataTable tabla = new DataTable();

                        adaptador.Fill(tabla);

                        dgvReportes.DataSource = tabla;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al generar el reporte:\n" + ex.Message,
                    "Biblioteca",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

     

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            cmbtiporeporte.SelectedIndex = -1;

            dgvReportes.DataSource = null;
        }
    }
}
