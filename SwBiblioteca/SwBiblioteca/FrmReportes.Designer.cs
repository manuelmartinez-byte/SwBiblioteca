namespace SwBiblioteca
{
    partial class FrmReportes
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
            pnlTitulo_reportes = new Panel();
            lblTitulo_reportes = new Label();
            this.pnldatos_reporte = new Panel();
            this.pnlBotones_reporte = new Panel();
            btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.btnGen_Reporte = new FontAwesome.Sharp.IconButton();
            this.cmbtiporeporte = new ComboBox();
            lblTipoReporte = new Label();
            dgvReportes = new DataGridView();
            pnlTitulo_reportes.SuspendLayout();
            this.pnldatos_reporte.SuspendLayout();
            this.pnlBotones_reporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReportes).BeginInit();
            SuspendLayout();
            // 
            // pnlTitulo_reportes
            // 
            pnlTitulo_reportes.BackColor = SystemColors.Highlight;
            pnlTitulo_reportes.Controls.Add(lblTitulo_reportes);
            pnlTitulo_reportes.Dock = DockStyle.Top;
            pnlTitulo_reportes.Location = new Point(0, 0);
            pnlTitulo_reportes.Name = "pnlTitulo_reportes";
            pnlTitulo_reportes.Size = new Size(1879, 60);
            pnlTitulo_reportes.TabIndex = 3;
            // 
            // lblTitulo_reportes
            // 
            lblTitulo_reportes.AutoSize = true;
            lblTitulo_reportes.BackColor = Color.Transparent;
            lblTitulo_reportes.Font = new Font("Corbel", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo_reportes.ForeColor = SystemColors.ButtonHighlight;
            lblTitulo_reportes.Location = new Point(510, 9);
            lblTitulo_reportes.Name = "lblTitulo_reportes";
            lblTitulo_reportes.Size = new Size(323, 36);
            lblTitulo_reportes.TabIndex = 0;
            lblTitulo_reportes.Text = "GESTION DE REPORTES";
            // 
            // pnldatos_reporte
            // 
            this.pnldatos_reporte.Controls.Add(this.pnlBotones_reporte);
            this.pnldatos_reporte.Controls.Add(this.cmbtiporeporte);
            this.pnldatos_reporte.Controls.Add(lblTipoReporte);
            this.pnldatos_reporte.Dock = DockStyle.Top;
            this.pnldatos_reporte.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            this.pnldatos_reporte.Location = new Point(0, 60);
            this.pnldatos_reporte.Name = "pnldatos_reporte";
            this.pnldatos_reporte.Size = new Size(1879, 352);
            this.pnldatos_reporte.TabIndex = 4;
            // 
            // pnlBotones_reporte
            // 
            this.pnlBotones_reporte.Controls.Add(btnLimpiar);
            this.pnlBotones_reporte.Controls.Add(this.btnGen_Reporte);
            this.pnlBotones_reporte.Location = new Point(403, 97);
            this.pnlBotones_reporte.Name = "pnlBotones_reporte";
            this.pnlBotones_reporte.Size = new Size(617, 61);
            this.pnlBotones_reporte.TabIndex = 4;
            // 
            // btnLimpiar
            // 
            btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.ThumbsDown;
            btnLimpiar.IconColor = Color.Black;
            btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Regular;
            btnLimpiar.IconSize = 25;
            btnLimpiar.ImageAlign = ContentAlignment.MiddleLeft;
            btnLimpiar.Location = new Point(383, 10);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(166, 40);
            btnLimpiar.TabIndex = 3;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnLimpiar.UseVisualStyleBackColor = true;
            // 
            // btnGen_Reporte
            // 
            this.btnGen_Reporte.IconChar = FontAwesome.Sharp.IconChar.ShareSquare;
            this.btnGen_Reporte.IconColor = Color.Black;
            this.btnGen_Reporte.IconFont = FontAwesome.Sharp.IconFont.Regular;
            this.btnGen_Reporte.IconSize = 25;
            this.btnGen_Reporte.ImageAlign = ContentAlignment.MiddleLeft;
            this.btnGen_Reporte.Location = new Point(197, 10);
            this.btnGen_Reporte.Name = "btnGen_Reporte";
            this.btnGen_Reporte.Size = new Size(166, 40);
            this.btnGen_Reporte.TabIndex = 2;
            this.btnGen_Reporte.Text = "Generar Reporte";
            this.btnGen_Reporte.TextImageRelation = TextImageRelation.ImageBeforeText;
            this.btnGen_Reporte.UseVisualStyleBackColor = true;
            // 
            // cmbtiporeporte
            // 
            this.cmbtiporeporte.FormattingEnabled = true;
            this.cmbtiporeporte.Location = new Point(614, 28);
            this.cmbtiporeporte.Name = "cmbtiporeporte";
            this.cmbtiporeporte.Size = new Size(214, 27);
            this.cmbtiporeporte.TabIndex = 17;
            // 
            // lblTipoReporte
            // 
            lblTipoReporte.AutoSize = true;
            lblTipoReporte.BackColor = Color.Transparent;
            lblTipoReporte.Font = new Font("Corbel", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTipoReporte.ForeColor = SystemColors.ActiveCaptionText;
            lblTipoReporte.Location = new Point(429, 36);
            lblTipoReporte.Name = "lblTipoReporte";
            lblTipoReporte.Size = new Size(144, 19);
            lblTipoReporte.TabIndex = 2;
            lblTipoReporte.Text = "TIPO DE REPORTE:";
            // 
            // dgvReportes
            // 
            dgvReportes.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReportes.Dock = DockStyle.Fill;
            dgvReportes.Location = new Point(0, 412);
            dgvReportes.Name = "dgvReportes";
            dgvReportes.Size = new Size(1879, 503);
            dgvReportes.TabIndex = 6;
            // 
            // FrmReportes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1879, 915);
            Controls.Add(dgvReportes);
            Controls.Add(this.pnldatos_reporte);
            Controls.Add(pnlTitulo_reportes);
            Name = "FrmReportes";
            Text = "FrmReportes";
            pnlTitulo_reportes.ResumeLayout(false);
            pnlTitulo_reportes.PerformLayout();
            this.pnldatos_reporte.ResumeLayout(false);
            this.pnldatos_reporte.PerformLayout();
            this.pnlBotones_reporte.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReportes).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel pnlTitulo_reportes;
        private Panel pnldatos_reporte;
        private Panel pnlBotones_reporte;
        private FontAwesome.Sharp.IconButton btnGen_Reporte;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private ComboBox cmbtiporeporte;
        private Label lblTipoReporte;
        private DataGridView dgvReportes;

        private Label lblTitulo_reportes;
        
        
       
       
       
      
        
    }
}