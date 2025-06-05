namespace SistemaAlertaVecinal
{
    partial class FormPrincipal
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
            lblBienvenida = new Label();
            lblZona = new Label();
            btnReportarEmergencia = new Button();
            btnVerAlertas = new Button();
            btnMisReportes = new Button();
            btnCerrarSesion = new Button();
            SuspendLayout();
            // 
            // lblBienvenida
            // 
            lblBienvenida.AutoSize = true;
            lblBienvenida.Font = new Font("Arial", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblBienvenida.Location = new Point(12, 19);
            lblBienvenida.Name = "lblBienvenida";
            lblBienvenida.Size = new Size(132, 22);
            lblBienvenida.TabIndex = 0;
            lblBienvenida.Text = "Cargando . . .";
            lblBienvenida.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblZona
            // 
            lblZona.AutoSize = true;
            lblZona.Font = new Font("Arial", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblZona.Location = new Point(12, 63);
            lblZona.Name = "lblZona";
            lblZona.Size = new Size(102, 18);
            lblZona.TabIndex = 1;
            lblZona.Text = "Cargando . . .";
            lblZona.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // btnReportarEmergencia
            // 
            btnReportarEmergencia.BackColor = Color.Brown;
            btnReportarEmergencia.Font = new Font("Arial", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnReportarEmergencia.ForeColor = Color.White;
            btnReportarEmergencia.Location = new Point(12, 95);
            btnReportarEmergencia.Name = "btnReportarEmergencia";
            btnReportarEmergencia.Size = new Size(460, 117);
            btnReportarEmergencia.TabIndex = 2;
            btnReportarEmergencia.Text = "🚨 REPORTAR EMERGENCIA 🚨";
            btnReportarEmergencia.UseVisualStyleBackColor = false;
            btnReportarEmergencia.Click += btnReportarEmergencia_Click;
            // 
            // btnVerAlertas
            // 
            btnVerAlertas.BackColor = Color.Orange;
            btnVerAlertas.ForeColor = Color.White;
            btnVerAlertas.Location = new Point(12, 218);
            btnVerAlertas.Name = "btnVerAlertas";
            btnVerAlertas.Size = new Size(226, 53);
            btnVerAlertas.TabIndex = 3;
            btnVerAlertas.Text = "VER ALERTAS RECIBIDAS";
            btnVerAlertas.UseVisualStyleBackColor = false;
            btnVerAlertas.Click += btnVerAlertas_Click;
            // 
            // btnMisReportes
            // 
            btnMisReportes.BackColor = Color.RoyalBlue;
            btnMisReportes.ForeColor = Color.White;
            btnMisReportes.Location = new Point(244, 218);
            btnMisReportes.Name = "btnMisReportes";
            btnMisReportes.Size = new Size(228, 53);
            btnMisReportes.TabIndex = 4;
            btnMisReportes.Text = "MIS REPORTES";
            btnMisReportes.UseVisualStyleBackColor = false;
            btnMisReportes.Click += btnMisReportes_Click;
            // 
            // btnCerrarSesion
            // 
            btnCerrarSesion.BackColor = Color.DimGray;
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.Location = new Point(12, 283);
            btnCerrarSesion.Name = "btnCerrarSesion";
            btnCerrarSesion.Size = new Size(460, 53);
            btnCerrarSesion.TabIndex = 5;
            btnCerrarSesion.Text = "CERRAR SESION";
            btnCerrarSesion.UseVisualStyleBackColor = false;
            btnCerrarSesion.Click += btnCerrarSesion_Click;
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(484, 361);
            Controls.Add(btnCerrarSesion);
            Controls.Add(btnMisReportes);
            Controls.Add(btnVerAlertas);
            Controls.Add(btnReportarEmergencia);
            Controls.Add(lblZona);
            Controls.Add(lblBienvenida);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "FormPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sistema de Alerta Vecinal - Panel Principal";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenida;
        private Label lblZona;
        private Button btnReportarEmergencia;
        private Button btnVerAlertas;
        private Button btnMisReportes;
        private Button btnCerrarSesion;
    }
}