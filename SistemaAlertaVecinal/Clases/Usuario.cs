namespace SistemaAlertaVecinal.Clases
{
    public class Usuario
    {
        public string DNI { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Telefono { get; set; }
        public string Contraseña { get; set; }
        public string Zona { get; set; }

        public Usuario()
        {
            DNI = "";
            Nombre = "";
            Direccion = "";
            Telefono = "";
            Contraseña = "";
            Zona = "";
        }
    }
}
