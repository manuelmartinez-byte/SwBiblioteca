namespace SwBiblioteca
{
    partial class FrmLibros
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
            pnlTitulo = new Panel();
            lblTitulo = new Label();
            pnlBusqueda = new Panel();
            btnBusqueda = new Button();
            txtbusquedaISBN = new TextBox();
            lblbusqueda = new Label();
            pnlDatos = new Panel();
            cmbEditorial = new ComboBox();
            cmbAutor = new ComboBox();
            txtexistencias = new TextBox();
            txtano = new TextBox();
            txtcategoria = new TextBox();
            txttitulo = new TextBox();
            txtISBN = new TextBox();
            lblExistencias = new Label();
            lblAño = new Label();
            lblTituloL = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            lblCategoria = new Label();
            lblISBN = new Label();
            pnlBotones = new Panel();
            btnCancelar = new FontAwesome.Sharp.IconButton();
            btnEliminar = new FontAwesome.Sharp.IconButton();
            btnEditar = new FontAwesome.Sharp.IconButton();
            btnGuardar = new FontAwesome.Sharp.IconButton();
            btnNuevo = new FontAwesome.Sharp.IconButton();
            dgvLibros = new DataGridView();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            pnlDatos.SuspendLayout();
            pnlBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.Highlight;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(1350, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(510, 9);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(281, 36);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "GESTION DE LIBROS";
            lblTitulo.Click += lblTitulo_Click;
            // 
            // pnlBusqueda
            // 
            pnlBusqueda.BackColor = SystemColors.ButtonHighlight;
            pnlBusqueda.Controls.Add(btnBusqueda);
            pnlBusqueda.Controls.Add(txtbusquedaISBN);
            pnlBusqueda.Controls.Add(lblbusqueda);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(1350, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Cursor = Cursors.Hand;
            btnBusqueda.Location = new Point(772, 6);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(99, 30);
            btnBusqueda.TabIndex = 3;
            btnBusqueda.Text = "Buscar";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += btnBusqueda_Click;
            // 
            // txtbusquedaISBN
            // 
            txtbusquedaISBN.Location = new Point(532, 11);
            txtbusquedaISBN.Name = "txtbusquedaISBN";
            txtbusquedaISBN.Size = new Size(207, 23);
            txtbusquedaISBN.TabIndex = 2;
            txtbusquedaISBN.TextChanged += txtbusqueda_TextChanged;
            // 
            // lblbusqueda
            // 
            lblbusqueda.AutoSize = true;
            lblbusqueda.BackColor = Color.Transparent;
            lblbusqueda.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbusqueda.ForeColor = SystemColors.ActiveCaptionText;
            lblbusqueda.Location = new Point(464, 11);
            lblbusqueda.Name = "lblbusqueda";
            lblbusqueda.Size = new Size(44, 19);
            lblbusqueda.TabIndex = 1;
            lblbusqueda.Text = "ISBN";
            lblbusqueda.Click += label2_Click;
            // 
            // pnlDatos
            // 
            pnlDatos.Controls.Add(cmbEditorial);
            pnlDatos.Controls.Add(pnlBotones);
            pnlDatos.Controls.Add(cmbAutor);
            pnlDatos.Controls.Add(txtexistencias);
            pnlDatos.Controls.Add(txtano);
            pnlDatos.Controls.Add(txtcategoria);
            pnlDatos.Controls.Add(txttitulo);
            pnlDatos.Controls.Add(txtISBN);
            pnlDatos.Controls.Add(lblExistencias);
            pnlDatos.Controls.Add(lblAño);
            pnlDatos.Controls.Add(lblTituloL);
            pnlDatos.Controls.Add(lblAutor);
            pnlDatos.Controls.Add(lblEditorial);
            pnlDatos.Controls.Add(lblCategoria);
            pnlDatos.Controls.Add(lblISBN);
            pnlDatos.Dock = DockStyle.Top;
            pnlDatos.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlDatos.Location = new Point(0, 115);
            pnlDatos.Name = "pnlDatos";
            pnlDatos.Size = new Size(1350, 352);
            pnlDatos.TabIndex = 2;
            // 
            // cmbEditorial
            // 
            cmbEditorial.FormattingEnabled = true;
            cmbEditorial.Location = new Point(614, 124);
            cmbEditorial.Name = "cmbEditorial";
            cmbEditorial.Size = new Size(214, 27);
            cmbEditorial.TabIndex = 18;
            // 
            // cmbAutor
            // 
            cmbAutor.FormattingEnabled = true;
            cmbAutor.Location = new Point(614, 92);
            cmbAutor.Name = "cmbAutor";
            cmbAutor.Size = new Size(214, 27);
            cmbAutor.TabIndex = 17;
            // 
            // txtexistencias
            // 
            txtexistencias.Location = new Point(614, 223);
            txtexistencias.Name = "txtexistencias";
            txtexistencias.Size = new Size(214, 27);
            txtexistencias.TabIndex = 16;
            // 
            // txtano
            // 
            txtano.Location = new Point(614, 190);
            txtano.Name = "txtano";
            txtano.Size = new Size(214, 27);
            txtano.TabIndex = 15;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(614, 157);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(214, 27);
            txtcategoria.TabIndex = 14;
            // 
            // txttitulo
            // 
            txttitulo.Location = new Point(614, 58);
            txttitulo.Name = "txttitulo";
            txttitulo.Size = new Size(214, 27);
            txttitulo.TabIndex = 11;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(614, 25);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(214, 27);
            txtISBN.TabIndex = 10;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Location = new Point(464, 222);
            lblExistencias.Name = "lblExistencias";
            lblExistencias.Size = new Size(109, 19);
            lblExistencias.TabIndex = 9;
            lblExistencias.Text = "EXISTENCIAS:";
            // 
            // lblAño
            // 
            lblAño.AutoSize = true;
            lblAño.BackColor = Color.Transparent;
            lblAño.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAño.ForeColor = SystemColors.ActiveCaptionText;
            lblAño.Location = new Point(464, 193);
            lblAño.Name = "lblAño";
            lblAño.Size = new Size(55, 19);
            lblAño.TabIndex = 8;
            lblAño.Text = "AÑO : ";
            // 
            // lblTituloL
            // 
            lblTituloL.AutoSize = true;
            lblTituloL.BackColor = Color.Transparent;
            lblTituloL.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTituloL.ForeColor = SystemColors.ActiveCaptionText;
            lblTituloL.Location = new Point(464, 62);
            lblTituloL.Name = "lblTituloL";
            lblTituloL.Size = new Size(73, 19);
            lblTituloL.TabIndex = 6;
            lblTituloL.Text = "TITULO : ";
            lblTituloL.Click += label4_Click;
            // 
            // lblAutor
            // 
            lblAutor.AutoSize = true;
            lblAutor.BackColor = Color.Transparent;
            lblAutor.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblAutor.ForeColor = SystemColors.ActiveCaptionText;
            lblAutor.Location = new Point(464, 95);
            lblAutor.Name = "lblAutor";
            lblAutor.Size = new Size(73, 19);
            lblAutor.TabIndex = 5;
            lblAutor.Text = "AUTOR : ";
            // 
            // lblEditorial
            // 
            lblEditorial.AutoSize = true;
            lblEditorial.BackColor = Color.Transparent;
            lblEditorial.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEditorial.ForeColor = SystemColors.ActiveCaptionText;
            lblEditorial.Location = new Point(464, 127);
            lblEditorial.Name = "lblEditorial";
            lblEditorial.Size = new Size(96, 19);
            lblEditorial.TabIndex = 4;
            lblEditorial.Text = "EDITORIAL: ";
            // 
            // lblCategoria
            // 
            lblCategoria.AutoSize = true;
            lblCategoria.BackColor = Color.Transparent;
            lblCategoria.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCategoria.ForeColor = SystemColors.ActiveCaptionText;
            lblCategoria.Location = new Point(464, 160);
            lblCategoria.Name = "lblCategoria";
            lblCategoria.Size = new Size(105, 19);
            lblCategoria.TabIndex = 3;
            lblCategoria.Text = "CATEGORIA : ";
            // 
            // lblISBN
            // 
            lblISBN.AutoSize = true;
            lblISBN.BackColor = Color.Transparent;
            lblISBN.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblISBN.ForeColor = SystemColors.ActiveCaptionText;
            lblISBN.Location = new Point(464, 28);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(55, 19);
            lblISBN.TabIndex = 2;
            lblISBN.Text = "ISBN : ";
            lblISBN.Click += label1_Click;
            // 
            // pnlBotones
            // 
            pnlBotones.Controls.Add(btnCancelar);
            pnlBotones.Controls.Add(btnEliminar);
            pnlBotones.Controls.Add(btnEditar);
            pnlBotones.Controls.Add(btnGuardar);
            pnlBotones.Controls.Add(btnNuevo);
            pnlBotones.Location = new Point(401, 274);
            pnlBotones.Name = "pnlBotones";
            pnlBotones.Size = new Size(617, 63);
            pnlBotones.TabIndex = 3;
            pnlBotones.Paint += pnlBotones_Paint;
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
            btnCancelar.Click += btnCancelar_Click;
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
            btnEliminar.Click += btnEliminar_Click;
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
            btnEditar.Click += btnEditar_Click;
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
            btnGuardar.Click += btnGuardar_Click;
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
            btnNuevo.Click += btnNuevo_Click;
            // 
            // dgvLibros
            // 
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Dock = DockStyle.Fill;
            dgvLibros.Location = new Point(0, 467);
            dgvLibros.Name = "dgvLibros";
            dgvLibros.Size = new Size(1350, 262);
            dgvLibros.TabIndex = 4;
            dgvLibros.CellContentClick += dgvLibros_CellContentClick;
            dgvLibros.CellDoubleClick += dgvLibros_CellDoubleClick;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1350, 729);
            Controls.Add(dgvLibros);
            Controls.Add(pnlDatos);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "FrmLibros";
            WindowState = FormWindowState.Maximized;
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            pnlDatos.ResumeLayout(false);
            pnlDatos.PerformLayout();
            pnlBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Label lblbusqueda;
        private TextBox txtbusquedaISBN;
        private Button btnBusqueda;
        private Panel pnlDatos;
        private Label lblISBN;
        private Label lblAutor;
        private Label lblTituloL;
        private Label lblEditorial;
        private Label lblAño;
        private Label lblExistencias;
        private TextBox txtexistencias;
        private TextBox txtano;
        private TextBox txteditorial;
        private TextBox txtautor;
        private Panel pnlBotones;
        private FontAwesome.Sharp.IconButton btnNuevo;
        private FontAwesome.Sharp.IconButton btnEditar;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnCancelar;
        private DataGridView dgvLibros;
        private ComboBox cmbEditorial;
        private ComboBox cmbAutor;
        private TextBox txtcategoria;
        private TextBox txttitulo;
        private TextBox txtISBN;
        private Label lblCategoria;
    }
}