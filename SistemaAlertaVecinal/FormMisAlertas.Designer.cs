namespace SistemaAlertaVecinal
{
    partial class FormMisAlertas
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
            components = new System.ComponentModel.Container();
            lblTitulo = new Label();
            dgvMisAlertas = new DataGridView();
            clmTipo = new DataGridViewTextBoxColumn();
            clmDescripcion = new DataGridViewTextBoxColumn();
            clmDireccion = new DataGridViewTextBoxColumn();
            clmFecha = new DataGridViewTextBoxColumn();
            clmReportadoPor = new DataGridViewTextBoxColumn();
            clmZona = new DataGridViewTextBoxColumn();
            sistemaSeguridadBindingSource = new BindingSource(components);
            txtContenido = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvMisAlertas).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sistemaSeguridadBindingSource).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(41, 18);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(115, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "MIS ALERTAS";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // dgvMisAlertas
            // 
            dgvMisAlertas.AllowUserToAddRows = false;
            dgvMisAlertas.AllowUserToDeleteRows = false;
            dgvMisAlertas.AllowUserToResizeColumns = false;
            dgvMisAlertas.AllowUserToResizeRows = false;
            dgvMisAlertas.BackgroundColor = Color.White;
            dgvMisAlertas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMisAlertas.Columns.AddRange(new DataGridViewColumn[] { clmTipo, clmDescripcion, clmDireccion, clmFecha, clmReportadoPor, clmZona });
            dgvMisAlertas.Location = new Point(12, 60);
            dgvMisAlertas.Name = "dgvMisAlertas";
            dgvMisAlertas.ReadOnly = true;
            dgvMisAlertas.RowHeadersVisible = false;
            dgvMisAlertas.Size = new Size(1013, 317);
            dgvMisAlertas.TabIndex = 1;
            dgvMisAlertas.CellClick += dgvMisAlertas_CellClick;
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
            // sistemaSeguridadBindingSource
            // 
            sistemaSeguridadBindingSource.DataSource = typeof(Clases.SistemaSeguridad);
            // 
            // txtContenido
            // 
            txtContenido.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            txtContenido.BorderStyle = BorderStyle.FixedSingle;
            txtContenido.Location = new Point(12, 407);
            txtContenido.Multiline = true;
            txtContenido.Name = "txtContenido";
            txtContenido.Size = new Size(1013, 98);
            txtContenido.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 389);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 3;
            label1.Text = "Contenido:";
            // 
            // FormMisAlertas
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 517);
            Controls.Add(label1);
            Controls.Add(txtContenido);
            Controls.Add(dgvMisAlertas);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormMisAlertas";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Consultar Alertas";
            Load += FormMisAlertas_Load;
            ((System.ComponentModel.ISupportInitialize)dgvMisAlertas).EndInit();
            ((System.ComponentModel.ISupportInitialize)sistemaSeguridadBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private ColumnHeader columnHeader2;
        private DataGridView dgvMisAlertas;
        private BindingSource sistemaSeguridadBindingSource;
        private DataGridViewTextBoxColumn clmTipo;
        private DataGridViewTextBoxColumn clmDescripcion;
        private DataGridViewTextBoxColumn clmDireccion;
        private DataGridViewTextBoxColumn clmFecha;
        private DataGridViewTextBoxColumn clmReportadoPor;
        private DataGridViewTextBoxColumn clmZona;
        private TextBox txtContenido;
        private Label label1;
    }
}