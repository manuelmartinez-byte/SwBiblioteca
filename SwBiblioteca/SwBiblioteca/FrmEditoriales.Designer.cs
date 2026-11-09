namespace SwBiblioteca
{
    partial class FrmEditoriales
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
            pnlTitulo_editoriales = new Panel();
            lblTitulo_editoriales = new Label();
            pnlDatos_editoriales = new Panel();
            pnlBotones_editoriales = new Panel();
            btnCancelarEditoriales = new FontAwesome.Sharp.IconButton();
            btnEliminarEditoriales = new FontAwesome.Sharp.IconButton();
            btnEditarEditoriales = new FontAwesome.Sharp.IconButton();
            btnGuardarEditoriales = new FontAwesome.Sharp.IconButton();
            btnNuevoEditoriales = new FontAwesome.Sharp.IconButton();
            txtInombreEditoriales = new TextBox();
            lblInombre_editoriales = new Label();
            dgvEditoriales = new DataGridView();
            pnlTitulo_editoriales.SuspendLayout();
            pnlDatos_editoriales.SuspendLayout();
            pnlBotones_editoriales.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo_editoriales
            // 
            pnlTitulo_editoriales.BackColor = SystemColors.Highlight;
            pnlTitulo_editoriales.Controls.Add(lblTitulo_editoriales);
            pnlTitulo_editoriales.Dock = DockStyle.Top;
            pnlTitulo_editoriales.Location = new Point(0, 0);
            pnlTitulo_editoriales.Name = "pnlTitulo_editoriales";
            pnlTitulo_editoriales.Size = new Size(1517, 60);
            pnlTitulo_editoriales.TabIndex = 1;
            // 
            // lblTitulo_editoriales
            // 
            lblTitulo_editoriales.AutoSize = true;
            lblTitulo_editoriales.BackColor = Color.Transparent;
            lblTitulo_editoriales.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo_editoriales.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo_editoriales.Location = new Point(510, 9);
            lblTitulo_editoriales.Name = "lblTitulo_editoriales";
            lblTitulo_editoriales.Size = new Size(358, 36);
            lblTitulo_editoriales.TabIndex = 0;
            lblTitulo_editoriales.Text = "GESTION DE EDITORIALES";
            // 
            // pnlDatos_editoriales
            // 
            pnlDatos_editoriales.Controls.Add(pnlBotones_editoriales);
            pnlDatos_editoriales.Controls.Add(txtInombreEditoriales);
            pnlDatos_editoriales.Controls.Add(lblInombre_editoriales);
            pnlDatos_editoriales.Dock = DockStyle.Top;
            pnlDatos_editoriales.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            pnlDatos_editoriales.Location = new Point(0, 60);
            pnlDatos_editoriales.Name = "pnlDatos_editoriales";
            pnlDatos_editoriales.Size = new Size(1517, 352);
            pnlDatos_editoriales.TabIndex = 3;
            // 
            // pnlBotones_editoriales
            // 
            pnlBotones_editoriales.Controls.Add(btnCancelarEditoriales);
            pnlBotones_editoriales.Controls.Add(btnEliminarEditoriales);
            pnlBotones_editoriales.Controls.Add(btnEditarEditoriales);
            pnlBotones_editoriales.Controls.Add(btnGuardarEditoriales);
            pnlBotones_editoriales.Controls.Add(btnNuevoEditoriales);
            pnlBotones_editoriales.Location = new Point(349, 107);
            pnlBotones_editoriales.Name = "pnlBotones_editoriales";
            pnlBotones_editoriales.Size = new Size(617, 63);
            pnlBotones_editoriales.TabIndex = 11;
            // 
            // btnCancelarEditoriales
            // 
            btnCancelarEditoriales.IconChar = FontAwesome.Sharp.IconChar.TimesRectangle;
            btnCancelarEditoriales.IconColor = Color.Black;
            btnCancelarEditoriales.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnCancelarEditoriales.IconSize = 25;
            btnCancelarEditoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnCancelarEditoriales.Location = new Point(503, 10);
            btnCancelarEditoriales.Name = "btnCancelarEditoriales";
            btnCancelarEditoriales.Size = new Size(100, 40);
            btnCancelarEditoriales.TabIndex = 4;
            btnCancelarEditoriales.Text = "Cancelar";
            btnCancelarEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnCancelarEditoriales.UseVisualStyleBackColor = true;
            btnCancelarEditoriales.Click += btnCancelar_Click;
            // 
            // btnEliminarEditoriales
            // 
            btnEliminarEditoriales.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown;
            btnEliminarEditoriales.IconColor = Color.Black;
            btnEliminarEditoriales.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEliminarEditoriales.IconSize = 25;
            btnEliminarEditoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnEliminarEditoriales.Location = new Point(383, 10);
            btnEliminarEditoriales.Name = "btnEliminarEditoriales";
            btnEliminarEditoriales.Size = new Size(100, 40);
            btnEliminarEditoriales.TabIndex = 3;
            btnEliminarEditoriales.Text = "Eliminar";
            btnEliminarEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEliminarEditoriales.UseVisualStyleBackColor = true;
            btnEliminarEditoriales.Click += btnEliminar_Click;
            // 
            // btnEditarEditoriales
            // 
            btnEditarEditoriales.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            btnEditarEditoriales.IconColor = Color.Black;
            btnEditarEditoriales.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnEditarEditoriales.IconSize = 25;
            btnEditarEditoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditarEditoriales.Location = new Point(263, 10);
            btnEditarEditoriales.Name = "btnEditarEditoriales";
            btnEditarEditoriales.Size = new Size(100, 40);
            btnEditarEditoriales.TabIndex = 2;
            btnEditarEditoriales.Text = "Editar";
            btnEditarEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditarEditoriales.UseVisualStyleBackColor = true;
            btnEditarEditoriales.Click += btnEditar_Click;
            // 
            // btnGuardarEditoriales
            // 
            btnGuardarEditoriales.IconChar = FontAwesome.Sharp.IconChar.Save;
            btnGuardarEditoriales.IconColor = Color.Black;
            btnGuardarEditoriales.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnGuardarEditoriales.IconSize = 25;
            btnGuardarEditoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnGuardarEditoriales.Location = new Point(143, 10);
            btnGuardarEditoriales.Name = "btnGuardarEditoriales";
            btnGuardarEditoriales.Size = new Size(100, 40);
            btnGuardarEditoriales.TabIndex = 1;
            btnGuardarEditoriales.Text = "Guardar";
            btnGuardarEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnGuardarEditoriales.UseVisualStyleBackColor = true;
            btnGuardarEditoriales.Click += btnGuardar_Click;
            // 
            // btnNuevoEditoriales
            // 
            btnNuevoEditoriales.IconChar = FontAwesome.Sharp.IconChar.PlusSquare;
            btnNuevoEditoriales.IconColor = Color.Black;
            btnNuevoEditoriales.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnNuevoEditoriales.IconSize = 25;
            btnNuevoEditoriales.ImageAlign = ContentAlignment.MiddleLeft;
            btnNuevoEditoriales.Location = new Point(23, 10);
            btnNuevoEditoriales.Name = "btnNuevoEditoriales";
            btnNuevoEditoriales.Size = new Size(100, 40);
            btnNuevoEditoriales.TabIndex = 0;
            btnNuevoEditoriales.Text = "Nuevo";
            btnNuevoEditoriales.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnNuevoEditoriales.UseVisualStyleBackColor = true;
            btnNuevoEditoriales.Click += btnNuevoEditoriales_Click;
            // 
            // txtInombreEditoriales
            // 
            txtInombreEditoriales.Location = new Point(614, 25);
            txtInombreEditoriales.Name = "txtInombreEditoriales";
            txtInombreEditoriales.Size = new Size(214, 27);
            txtInombreEditoriales.TabIndex = 10;
            // 
            // lblInombre_editoriales
            // 
            lblInombre_editoriales.AutoSize = true;
            lblInombre_editoriales.BackColor = Color.Transparent;
            lblInombre_editoriales.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInombre_editoriales.ForeColor = SystemColors.ActiveCaptionText;
            lblInombre_editoriales.Location = new Point(464, 28);
            lblInombre_editoriales.Name = "lblInombre_editoriales";
            lblInombre_editoriales.Size = new Size(86, 19);
            lblInombre_editoriales.TabIndex = 2;
            lblInombre_editoriales.Text = "NOMBRE : ";
            // 
            // dgvEditoriales
            // 
            dgvEditoriales.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvEditoriales.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvEditoriales.Dock = DockStyle.Fill;
            dgvEditoriales.Location = new Point(0, 412);
            dgvEditoriales.Name = "dgvEditoriales";
            dgvEditoriales.Size = new Size(1517, 486);
            dgvEditoriales.TabIndex = 12;
            dgvEditoriales.CellDoubleClick += dgvEditoriales_CellDoubleClick;
            // 
            // FrmEditoriales
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1517, 898);
            Controls.Add(dgvEditoriales);
            Controls.Add(pnlDatos_editoriales);
            Controls.Add(pnlTitulo_editoriales);
            Name = "FrmEditoriales";
            Text = "FrmEditoriales";
            pnlTitulo_editoriales.ResumeLayout(false);
            pnlTitulo_editoriales.PerformLayout();
            pnlDatos_editoriales.ResumeLayout(false);
            pnlDatos_editoriales.PerformLayout();
            pnlBotones_editoriales.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvEditoriales).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo_editoriales;
        private Label lblTitulo_editoriales;
        private Panel pnlDatos_editoriales;
        private TextBox txtInombreEditoriales;
        private Label lblInombre_editoriales;
        private Panel pnlBotones_editoriales;
        private FontAwesome.Sharp.IconButton btnCancelarEditoriales;
        private FontAwesome.Sharp.IconButton btnEliminarEditoriales;
        private FontAwesome.Sharp.IconButton btnEditarEditoriales;
        private FontAwesome.Sharp.IconButton btnGuardarEditoriales;
        private FontAwesome.Sharp.IconButton btnNuevoEditoriales;
        private DataGridView dgvEditoriales;
    }
}