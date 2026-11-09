namespace SwBiblioteca
{
    partial class FrmPrestamos
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pnlTitulo_prestamos = new Panel();
            lblTitulo_prestamos = new Label();
            pnlDatos_prestamos = new Panel();
            pnlBotones_prestamos = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dtpFechaDevolucion = new DateTimePicker();
            dtpFechaPrestamo = new DateTimePicker();
            cmbLibro = new ComboBox();
            cmbusuario_prestamo = new ComboBox();
            lblLibro_prestamos = new Label();
            lblFechaprestamo = new Label();
            lblfechadevolucion = new Label();
            lblusuarios_prestamos = new Label();
            dgvPrestamos = new DataGridView();
            pnlTitulo_prestamos.SuspendLayout();
            pnlDatos_prestamos.SuspendLayout();
            pnlBotones_prestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo_prestamos
            // 
            pnlTitulo_prestamos.BackColor = SystemColors.Highlight;
            pnlTitulo_prestamos.Controls.Add(lblTitulo_prestamos);
            pnlTitulo_prestamos.Dock = DockStyle.Top;
            pnlTitulo_prestamos.Location = new Point(0, 0);
            pnlTitulo_prestamos.Name = "pnlTitulo_prestamos";
            pnlTitulo_prestamos.Size = new Size(1140, 60);
            pnlTitulo_prestamos.TabIndex = 2;
            // 
            // lblTitulo_prestamos
            // 
            lblTitulo_prestamos.AutoSize = true;
            lblTitulo_prestamos.BackColor = Color.Transparent;
            lblTitulo_prestamos.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo_prestamos.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo_prestamos.Location = new Point(510, 9);
            lblTitulo_prestamos.Name = "lblTitulo_prestamos";
            lblTitulo_prestamos.Size = new Size(347, 36);
            lblTitulo_prestamos.TabIndex = 0;
            lblTitulo_prestamos.Text = "GESTION DE PRESTAMOS";
            // 
            // pnlDatos_prestamos
            // 
            pnlDatos_prestamos.Controls.Add(pnlBotones_prestamos);
            pnlDatos_prestamos.Controls.Add(dtpFechaDevolucion);
            pnlDatos_prestamos.Controls.Add(dtpFechaPrestamo);
            pnlDatos_prestamos.Controls.Add(cmbLibro);
            pnlDatos_prestamos.Controls.Add(cmbusuario_prestamo);
            pnlDatos_prestamos.Controls.Add(lblLibro_prestamos);
            pnlDatos_prestamos.Controls.Add(lblFechaprestamo);
            pnlDatos_prestamos.Controls.Add(lblfechadevolucion);
            pnlDatos_prestamos.Controls.Add(lblusuarios_prestamos);
            pnlDatos_prestamos.Dock = DockStyle.Top;
            pnlDatos_prestamos.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlDatos_prestamos.Location = new Point(0, 60);
            pnlDatos_prestamos.Name = "pnlDatos_prestamos";
            pnlDatos_prestamos.Size = new Size(1140, 352);
            pnlDatos_prestamos.TabIndex = 3;
            // 
            // pnlBotones_prestamos
            // 
            pnlBotones_prestamos.Controls.Add(btnCancelar);
            pnlBotones_prestamos.Controls.Add(btnEliminar);
            pnlBotones_prestamos.Controls.Add(btnEditar);
            pnlBotones_prestamos.Controls.Add(btnGuardar);
            pnlBotones_prestamos.Controls.Add(btnNuevo);
            pnlBotones_prestamos.Location = new Point(392, 243);
            pnlBotones_prestamos.Name = "pnlBotones_prestamos";
            pnlBotones_prestamos.Size = new Size(617, 61);
            pnlBotones_prestamos.TabIndex = 4;
            // 
            // btnCancelar
            // 
            btnCancelar.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnCancelar.IconColor = Color.Black;
            btnCancelar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnCancelar.IconSize = 25;
            btnCancelar.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelar.Location = new Point(503, 10);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 40);
            btnCancelar.TabIndex = 4;
            btnCancelar.Text = "Cancelar";
            btnCancelar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEliminar
            // 
            btnEliminar.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown;
            btnEliminar.IconColor = Color.Black;
            btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEliminar.IconSize = 25;
            btnEliminar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminar.Location = new Point(383, 10);
            btnEliminar.Name = "btnEliminar";
            btnEliminar.Size = new Size(100, 40);
            btnEliminar.TabIndex = 3;
            btnEliminar.Text = "Eliminar";
            btnEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            btnEditar.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            btnEditar.IconColor = Color.Black;
            btnEditar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEditar.IconSize = 25;
            btnEditar.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditar.Location = new Point(263, 10);
            btnEditar.Name = "btnEditar";
            btnEditar.Size = new Size(100, 40);
            btnEditar.TabIndex = 2;
            btnEditar.Text = "Editar";
            btnEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnGuardar
            // 
            btnGuardar.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardar.IconColor = Color.Black;
            btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardar.IconSize = 25;
            btnGuardar.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardar.Location = new Point(143, 10);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 40);
            btnGuardar.TabIndex = 1;
            btnGuardar.Text = "Guardar";
            btnGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnNuevo
            // 
            btnNuevo.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevo.IconColor = Color.Black;
            btnNuevo.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnNuevo.IconSize = 25;
            btnNuevo.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevo.Location = new Point(23, 10);
            btnNuevo.Name = "btnNuevo";
            btnNuevo.Size = new Size(100, 40);
            btnNuevo.TabIndex = 0;
            btnNuevo.Text = "Nuevo";
            btnNuevo.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevo.UseVisualStyleBackColor = true;
            // 
            // dtpFechaDevolucion
            // 
            dtpFechaDevolucion.Format = DateTimePickerFormat.Short;
            dtpFechaDevolucion.Location = new Point(614, 142);
            dtpFechaDevolucion.Name = "dtpFechaDevolucion";
            dtpFechaDevolucion.Size = new Size(219, 27);
            dtpFechaDevolucion.TabIndex = 20;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Format = DateTimePickerFormat.Short;
            dtpFechaPrestamo.Location = new Point(614, 103);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(219, 27);
            dtpFechaPrestamo.TabIndex = 19;
            // 
            // cmbLibro
            // 
            cmbLibro.FormattingEnabled = true;
            cmbLibro.Location = new Point(614, 65);
            cmbLibro.Name = "cmbLibro";
            cmbLibro.Size = new Size(214, 27);
            cmbLibro.TabIndex = 18;
            // 
            // cmbusuario_prestamo
            // 
            cmbusuario_prestamo.FormattingEnabled = true;
            cmbusuario_prestamo.Location = new Point(614, 28);
            cmbusuario_prestamo.Name = "cmbusuario_prestamo";
            cmbusuario_prestamo.Size = new Size(214, 27);
            cmbusuario_prestamo.TabIndex = 17;
            // 
            // lblLibro_prestamos
            // 
            lblLibro_prestamos.AutoSize = true;
            lblLibro_prestamos.BackColor = Color.Transparent;
            lblLibro_prestamos.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblLibro_prestamos.ForeColor = SystemColors.ActiveCaptionText;
            lblLibro_prestamos.Location = new Point(429, 73);
            lblLibro_prestamos.Name = "lblLibro_prestamos";
            lblLibro_prestamos.Size = new Size(62, 19);
            lblLibro_prestamos.TabIndex = 6;
            lblLibro_prestamos.Text = "LIBRO :";
            lblLibro_prestamos.Click += lblLibro_prestamos_Click;
            // 
            // lblFechaprestamo
            // 
            lblFechaprestamo.AutoSize = true;
            lblFechaprestamo.BackColor = Color.Transparent;
            lblFechaprestamo.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFechaprestamo.ForeColor = SystemColors.ActiveCaptionText;
            lblFechaprestamo.Location = new Point(429, 111);
            lblFechaprestamo.Name = "lblFechaprestamo";
            lblFechaprestamo.Size = new Size(147, 19);
            lblFechaprestamo.TabIndex = 5;
            lblFechaprestamo.Text = "FECHA PRESTAMO:";
            // 
            // lblfechadevolucion
            // 
            lblfechadevolucion.AutoSize = true;
            lblfechadevolucion.BackColor = Color.Transparent;
            lblfechadevolucion.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblfechadevolucion.ForeColor = SystemColors.ActiveCaptionText;
            lblfechadevolucion.Location = new Point(429, 150);
            lblfechadevolucion.Name = "lblfechadevolucion";
            lblfechadevolucion.Size = new Size(164, 19);
            lblfechadevolucion.TabIndex = 4;
            lblfechadevolucion.Text = "FECHA DEVOLUCION:";
            // 
            // lblusuarios_prestamos
            // 
            lblusuarios_prestamos.AutoSize = true;
            lblusuarios_prestamos.BackColor = Color.Transparent;
            lblusuarios_prestamos.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblusuarios_prestamos.ForeColor = SystemColors.ActiveCaptionText;
            lblusuarios_prestamos.Location = new Point(429, 36);
            lblusuarios_prestamos.Name = "lblusuarios_prestamos";
            lblusuarios_prestamos.Size = new Size(85, 19);
            lblusuarios_prestamos.TabIndex = 2;
            lblusuarios_prestamos.Text = "USUARIO :";
            // 
            // dgvPrestamos
            // 
            dgvPrestamos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvPrestamos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvPrestamos.Dock = DockStyle.Fill;
            dgvPrestamos.Location = new Point(0, 412);
            dgvPrestamos.Name = "dgvPrestamos";
            dgvPrestamos.Size = new Size(1140, 243);
            dgvPrestamos.TabIndex = 5;
            // 
            // FrmPrestamos
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1140, 655);
            Controls.Add(dgvPrestamos);
            Controls.Add(pnlDatos_prestamos);
            Controls.Add(pnlTitulo_prestamos);
            Name = "FrmPrestamos";
            Text = "FrmPrestamos";
            pnlTitulo_prestamos.ResumeLayout(false);
            pnlTitulo_prestamos.PerformLayout();
            pnlDatos_prestamos.ResumeLayout(false);
            pnlDatos_prestamos.PerformLayout();
            pnlBotones_prestamos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvPrestamos).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo_prestamos;
        private Label lblTitulo_prestamos;
        private Panel pnlDatos_prestamos;
        private ComboBox cmbLibro;
        private ComboBox cmbusuario_prestamo;
        private DateTimePicker dtpFechaDevolucion;
        private DateTimePicker dtpFechaPrestamo;
        private TextBox txtISBN;
        private Label lblLibro_prestamos;
        private Label lblFechaprestamo;
        private Label lblfechadevolucion;
        private Label lblusuarios_prestamos;
     
        private Panel pnlBotones_prestamos;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private DataGridView dgvPrestamos;
    }
}