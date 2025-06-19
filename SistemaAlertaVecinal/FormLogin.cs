using SistemaAlertaVecinal.Clases;
using System.Net;

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

                this.DialogResult = DialogResult.OK;
                this.Close();
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

        private void FormLogin_Load(object sender, EventArgs e)
        {
            Usuario? usuario = SistemaSeguridad.ObtenerUsuarioActual();
            if (usuario != null)
            {
                if (SistemaSeguridad.ValidarUsuario(usuario.DNI, usuario.Contrase�a))
                {
                    MessageBox.Show("Bienvenid@ " + SistemaSeguridad.usuarioActual!.Nombre + "!", "Acceso Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("DNI o contrase�a incorrectos", "Error de Acceso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
    }
}
