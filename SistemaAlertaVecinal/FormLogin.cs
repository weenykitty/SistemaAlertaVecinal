using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            string dni = txtDNI.Text.Trim();
            string contrase�a = txtContrase�a.Text.Trim();

            if (dni == "" || contrase�a == "")
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (SistemaSeguridad.ValidarUsuario(dni, contrase�a))
            {
                MessageBox.Show("Bienvenid@ " + SistemaSeguridad.usuarioActual!.Nombre + "!", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                FormPrincipal formPrincipal = new FormPrincipal();
                this.Hide();
                formPrincipal.ShowDialog();
                this.Show();

                // Limpiar campos
                txtDNI.Text = "";
                txtContrase�a.Text = "";
            }
            else
            {
                MessageBox.Show("DNI o contrase�a incorrectos", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            FormRegistro formRegistro = new FormRegistro();
            formRegistro.ShowDialog();
        }
    }
}
