namespace SwBiblioteca
{
    partial class FrmMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMenu));
            Pnlinterfaz = new Panel();
            BtnSalir = new FontAwesome.Sharp.IconButton();
            BtnReportes = new FontAwesome.Sharp.IconButton();
            BtnPrestamos = new FontAwesome.Sharp.IconButton();
            BtnEditoriales = new FontAwesome.Sharp.IconButton();
            BtnAutores = new FontAwesome.Sharp.IconButton();
            BtnUsuarios = new FontAwesome.Sharp.IconButton();
            BtnLibros = new FontAwesome.Sharp.IconButton();
            BtnInicio = new FontAwesome.Sharp.IconButton();
            button1 = new Button();
            panel1 = new Panel();
            picLogo = new PictureBox();
            lblSubtittle = new Label();
            LblTittle = new Label();
            panel3 = new Panel();
            PnlTop = new Panel();
            PnlButton = new Panel();
            PnlCenter = new Panel();
            Pnlinterfaz.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).BeginInit();
            SuspendLayout();
            // 
            // Pnlinterfaz
            // 
            Pnlinterfaz.BackColor = SystemColors.ActiveCaption;
            Pnlinterfaz.Controls.Add(BtnSalir);
            Pnlinterfaz.Controls.Add(BtnReportes);
            Pnlinterfaz.Controls.Add(BtnPrestamos);
            Pnlinterfaz.Controls.Add(BtnEditoriales);
            Pnlinterfaz.Controls.Add(BtnAutores);
            Pnlinterfaz.Controls.Add(BtnUsuarios);
            Pnlinterfaz.Controls.Add(BtnLibros);
            Pnlinterfaz.Controls.Add(BtnInicio);
            Pnlinterfaz.Controls.Add(button1);
            Pnlinterfaz.Controls.Add(panel1);
            Pnlinterfaz.Controls.Add(panel3);
            Pnlinterfaz.Dock = DockStyle.Left;
            Pnlinterfaz.Location = new Point(0, 0);
            Pnlinterfaz.Name = "Pnlinterfaz";
            Pnlinterfaz.Size = new Size(230, 561);
            Pnlinterfaz.TabIndex = 0;
            // 
            // BtnSalir
            // 
            BtnSalir.Dock = DockStyle.Top;
            BtnSalir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnSalir.IconChar = FontAwesome.Sharp.IconChar.X;
            BtnSalir.IconColor = Color.Black;
            BtnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnSalir.IconSize = 30;
            BtnSalir.Location = new Point(0, 420);
            BtnSalir.Name = "BtnSalir";
            BtnSalir.Size = new Size(230, 48);
            BtnSalir.TabIndex = 10;
            BtnSalir.Text = "Salir";
            BtnSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnSalir.UseVisualStyleBackColor = true;
            BtnSalir.Click += BtnSalir_Click;
            // 
            // BtnReportes
            // 
            BtnReportes.Dock = DockStyle.Top;
            BtnReportes.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnReportes.IconChar = FontAwesome.Sharp.IconChar.BookBookmark;
            BtnReportes.IconColor = Color.Black;
            BtnReportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnReportes.IconSize = 30;
            BtnReportes.Location = new Point(0, 372);
            BtnReportes.Name = "BtnReportes";
            BtnReportes.Size = new Size(230, 48);
            BtnReportes.TabIndex = 9;
            BtnReportes.Text = "Reportes";
            BtnReportes.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnReportes.UseVisualStyleBackColor = true;
            BtnReportes.Click += BtnReportes_Click;
            // 
            // BtnPrestamos
            // 
            BtnPrestamos.Dock = DockStyle.Top;
            BtnPrestamos.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnPrestamos.IconChar = FontAwesome.Sharp.IconChar.MoneyBills;
            BtnPrestamos.IconColor = Color.Black;
            BtnPrestamos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnPrestamos.IconSize = 30;
            BtnPrestamos.Location = new Point(0, 324);
            BtnPrestamos.Name = "BtnPrestamos";
            BtnPrestamos.Size = new Size(230, 48);
            BtnPrestamos.TabIndex = 8;
            BtnPrestamos.Text = "Prestamos";
            BtnPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnPrestamos.UseVisualStyleBackColor = true;
            BtnPrestamos.Click += BtnPrestamos_Click;
            // 
            // BtnEditoriales
            // 
            BtnEditoriales.Dock = DockStyle.Top;
            BtnEditoriales.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnEditoriales.IconChar = FontAwesome.Sharp.IconChar.Bookmark;
            BtnEditoriales.IconColor = Color.Black;
            BtnEditoriales.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnEditoriales.IconSize = 30;
            BtnEditoriales.Location = new Point(0, 276);
            BtnEditoriales.Name = "BtnEditoriales";
            BtnEditoriales.Size = new Size(230, 48);
            BtnEditoriales.TabIndex = 7;
            BtnEditoriales.Text = "Editoriales";
            BtnEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnEditoriales.UseVisualStyleBackColor = true;
            BtnEditoriales.Click += BtnEditoriales_Click;
            // 
            // BtnAutores
            // 
            BtnAutores.Dock = DockStyle.Top;
            BtnAutores.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnAutores.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            BtnAutores.IconColor = Color.Black;
            BtnAutores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnAutores.IconSize = 30;
            BtnAutores.Location = new Point(0, 228);
            BtnAutores.Name = "BtnAutores";
            BtnAutores.Size = new Size(230, 48);
            BtnAutores.TabIndex = 6;
            BtnAutores.Text = "Autores";
            BtnAutores.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnAutores.UseVisualStyleBackColor = true;
            BtnAutores.Click += BtnAutores_Click;
            // 
            // BtnUsuarios
            // 
            BtnUsuarios.Dock = DockStyle.Top;
            BtnUsuarios.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnUsuarios.IconChar = FontAwesome.Sharp.IconChar.PersonRunning;
            BtnUsuarios.IconColor = Color.Black;
            BtnUsuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnUsuarios.IconSize = 30;
            BtnUsuarios.Location = new Point(0, 180);
            BtnUsuarios.Name = "BtnUsuarios";
            BtnUsuarios.Size = new Size(230, 48);
            BtnUsuarios.TabIndex = 5;
            BtnUsuarios.Text = "Usuarios";
            BtnUsuarios.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnUsuarios.UseVisualStyleBackColor = true;
            BtnUsuarios.Click += BtnUsuarios_Click;
            // 
            // BtnLibros
            // 
            BtnLibros.Dock = DockStyle.Top;
            BtnLibros.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnLibros.IconChar = FontAwesome.Sharp.IconChar.Book;
            BtnLibros.IconColor = Color.Black;
            BtnLibros.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnLibros.IconSize = 30;
            BtnLibros.Location = new Point(0, 132);
            BtnLibros.Name = "BtnLibros";
            BtnLibros.Size = new Size(230, 48);
            BtnLibros.TabIndex = 4;
            BtnLibros.Text = "Libros";
            BtnLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnLibros.UseVisualStyleBackColor = true;
            BtnLibros.Click += BtnLibros_Click;
            // 
            // BtnInicio
            // 
            BtnInicio.Dock = DockStyle.Top;
            BtnInicio.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BtnInicio.IconChar = FontAwesome.Sharp.IconChar.House;
            BtnInicio.IconColor = Color.Black;
            BtnInicio.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnInicio.IconSize = 30;
            BtnInicio.Location = new Point(0, 84);
            BtnInicio.Name = "BtnInicio";
            BtnInicio.Size = new Size(230, 48);
            BtnInicio.TabIndex = 3;
            BtnInicio.Text = "Inicio";
            BtnInicio.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnInicio.UseVisualStyleBackColor = true;
            BtnInicio.Click += BtnInicio_Click;
            // 
            // button1
            // 
            button1.Location = new Point(161, 225);
            button1.Name = "button1";
            button1.Size = new Size(8, 8);
            button1.TabIndex = 2;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.HotTrack;
            panel1.Controls.Add(picLogo);
            panel1.Controls.Add(lblSubtittle);
            panel1.Controls.Add(LblTittle);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(230, 84);
            panel1.TabIndex = 1;
            // 
            // picLogo
            // 
            picLogo.Image = Properties.Resources.images_removebg_preview;
            picLogo.InitialImage = (Image)resources.GetObject("picLogo.InitialImage");
            picLogo.Location = new Point(4, 8);
            picLogo.Margin = new Padding(0);
            picLogo.Name = "picLogo";
            picLogo.Size = new Size(81, 67);
            picLogo.SizeMode = PictureBoxSizeMode.Zoom;
            picLogo.TabIndex = 2;
            picLogo.TabStop = false;
            // 
            // lblSubtittle
            // 
            lblSubtittle.AutoSize = true;
            lblSubtittle.Font = new Font("Corbel", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblSubtittle.ForeColor = SystemColors.ButtonHighlight;
            lblSubtittle.Location = new Point(87, 49);
            lblSubtittle.Name = "lblSubtittle";
            lblSubtittle.Size = new Size(137, 19);
            lblSubtittle.TabIndex = 1;
            lblSubtittle.Text = "Sistema de Gestión";
            // 
            // LblTittle
            // 
            LblTittle.AutoSize = true;
            LblTittle.Font = new Font("Corbel", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LblTittle.ForeColor = SystemColors.ButtonHighlight;
            LblTittle.Location = new Point(85, 20);
            LblTittle.Name = "LblTittle";
            LblTittle.Size = new Size(145, 29);
            LblTittle.TabIndex = 0;
            LblTittle.Text = "BIBLIOTECA";
            LblTittle.TextAlign = ContentAlignment.TopRight;
            LblTittle.Click += label1_Click;
            // 
            // panel3
            // 
            panel3.Location = new Point(267, 488);
            panel3.Name = "panel3";
            panel3.Size = new Size(617, 70);
            panel3.TabIndex = 0;
            // 
            // PnlTop
            // 
            PnlTop.BackColor = SystemColors.InactiveCaption;
            PnlTop.Dock = DockStyle.Top;
            PnlTop.Location = new Point(230, 0);
            PnlTop.Name = "PnlTop";
            PnlTop.Size = new Size(654, 84);
            PnlTop.TabIndex = 1;
            // 
            // PnlButton
            // 
            PnlButton.BackColor = SystemColors.InactiveCaption;
            PnlButton.Dock = DockStyle.Bottom;
            PnlButton.Location = new Point(230, 475);
            PnlButton.Name = "PnlButton";
            PnlButton.Size = new Size(654, 86);
            PnlButton.TabIndex = 2;
            // 
            // PnlCenter
            // 
            PnlCenter.Dock = DockStyle.Fill;
            PnlCenter.Location = new Point(230, 84);
            PnlCenter.Name = "PnlCenter";
            PnlCenter.Size = new Size(654, 391);
            PnlCenter.TabIndex = 3;
            // 
            // FrmMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(884, 561);
            Controls.Add(PnlCenter);
            Controls.Add(PnlButton);
            Controls.Add(PnlTop);
            Controls.Add(Pnlinterfaz);
            Name = "FrmMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema Gestíon de Biblioteca";
            WindowState = FormWindowState.Maximized;
            Pnlinterfaz.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)picLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel Pnlinterfaz;
        private Panel panel3;
        private Panel PnlTop;
        private Panel PnlButton;
        private Panel PnlCenter;
        private Panel panel1;
        private Label LblTittle;
        private Label lblSubtittle;
        private PictureBox picLogo;
        private FontAwesome.Sharp.IconButton BtnInicio;
        private Button button1;
        private FontAwesome.Sharp.IconButton BtnEditoriales;
        private FontAwesome.Sharp.IconButton BtnAutores;
        private FontAwesome.Sharp.IconButton BtnUsuarios;
        private FontAwesome.Sharp.IconButton BtnLibros;
        private FontAwesome.Sharp.IconButton BtnSalir;
        private FontAwesome.Sharp.IconButton BtnReportes;
        private FontAwesome.Sharp.IconButton BtnPrestamos;
    }
}
