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
            txtbusqueda = new TextBox();
            lblbusqueda = new Label();
            panel1 = new Panel();
            lblExistencias = new Label();
            lblAño = new Label();
            lblTituloL = new Label();
            lblAutor = new Label();
            lblEditorial = new Label();
            lblCategoria = new Label();
            lblISBN = new Label();
            txtISBN = new TextBox();
            txttitulo = new TextBox();
            txtautor = new TextBox();
            txteditorial = new TextBox();
            txtcategoria = new TextBox();
            txtaño = new TextBox();
            txtexistencias = new TextBox();
            pnlTitulo.SuspendLayout();
            pnlBusqueda.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // pnlTitulo
            // 
            pnlTitulo.BackColor = SystemColors.Highlight;
            pnlTitulo.Controls.Add(lblTitulo);
            pnlTitulo.Dock = DockStyle.Top;
            pnlTitulo.Location = new Point(0, 0);
            pnlTitulo.Name = "pnlTitulo";
            pnlTitulo.Size = new Size(869, 60);
            pnlTitulo.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Transparent;
            lblTitulo.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo.Location = new Point(284, 9);
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
            pnlBusqueda.Controls.Add(txtbusqueda);
            pnlBusqueda.Controls.Add(lblbusqueda);
            pnlBusqueda.Dock = DockStyle.Top;
            pnlBusqueda.Location = new Point(0, 60);
            pnlBusqueda.Name = "pnlBusqueda";
            pnlBusqueda.Size = new Size(869, 55);
            pnlBusqueda.TabIndex = 1;
            // 
            // btnBusqueda
            // 
            btnBusqueda.Location = new Point(545, 11);
            btnBusqueda.Name = "btnBusqueda";
            btnBusqueda.Size = new Size(99, 30);
            btnBusqueda.TabIndex = 3;
            btnBusqueda.Text = "Buscar";
            btnBusqueda.UseVisualStyleBackColor = true;
            btnBusqueda.Click += button1_Click;
            // 
            // txtbusqueda
            // 
            txtbusqueda.Location = new Point(311, 16);
            txtbusqueda.Name = "txtbusqueda";
            txtbusqueda.Size = new Size(207, 23);
            txtbusqueda.TabIndex = 2;
            txtbusqueda.TextChanged += txtbusqueda_TextChanged;
            // 
            // lblbusqueda
            // 
            lblbusqueda.AutoSize = true;
            lblbusqueda.BackColor = Color.Transparent;
            lblbusqueda.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblbusqueda.ForeColor = SystemColors.ActiveCaptionText;
            lblbusqueda.Location = new Point(238, 16);
            lblbusqueda.Name = "lblbusqueda";
            lblbusqueda.Size = new Size(44, 19);
            lblbusqueda.TabIndex = 1;
            lblbusqueda.Text = "ISBN";
            lblbusqueda.Click += label2_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(txtexistencias);
            panel1.Controls.Add(txteditorial);
            panel1.Controls.Add(txtaño);
            panel1.Controls.Add(txtcategoria);
            panel1.Controls.Add(txtautor);
            panel1.Controls.Add(txttitulo);
            panel1.Controls.Add(txtISBN);
            panel1.Controls.Add(lblExistencias);
            panel1.Controls.Add(lblAño);
            panel1.Controls.Add(lblTituloL);
            panel1.Controls.Add(lblAutor);
            panel1.Controls.Add(lblEditorial);
            panel1.Controls.Add(lblCategoria);
            panel1.Controls.Add(lblISBN);
            panel1.Dock = DockStyle.Top;
            panel1.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(0, 115);
            panel1.Name = "panel1";
            panel1.Size = new Size(869, 352);
            panel1.TabIndex = 2;
            // 
            // lblExistencias
            // 
            lblExistencias.AutoSize = true;
            lblExistencias.Location = new Point(238, 225);
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
            lblAño.Location = new Point(238, 196);
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
            lblTituloL.Location = new Point(238, 65);
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
            lblAutor.Location = new Point(238, 98);
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
            lblEditorial.Location = new Point(238, 130);
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
            lblCategoria.Location = new Point(238, 163);
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
            lblISBN.Location = new Point(238, 31);
            lblISBN.Name = "lblISBN";
            lblISBN.Size = new Size(55, 19);
            lblISBN.TabIndex = 2;
            lblISBN.Text = "ISBN : ";
            lblISBN.Click += label1_Click;
            // 
            // txtISBN
            // 
            txtISBN.Location = new Point(388, 28);
            txtISBN.Name = "txtISBN";
            txtISBN.Size = new Size(214, 27);
            txtISBN.TabIndex = 10;
            // 
            // texttitulo
            // 
            txttitulo.Location = new Point(388, 61);
            txttitulo.Name = "texttitulo";
            txttitulo.Size = new Size(214, 27);
            txttitulo.TabIndex = 11;
            // 
            // txtautor
            // 
            txtautor.Location = new Point(388, 94);
            txtautor.Name = "txtautor";
            txtautor.Size = new Size(214, 27);
            txtautor.TabIndex = 12;
            // 
            // txteditorial
            // 
            txteditorial.Location = new Point(388, 127);
            txteditorial.Name = "txteditorial";
            txteditorial.Size = new Size(214, 27);
            txteditorial.TabIndex = 13;
            // 
            // txtcategoria
            // 
            txtcategoria.Location = new Point(388, 160);
            txtcategoria.Name = "txtcategoria";
            txtcategoria.Size = new Size(214, 27);
            txtcategoria.TabIndex = 14;
            // 
            // txtaño
            // 
            txtaño.Location = new Point(388, 193);
            txtaño.Name = "txtaño";
            txtaño.Size = new Size(214, 27);
            txtaño.TabIndex = 15;
            // 
            // txtexistencias
            // 
            txtexistencias.Location = new Point(388, 226);
            txtexistencias.Name = "txtexistencias";
            txtexistencias.Size = new Size(214, 27);
            txtexistencias.TabIndex = 16;
            // 
            // FrmLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(869, 578);
            Controls.Add(panel1);
            Controls.Add(pnlBusqueda);
            Controls.Add(pnlTitulo);
            Name = "FrmLibros";
            Text = "FrmLibros";
            pnlTitulo.ResumeLayout(false);
            pnlTitulo.PerformLayout();
            pnlBusqueda.ResumeLayout(false);
            pnlBusqueda.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo;
        private Label lblTitulo;
        private Panel pnlBusqueda;
        private Label lblbusqueda;
        private TextBox txtbusqueda;
        private Button btnBusqueda;
        private Panel panel1;
        private Label lblISBN;
        private Label lblAutor;
        private Label lblTituloL;
        private Label lblEditorial;
        private Label lblCategoria;
        private Label lblAño;
        private Label lblExistencias;
        private TextBox txtexistencias;
        private TextBox txtaño;
        private TextBox txtcategoria;
        private TextBox txteditorial;
        private TextBox txtautor;
        private TextBox txttitulo;
        private TextBox txtISBN;
    }
}