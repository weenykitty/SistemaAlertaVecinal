using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    public partial class FormRegistro : Form
    {
        public FormRegistro()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            string nombre = txtNombre.Text.Trim();
            string direccion = txtDireccion.Text.Trim();
            string telefono = txtTelefono.Text.Trim();
            string contraseña = txtContraseña.Text.Trim();
            string zona = cmbZona.Text.Trim();

            if (SistemaSeguridad.RegistrarUsuario(dni, nombre, direccion, telefono, contraseña, zona))
            {
                MessageBox.Show("Usuario registrado exitosamente", "Registro Completo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                MessageBox.Show("Error al registrar el usuario, verifique los datos ingresados", "Error de Registro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
