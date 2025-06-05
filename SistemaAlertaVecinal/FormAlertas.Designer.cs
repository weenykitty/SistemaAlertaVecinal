namespace SistemaAlertaVecinal
{
    partial class FormAlertas
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
            label1 = new Label();
            txtContenido = new TextBox();
            dgvMisReportes = new DataGridView();
            clmTipo = new DataGridViewTextBoxColumn();
            clmDescripcion = new DataGridViewTextBoxColumn();
            clmDireccion = new DataGridViewTextBoxColumn();
            clmFecha = new DataGridViewTextBoxColumn();
            clmReportadoPor = new DataGridViewTextBoxColumn();
            clmZona = new DataGridViewTextBoxColumn();
            lblTitulo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMisReportes).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 389);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 7;
            label1.Text = "Contenido:";
            // 
            // txtContenido
            // 
            txtContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContenido.BorderStyle = BorderStyle.FixedSingle;
            txtContenido.Location = new Point(12, 407);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(1013, 98);
            txtContenido.TabIndex = 6;
            // 
            // dgvMisReportes
            // 
            dgvMisReportes.AllowUserToAddRows = false;
            dgvMisReportes.AllowUserToDeleteRows = false;
            dgvMisReportes.AllowUserToResizeColumns = false;
            dgvMisReportes.AllowUserToResizeRows = false;
            dgvMisReportes.BackgroundColor = Color.White;
            dgvMisReportes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMisReportes.Columns.AddRange(new DataGridViewColumn[] { clmTipo, clmDescripcion, clmDireccion, clmFecha, clmReportadoPor, clmZona });
            dgvMisReportes.Location = new Point(12, 60);
            dgvMisReportes.Name = "dgvMisReportes";
            dgvMisReportes.ReadOnly = true;
            dgvMisReportes.RowHeadersVisible = false;
            dgvMisReportes.Size = new Size(1013, 317);
            dgvMisReportes.TabIndex = 5;
            dgvMisReportes.CellClick += dgvMisReportes_CellClick;
            // 
            // clmTipo
            // 
            clmTipo.HeaderText = "Tipo";
            clmTipo.Name = "clmTipo";
            clmTipo.ReadOnly = true;
            clmTipo.Resizable = DataGridViewTriState.False;
            clmTipo.Width = 125;
            // 
            // clmDescripcion
            // 
            clmDescripcion.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            clmDescripcion.HeaderText = "Descripción";
            clmDescripcion.Name = "clmDescripcion";
            clmDescripcion.ReadOnly = true;
            clmDescripcion.Resizable = DataGridViewTriState.False;
            // 
            // clmDireccion
            // 
            clmDireccion.HeaderText = "Dirección";
            clmDireccion.Name = "clmDireccion";
            clmDireccion.ReadOnly = true;
            clmDireccion.Resizable = DataGridViewTriState.False;
            clmDireccion.Width = 125;
            // 
            // clmFecha
            // 
            clmFecha.HeaderText = "Fecha";
            clmFecha.Name = "clmFecha";
            clmFecha.ReadOnly = true;
            clmFecha.Resizable = DataGridViewTriState.False;
            clmFecha.Width = 125;
            // 
            // clmReportadoPor
            // 
            clmReportadoPor.HeaderText = "Reportado por ";
            clmReportadoPor.Name = "clmReportadoPor";
            clmReportadoPor.ReadOnly = true;
            clmReportadoPor.Resizable = DataGridViewTriState.False;
            clmReportadoPor.Width = 125;
            // 
            // clmZona
            // 
            clmZona.FillWeight = 75F;
            clmZona.HeaderText = "Zona";
            clmZona.Name = "clmZona";
            clmZona.ReadOnly = true;
            clmZona.Resizable = DataGridViewTriState.False;
            clmZona.Width = 125;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(41, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(180, 19);
            lblTitulo.TabIndex = 4;
            lblTitulo.Text = "ALERTAS EN MI ZONA";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // FormAlertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 517);
            Controls.Add(label1);
            Controls.Add(txtContenido);
            Controls.Add(dgvMisReportes);
            Controls.Add(lblTitulo);
            Name = "FormAlertas";
            Text = "Alertas en mi Zona";
            Load += FormAlertas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMisReportes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtContenido;
        private DataGridView dgvMisReportes;
        private DataGridViewTextBoxColumn clmTipo;
        private DataGridViewTextBoxColumn clmDescripcion;
        private DataGridViewTextBoxColumn clmDireccion;
        private DataGridViewTextBoxColumn clmFecha;
        private DataGridViewTextBoxColumn clmReportadoPor;
        private DataGridViewTextBoxColumn clmZona;
        private Label lblTitulo;
    }
}