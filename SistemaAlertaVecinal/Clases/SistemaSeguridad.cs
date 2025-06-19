using System.ComponentModel.DataAnnotations;

namespace SistemaAlertaVecinal.Clases
{
    public class SistemaSeguridad
    {
        private static string archivoLocalUsuarios = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "SistemaAlertaVecinal",
            "credenciales.txt"
        );

        private static string archivoLocalAlertas = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "SistemaAlertaVecinal",
            "alertas.txt"
        );

        private static string archivoUsuarioActual = Path.Combine(
            Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData),
            "SistemaAlertaVecinal",
            "usuarioActual.txt"
        );

        private static List<Usuario> usuarios = new List<Usuario>();
        private static List<Alerta> alertas = new List<Alerta>();
        public static Usuario? usuarioActual;
        static SistemaSeguridad()
        {
            CargarDatosUsuarios();
            CargarDatosAlertas();
            CargarUsuarioActual();
        }

        //Carga los datos del usuario actual desde un archivo de texto
        public static void CargarUsuarioActual()
        {
            try
            {
                if (File.Exists(archivoUsuarioActual))
                {
                    using (StreamReader reader = new StreamReader(archivoUsuarioActual))
                    {
                        string? linea = reader.ReadLine();
                        if (linea != null)
                        {
                            string[] partes = linea.Split('|');
                            if (partes.Length == 6)
                            {
                                usuarioActual = new Usuario
                                {
                                    DNI = partes[0],
                                    Nombre = partes[1],
                                    Direccion = partes[2],
                                    Telefono = partes[3],
                                    Contraseña = partes[4],
                                    Zona = partes[5]
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar el usuario actual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Lee cada usuario del archivo de texto y lo carga en la lista de usuarios
        public static void CargarDatosUsuarios()
        {
            try
            {
                if (File.Exists(archivoLocalUsuarios))
                {
                    using (StreamReader reader = new StreamReader(archivoLocalUsuarios))
                    {
                        string linea;
                        while ((linea = reader.ReadLine()) != null)
                        {
                            string[] partes = linea.Split('|');
                            if (partes.Length == 6)
                            {
                                usuarios.Add(new Usuario
                                {
                                    DNI = partes[0],
                                    Nombre = partes[1],
                                    Direccion = partes[2],
                                    Telefono = partes[3],
                                    Contraseña = partes[4],
                                    Zona = partes[5]
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Guarda el usuario actual en un archivo de texto para persistencia
        public static void GuardarUsuarioActual()
        {
            try
            {
                string? directorio = Path.GetDirectoryName(archivoUsuarioActual);
                if (!string.IsNullOrEmpty(directorio) && !Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }
                using (StreamWriter writer = new StreamWriter(archivoUsuarioActual, false))
                {
                    if (usuarioActual != null)
                    {
                        string linea = $"{usuarioActual.DNI}|{usuarioActual.Nombre}|{usuarioActual.Direccion}|{usuarioActual.Telefono}|{usuarioActual.Contraseña}|{usuarioActual.Zona}";
                        writer.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el usuario actual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Valida si existe un usuario y si la cotnraseña es correcta
        public static bool ValidarUsuario(string dni, string contraseña)
        {
            foreach(Usuario usuario in usuarios)
            {
                if (usuario.DNI == dni && usuario.Contraseña == contraseña)
                {
                    usuarioActual = usuario;
                    GuardarUsuarioActual(); 
                    return true; 
                }
            }
            return false;
        }

        public static Usuario? ObtenerUsuarioActual()
        {
            return usuarioActual;
        }

        //Guarda los datos de un usuario en un archivo de texto para persistencia
        public static void GuardarDatosUsuarios()
        {
            try
            {
                string? directorio = Path.GetDirectoryName(archivoLocalUsuarios);
                if (!string.IsNullOrEmpty(directorio) && !Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }
                using (StreamWriter writer = new StreamWriter(archivoLocalUsuarios, false))
                {
                    foreach (Usuario usuario in usuarios)
                    {
                        string linea = $"{usuario.DNI}|{usuario.Nombre}|{usuario.Direccion}|{usuario.Telefono}|{usuario.Contraseña}|{usuario.Zona}";
                        writer.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos de los usuarios: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                GuardarDatosUsuarios();
                return true;
            }
            return false; 
        }


        //Limpia el archivo de usuario actual para eliminar la sesión
        public static void EliminarUsuarioActual()
        {
            try
            {
                if (File.Exists(archivoUsuarioActual))
                {
                    File.Delete(archivoUsuarioActual);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al eliminar el usuario actual: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Cerrar sesión del usuario actual
        public static void CerrarSesion()
        {
            usuarioActual = null;
            EliminarUsuarioActual();
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

        //Guarda los datos de las alertas en un archivo de texto para persistencia
        public static void GuardarDatosAlertas()
        {
            try
            {
                string? directorio = Path.GetDirectoryName(archivoLocalAlertas);
                if (!string.IsNullOrEmpty(directorio) && !Directory.Exists(directorio))
                {
                    Directory.CreateDirectory(directorio);
                }
                using (StreamWriter writer = new StreamWriter(archivoLocalAlertas, false))
                {
                    foreach (Alerta alerta in alertas)
                    {
                        string linea = $"{alerta.Tipo}|{alerta.Descripcion}|{alerta.Direccion}|{alerta.ReportadoPor}|{alerta.Zona}|{alerta.Fecha}";
                        writer.WriteLine(linea);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar los datos de las alertas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Lee cada alerta del archivo de texto y lo carga en la lista de alertas
        public static void CargarDatosAlertas()
        {
            try
            {
                if (File.Exists(archivoLocalAlertas))
                {
                    using (StreamReader reader = new StreamReader(archivoLocalAlertas))
                    {
                        string linea;
                        while ((linea = reader.ReadLine()) != null)
                        {
                            string[] partes = linea.Split('|');
                            if (partes.Length == 6)
                            {
                                alertas.Add(new Alerta
                                {
                                    Tipo = partes[0],
                                    Descripcion = partes[1],
                                    Direccion = partes[2],
                                    ReportadoPor = partes[3],
                                    Zona = partes[4],
                                    Fecha = DateTime.Parse(partes[5])
                                });
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos de las alertas: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Crear una alerta de incidente
        public static void CrearAlerta(FormularioAlerta formulario)
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
                GuardarDatosAlertas();
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

        //Obtener alertas del usuario actual
        public static List<Alerta> ObtenerMisAlertas()
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
