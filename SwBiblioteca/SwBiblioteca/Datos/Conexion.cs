using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;


namespace SwBiblioteca.Datos
{
    public class Conexion
    {
        

        private string cadenaConexion = "Server=localhost;Database=SwBiblioteca;Integrated Security=True;TrustServerCertificate=true";

        public SqlConnection ObtenerConexion()
        {
            return new SqlConnection(cadenaConexion);
        }
    }
}

