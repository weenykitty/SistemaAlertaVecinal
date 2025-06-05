namespace SistemaAlertaVecinal.Clases
{
    public class FormularioAlerta
    {
        public required string Tipo { get; set; }
        public required string Descripcion { get; set; }
        public required string Direccion { get; set; }
    }
    public class Alerta
    {
        public string Tipo { get; set; }
        public string Descripcion { get; set; }
        public string Direccion { get; set; }
        public DateTime Fecha { get; set; }
        public string ReportadoPor { get; set; }
        public string Zona { get; set; }

        public Alerta()
        {
            Tipo = "";
            Descripcion = "";
            Direccion = "";
            Fecha = DateTime.Now;
            ReportadoPor = "";
            Zona = "";
        }
    }
}
