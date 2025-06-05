namespace SistemaAlertaVecinal
{
    partial class FormRegistro
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
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblNombre = new Label();
            txtNombre = new TextBox();
            lblDireccion = new Label();
            txtDireccion = new TextBox();
            lblTelefono = new Label();
            txtTelefono = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            btnGuardar = new Button();
            btnCancelar = new Button();
            cmbZona = new ComboBox();
            lblZona = new Label();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(97, 23);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(248, 19);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "REGISTRO DE NUEVO VECINO";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(50, 60);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(86, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI (8 digitos):";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(50, 80);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(141, 23);
            txtDNI.TabIndex = 2;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.Location = new Point(50, 110);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(110, 15);
            lblNombre.TabIndex = 3;
            lblNombre.Text = "Nombre Completo:";
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(50, 130);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(320, 23);
            txtNombre.TabIndex = 4;
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.Location = new Point(50, 211);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(113, 15);
            lblDireccion.TabIndex = 5;
            lblDireccion.Text = "Dirección completa:";
            // 
            // txtDireccion
            // 
            txtDireccion.Location = new Point(50, 229);
            txtDireccion.Name = "txtDireccion";
            txtDireccion.Size = new Size(320, 23);
            txtDireccion.TabIndex = 6;
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.Location = new Point(197, 60);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(112, 15);
            lblTelefono.TabIndex = 7;
            lblTelefono.Text = "Teléfono (9 dígitos):";
            // 
            // txtTelefono
            // 
            txtTelefono.Location = new Point(197, 80);
            txtTelefono.MaxLength = 9;
            txtTelefono.Name = "txtTelefono";
            txtTelefono.Size = new Size(173, 23);
            txtTelefono.TabIndex = 8;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(50, 161);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(188, 15);
            lblContraseña.TabIndex = 9;
            lblContraseña.Text = "Contraseña (mínimo 4 caracteres):";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(50, 179);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(200, 23);
            txtContraseña.TabIndex = 10;
            // 
            // btnGuardar
            // 
            btnGuardar.BackColor = Color.Green;
            btnGuardar.ForeColor = Color.White;
            btnGuardar.Location = new Point(106, 335);
            btnGuardar.Name = "btnGuardar";
            btnGuardar.Size = new Size(100, 35);
            btnGuardar.TabIndex = 11;
            btnGuardar.Text = "GUARDAR";
            btnGuardar.UseVisualStyleBackColor = false;
            btnGuardar.Click += btnGuardar_Click;
            // 
            // btnCancelar
            // 
            btnCancelar.BackColor = Color.Red;
            btnCancelar.ForeColor = Color.White;
            btnCancelar.Location = new Point(233, 335);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(100, 35);
            btnCancelar.TabIndex = 12;
            btnCancelar.Text = "CANCELAR";
            btnCancelar.UseVisualStyleBackColor = false;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // cmbZona
            // 
            cmbZona.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbZona.FormattingEnabled = true;
            cmbZona.Items.AddRange(new object[] { "Centro Histórico", "La Esperanza", "El Porvenir", "Florencia de Mora", "Victor Larco Herrera" });
            cmbZona.Location = new Point(50, 279);
            cmbZona.Name = "cmbZona";
            cmbZona.Size = new Size(320, 23);
            cmbZona.TabIndex = 13;
            // 
            // lblZona
            // 
            lblZona.AutoSize = true;
            lblZona.Location = new Point(50, 261);
            lblZona.Name = "lblZona";
            lblZona.Size = new Size(37, 15);
            lblZona.TabIndex = 14;
            lblZona.Text = "Zona:";
            // 
            // FormRegistro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 382);
            Controls.Add(lblZona);
            Controls.Add(cmbZona);
            Controls.Add(btnCancelar);
            Controls.Add(btnGuardar);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtTelefono);
            Controls.Add(lblTelefono);
            Controls.Add(txtDireccion);
            Controls.Add(lblDireccion);
            Controls.Add(txtNombre);
            Controls.Add(lblNombre);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormRegistro";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registro de Nuevo Vecino";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private Label lblDNI;
        private TextBox txtDNI;
        private Label lblNombre;
        private TextBox txtNombre;
        private Label lblDireccion;
        private TextBox txtDireccion;
        private Label lblTelefono;
        private TextBox txtTelefono;
        private Label lblContraseña;
        private TextBox txtContraseña;
        private Button btnGuardar;
        private Button btnCancelar;
        private ComboBox cmbZona;
        private Label lblZona;
    }
}