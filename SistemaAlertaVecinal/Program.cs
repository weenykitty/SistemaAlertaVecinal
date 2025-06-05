using SistemaAlertaVecinal.Clases;

namespace SistemaAlertaVecinal
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            //Crear sistema de seguridad
            Application.Run(new FormLogin());
        }
    }
}