using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            while (true)
            {
                FormLogin loginForm = new FormLogin();
                if (loginForm.ShowDialog() == DialogResult.OK)
                {
                    FormPrincipal formPrincipal = new FormPrincipal();
                    Application.Run(formPrincipal);

                    // Si el FormPrincipal se cierra voluntariamente (logout)
                    if (!formPrincipal.CerroSesion)
                        break; // Si se cerró sin cerrar sesión, salir del bucle y terminar app
                }
                else
                {
                    break; // El usuario cerró el login sin iniciar sesión
                }
            }
        }
    }
}