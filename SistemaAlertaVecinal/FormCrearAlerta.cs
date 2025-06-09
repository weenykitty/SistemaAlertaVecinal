using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    public partial class FormCrearAlerta : Form
    {
        public FormCrearAlerta()
        {
            InitializeComponent();
        }
        private void btnEnviarReporte_Click(object sender, EventArgs e)
        {
            IntentarCrearReporte();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            CerrarFormulario();
        }
        private bool ValidarFormulario(FormularioAlerta formulario)
        {
            if (formulario.Tipo == "")
            {
                MessageBox.Show("Por favor, seleccione un tipo de reporte.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(formulario.Descripcion))
            {
                MessageBox.Show("Por favor, ingrese una descripción del incidente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (formulario.Descripcion.Length < 50)
            {
                MessageBox.Show("La descripción debe tener al menos 50 caracteres.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(formulario.Direccion))
            {
                MessageBox.Show("Por favor, ingrese la dirección del incidente.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }
        private void IntentarCrearReporte()
        {
            FormularioAlerta formulario = new FormularioAlerta
            {
                Tipo = cmbTipo.SelectedItem?.ToString() ?? "",
                Descripcion = txtDescripcion.Text,
                Direccion = txtDireccion.Text
            };
            if (ValidarFormulario(formulario))
            {
                SistemaSeguridad.CrearAlerta(formulario);
                MessageBox.Show("Reporte enviado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CerrarFormulario();
            }
        }
        private void CerrarFormulario()
        {
            this.Close();
        }
    }
}
