using System.ComponentModel.DataAnnotations;

namespace SistemaAlertaVecinal.Clases
{
    public class SistemaSeguridad
    {
        //Arrays para guardar datos (maximo 50 usuarios, 100 incidentes)
        private static List<Usuario> usuarios = new List<Usuario>();
        private static List<Alerta> alertas = new List<Alerta>();
        public static Usuario? usuarioActual;
        static SistemaSeguridad()
        {
            usuarioActual = null;

            // Usuario Test1
            usuarios.Add(new Usuario
            {
                DNI = "12345678",
                Nombre = "Juan Pérez",
                Direccion = "Jr. Pizarro 123, Centro Histórico",
                Telefono = "987654321",
                Contraseña = "1234",
                Zona = "El Porvenir"
            });

            // Usuario Test2
            usuarios.Add(new Usuario
            {
                DNI = "12345678",
                Nombre = "Ale Medrano",
                Direccion = "Jr. Pizarro 123, Centro Histórico",
                Telefono = "987654321",
                Contraseña = "1235",
                Zona = "El Porvenir"
            });
        }


        //Valida si existe un usuario y si la cotnraseña es correcta
        public static bool ValidarUsuario(string dni, string contraseña)
        {
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.DNI == dni && usuario.Contraseña == contraseña)
                {
                    usuarioActual = usuario; 
                    return true; 
                }
            }
            return false;
        }

        //Registra un nuevo usuario en el sistema
        public static bool RegistrarUsuario(string dni, string nombre, string direccion, string telefono, string contraseña, string zona)
        {
            if (dni.Length != 8 || nombre == "" || direccion == "" || telefono.Length != 9 || contraseña.Length < 4 || zona == "")
            {
                return false;
            }

            if (usuarios.Any(u => u.DNI == dni))
            {
                return false; 
            }

            if (usuarios.Count < 50)
            {
                usuarios.Add(new Usuario()
                {
                    DNI = dni,
                    Nombre = nombre,
                    Direccion = direccion,
                    Telefono = telefono,
                    Contraseña = contraseña,
                    Zona = zona
                });
                return true;
            }
            return false; 
        }

        public static string DeterminarZona(string direccion)
        {
            string dir = direccion.ToLower();

            switch (true)
            {
                case var _ when dir.Contains("centro histórico"):
                    return "Centro Histórico";

                case var _ when dir.Contains("la esperanza"):
                    return "La Esperanza";

                case var _ when dir.Contains("el porvenir"):
                    return "El Porvenir";

                case var _ when dir.Contains("florencia de mora"):
                    return "Florencia de Mora";

                case var _ when dir.Contains("victor larco herrera"):
                    return "Victor Larco Herrera";

                default:
                    return "";
            }
        }


        //Crear un reporte de incidente
        public static void CrearReporte(FormularioAlerta formulario)
        {
            if (usuarioActual == null)
            {
                throw new InvalidOperationException("Usuario no autenticado.");
            }
            if (alertas.Count < 100)
            {
                alertas.Add(new Alerta()
                {
                    Tipo = formulario.Tipo,
                    Descripcion = formulario.Descripcion,
                    Direccion = formulario.Direccion,
                    ReportadoPor = usuarioActual.DNI,
                    Zona = usuarioActual.Zona,
                });
                return;
            }
            MessageBox.Show("No se pueden registrar más incidentes, el sistema está lleno.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        //Buscar vecinos de la misma zona para enviar alertas
        public static List<Alerta> BuscarAlertasEnMiZona()
        {
            if (usuarioActual == null)
            {
                throw new InvalidOperationException("Usuario no autenticado.");
            }
            List<Alerta> resultados = new List<Alerta>();

            foreach (Alerta alerta in alertas)
            {
                if (alerta.Zona == usuarioActual.Zona && alerta.ReportadoPor != usuarioActual.DNI)
                {
                    resultados.Add(alerta);
                }
            }
            return resultados;
        }

        //Obtener reportes del usuario actual
        public static List<Alerta> ObtenerMisReportes()
        {
            if (usuarioActual == null)
            {
                throw new InvalidOperationException("Usuario no autenticado.");
            }
            List<Alerta> resultados = new List<Alerta>();
            foreach (Alerta alerta in alertas)
            {
                if (alerta.ReportadoPor == usuarioActual.DNI)
                {
                    resultados.Add(alerta);
                }
            }
            return resultados;
        }
    }
}
