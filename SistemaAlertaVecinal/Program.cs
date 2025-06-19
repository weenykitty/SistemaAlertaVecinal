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
                        break; // Si se cerr� sin cerrar sesi�n, salir del bucle y terminar app
                }
                else
                {
                    break; // El usuario cerr� el login sin iniciar sesi�n
                }
            }
        }
    }
}