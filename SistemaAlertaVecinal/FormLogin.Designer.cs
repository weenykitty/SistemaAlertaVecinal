namespace SistemaAlertaVecinal
{
    partial class FormLogin
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
            lblTitulo = new Label();
            lblDNI = new Label();
            txtDNI = new TextBox();
            lblContraseña = new Label();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            btnRegistrarse = new Button();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.Location = new Point(50, 20);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(295, 22);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "SISTEMA DE ALERTA VECINAL";
            lblTitulo.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.Location = new Point(50, 80);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(30, 15);
            lblDNI.TabIndex = 1;
            lblDNI.Text = "DNI:";
            // 
            // txtDNI
            // 
            txtDNI.Location = new Point(50, 100);
            txtDNI.MaxLength = 8;
            txtDNI.Name = "txtDNI";
            txtDNI.Size = new Size(200, 23);
            txtDNI.TabIndex = 2;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Location = new Point(50, 130);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(70, 15);
            lblContraseña.TabIndex = 3;
            lblContraseña.Text = "Contraseña:";
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(50, 150);
            txtContraseña.MaxLength = 4;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(200, 23);
            txtContraseña.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Blue;
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(160, 190);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(100, 35);
            btnIngresar.TabIndex = 5;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // btnRegistrarse
            // 
            btnRegistrarse.BackColor = Color.Green;
            btnRegistrarse.ForeColor = Color.White;
            btnRegistrarse.Location = new Point(50, 190);
            btnRegistrarse.Name = "btnRegistrarse";
            btnRegistrarse.Size = new Size(100, 35);
            btnRegistrarse.TabIndex = 6;
            btnRegistrarse.Text = "REGISTRARSE";
            btnRegistrarse.UseVisualStyleBackColor = false;
            btnRegistrarse.Click += btnRegistrarse_Click;
            // 
            // FormLogin
            // 
            ClientSize = new Size(384, 261);
            Controls.Add(btnRegistrarse);
            Controls.Add(btnIngresar);
            Controls.Add(txtContraseña);
            Controls.Add(lblContraseña);
            Controls.Add(txtDNI);
            Controls.Add(lblDNI);
            Controls.Add(lblTitulo);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Alerta Vecinal - Trujillo";
            Load += FormLogin_Load;
            ResumeLayout(false);
            PerformLayout();

        }
        #endregion

        private TextBox txtContraseña;
        private TextBox txtDNI;
        private Label lblTitulo;
        private Label lblDNI;
        private Label lblContraseña;
        private Button btnIngresar;
        private Button btnRegistrarse;
    }
}
