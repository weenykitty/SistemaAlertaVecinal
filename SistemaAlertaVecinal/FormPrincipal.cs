﻿using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    public partial class FormPrincipal : Form
    {
        public bool CerroSesion { get; private set; } = false;

        public FormPrincipal()
        {
            if (SistemaSeguridad.usuarioActual == null)
            {
                throw new InvalidOperationException("No se puede acceder al FormPrincipal sin Logear.");
            }
            InitializeComponent();

            lblBienvenida.Text = "Bienvenid@ " + SistemaSeguridad.usuarioActual.Nombre + "!";
            lblZona.Text = "Su zona: " + SistemaSeguridad.usuarioActual.Zona;
        }

        private void btnReportarEmergencia_Click(object sender, EventArgs e)
        {
            FormCrearAlerta formCrearAlerta = new FormCrearAlerta();
            formCrearAlerta.ShowDialog();
        }

        private void btnVerAlertas_Click(object sender, EventArgs e)
        {
            FormAlertas formAlertas = new FormAlertas();
            formAlertas.ShowDialog();
        }
        private void btnMisAlertas_Click(object sender, EventArgs e)
        {
            FormMisAlertas formMisAlertas = new FormMisAlertas();
            formMisAlertas.ShowDialog();
        }
        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("¿Está seguro que desea cerrar sesión?",
                                           "Confirmar", MessageBoxButtons.YesNo,
                                           MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                SistemaSeguridad.CerrarSesion();
                CerroSesion = true;
                this.Close();
            }
        }

    }
}
