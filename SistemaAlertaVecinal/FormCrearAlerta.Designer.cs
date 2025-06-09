namespace SistemaAlertaVecinal
{
    partial class FormCrearAlerta
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
            lblTitulo = new Label();
            lblTipo = new Label();
            cmbTipo = new ComboBox();
            lblDescripcion = new Label();
            txtDescripcion = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            btnEnviarReporte = new Button();
            btnCancelar = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(117, 21);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(225, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "ALERTA DE INCIDENTE";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTipo
            // 
            lblTipo.AutoSize = true;
            lblTipo.Location = new Point(42, 68);
            lblTipo.Name = "lblTipo";
            lblTipo.Size = new Size(99, 15);
            lblTipo.TabIndex = 1;
            lblTipo.Text = "Tipo de Incidente";
            // 
            // cmbTipo
            // 
            cmbTipo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbTipo.FormattingEnabled = true;
            cmbTipo.Items.AddRange(new object[] { "Robo/Asalto", "Persona Sospechosa", "Emergencia Médica", "Accidente de Tránsito", "Otros" });
            cmbTipo.Location = new Point(42, 99);
            cmbTipo.Name = "cmbTipo";
            cmbTipo.Size = new Size(185, 23);
            cmbTipo.TabIndex = 2;
            // 
            // lblDescripcion
            // 
            lblDescripcion.AutoSize = true;
            lblDescripcion.Location = new Point(142, 137);
            lblDescripcion.Name = "lblDescripcion";
            lblDescripcion.Size = new Size(196, 15);
            lblDescripcion.TabIndex = 3;
            lblDescripcion.Text = "Descripción (mínimo 50 caracteres):";
            // 
            // txtDescripcion
            // 
            txtDescripcion.Location = new Point(42, 167);
            txtDescripcion.Multiline = true;
            txtDescripcion.Name = "txtDescripcion";
            txtDescripcion.ScrollBars = ScrollBars.Vertical;
            txtDescripcion.Size = new Size(403, 165);
            txtDescripcion.TabIndex = 4;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(264, 68);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(131, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección del Incidente:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(264, 99);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(181, 23);
            txtDireccion.TabIndex = 6;
            // 
            // btnEnviarReporte
            // 
            btnEnviarReporte.BackColor = Color.Red;
            btnEnviarReporte.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEnviarReporte.ForeColor = Color.White;
            btnEnviarReporte.Location = new Point(192, 351);
            btnEnviarReporte.Name = "btnEnviarReporte";
            btnEnviarReporte.Size = new Size(280, 48);
            btnEnviarReporte.TabIndex = 7;
            btnEnviarReporte.Text = "🚨 ENVIAR REPORTE URGENTE 🚨";
            btnEnviarReporte.UseVisualStyleBackColor = false;
            btnEnviarReporte.Click += btnEnviarReporte_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.DimGray;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(42, 351);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(139, 48);
            btnCancelar.TabIndex = 8;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // FormAlerta
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 411);
            Controls.Add(btnCancelar);
            Controls.Add(btnEnviarReporte);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtDescripcion);
            Controls.Add(lblDescripcion);
            Controls.Add(cmbTipo);
            Controls.Add(lblTipo);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormAlerta";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Alertar Incidente de Seguridad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblTipo;
        private ComboBox cmbTipo;
        private Label lblDescripcion;
        private TextBox txtDescripcion;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Button btnEnviarReporte;
        private Button btnCancelar;
    }
}