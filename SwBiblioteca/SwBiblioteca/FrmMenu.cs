using SwBiblioteca.Datos;

namespace SwBiblioteca
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
            //TEST CONEXION DE BASE DE DATOS
            //Conexion conexion = new Conexion()
            //try
            //{
           //     using (var connection = conexion.ObtenerConexion())
           //     {
            //        connection.Open();
                    // La conexión se ha establecido correctamente
           //         MessageBox.Show("Conexión a la base de datos establecida correctamente.",
           //             "SwBiblioteca",
           //             MessageBoxButtons.OK,
           //             MessageBoxIcon.Information);
          //      }
          //  }
          //  catch (Exception ex)
          //  {
          //      MessageBox.Show("Error al conectar a la base de datos: " + ex.Message,
         //           "SwBiblioteca",
          //          MessageBoxButtons.OK,
         //           MessageBoxIcon.Error);
         //   }

            AbrirFormulario(new FormInicio());
        }

        private void AbrirFormulario(Form formulario)
        {
            formulario.TopLevel = false;
            formulario.Dock = DockStyle.Fill;
            formulario.FormBorderStyle = FormBorderStyle.None;
            PnlCenter.Controls.Clear();
            PnlCenter.Controls.Add(formulario);
            formulario.Show();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FormInicio());
        }

        private void BtnLibros_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmLibros());
        }

        private void BtnUsuarios_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmUsuarios());
        }

        private void BtnAutores_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmAutores());
        }

        private void BtnEditoriales_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmEditoriales());
        }

        private void BtnPrestamos_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmPrestamos());
        }

        private void BtnReportes_Click(object sender, EventArgs e)
        {
            AbrirFormulario(new FrmReportes());
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
